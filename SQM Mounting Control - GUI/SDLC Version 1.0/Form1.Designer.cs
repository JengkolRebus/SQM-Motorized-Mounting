namespace SDLC_Version_1._0
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_connect_arduino = new System.Windows.Forms.Button();
            this.port_arduino = new System.Windows.Forms.ComboBox();
            this.btn_read_once = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.port_sqm = new System.Windows.Forms.ComboBox();
            this.btn_connect_sqm = new System.Windows.Forms.Button();
            this.tb_altitude = new System.Windows.Forms.TextBox();
            this.tb_azimuth = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_pos_log = new System.Windows.Forms.ListBox();
            this.cb_manual_interval = new System.Windows.Forms.ComboBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cb_schedule_interval = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_set = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_schedule_task = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.tb_schedule_azm = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_schedule_alt = new System.Windows.Forms.TextBox();
            this.serialPort_arduino = new System.IO.Ports.SerialPort(this.components);
            this.serialPort_sqm = new System.IO.Ports.SerialPort(this.components);
            this.interval_manual = new System.Windows.Forms.Timer(this.components);
            this.interval_schedule = new System.Windows.Forms.Timer(this.components);
            this.lb_current_time = new System.Windows.Forms.Label();
            this.current_time_from = new System.Windows.Forms.Timer(this.components);
            this.btn_save = new System.Windows.Forms.Button();
            this.tb_log = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tb_savefile = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(244, 6);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(561, 316);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // btn_connect_arduino
            // 
            this.btn_connect_arduino.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_connect_arduino.FlatAppearance.BorderSize = 0;
            this.btn_connect_arduino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_connect_arduino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_connect_arduino.ForeColor = System.Drawing.Color.White;
            this.btn_connect_arduino.Location = new System.Drawing.Point(6, 46);
            this.btn_connect_arduino.Name = "btn_connect_arduino";
            this.btn_connect_arduino.Size = new System.Drawing.Size(96, 28);
            this.btn_connect_arduino.TabIndex = 21;
            this.btn_connect_arduino.Text = "Connect";
            this.btn_connect_arduino.UseVisualStyleBackColor = false;
            this.btn_connect_arduino.Click += new System.EventHandler(this.btn_connect_arduino_Click);
            // 
            // port_arduino
            // 
            this.port_arduino.FormattingEnabled = true;
            this.port_arduino.Location = new System.Drawing.Point(6, 19);
            this.port_arduino.Name = "port_arduino";
            this.port_arduino.Size = new System.Drawing.Size(96, 21);
            this.port_arduino.TabIndex = 22;
            // 
            // btn_read_once
            // 
            this.btn_read_once.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_read_once.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_read_once.FlatAppearance.BorderSize = 0;
            this.btn_read_once.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_read_once.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_read_once.ForeColor = System.Drawing.Color.White;
            this.btn_read_once.Location = new System.Drawing.Point(102, 386);
            this.btn_read_once.Name = "btn_read_once";
            this.btn_read_once.Size = new System.Drawing.Size(65, 28);
            this.btn_read_once.TabIndex = 23;
            this.btn_read_once.Text = "Read";
            this.btn_read_once.UseVisualStyleBackColor = false;
            this.btn_read_once.Click += new System.EventHandler(this.btn_read_once_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_clear.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_clear.FlatAppearance.BorderSize = 0;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(173, 386);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(65, 28);
            this.btn_clear.TabIndex = 24;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // port_sqm
            // 
            this.port_sqm.FormattingEnabled = true;
            this.port_sqm.Location = new System.Drawing.Point(5, 19);
            this.port_sqm.Name = "port_sqm";
            this.port_sqm.Size = new System.Drawing.Size(96, 21);
            this.port_sqm.TabIndex = 26;
            // 
            // btn_connect_sqm
            // 
            this.btn_connect_sqm.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_connect_sqm.FlatAppearance.BorderSize = 0;
            this.btn_connect_sqm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_connect_sqm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_connect_sqm.ForeColor = System.Drawing.Color.White;
            this.btn_connect_sqm.Location = new System.Drawing.Point(5, 46);
            this.btn_connect_sqm.Name = "btn_connect_sqm";
            this.btn_connect_sqm.Size = new System.Drawing.Size(96, 28);
            this.btn_connect_sqm.TabIndex = 25;
            this.btn_connect_sqm.Text = "Connect";
            this.btn_connect_sqm.UseVisualStyleBackColor = false;
            this.btn_connect_sqm.Click += new System.EventHandler(this.btn_connect_sqm_Click);
            // 
            // tb_altitude
            // 
            this.tb_altitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_altitude.Location = new System.Drawing.Point(75, 22);
            this.tb_altitude.Name = "tb_altitude";
            this.tb_altitude.Size = new System.Drawing.Size(36, 23);
            this.tb_altitude.TabIndex = 27;
            // 
            // tb_azimuth
            // 
            this.tb_azimuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_azimuth.Location = new System.Drawing.Point(75, 51);
            this.tb_azimuth.Name = "tb_azimuth";
            this.tb_azimuth.Size = new System.Drawing.Size(36, 23);
            this.tb_azimuth.TabIndex = 28;
            // 
            // btn_send
            // 
            this.btn_send.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_send.FlatAppearance.BorderSize = 0;
            this.btn_send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_send.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_send.ForeColor = System.Drawing.Color.White;
            this.btn_send.Location = new System.Drawing.Point(46, 80);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(65, 28);
            this.btn_send.TabIndex = 29;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = false;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Altitude";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Azimuth";
            // 
            // lb_pos_log
            // 
            this.lb_pos_log.FormattingEnabled = true;
            this.lb_pos_log.Location = new System.Drawing.Point(117, 27);
            this.lb_pos_log.Name = "lb_pos_log";
            this.lb_pos_log.Size = new System.Drawing.Size(109, 82);
            this.lb_pos_log.TabIndex = 32;
            // 
            // cb_manual_interval
            // 
            this.cb_manual_interval.DropDownHeight = 50;
            this.cb_manual_interval.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_manual_interval.FormattingEnabled = true;
            this.cb_manual_interval.IntegralHeight = false;
            this.cb_manual_interval.ItemHeight = 16;
            this.cb_manual_interval.Items.AddRange(new object[] {
            "1000",
            "2000",
            "3000",
            "4000",
            "5000",
            "6000",
            "7000",
            "8000",
            "9000",
            "10000",
            "11000",
            "12000",
            "13000",
            "14000",
            "15000",
            "16000",
            "17000",
            "18000",
            "19000",
            "20000",
            "21000",
            "22000",
            "23000",
            "24000",
            "25000",
            "26000",
            "27000",
            "28000",
            "29000",
            "30000",
            "31000",
            "32000",
            "33000",
            "34000",
            "35000",
            "36000",
            "37000",
            "38000",
            "39000",
            "40000",
            "41000",
            "42000",
            "43000",
            "44000",
            "45000",
            "46000",
            "47000",
            "48000",
            "49000",
            "50000",
            "51000",
            "52000",
            "53000",
            "54000",
            "55000",
            "56000",
            "57000",
            "58000",
            "59000",
            "60000"});
            this.cb_manual_interval.Location = new System.Drawing.Point(6, 19);
            this.cb_manual_interval.Name = "cb_manual_interval";
            this.cb_manual_interval.Size = new System.Drawing.Size(65, 24);
            this.cb_manual_interval.TabIndex = 33;
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.Red;
            this.btn_start.FlatAppearance.BorderSize = 0;
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.ForeColor = System.Drawing.Color.White;
            this.btn_start.Location = new System.Drawing.Point(6, 49);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(97, 28);
            this.btn_start.TabIndex = 34;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_stop.FlatAppearance.BorderSize = 0;
            this.btn_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stop.ForeColor = System.Drawing.Color.White;
            this.btn_stop.Location = new System.Drawing.Point(6, 83);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(97, 28);
            this.btn_stop.TabIndex = 35;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = false;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(77, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "ms";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(9, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 108);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Port Setting";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_connect_sqm);
            this.groupBox3.Controls.Add(this.port_sqm);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(119, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(107, 82);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SQM Port";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.port_arduino);
            this.groupBox2.Controls.Add(this.btn_connect_arduino);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(107, 82);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Controller Port";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.Controls.Add(this.cb_manual_interval);
            this.groupBox4.Controls.Add(this.btn_start);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.btn_stop);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(697, 336);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(109, 118);
            this.groupBox4.TabIndex = 38;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Interval";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.tb_altitude);
            this.groupBox5.Controls.Add(this.tb_azimuth);
            this.groupBox5.Controls.Add(this.lb_pos_log);
            this.groupBox5.Controls.Add(this.btn_send);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(9, 120);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(232, 115);
            this.groupBox5.TabIndex = 39;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Position";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(74, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(84, 23);
            this.dateTimePicker1.TabIndex = 40;
            // 
            // cb_schedule_interval
            // 
            this.cb_schedule_interval.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_schedule_interval.FormattingEnabled = true;
            this.cb_schedule_interval.Items.AddRange(new object[] {
            "1000",
            "2000",
            "3000",
            "4000",
            "5000",
            "6000",
            "7000",
            "8000",
            "9000",
            "10000",
            "11000",
            "12000",
            "13000",
            "14000",
            "15000",
            "16000",
            "17000",
            "18000",
            "19000",
            "20000",
            "21000",
            "22000",
            "23000",
            "24000",
            "25000",
            "26000",
            "27000",
            "28000",
            "29000",
            "30000",
            "31000",
            "32000",
            "33000",
            "34000",
            "35000",
            "36000",
            "37000",
            "38000",
            "39000",
            "40000",
            "41000",
            "42000",
            "43000",
            "44000",
            "45000",
            "46000",
            "47000",
            "48000",
            "49000",
            "50000",
            "51000",
            "52000",
            "53000",
            "54000",
            "55000",
            "56000",
            "57000",
            "58000",
            "59000",
            "60000"});
            this.cb_schedule_interval.Location = new System.Drawing.Point(75, 109);
            this.cb_schedule_interval.Name = "cb_schedule_interval";
            this.cb_schedule_interval.Size = new System.Drawing.Size(65, 24);
            this.cb_schedule_interval.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(146, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "ms";
            // 
            // btn_set
            // 
            this.btn_set.BackColor = System.Drawing.Color.DarkRed;
            this.btn_set.FlatAppearance.BorderSize = 0;
            this.btn_set.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_set.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_set.ForeColor = System.Drawing.Color.White;
            this.btn_set.Location = new System.Drawing.Point(75, 169);
            this.btn_set.Name = "btn_set";
            this.btn_set.Size = new System.Drawing.Size(97, 28);
            this.btn_set.TabIndex = 37;
            this.btn_set.Text = "Set";
            this.btn_set.UseVisualStyleBackColor = false;
            this.btn_set.Click += new System.EventHandler(this.btn_set_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(26, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 44;
            this.label5.Text = "Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(25, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 45;
            this.label6.Text = "Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(7, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 46;
            this.label7.Text = "Interval";
            // 
            // tb_schedule_task
            // 
            this.tb_schedule_task.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_schedule_task.Location = new System.Drawing.Point(6, 203);
            this.tb_schedule_task.Name = "tb_schedule_task";
            this.tb_schedule_task.Size = new System.Drawing.Size(221, 23);
            this.tb_schedule_task.TabIndex = 47;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.comboBox1);
            this.groupBox6.Controls.Add(this.dateTimePicker2);
            this.groupBox6.Controls.Add(this.tb_schedule_azm);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.tb_schedule_alt);
            this.groupBox6.Controls.Add(this.dateTimePicker1);
            this.groupBox6.Controls.Add(this.tb_schedule_task);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.cb_schedule_interval);
            this.groupBox6.Controls.Add(this.btn_set);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.ForeColor = System.Drawing.Color.White;
            this.groupBox6.Location = new System.Drawing.Point(6, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(232, 233);
            this.groupBox6.TabIndex = 48;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Schedule";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(19, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 17);
            this.label9.TabIndex = 51;
            this.label9.Text = "Count";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1000",
            "2000",
            "3000",
            "4000",
            "5000",
            "6000",
            "7000",
            "8000",
            "9000",
            "10000",
            "11000",
            "12000",
            "13000",
            "14000",
            "15000",
            "16000",
            "17000",
            "18000",
            "19000",
            "20000",
            "21000",
            "22000",
            "23000",
            "24000",
            "25000",
            "26000",
            "27000",
            "28000",
            "29000",
            "30000",
            "31000",
            "32000",
            "33000",
            "34000",
            "35000",
            "36000",
            "37000",
            "38000",
            "39000",
            "40000",
            "41000",
            "42000",
            "43000",
            "44000",
            "45000",
            "46000",
            "47000",
            "48000",
            "49000",
            "50000",
            "51000",
            "52000",
            "53000",
            "54000",
            "55000",
            "56000",
            "57000",
            "58000",
            "59000",
            "60000"});
            this.comboBox1.Location = new System.Drawing.Point(75, 139);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(65, 24);
            this.comboBox1.TabIndex = 50;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(75, 51);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(78, 23);
            this.dateTimePicker2.TabIndex = 49;
            // 
            // tb_schedule_azm
            // 
            this.tb_schedule_azm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_schedule_azm.Location = new System.Drawing.Point(117, 80);
            this.tb_schedule_azm.Name = "tb_schedule_azm";
            this.tb_schedule_azm.Size = new System.Drawing.Size(36, 23);
            this.tb_schedule_azm.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 48;
            this.label8.Text = "Position";
            // 
            // tb_schedule_alt
            // 
            this.tb_schedule_alt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_schedule_alt.Location = new System.Drawing.Point(75, 80);
            this.tb_schedule_alt.Name = "tb_schedule_alt";
            this.tb_schedule_alt.Size = new System.Drawing.Size(36, 23);
            this.tb_schedule_alt.TabIndex = 33;
            // 
            // serialPort_sqm
            // 
            this.serialPort_sqm.BaudRate = 115200;
            this.serialPort_sqm.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_sqm_DataReceived);
            // 
            // interval_manual
            // 
            this.interval_manual.Interval = 1000;
            this.interval_manual.Tick += new System.EventHandler(this.timer_manual_Tick);
            // 
            // interval_schedule
            // 
            this.interval_schedule.Tick += new System.EventHandler(this.interval_schedule_Tick);
            // 
            // lb_current_time
            // 
            this.lb_current_time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_current_time.AutoSize = true;
            this.lb_current_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_current_time.ForeColor = System.Drawing.Color.White;
            this.lb_current_time.Location = new System.Drawing.Point(12, 489);
            this.lb_current_time.Name = "lb_current_time";
            this.lb_current_time.Size = new System.Drawing.Size(102, 17);
            this.lb_current_time.TabIndex = 49;
            this.lb_current_time.Text = "Current Time";
            // 
            // current_time_from
            // 
            this.current_time_from.Interval = 1000;
            this.current_time_from.Tick += new System.EventHandler(this.current_time_from_Tick);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_save.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(173, 424);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(65, 28);
            this.btn_save.TabIndex = 50;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // tb_log
            // 
            this.tb_log.Location = new System.Drawing.Point(244, 6);
            this.tb_log.Multiline = true;
            this.tb_log.Name = "tb_log";
            this.tb_log.Size = new System.Drawing.Size(523, 316);
            this.tb_log.TabIndex = 51;
            this.tb_log.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(135, 241);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(103, 23);
            this.textBox1.TabIndex = 52;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(135, 270);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(103, 23);
            this.textBox2.TabIndex = 53;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(135, 299);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(103, 23);
            this.textBox3.TabIndex = 54;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(135, 328);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(103, 23);
            this.textBox4.TabIndex = 55;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(820, 486);
            this.tabControl1.TabIndex = 56;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tabPage1.Controls.Add(this.tb_savefile);
            this.tabPage1.Controls.Add(this.chart1);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.textBox5);
            this.tabPage1.Controls.Add(this.tb_log);
            this.tabPage1.Controls.Add(this.btn_save);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.btn_clear);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.btn_read_once);
            this.tabPage1.Controls.Add(this.textBox6);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(812, 460);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Reading";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(263, 345);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 17);
            this.label11.TabIndex = 33;
            this.label11.Text = "Location";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(626, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 28);
            this.button1.TabIndex = 58;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(135, 357);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(103, 23);
            this.textBox5.TabIndex = 56;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(9, 241);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(229, 23);
            this.textBox6.TabIndex = 57;
            this.textBox6.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(812, 460);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Schedule";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.CreatePrompt = true;
            // 
            // tb_savefile
            // 
            this.tb_savefile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_savefile.Location = new System.Drawing.Point(339, 342);
            this.tb_savefile.Name = "tb_savefile";
            this.tb_savefile.Size = new System.Drawing.Size(281, 23);
            this.tb_savefile.TabIndex = 59;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(820, 515);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lb_current_time);
            this.Name = "Form1";
            this.Text = "SDLC";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btn_connect_arduino;
        private System.Windows.Forms.ComboBox port_arduino;
        private System.Windows.Forms.Button btn_read_once;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.ComboBox port_sqm;
        private System.Windows.Forms.Button btn_connect_sqm;
        private System.Windows.Forms.TextBox tb_altitude;
        private System.Windows.Forms.TextBox tb_azimuth;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lb_pos_log;
        private System.Windows.Forms.ComboBox cb_manual_interval;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cb_schedule_interval;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_set;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_schedule_task;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox tb_schedule_azm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_schedule_alt;
        private System.IO.Ports.SerialPort serialPort_arduino;
        private System.IO.Ports.SerialPort serialPort_sqm;
        private System.Windows.Forms.Timer interval_manual;
        private System.Windows.Forms.Timer interval_schedule;
        private System.Windows.Forms.Label lb_current_time;
        private System.Windows.Forms.Timer current_time_from;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox tb_log;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox tb_savefile;
    }
}

