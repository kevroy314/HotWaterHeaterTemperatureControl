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
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.logButton = new System.Windows.Forms.Button();
            this.latestSampleLabel = new System.Windows.Forms.Label();
            this.serialInterfaceString = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.setTempButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.setWindowButton = new System.Windows.Forms.Button();
            this.averageTextBox = new System.Windows.Forms.TextBox();
            this.setAverageButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
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
            this.chart.Location = new System.Drawing.Point(0, 0);
            this.chart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.chart.Size = new System.Drawing.Size(1187, 530);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            // 
            // logButton
            // 
            this.logButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logButton.ForeColor = System.Drawing.Color.White;
            this.logButton.Location = new System.Drawing.Point(213, 540);
            this.logButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logButton.Name = "logButton";
            this.logButton.Size = new System.Drawing.Size(132, 33);
            this.logButton.TabIndex = 1;
            this.logButton.Text = "Log";
            this.logButton.UseVisualStyleBackColor = true;
            this.logButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // latestSampleLabel
            // 
            this.latestSampleLabel.AutoSize = true;
            this.latestSampleLabel.ForeColor = System.Drawing.Color.White;
            this.latestSampleLabel.Location = new System.Drawing.Point(852, 551);
            this.latestSampleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.latestSampleLabel.Name = "latestSampleLabel";
            this.latestSampleLabel.Size = new System.Drawing.Size(0, 17);
            this.latestSampleLabel.TabIndex = 2;
            // 
            // serialInterfaceString
            // 
            this.serialInterfaceString.BackColor = System.Drawing.Color.Black;
            this.serialInterfaceString.ForeColor = System.Drawing.Color.White;
            this.serialInterfaceString.Location = new System.Drawing.Point(213, 510);
            this.serialInterfaceString.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.serialInterfaceString.Name = "serialInterfaceString";
            this.serialInterfaceString.Size = new System.Drawing.Size(132, 22);
            this.serialInterfaceString.TabIndex = 3;
            this.serialInterfaceString.Text = "COM4";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(722, 508);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "170F";
            // 
            // setTempButton
            // 
            this.setTempButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setTempButton.ForeColor = System.Drawing.Color.White;
            this.setTempButton.Location = new System.Drawing.Point(722, 538);
            this.setTempButton.Margin = new System.Windows.Forms.Padding(4);
            this.setTempButton.Name = "setTempButton";
            this.setTempButton.Size = new System.Drawing.Size(132, 33);
            this.setTempButton.TabIndex = 4;
            this.setTempButton.Text = "Set Temperature";
            this.setTempButton.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Black;
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(582, 508);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 22);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "COM4";
            // 
            // setWindowButton
            // 
            this.setWindowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setWindowButton.ForeColor = System.Drawing.Color.White;
            this.setWindowButton.Location = new System.Drawing.Point(582, 538);
            this.setWindowButton.Margin = new System.Windows.Forms.Padding(4);
            this.setWindowButton.Name = "setWindowButton";
            this.setWindowButton.Size = new System.Drawing.Size(132, 33);
            this.setWindowButton.TabIndex = 6;
            this.setWindowButton.Text = "Set Window";
            this.setWindowButton.UseVisualStyleBackColor = true;
            // 
            // averageTextBox
            // 
            this.averageTextBox.BackColor = System.Drawing.Color.Black;
            this.averageTextBox.ForeColor = System.Drawing.Color.White;
            this.averageTextBox.Location = new System.Drawing.Point(442, 510);
            this.averageTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.averageTextBox.Name = "averageTextBox";
            this.averageTextBox.Size = new System.Drawing.Size(132, 22);
            this.averageTextBox.TabIndex = 9;
            this.averageTextBox.Text = "COM4";
            // 
            // setAverageButton
            // 
            this.setAverageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setAverageButton.ForeColor = System.Drawing.Color.White;
            this.setAverageButton.Location = new System.Drawing.Point(442, 540);
            this.setAverageButton.Margin = new System.Windows.Forms.Padding(4);
            this.setAverageButton.Name = "setAverageButton";
            this.setAverageButton.Size = new System.Drawing.Size(132, 33);
            this.setAverageButton.TabIndex = 8;
            this.setAverageButton.Text = "Set Average";
            this.setAverageButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1188, 586);
            this.Controls.Add(this.averageTextBox);
            this.Controls.Add(this.setAverageButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.setWindowButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.setTempButton);
            this.Controls.Add(this.serialInterfaceString);
            this.Controls.Add(this.latestSampleLabel);
            this.Controls.Add(this.logButton);
            this.Controls.Add(this.chart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Logger";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button logButton;
        private System.Windows.Forms.Label latestSampleLabel;
        private System.Windows.Forms.TextBox serialInterfaceString;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button setTempButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button setWindowButton;
        private System.Windows.Forms.TextBox averageTextBox;
        private System.Windows.Forms.Button setAverageButton;
    }
}

