using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Text.RegularExpressions;

namespace SDLC_Version_1._0
{
    public partial class Form1 : Form
    {
        private string sqm_receive;
        
        public Form1()
        {
            InitializeComponent();
            current_time_from.Enabled = true;
            serialPort_sqm.ReadTimeout = 255;
            string[] ports = SerialPort.GetPortNames();
            foreach(string port in ports)
            {
                port_arduino.Items.Add(port);
                port_sqm.Items.Add(port);
            }
            dateTimePicker2.CustomFormat = "HH:mm";
            dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;

        }

        private void current_time_from_Tick(object sender, EventArgs e)
        {
            lb_current_time.Text = DateTime.Now.ToLongTimeString();
        }

        private void interval_schedule_Tick(object sender, EventArgs e)
        {

        }

        private void btn_connect_arduino_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort_arduino.PortName = port_arduino.SelectedItem.ToString();
                serialPort_arduino.Open();
            }
            catch(Exception arduino_port_connection)
            {
                MessageBox.Show(arduino_port_connection.Message);
            }
        }

        private void btn_connect_sqm_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort_sqm.PortName = port_sqm.SelectedItem.ToString();
                serialPort_sqm.Open();
            }
            catch(Exception sqm_port_connection)
            {
                MessageBox.Show(sqm_port_connection.Message);
            }
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            lb_pos_log.Items.Add("(" + tb_altitude.Text + "," + tb_azimuth.Text + ")");
            tb_log.AppendText("Position: (" + tb_altitude.Text + "," + tb_azimuth.Text + ")"+"\n");
            tb_altitude.Clear();
            tb_azimuth.Clear();
        }

        private void btn_read_once_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort_sqm.Write("rx\r");
            }
            catch(Exception ex_read)
            {
                MessageBox.Show(ex_read.Message);
            }
            
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {

        }

        private void serialPort_sqm_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            sqm_receive = serialPort_sqm.ReadLine();
            this.Invoke(new EventHandler(display_sqm_receive));
            
        }

        private void display_sqm_receive(object sender, EventArgs e)
        {
            textBox6.Text = sqm_receive;
                string[] separator = { "," };
                string datareceive = textBox6.Text;
                string[] values = datareceive.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                textBox1.Text = values[1];
                textBox2.Text = values[2];
                textBox3.Text = values[3];
                textBox4.Text = values[4];
                textBox5.Text = values[5];
            chart1.Series[0].Points.AddY(Regex.Replace(textBox1.Text,"[A-Za-z]",""));
        }

        private void timer_manual_Tick(object sender, EventArgs e)
        {
            serialPort_sqm.Write("rx\r");
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort_sqm.Write("rx\r");
                interval_manual.Interval = Convert.ToInt32(cb_manual_interval.SelectedItem);
                interval_manual.Enabled = true;
                tb_log.AppendText("Interval: " + interval_manual.Interval.ToString() + "ms" + "\n");
            }
            catch(Exception ex_start)
            {
                MessageBox.Show(ex_start.Message);
            }
            
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            interval_manual.Stop();
            tb_log.AppendText("Reading :" + "\n");
        }

        private void btn_set_Click(object sender, EventArgs e)
        {
            tb_schedule_task.Text = dateTimePicker1.Value.ToShortDateString() + "\t" + dateTimePicker2.Value.ToShortTimeString();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string date = DateTime.Now.Day.ToString();
            string month = DateTime.Now.Month.ToString();
            string year = DateTime.Now.Year.ToString();
            string hour = DateTime.Now.Hour.ToString();
            string minute = DateTime.Now.Minute.ToString();
            string second = DateTime.Now.Second.ToString();
            tb_schedule_task.Text = date;
            try
            {
                string pathfile = @"C:\Users\Omicron\Desktop\Data\";
                string filename = date+month+year+hour+minute+second+".txt";
                System.IO.File.WriteAllText(pathfile + filename, tb_log.Text);
                MessageBox.Show("Data disimpan di: " + pathfile);
            }
            catch(Exception ex_save)
            {
                MessageBox.Show(ex_save.Message);
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "SQMReading";
            saveFileDialog1.InitialDirectory = Convert.ToString(Environment.SpecialFolder.MyDocuments);
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tb_savefile.Text = string.Format("{0}", saveFileDialog1.FileName);
            }
        }
    }
}
