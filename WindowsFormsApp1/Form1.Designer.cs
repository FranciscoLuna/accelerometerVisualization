namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.manageReadingButton = new System.Windows.Forms.Button();
            this.MicrocontrollerPort = new System.IO.Ports.SerialPort(this.components);
            this.receivedPortData = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.portStatus = new System.Windows.Forms.Label();
            this.readPortTimer = new System.Windows.Forms.Timer(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // manageReadingButton
            // 
            this.manageReadingButton.Location = new System.Drawing.Point(281, 581);
            this.manageReadingButton.Name = "manageReadingButton";
            this.manageReadingButton.Size = new System.Drawing.Size(176, 23);
            this.manageReadingButton.TabIndex = 0;
            this.manageReadingButton.Text = "Comenzar lectura";
            this.manageReadingButton.UseVisualStyleBackColor = true;
            this.manageReadingButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // MicrocontrollerPort
            // 
            this.MicrocontrollerPort.PortName = "COM7";
            this.MicrocontrollerPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.MicroconrollerPort_DataReceived);
            // 
            // receivedPortData
            // 
            this.receivedPortData.Location = new System.Drawing.Point(12, 25);
            this.receivedPortData.Multiline = true;
            this.receivedPortData.Name = "receivedPortData";
            this.receivedPortData.Size = new System.Drawing.Size(157, 579);
            this.receivedPortData.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Salida:";
            // 
            // portStatus
            // 
            this.portStatus.AutoSize = true;
            this.portStatus.Location = new System.Drawing.Point(474, 586);
            this.portStatus.Name = "portStatus";
            this.portStatus.Size = new System.Drawing.Size(114, 13);
            this.portStatus.TabIndex = 3;
            this.portStatus.Text = "Estado: No conectado";
            // 
            // readPortTimer
            // 
            this.readPortTimer.Interval = 2;
            this.readPortTimer.Tick += new System.EventHandler(this.readPortTimer_Tick);
            // 
            // chart1
            // 
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.BorderColor = System.Drawing.Color.Maroon;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(185, 25);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Accel. X";
            series1.YValuesPerPoint = 6;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Accel. Y";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Accel. Z";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Gyr. X";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Gyr. Y";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "Gyr. Z";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(603, 550);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 616);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.portStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.receivedPortData);
            this.Controls.Add(this.manageReadingButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button manageReadingButton;
        private System.IO.Ports.SerialPort MicrocontrollerPort;
        private System.Windows.Forms.TextBox receivedPortData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label portStatus;
        private System.Windows.Forms.Timer readPortTimer;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

