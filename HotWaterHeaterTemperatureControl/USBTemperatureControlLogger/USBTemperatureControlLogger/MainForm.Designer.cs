namespace USBTemperatureControlLogger
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.connectButton = new System.Windows.Forms.Button();
            this.latestSampleLabel = new System.Windows.Forms.Label();
            this.setTempButton = new System.Windows.Forms.Button();
            this.setWindowButton = new System.Windows.Forms.Button();
            this.setAverageButton = new System.Windows.Forms.Button();
            this.tempUnitsLabel = new System.Windows.Forms.Label();
            this.comPortListBox = new System.Windows.Forms.ListBox();
            this.autoModeButton = new System.Windows.Forms.Button();
            this.forceStopButton = new System.Windows.Forms.Button();
            this.forceStartButton = new System.Windows.Forms.Button();
            this.tempNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.windowNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.windowUnitsLabel = new System.Windows.Forms.Label();
            this.averageNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.averageUnitsLabel = new System.Windows.Forms.Label();
            this.latestSampleLabelLabel = new System.Windows.Forms.Label();
            this.runTimeLabelLabel = new System.Windows.Forms.Label();
            this.runTimeLabel = new System.Windows.Forms.Label();
            this.minBox = new System.Windows.Forms.PictureBox();
            this.closeBox = new System.Windows.Forms.PictureBox();
            this.statusLabelLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.clearChartButton = new System.Windows.Forms.Button();
            this.ipAddressTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.averageNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.Color.Black;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisX2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX2.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX2.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX2.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX2.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.ScaleView.Zoomable = false;
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisY2.IsStartedFromZero = false;
            chartArea1.AxisY2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY2.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY2.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY2.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY2.TitleForeColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Location = new System.Drawing.Point(10, 38);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Temperature";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Name = "Target Temperature";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series3.Name = "RelayState";
            series3.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.chart.Series.Add(series1);
            this.chart.Series.Add(series2);
            this.chart.Series.Add(series3);
            this.chart.Size = new System.Drawing.Size(890, 431);
            this.chart.TabIndex = 0;
            // 
            // connectButton
            // 
            this.connectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectButton.ForeColor = System.Drawing.Color.White;
            this.connectButton.Location = new System.Drawing.Point(20, 497);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(99, 27);
            this.connectButton.TabIndex = 1;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // latestSampleLabel
            // 
            this.latestSampleLabel.AutoSize = true;
            this.latestSampleLabel.ForeColor = System.Drawing.Color.White;
            this.latestSampleLabel.Location = new System.Drawing.Point(770, 501);
            this.latestSampleLabel.Name = "latestSampleLabel";
            this.latestSampleLabel.Size = new System.Drawing.Size(0, 13);
            this.latestSampleLabel.TabIndex = 2;
            // 
            // setTempButton
            // 
            this.setTempButton.Enabled = false;
            this.setTempButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setTempButton.ForeColor = System.Drawing.Color.White;
            this.setTempButton.Location = new System.Drawing.Point(124, 497);
            this.setTempButton.Name = "setTempButton";
            this.setTempButton.Size = new System.Drawing.Size(99, 27);
            this.setTempButton.TabIndex = 4;
            this.setTempButton.Text = "Set Temperature";
            this.setTempButton.UseVisualStyleBackColor = true;
            this.setTempButton.Click += new System.EventHandler(this.setTempButton_Click);
            // 
            // setWindowButton
            // 
            this.setWindowButton.Enabled = false;
            this.setWindowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setWindowButton.ForeColor = System.Drawing.Color.White;
            this.setWindowButton.Location = new System.Drawing.Point(230, 497);
            this.setWindowButton.Name = "setWindowButton";
            this.setWindowButton.Size = new System.Drawing.Size(99, 27);
            this.setWindowButton.TabIndex = 6;
            this.setWindowButton.Text = "Set Window";
            this.setWindowButton.UseVisualStyleBackColor = true;
            this.setWindowButton.Click += new System.EventHandler(this.setWindowButton_Click);
            // 
            // setAverageButton
            // 
            this.setAverageButton.Enabled = false;
            this.setAverageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setAverageButton.ForeColor = System.Drawing.Color.White;
            this.setAverageButton.Location = new System.Drawing.Point(334, 497);
            this.setAverageButton.Name = "setAverageButton";
            this.setAverageButton.Size = new System.Drawing.Size(99, 27);
            this.setAverageButton.TabIndex = 8;
            this.setAverageButton.Text = "Set Average";
            this.setAverageButton.UseVisualStyleBackColor = true;
            this.setAverageButton.Click += new System.EventHandler(this.setAverageButton_Click);
            // 
            // tempUnitsLabel
            // 
            this.tempUnitsLabel.AutoSize = true;
            this.tempUnitsLabel.ForeColor = System.Drawing.Color.White;
            this.tempUnitsLabel.Location = new System.Drawing.Point(193, 477);
            this.tempUnitsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tempUnitsLabel.Name = "tempUnitsLabel";
            this.tempUnitsLabel.Size = new System.Drawing.Size(32, 13);
            this.tempUnitsLabel.TabIndex = 9;
            this.tempUnitsLabel.Text = "degC";
            // 
            // comPortListBox
            // 
            this.comPortListBox.BackColor = System.Drawing.Color.Black;
            this.comPortListBox.ForeColor = System.Drawing.Color.White;
            this.comPortListBox.FormattingEnabled = true;
            this.comPortListBox.Location = new System.Drawing.Point(20, 475);
            this.comPortListBox.Margin = new System.Windows.Forms.Padding(2);
            this.comPortListBox.Name = "comPortListBox";
            this.comPortListBox.Size = new System.Drawing.Size(100, 17);
            this.comPortListBox.TabIndex = 10;
            // 
            // autoModeButton
            // 
            this.autoModeButton.Enabled = false;
            this.autoModeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.autoModeButton.ForeColor = System.Drawing.Color.White;
            this.autoModeButton.Location = new System.Drawing.Point(665, 497);
            this.autoModeButton.Name = "autoModeButton";
            this.autoModeButton.Size = new System.Drawing.Size(99, 27);
            this.autoModeButton.TabIndex = 11;
            this.autoModeButton.Text = "Enable Auto";
            this.autoModeButton.UseVisualStyleBackColor = true;
            this.autoModeButton.Click += new System.EventHandler(this.autoModeButton_Click);
            // 
            // forceStopButton
            // 
            this.forceStopButton.Enabled = false;
            this.forceStopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forceStopButton.ForeColor = System.Drawing.Color.White;
            this.forceStopButton.Location = new System.Drawing.Point(560, 497);
            this.forceStopButton.Name = "forceStopButton";
            this.forceStopButton.Size = new System.Drawing.Size(99, 27);
            this.forceStopButton.TabIndex = 12;
            this.forceStopButton.Text = "Force Stop";
            this.forceStopButton.UseVisualStyleBackColor = true;
            this.forceStopButton.Click += new System.EventHandler(this.forceStopButton_Click);
            // 
            // forceStartButton
            // 
            this.forceStartButton.Enabled = false;
            this.forceStartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forceStartButton.ForeColor = System.Drawing.Color.White;
            this.forceStartButton.Location = new System.Drawing.Point(455, 497);
            this.forceStartButton.Name = "forceStartButton";
            this.forceStartButton.Size = new System.Drawing.Size(99, 27);
            this.forceStartButton.TabIndex = 13;
            this.forceStartButton.Text = "Force Start";
            this.forceStartButton.UseVisualStyleBackColor = true;
            this.forceStartButton.Click += new System.EventHandler(this.forceStartButton_Click);
            // 
            // tempNumericUpDown
            // 
            this.tempNumericUpDown.BackColor = System.Drawing.Color.Black;
            this.tempNumericUpDown.DecimalPlaces = 2;
            this.tempNumericUpDown.ForeColor = System.Drawing.Color.White;
            this.tempNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.tempNumericUpDown.Location = new System.Drawing.Point(123, 475);
            this.tempNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.tempNumericUpDown.Name = "tempNumericUpDown";
            this.tempNumericUpDown.Size = new System.Drawing.Size(65, 20);
            this.tempNumericUpDown.TabIndex = 14;
            // 
            // windowNumericUpDown
            // 
            this.windowNumericUpDown.BackColor = System.Drawing.Color.Black;
            this.windowNumericUpDown.DecimalPlaces = 2;
            this.windowNumericUpDown.ForeColor = System.Drawing.Color.White;
            this.windowNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.windowNumericUpDown.Location = new System.Drawing.Point(230, 475);
            this.windowNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.windowNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.windowNumericUpDown.Name = "windowNumericUpDown";
            this.windowNumericUpDown.Size = new System.Drawing.Size(65, 20);
            this.windowNumericUpDown.TabIndex = 16;
            // 
            // windowUnitsLabel
            // 
            this.windowUnitsLabel.AutoSize = true;
            this.windowUnitsLabel.ForeColor = System.Drawing.Color.White;
            this.windowUnitsLabel.Location = new System.Drawing.Point(299, 477);
            this.windowUnitsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.windowUnitsLabel.Name = "windowUnitsLabel";
            this.windowUnitsLabel.Size = new System.Drawing.Size(32, 13);
            this.windowUnitsLabel.TabIndex = 15;
            this.windowUnitsLabel.Text = "degC";
            // 
            // averageNumericUpDown
            // 
            this.averageNumericUpDown.BackColor = System.Drawing.Color.Black;
            this.averageNumericUpDown.ForeColor = System.Drawing.Color.White;
            this.averageNumericUpDown.Location = new System.Drawing.Point(334, 475);
            this.averageNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.averageNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.averageNumericUpDown.Name = "averageNumericUpDown";
            this.averageNumericUpDown.Size = new System.Drawing.Size(48, 20);
            this.averageNumericUpDown.TabIndex = 18;
            this.averageNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // averageUnitsLabel
            // 
            this.averageUnitsLabel.AutoSize = true;
            this.averageUnitsLabel.ForeColor = System.Drawing.Color.White;
            this.averageUnitsLabel.Location = new System.Drawing.Point(387, 477);
            this.averageUnitsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.averageUnitsLabel.Name = "averageUnitsLabel";
            this.averageUnitsLabel.Size = new System.Drawing.Size(47, 13);
            this.averageUnitsLabel.TabIndex = 17;
            this.averageUnitsLabel.Text = "Samples";
            // 
            // latestSampleLabelLabel
            // 
            this.latestSampleLabelLabel.AutoSize = true;
            this.latestSampleLabelLabel.ForeColor = System.Drawing.Color.White;
            this.latestSampleLabelLabel.Location = new System.Drawing.Point(770, 484);
            this.latestSampleLabelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.latestSampleLabelLabel.Name = "latestSampleLabelLabel";
            this.latestSampleLabelLabel.Size = new System.Drawing.Size(74, 13);
            this.latestSampleLabelLabel.TabIndex = 19;
            this.latestSampleLabelLabel.Text = "Latest Sample";
            // 
            // runTimeLabelLabel
            // 
            this.runTimeLabelLabel.AutoSize = true;
            this.runTimeLabelLabel.ForeColor = System.Drawing.Color.White;
            this.runTimeLabelLabel.Location = new System.Drawing.Point(848, 484);
            this.runTimeLabelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.runTimeLabelLabel.Name = "runTimeLabelLabel";
            this.runTimeLabelLabel.Size = new System.Drawing.Size(53, 13);
            this.runTimeLabelLabel.TabIndex = 20;
            this.runTimeLabelLabel.Text = "Run Time";
            // 
            // runTimeLabel
            // 
            this.runTimeLabel.AutoSize = true;
            this.runTimeLabel.ForeColor = System.Drawing.Color.White;
            this.runTimeLabel.Location = new System.Drawing.Point(848, 501);
            this.runTimeLabel.Name = "runTimeLabel";
            this.runTimeLabel.Size = new System.Drawing.Size(0, 13);
            this.runTimeLabel.TabIndex = 21;
            // 
            // minBox
            // 
            this.minBox.BackColor = System.Drawing.Color.Transparent;
            this.minBox.Image = global::USBTemperatureControlLogger.Properties.Resources.appbar_minus_darkgray;
            this.minBox.Location = new System.Drawing.Point(772, 10);
            this.minBox.Margin = new System.Windows.Forms.Padding(2);
            this.minBox.Name = "minBox";
            this.minBox.Size = new System.Drawing.Size(76, 76);
            this.minBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.minBox.TabIndex = 23;
            this.minBox.TabStop = false;
            // 
            // closeBox
            // 
            this.closeBox.Image = global::USBTemperatureControlLogger.Properties.Resources.appbar_close_darkgray;
            this.closeBox.Location = new System.Drawing.Point(833, 10);
            this.closeBox.Margin = new System.Windows.Forms.Padding(2);
            this.closeBox.Name = "closeBox";
            this.closeBox.Size = new System.Drawing.Size(76, 76);
            this.closeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.closeBox.TabIndex = 22;
            this.closeBox.TabStop = false;
            // 
            // statusLabelLabel
            // 
            this.statusLabelLabel.AutoSize = true;
            this.statusLabelLabel.ForeColor = System.Drawing.Color.White;
            this.statusLabelLabel.Location = new System.Drawing.Point(33, 28);
            this.statusLabelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.statusLabelLabel.Name = "statusLabelLabel";
            this.statusLabelLabel.Size = new System.Drawing.Size(43, 13);
            this.statusLabelLabel.TabIndex = 24;
            this.statusLabelLabel.Text = "Status: ";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.ForeColor = System.Drawing.Color.Red;
            this.statusLabel.Location = new System.Drawing.Point(76, 28);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(73, 13);
            this.statusLabel.TabIndex = 25;
            this.statusLabel.Text = "Disconnected";
            // 
            // clearChartButton
            // 
            this.clearChartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearChartButton.ForeColor = System.Drawing.Color.White;
            this.clearChartButton.Location = new System.Drawing.Point(406, 18);
            this.clearChartButton.Name = "clearChartButton";
            this.clearChartButton.Size = new System.Drawing.Size(99, 27);
            this.clearChartButton.TabIndex = 26;
            this.clearChartButton.Text = "Clear Chart";
            this.clearChartButton.UseVisualStyleBackColor = true;
            this.clearChartButton.Click += new System.EventHandler(this.clearChartButton_Click);
            // 
            // ipAddressTextBox
            // 
            this.ipAddressTextBox.AutoCompleteCustomSource.AddRange(new string[] {
            "192.168.1.60"});
            this.ipAddressTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ipAddressTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.ipAddressTextBox.BackColor = System.Drawing.Color.Black;
            this.ipAddressTextBox.ForeColor = System.Drawing.Color.White;
            this.ipAddressTextBox.Location = new System.Drawing.Point(20, 450);
            this.ipAddressTextBox.Name = "ipAddressTextBox";
            this.ipAddressTextBox.Size = new System.Drawing.Size(99, 20);
            this.ipAddressTextBox.TabIndex = 27;
            this.ipAddressTextBox.Text = "192.168.1.60";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(919, 534);
            this.Controls.Add(this.ipAddressTextBox);
            this.Controls.Add(this.clearChartButton);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.statusLabelLabel);
            this.Controls.Add(this.minBox);
            this.Controls.Add(this.closeBox);
            this.Controls.Add(this.runTimeLabel);
            this.Controls.Add(this.runTimeLabelLabel);
            this.Controls.Add(this.latestSampleLabelLabel);
            this.Controls.Add(this.averageNumericUpDown);
            this.Controls.Add(this.averageUnitsLabel);
            this.Controls.Add(this.windowNumericUpDown);
            this.Controls.Add(this.windowUnitsLabel);
            this.Controls.Add(this.tempNumericUpDown);
            this.Controls.Add(this.forceStartButton);
            this.Controls.Add(this.forceStopButton);
            this.Controls.Add(this.autoModeButton);
            this.Controls.Add(this.comPortListBox);
            this.Controls.Add(this.tempUnitsLabel);
            this.Controls.Add(this.setAverageButton);
            this.Controls.Add(this.setWindowButton);
            this.Controls.Add(this.setTempButton);
            this.Controls.Add(this.latestSampleLabel);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.chart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "USB Temperature Control Logger";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.averageNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label latestSampleLabel;
        private System.Windows.Forms.Button setTempButton;
        private System.Windows.Forms.Button setWindowButton;
        private System.Windows.Forms.Button setAverageButton;
        private System.Windows.Forms.Label tempUnitsLabel;
        private System.Windows.Forms.ListBox comPortListBox;
        private System.Windows.Forms.Button autoModeButton;
        private System.Windows.Forms.Button forceStopButton;
        private System.Windows.Forms.Button forceStartButton;
        private System.Windows.Forms.NumericUpDown tempNumericUpDown;
        private System.Windows.Forms.NumericUpDown windowNumericUpDown;
        private System.Windows.Forms.Label windowUnitsLabel;
        private System.Windows.Forms.NumericUpDown averageNumericUpDown;
        private System.Windows.Forms.Label averageUnitsLabel;
        private System.Windows.Forms.Label latestSampleLabelLabel;
        private System.Windows.Forms.Label runTimeLabelLabel;
        private System.Windows.Forms.Label runTimeLabel;
        private System.Windows.Forms.PictureBox closeBox;
        private System.Windows.Forms.PictureBox minBox;
        private System.Windows.Forms.Label statusLabelLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button clearChartButton;
        private System.Windows.Forms.TextBox ipAddressTextBox;
    }
}

