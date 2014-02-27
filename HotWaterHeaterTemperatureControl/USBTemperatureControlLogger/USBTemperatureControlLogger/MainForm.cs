using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USBTemperatureControlLogger
{
    public partial class MainForm : Form
    {
        //Running State of the thread
        private bool running = false;

        private bool comPortDetectorThreadRunning = false;
        private Thread comPortDetectorThread;

        private System.Collections.Generic.Queue<Tuple<Command,double>> commandQueue;

        private enum Command {SetTemperature, SetWindow, SetAverage, ForceStart, ForceStop, AutoMode};

        private StreamWriter writer;

        #region Mouse Drag Extern Interface

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        #endregion

        public MainForm()
        {
            InitializeComponent();

            this.MouseDown += MainForm_MouseDown;
            this.chart.MouseDown += MainForm_MouseDown;
            this.FormClosing += Form1_FormClosing;

            string[] availableComPorts = SerialPort.GetPortNames();

            if (availableComPorts.Length <= 0)
                MessageBox.Show("Error: There are no devices connected via COM ports. Please check device connections.");

            comPortListBox.Items.AddRange(availableComPorts);

            #region Minimize/Close Button Behavior Callback Registration

            minBox.MouseEnter += minBox_MouseEnter;
            minBox.MouseLeave += minBox_MouseLeave;
            minBox.MouseDown += minBox_MouseDown;
            minBox.MouseUp += minBox_MouseUp;
            minBox.MouseClick += minBox_MouseClick;

            closeBox.MouseEnter += closeBox_MouseEnter;
            closeBox.MouseLeave += closeBox_MouseLeave;
            closeBox.MouseDown += closeBox_MouseDown;
            closeBox.MouseUp += closeBox_MouseUp;
            closeBox.MouseClick += closeBox_MouseClick;

            #endregion

            comPortDetectorThread = new Thread(new ThreadStart(pollComPorts));
            comPortDetectorThread.Start();

            commandQueue = new System.Collections.Generic.Queue<Tuple<Command,double>>();
        }

        private void pollComPorts()
        {
            comPortDetectorThreadRunning = true;
            while (comPortDetectorThreadRunning)
            {
                UpdatePortList(SerialPort.GetPortNames());
                Thread.Sleep(1000);
            }
        }

        #region Minimize/Close Button Behavior Callbacks

        void closeBox_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        void closeBox_MouseUp(object sender, MouseEventArgs e)
        {
            closeBox.Image = global::USBTemperatureControlLogger.Properties.Resources.appbar_close_darkgray;
        }

        void closeBox_MouseDown(object sender, MouseEventArgs e)
        {
            closeBox.Image = global::USBTemperatureControlLogger.Properties.Resources.appbar_close;
        }

        void closeBox_MouseLeave(object sender, EventArgs e)
        {
            closeBox.Image = global::USBTemperatureControlLogger.Properties.Resources.appbar_close_darkgray;
        }

        void closeBox_MouseEnter(object sender, EventArgs e)
        {
            closeBox.Image = global::USBTemperatureControlLogger.Properties.Resources.appbar_close_gray;
        }

        void minBox_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        void minBox_MouseUp(object sender, MouseEventArgs e)
        {
            minBox.Image = global::USBTemperatureControlLogger.Properties.Resources.appbar_minus_darkgray;
        }

        void minBox_MouseDown(object sender, MouseEventArgs e)
        {
            minBox.Image = global::USBTemperatureControlLogger.Properties.Resources.appbar_minus;
        }

        void minBox_MouseLeave(object sender, EventArgs e)
        {
            minBox.Image = global::USBTemperatureControlLogger.Properties.Resources.appbar_minus_darkgray;
        }

        void minBox_MouseEnter(object sender, EventArgs e)
        {
            minBox.Image = global::USBTemperatureControlLogger.Properties.Resources.appbar_minus_gray;
        }

        #endregion

        #region Escape to Close

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        #endregion

        #region Window Dragging

        void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion

        private void ResetFileWriter()
        {
            try { writer.Close(); } catch (Exception) { }
            DateTime current = DateTime.Now;
            string filepath = "log_d" + current.Day + "-" + current.Month + "-" + current.Year + "_t" + current.Hour + "-" + current.Minute + "-" + current.Second + "-" + current.Millisecond + ".tsv";
            writer = new StreamWriter(filepath, false);
        }

        void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Shut down acquisition thread
            running = false;
            comPortDetectorThreadRunning = false;
            writer.Close();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            //Run thread if not running, stop if running
            if (!running)
            {
                Thread t = new Thread(new ThreadStart(log));
                t.Start();
                running = true;
            }
            else
                running = false;
        }

        private void log()
        {
            //Set button text
            SetConnectionState(true);

            DateTime startTime = DateTime.Now;

            ResetFileWriter();

            try
            {
                //Try to open a serial connection
                SerialPort serial = new SerialPort(""); //TODO
                serial.Open();

                while (running)
                {
                    //Poll the controller for status
                    serial.Write("d");
                    //Wait for a response (250 was experimentally determined)
                    Thread.Sleep(250);
                    string tmp = serial.ReadExisting();
                    string[] tmpSplit = tmp.Split(new char[] { ':', ' ', '/' }, StringSplitOptions.RemoveEmptyEntries);
                    //Extract data and add to chart if valid
                    try
                    {
                        double point = double.Parse(tmpSplit[2]);
                        double target = double.Parse(tmpSplit[3]);
                        bool relayOn = tmpSplit[4] == "ON\r\n" ? true : false;
                        AddPoint(point, target, relayOn);
                        SetSampleLabelText("" + point);
                        RefreshChart();
                    }
                    catch (Exception) { }

                    while (commandQueue.Count > 0)
                    {
                        Tuple<Command,double> command = commandQueue.Dequeue();
                        switch (command.Item1)
                        {
                            case Command.AutoMode:
                                serial.Write("a");
                                break;
                            case Command.ForceStart:
                                serial.Write("1");
                                break;
                            case Command.ForceStop:
                                serial.Write("0");
                                break;
                            case Command.SetAverage:
                                serial.Write("m" + command.Item2.ToString("F") + "*");
                                break;
                            case Command.SetTemperature:
                                serial.Write("t" + command.Item2.ToString("F") + "*");
                                break;
                            case Command.SetWindow:
                                serial.Write("w" + command.Item2.ToString("F") + "*");
                                break;
                        }
                        Thread.Sleep(1);
                    }
                    TimeSpan runTimeSpan = DateTime.Now.Subtract(startTime);
                    runTimeLabel.Text = runTimeSpan.TotalHours + "h" + runTimeSpan.TotalMilliseconds + "m" + runTimeSpan.TotalSeconds + "." + runTimeSpan.TotalMilliseconds + "s";
                }
                //Close the serial connection
                serial.Close();
            }
            catch (Exception) {  MessageBox.Show("Problem with serial connection. Is the port correct?"); running = false; }
            //Reset button text
            SetConnectionState(false);
        }


        //Asynchronous GUI Access Delegates
        delegate void SetSampleLabelTextCallback(string text);
        delegate void UpdatePortListCallback(string[] list);
        delegate void SetConnectionStateCallback(bool connected);
        delegate void AddPointCallback(double point, double target, bool relayOn);
        delegate void RefreshChartCallback();

        //Set the label text for current sample value
        private void SetSampleLabelText(string text)
        {
            if(latestSampleLabel.InvokeRequired)
            {
                SetSampleLabelTextCallback d = new SetSampleLabelTextCallback(SetSampleLabelText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                latestSampleLabel.Text = text;
            }
        }

        //Update list of available ports
        private void UpdatePortList(string[] list)
        {
            if(comPortListBox.InvokeRequired)
            {
                UpdatePortListCallback d = new UpdatePortListCallback(UpdatePortList);
                this.Invoke(d, new object[] { list});
            }
            else
            {
                comPortListBox.Items.Clear();
                comPortListBox.Items.AddRange(list);
            }
        }

        //Set the botton text for toggle on/off
        private void SetConnectionState(bool connected)
        {
            if (connectButton.InvokeRequired)
            {
                SetConnectionStateCallback d = new SetConnectionStateCallback(SetConnectionState);
                this.Invoke(d, new object[] { connected });
            }
            else
            {
                if (connected)
                {
                    statusLabel.Text = "Connected";
                    statusLabel.ForeColor = Color.Green;
                    connectButton.Text = "Disconnect";
                    setTempButton.Enabled = true;
                    setWindowButton.Enabled = true;
                    setAverageButton.Enabled = true;
                    forceStartButton.Enabled = true;
                    forceStopButton.Enabled = true;
                    autoModeButton.Enabled = true;
                }
                else
                {
                    statusLabel.Text = "Disconnected";
                    statusLabel.ForeColor = Color.Red;
                    connectButton.Text = "Connect";
                    setTempButton.Enabled = false;
                    setWindowButton.Enabled = false;
                    setAverageButton.Enabled = false;
                    forceStartButton.Enabled = false;
                    forceStopButton.Enabled = false;
                    autoModeButton.Enabled = false;
                }
            }
                
        }

        //Add a point to the chart
        private void AddPoint(double point, double target, bool relayOn)
        {
            if (chart.InvokeRequired)
            {
                AddPointCallback d = new AddPointCallback(AddPoint);
                this.Invoke(d, new object[] { point, target, relayOn });
            }
            else
            {
                if (chart.Series[0].Points.Count > 10000)
                    chart.Series[0].Points.RemoveAt(0);
                int relayPoint = relayOn?1:0;
                chart.Series[0].Points.AddY(point);
                chart.Series[1].Points.AddY(target);
                chart.Series[2].Points.AddY(relayPoint);
                writer.WriteLine(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "\t" + point + "\t" + target + "\t" + relayPoint);
            }
        }

        //Refresh the chart
        private void RefreshChart()
        {
            if (chart.InvokeRequired)
            {
                RefreshChartCallback d = new RefreshChartCallback(RefreshChart);
                this.Invoke(d, null);
            }
            else
            {
                chart.Refresh();
            }
        }

        private void setTempButton_Click(object sender, EventArgs e)
        {
            commandQueue.Enqueue(new Tuple<Command, double>(Command.SetTemperature, (double)tempNumericUpDown.Value));
        }

        private void setWindowButton_Click(object sender, EventArgs e)
        {
            commandQueue.Enqueue(new Tuple<Command, double>(Command.SetWindow, (double)windowNumericUpDown.Value));
        }

        private void setAverageButton_Click(object sender, EventArgs e)
        {
            commandQueue.Enqueue(new Tuple<Command, double>(Command.SetAverage, (double)averageNumericUpDown.Value));
        }

        private void forceStartButton_Click(object sender, EventArgs e)
        {
            commandQueue.Enqueue(new Tuple<Command, double>(Command.ForceStart, 0));
        }

        private void forceStopButton_Click(object sender, EventArgs e)
        {
            commandQueue.Enqueue(new Tuple<Command, double>(Command.ForceStop, 0));
        }

        private void autoModeButton_Click(object sender, EventArgs e)
        {
            commandQueue.Enqueue(new Tuple<Command, double>(Command.AutoMode, 0));
        }

        private void clearChartButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chart.Series.Count; i++)
                chart.Series[i].Points.Clear();
        }
    }
}
