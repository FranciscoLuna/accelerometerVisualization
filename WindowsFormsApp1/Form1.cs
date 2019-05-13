using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        /*private char[] portData = new char[100];
        int index = 0;*/

        private int x_range = 1000;
        private int current_max_range;

        private string lineData;
        private int time_acum;
        private bool data_received = false;

        private const string FILE_NAME = "SamplingTest.csv";
        private string COLUMNS_NAME = "time\taccX\taccY\taccY\tgyrX\tgyrY\tgyrZ" + Environment.NewLine;

        string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        private string[] samples = { };

        delegate void updateDataDelegate();

        public Form1()
        {

            InitializeComponent();
            MicrocontrollerPort.Open();

            current_max_range = x_range;

            time_acum = 0;

            chart1.ChartAreas[0].AxisX.Maximum = x_range;

            if (MicrocontrollerPort.IsOpen) { 
                portStatus.Text = "Estado: Conectado";
                File.WriteAllText(Path.Combine(docPath, FILE_NAME), COLUMNS_NAME);
            }
            else
                receivedPortData.Text = "Estado: Fallo en la conexión";
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            //DEPRECATED

            readPortTimer.Enabled = !readPortTimer.Enabled;

            if (readPortTimer.Enabled)
                manageReadingButton.Text = "Pausar lectura";
            else
                manageReadingButton.Text = "Comenzar/reanudar lectura";
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MicrocontrollerPort.Close();
        }

        private void readPortTimer_Tick(object sender, EventArgs e)
        {
            if (data_received)
            {
                extractSampleInformation();
                
                data_received = false;
            }
        }

        private void MicroconrollerPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try {

                if (MicrocontrollerPort.IsOpen)
                {
                    if (MicrocontrollerPort.BytesToRead > 1)
                    {

                        lineData = MicrocontrollerPort.ReadLine();

                        data_received = true;


                    }
                }
            }
            catch
            {
                MicrocontrollerPort.Close();
            }
            
            //this.Invalidate();
        }

        

        private void extractSampleInformation()
        {
            if (lineData != null)
            {
                //receivedPortData.Text += ("---" + lineData + "+++");

                string[] splitted_data = lineData.Split(';');

                if (splitted_data.Length == 7)
                {
                    receivedPortData.Text += (splitted_data[0] + ";");
                    time_acum += int.Parse(splitted_data[0]);

                    // Data to write
                    string sampleLine = lineData.Replace(';', '\t');

                    if (time_acum >= current_max_range)
                    {
                        

                        chart1.ChartAreas[0].AxisX.Minimum = current_max_range;
                        current_max_range += x_range;
                        chart1.ChartAreas[0].AxisX.Maximum = current_max_range;
                        for (int i = 1; i < 4; i++)
                        {
                            chart1.Series[i - 1].Points.Clear();
                        }

                    }

                    for (int i = 1; i < 4; i++)
                    {
                        chart1.Series[i - 1].Points.AddXY(time_acum, int.Parse(splitted_data[i]));
                    }
                    string[] lines = { sampleLine };
                    File.AppendAllLines(Path.Combine(docPath, FILE_NAME), lines);

                }

            }

        }
    }
}
