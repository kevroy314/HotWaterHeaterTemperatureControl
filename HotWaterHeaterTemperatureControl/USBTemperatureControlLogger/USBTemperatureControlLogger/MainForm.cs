using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
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

        public MainForm()
        {
            InitializeComponent();
            //Register form closing event for safe shutdown
            this.FormClosing += Form1_FormClosing;
        }

        void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Shut down acquisition thread
            running = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Run thread if not running, stop if running
            if (!running)
            {
                Thread t = new Thread(new ThreadStart(log));
                t.Start();
            }
            else
                running = false;
        }

        private void log()
        {
            //Thread is running
            running = true;
            //Set button text
            SetButtonText("Stop Logging");
            try
            {
                //Try to open a serial connection
                SerialPort serial = new SerialPort(serialInterfaceString.Text);
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
                        SetLabelText("" + point);
                        RefreshChart();
                    }
                    catch (Exception) { }
                }
                //Close the serial connection
                serial.Close();
            }
            catch (Exception) { MessageBox.Show("Problem with serial connection. Is the port correct?"); running = false; }
            //Reset button text
            SetButtonText("Log");
        }


        //Asynchronous GUI Access Delegates
        delegate void SetLabelTextCallback(string text);
        delegate void SetButtonTextCallback(string text);
        delegate void AddPointCallback(double point, double target, bool relayOn);
        delegate void RefreshChartCallback();

        //Set the label text for current sample value
        private void SetLabelText(string text)
        {
            if(latestSampleLabel.InvokeRequired)
            {
                SetLabelTextCallback d = new SetLabelTextCallback(SetLabelText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                latestSampleLabel.Text = text;
            }
        }

        //Set the botton text for toggle on/off
        private void SetButtonText(string text)
        {
            if (logButton.InvokeRequired)
            {
                SetButtonTextCallback d = new SetButtonTextCallback(SetButtonText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                logButton.Text = text;
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
                chart.Series[0].Points.AddY(point);
                chart.Series[1].Points.AddY(target);
                if (relayOn) chart.Series[2].Points.AddY(1);
                else chart.Series[2].Points.AddY(0);
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
    }
}
