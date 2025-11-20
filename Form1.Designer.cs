namespace SG_SA_Sequence
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_SG_address = new System.Windows.Forms.TextBox();
            this.textBox_SA_address = new System.Windows.Forms.TextBox();
            this.button_SG_connection = new System.Windows.Forms.Button();
            this.button_SA_connection = new System.Windows.Forms.Button();
            this.label_connection = new System.Windows.Forms.Label();
            this.label__input_signal_set = new System.Windows.Forms.Label();
            this.textFreq1 = new System.Windows.Forms.TextBox();
            this.textFreq2 = new System.Windows.Forms.TextBox();
            this.textFreq3 = new System.Windows.Forms.TextBox();
            this.textFreq4 = new System.Windows.Forms.TextBox();
            this.textFreq5 = new System.Windows.Forms.TextBox();
            this.label_Unit1 = new System.Windows.Forms.Label();
            this.label_Unit2 = new System.Windows.Forms.Label();
            this.label_Unit3 = new System.Windows.Forms.Label();
            this.label_Unit4 = new System.Windows.Forms.Label();
            this.label_Unit5 = new System.Windows.Forms.Label();
            this.textPower1 = new System.Windows.Forms.TextBox();
            this.textPower2 = new System.Windows.Forms.TextBox();
            this.textPower3 = new System.Windows.Forms.TextBox();
            this.textPower4 = new System.Windows.Forms.TextBox();
            this.textPower5 = new System.Windows.Forms.TextBox();
            this.label_Unit6 = new System.Windows.Forms.Label();
            this.label_Unit7 = new System.Windows.Forms.Label();
            this.label_Unit8 = new System.Windows.Forms.Label();
            this.label_Unit9 = new System.Windows.Forms.Label();
            this.label_Unit10 = new System.Windows.Forms.Label();
            this.label_freq1 = new System.Windows.Forms.Label();
            this.label_freq2 = new System.Windows.Forms.Label();
            this.label_freq3 = new System.Windows.Forms.Label();
            this.label_freq4 = new System.Windows.Forms.Label();
            this.label_freq5 = new System.Windows.Forms.Label();
            this.button_Measurement = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_Result = new System.Windows.Forms.Label();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.button_Reset = new System.Windows.Forms.Button();
            this.button_Freq1_Set = new System.Windows.Forms.Button();
            this.button_Freq2_Set = new System.Windows.Forms.Button();
            this.button_Freq3_Set = new System.Windows.Forms.Button();
            this.button_Freq4_Set = new System.Windows.Forms.Button();
            this.button_Freq5_Set = new System.Windows.Forms.Button();
            this.textBox_save_location = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(519, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Frequency Range : 250 kHz ~ 3.0 GHz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(519, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Power Range : -136 dBm ~ 20 dBm";
            // 
            // textBox_SG_address
            // 
            this.textBox_SG_address.Location = new System.Drawing.Point(23, 39);
            this.textBox_SG_address.Name = "textBox_SG_address";
            this.textBox_SG_address.Size = new System.Drawing.Size(255, 20);
            this.textBox_SG_address.TabIndex = 2;
            this.textBox_SG_address.Text = "GPIB0::5::INSTR";
            // 
            // textBox_SA_address
            // 
            this.textBox_SA_address.Location = new System.Drawing.Point(474, 39);
            this.textBox_SA_address.Name = "textBox_SA_address";
            this.textBox_SA_address.Size = new System.Drawing.Size(255, 20);
            this.textBox_SA_address.TabIndex = 3;
            this.textBox_SA_address.Text = "192.168.32.10";
            // 
            // button_SG_connection
            // 
            this.button_SG_connection.Location = new System.Drawing.Point(284, 37);
            this.button_SG_connection.Name = "button_SG_connection";
            this.button_SG_connection.Size = new System.Drawing.Size(148, 23);
            this.button_SG_connection.TabIndex = 4;
            this.button_SG_connection.Text = "SG Connect";
            this.button_SG_connection.UseVisualStyleBackColor = true;
            this.button_SG_connection.Click += new System.EventHandler(this.button_SG_connection_Click_1);
            // 
            // button_SA_connection
            // 
            this.button_SA_connection.Location = new System.Drawing.Point(735, 36);
            this.button_SA_connection.Name = "button_SA_connection";
            this.button_SA_connection.Size = new System.Drawing.Size(148, 23);
            this.button_SA_connection.TabIndex = 5;
            this.button_SA_connection.Text = "SA Connect";
            this.button_SA_connection.UseVisualStyleBackColor = true;
            this.button_SA_connection.Click += new System.EventHandler(this.button_SA_connection_Click_1);
            // 
            // label_connection
            // 
            this.label_connection.AutoSize = true;
            this.label_connection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_connection.Location = new System.Drawing.Point(20, 23);
            this.label_connection.Name = "label_connection";
            this.label_connection.Size = new System.Drawing.Size(174, 13);
            this.label_connection.TabIndex = 6;
            this.label_connection.Text = "Instrument Connection Check";
            // 
            // label__input_signal_set
            // 
            this.label__input_signal_set.AutoSize = true;
            this.label__input_signal_set.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label__input_signal_set.Location = new System.Drawing.Point(20, 71);
            this.label__input_signal_set.Name = "label__input_signal_set";
            this.label__input_signal_set.Size = new System.Drawing.Size(133, 13);
            this.label__input_signal_set.TabIndex = 7;
            this.label__input_signal_set.Text = "Set Input Signal in SG";
            // 
            // textFreq1
            // 
            this.textFreq1.Location = new System.Drawing.Point(106, 87);
            this.textFreq1.Name = "textFreq1";
            this.textFreq1.Size = new System.Drawing.Size(97, 20);
            this.textFreq1.TabIndex = 8;
            // 
            // textFreq2
            // 
            this.textFreq2.Location = new System.Drawing.Point(106, 113);
            this.textFreq2.Name = "textFreq2";
            this.textFreq2.Size = new System.Drawing.Size(97, 20);
            this.textFreq2.TabIndex = 9;
            // 
            // textFreq3
            // 
            this.textFreq3.Location = new System.Drawing.Point(106, 139);
            this.textFreq3.Name = "textFreq3";
            this.textFreq3.Size = new System.Drawing.Size(97, 20);
            this.textFreq3.TabIndex = 10;
            // 
            // textFreq4
            // 
            this.textFreq4.Location = new System.Drawing.Point(106, 165);
            this.textFreq4.Name = "textFreq4";
            this.textFreq4.Size = new System.Drawing.Size(97, 20);
            this.textFreq4.TabIndex = 11;
            // 
            // textFreq5
            // 
            this.textFreq5.Location = new System.Drawing.Point(106, 191);
            this.textFreq5.Name = "textFreq5";
            this.textFreq5.Size = new System.Drawing.Size(97, 20);
            this.textFreq5.TabIndex = 12;
            // 
            // label_Unit1
            // 
            this.label_Unit1.AutoSize = true;
            this.label_Unit1.Location = new System.Drawing.Point(209, 90);
            this.label_Unit1.Name = "label_Unit1";
            this.label_Unit1.Size = new System.Drawing.Size(29, 13);
            this.label_Unit1.TabIndex = 13;
            this.label_Unit1.Text = "MHz";
            // 
            // label_Unit2
            // 
            this.label_Unit2.AutoSize = true;
            this.label_Unit2.Location = new System.Drawing.Point(209, 116);
            this.label_Unit2.Name = "label_Unit2";
            this.label_Unit2.Size = new System.Drawing.Size(29, 13);
            this.label_Unit2.TabIndex = 14;
            this.label_Unit2.Text = "MHz";
            // 
            // label_Unit3
            // 
            this.label_Unit3.AutoSize = true;
            this.label_Unit3.Location = new System.Drawing.Point(209, 142);
            this.label_Unit3.Name = "label_Unit3";
            this.label_Unit3.Size = new System.Drawing.Size(29, 13);
            this.label_Unit3.TabIndex = 15;
            this.label_Unit3.Text = "MHz";
            // 
            // label_Unit4
            // 
            this.label_Unit4.AutoSize = true;
            this.label_Unit4.Location = new System.Drawing.Point(209, 168);
            this.label_Unit4.Name = "label_Unit4";
            this.label_Unit4.Size = new System.Drawing.Size(29, 13);
            this.label_Unit4.TabIndex = 16;
            this.label_Unit4.Text = "MHz";
            // 
            // label_Unit5
            // 
            this.label_Unit5.AutoSize = true;
            this.label_Unit5.Location = new System.Drawing.Point(209, 194);
            this.label_Unit5.Name = "label_Unit5";
            this.label_Unit5.Size = new System.Drawing.Size(29, 13);
            this.label_Unit5.TabIndex = 17;
            this.label_Unit5.Text = "MHz";
            // 
            // textPower1
            // 
            this.textPower1.Location = new System.Drawing.Point(257, 87);
            this.textPower1.Name = "textPower1";
            this.textPower1.Size = new System.Drawing.Size(77, 20);
            this.textPower1.TabIndex = 18;
            // 
            // textPower2
            // 
            this.textPower2.Location = new System.Drawing.Point(257, 113);
            this.textPower2.Name = "textPower2";
            this.textPower2.Size = new System.Drawing.Size(77, 20);
            this.textPower2.TabIndex = 19;
            // 
            // textPower3
            // 
            this.textPower3.Location = new System.Drawing.Point(257, 139);
            this.textPower3.Name = "textPower3";
            this.textPower3.Size = new System.Drawing.Size(77, 20);
            this.textPower3.TabIndex = 20;
            // 
            // textPower4
            // 
            this.textPower4.Location = new System.Drawing.Point(257, 165);
            this.textPower4.Name = "textPower4";
            this.textPower4.Size = new System.Drawing.Size(77, 20);
            this.textPower4.TabIndex = 21;
            // 
            // textPower5
            // 
            this.textPower5.Location = new System.Drawing.Point(257, 191);
            this.textPower5.Name = "textPower5";
            this.textPower5.Size = new System.Drawing.Size(77, 20);
            this.textPower5.TabIndex = 22;
            // 
            // label_Unit6
            // 
            this.label_Unit6.AutoSize = true;
            this.label_Unit6.Location = new System.Drawing.Point(340, 90);
            this.label_Unit6.Name = "label_Unit6";
            this.label_Unit6.Size = new System.Drawing.Size(28, 13);
            this.label_Unit6.TabIndex = 23;
            this.label_Unit6.Text = "dBm";
            // 
            // label_Unit7
            // 
            this.label_Unit7.AutoSize = true;
            this.label_Unit7.Location = new System.Drawing.Point(340, 116);
            this.label_Unit7.Name = "label_Unit7";
            this.label_Unit7.Size = new System.Drawing.Size(28, 13);
            this.label_Unit7.TabIndex = 24;
            this.label_Unit7.Text = "dBm";
            // 
            // label_Unit8
            // 
            this.label_Unit8.AutoSize = true;
            this.label_Unit8.Location = new System.Drawing.Point(340, 142);
            this.label_Unit8.Name = "label_Unit8";
            this.label_Unit8.Size = new System.Drawing.Size(28, 13);
            this.label_Unit8.TabIndex = 25;
            this.label_Unit8.Text = "dBm";
            // 
            // label_Unit9
            // 
            this.label_Unit9.AutoSize = true;
            this.label_Unit9.Location = new System.Drawing.Point(340, 168);
            this.label_Unit9.Name = "label_Unit9";
            this.label_Unit9.Size = new System.Drawing.Size(28, 13);
            this.label_Unit9.TabIndex = 26;
            this.label_Unit9.Text = "dBm";
            // 
            // label_Unit10
            // 
            this.label_Unit10.AutoSize = true;
            this.label_Unit10.Location = new System.Drawing.Point(340, 194);
            this.label_Unit10.Name = "label_Unit10";
            this.label_Unit10.Size = new System.Drawing.Size(28, 13);
            this.label_Unit10.TabIndex = 27;
            this.label_Unit10.Text = "dBm";
            // 
            // label_freq1
            // 
            this.label_freq1.AutoSize = true;
            this.label_freq1.Location = new System.Drawing.Point(20, 90);
            this.label_freq1.Name = "label_freq1";
            this.label_freq1.Size = new System.Drawing.Size(88, 13);
            this.label_freq1.TabIndex = 28;
            this.label_freq1.Text = "Test Freq1 : ( f1 )";
            // 
            // label_freq2
            // 
            this.label_freq2.AutoSize = true;
            this.label_freq2.Location = new System.Drawing.Point(20, 116);
            this.label_freq2.Name = "label_freq2";
            this.label_freq2.Size = new System.Drawing.Size(88, 13);
            this.label_freq2.TabIndex = 29;
            this.label_freq2.Text = "Test Freq2 : ( f2 )";
            // 
            // label_freq3
            // 
            this.label_freq3.AutoSize = true;
            this.label_freq3.Location = new System.Drawing.Point(20, 142);
            this.label_freq3.Name = "label_freq3";
            this.label_freq3.Size = new System.Drawing.Size(88, 13);
            this.label_freq3.TabIndex = 30;
            this.label_freq3.Text = "Test Freq3 : ( f3 )";
            // 
            // label_freq4
            // 
            this.label_freq4.AutoSize = true;
            this.label_freq4.Location = new System.Drawing.Point(20, 168);
            this.label_freq4.Name = "label_freq4";
            this.label_freq4.Size = new System.Drawing.Size(88, 13);
            this.label_freq4.TabIndex = 31;
            this.label_freq4.Text = "Test Freq4 : ( f4 )";
            // 
            // label_freq5
            // 
            this.label_freq5.AutoSize = true;
            this.label_freq5.Location = new System.Drawing.Point(20, 194);
            this.label_freq5.Name = "label_freq5";
            this.label_freq5.Size = new System.Drawing.Size(88, 13);
            this.label_freq5.TabIndex = 32;
            this.label_freq5.Text = "Test Freq5 : ( f5 )";
            // 
            // button_Measurement
            // 
            this.button_Measurement.Location = new System.Drawing.Point(23, 229);
            this.button_Measurement.Name = "button_Measurement";
            this.button_Measurement.Size = new System.Drawing.Size(144, 23);
            this.button_Measurement.TabIndex = 33;
            this.button_Measurement.Text = "Measurement";
            this.button_Measurement.UseVisualStyleBackColor = true;
            this.button_Measurement.Click += new System.EventHandler(this.button_Measurement_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dataGridView1.Location = new System.Drawing.Point(23, 282);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(860, 282);
            this.dataGridView1.TabIndex = 34;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Test Freq[MHz]";
            this.Column1.Name = "Column1";
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Measured Power[dBm]";
            this.Column2.Name = "Column2";
            this.Column2.Width = 70;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "2 x Freq[MHz]";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Measured Power[dBm]";
            this.Column4.Name = "Column4";
            this.Column4.Width = 70;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "3 x Freq[MHz]";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Measured Power[dBm]";
            this.Column6.Name = "Column6";
            this.Column6.Width = 70;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "4 x Freq[MHz]";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Measured Power[dBm]";
            this.Column8.Name = "Column8";
            this.Column8.Width = 70;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Offset[dB]";
            this.Column9.Name = "Column9";
            this.Column9.Width = 70;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Noise Floor[dBm]";
            this.Column10.Name = "Column10";
            this.Column10.Width = 80;
            // 
            // label_Result
            // 
            this.label_Result.AutoSize = true;
            this.label_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Result.Location = new System.Drawing.Point(20, 266);
            this.label_Result.Name = "label_Result";
            this.label_Result.Size = new System.Drawing.Size(122, 13);
            this.label_Result.TabIndex = 35;
            this.label_Result.Text = "Measurement Result";
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(244, 580);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(144, 23);
            this.button_Save.TabIndex = 36;
            this.button_Save.Text = "Save Data to Excel";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click_1);
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(739, 580);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(144, 23);
            this.button_Close.TabIndex = 37;
            this.button_Close.Text = "Exit";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click_1);
            // 
            // button_Reset
            // 
            this.button_Reset.Location = new System.Drawing.Point(176, 229);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(144, 23);
            this.button_Reset.TabIndex = 38;
            this.button_Reset.Text = "Reset Setting";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click_1);
            // 
            // button_Freq1_Set
            // 
            this.button_Freq1_Set.Location = new System.Drawing.Point(386, 85);
            this.button_Freq1_Set.Name = "button_Freq1_Set";
            this.button_Freq1_Set.Size = new System.Drawing.Size(112, 23);
            this.button_Freq1_Set.TabIndex = 39;
            this.button_Freq1_Set.Text = "Freq1 Set Complete";
            this.button_Freq1_Set.UseVisualStyleBackColor = true;
            this.button_Freq1_Set.Click += new System.EventHandler(this.button_Freq1_Set_Click_1);
            // 
            // button_Freq2_Set
            // 
            this.button_Freq2_Set.Location = new System.Drawing.Point(386, 112);
            this.button_Freq2_Set.Name = "button_Freq2_Set";
            this.button_Freq2_Set.Size = new System.Drawing.Size(112, 23);
            this.button_Freq2_Set.TabIndex = 40;
            this.button_Freq2_Set.Text = "Freq2 Set Complete";
            this.button_Freq2_Set.UseVisualStyleBackColor = true;
            this.button_Freq2_Set.Click += new System.EventHandler(this.button_Freq2_Set_Click_1);
            // 
            // button_Freq3_Set
            // 
            this.button_Freq3_Set.Location = new System.Drawing.Point(386, 137);
            this.button_Freq3_Set.Name = "button_Freq3_Set";
            this.button_Freq3_Set.Size = new System.Drawing.Size(112, 23);
            this.button_Freq3_Set.TabIndex = 41;
            this.button_Freq3_Set.Text = "Freq3 Set Complete";
            this.button_Freq3_Set.UseVisualStyleBackColor = true;
            this.button_Freq3_Set.Click += new System.EventHandler(this.button_Freq3_Set_Click_1);
            // 
            // button_Freq4_Set
            // 
            this.button_Freq4_Set.Location = new System.Drawing.Point(386, 163);
            this.button_Freq4_Set.Name = "button_Freq4_Set";
            this.button_Freq4_Set.Size = new System.Drawing.Size(112, 23);
            this.button_Freq4_Set.TabIndex = 42;
            this.button_Freq4_Set.Text = "Freq4 Set Complete";
            this.button_Freq4_Set.UseVisualStyleBackColor = true;
            this.button_Freq4_Set.Click += new System.EventHandler(this.button_Freq4_Set_Click_1);
            // 
            // button_Freq5_Set
            // 
            this.button_Freq5_Set.Location = new System.Drawing.Point(386, 189);
            this.button_Freq5_Set.Name = "button_Freq5_Set";
            this.button_Freq5_Set.Size = new System.Drawing.Size(112, 23);
            this.button_Freq5_Set.TabIndex = 43;
            this.button_Freq5_Set.Text = "Freq5 Set Complete";
            this.button_Freq5_Set.UseVisualStyleBackColor = true;
            this.button_Freq5_Set.Click += new System.EventHandler(this.button_Freq5_Set_Click_1);
            // 
            // textBox_save_location
            // 
            this.textBox_save_location.Location = new System.Drawing.Point(23, 582);
            this.textBox_save_location.Name = "textBox_save_location";
            this.textBox_save_location.Size = new System.Drawing.Size(215, 20);
            this.textBox_save_location.TabIndex = 44;
            this.textBox_save_location.Text = "C:\\test";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(895, 628);
            this.Controls.Add(this.textBox_save_location);
            this.Controls.Add(this.button_Freq5_Set);
            this.Controls.Add(this.button_Freq4_Set);
            this.Controls.Add(this.button_Freq3_Set);
            this.Controls.Add(this.button_Freq2_Set);
            this.Controls.Add(this.button_Freq1_Set);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.label_Result);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_Measurement);
            this.Controls.Add(this.label_freq5);
            this.Controls.Add(this.label_freq4);
            this.Controls.Add(this.label_freq3);
            this.Controls.Add(this.label_freq2);
            this.Controls.Add(this.label_freq1);
            this.Controls.Add(this.label_Unit10);
            this.Controls.Add(this.label_Unit9);
            this.Controls.Add(this.label_Unit8);
            this.Controls.Add(this.label_Unit7);
            this.Controls.Add(this.label_Unit6);
            this.Controls.Add(this.textPower5);
            this.Controls.Add(this.textPower4);
            this.Controls.Add(this.textPower3);
            this.Controls.Add(this.textPower2);
            this.Controls.Add(this.textPower1);
            this.Controls.Add(this.label_Unit5);
            this.Controls.Add(this.label_Unit4);
            this.Controls.Add(this.label_Unit3);
            this.Controls.Add(this.label_Unit2);
            this.Controls.Add(this.label_Unit1);
            this.Controls.Add(this.textFreq5);
            this.Controls.Add(this.textFreq4);
            this.Controls.Add(this.textFreq3);
            this.Controls.Add(this.textFreq2);
            this.Controls.Add(this.textFreq1);
            this.Controls.Add(this.label__input_signal_set);
            this.Controls.Add(this.label_connection);
            this.Controls.Add(this.button_SA_connection);
            this.Controls.Add(this.button_SG_connection);
            this.Controls.Add(this.textBox_SA_address);
            this.Controls.Add(this.textBox_SG_address);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Test ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_SG_address;
        private System.Windows.Forms.TextBox textBox_SA_address;
        private System.Windows.Forms.Button button_SG_connection;
        private System.Windows.Forms.Button button_SA_connection;
        private System.Windows.Forms.Label label_connection;
        private System.Windows.Forms.Label label__input_signal_set;
        private System.Windows.Forms.TextBox textFreq1;
        private System.Windows.Forms.TextBox textFreq2;
        private System.Windows.Forms.TextBox textFreq3;
        private System.Windows.Forms.TextBox textFreq4;
        private System.Windows.Forms.TextBox textFreq5;
        private System.Windows.Forms.Label label_Unit1;
        private System.Windows.Forms.Label label_Unit2;
        private System.Windows.Forms.Label label_Unit3;
        private System.Windows.Forms.Label label_Unit4;
        private System.Windows.Forms.Label label_Unit5;
        private System.Windows.Forms.TextBox textPower1;
        private System.Windows.Forms.TextBox textPower2;
        private System.Windows.Forms.TextBox textPower3;
        private System.Windows.Forms.TextBox textPower4;
        private System.Windows.Forms.TextBox textPower5;
        private System.Windows.Forms.Label label_Unit6;
        private System.Windows.Forms.Label label_Unit7;
        private System.Windows.Forms.Label label_Unit8;
        private System.Windows.Forms.Label label_Unit9;
        private System.Windows.Forms.Label label_Unit10;
        private System.Windows.Forms.Label label_freq1;
        private System.Windows.Forms.Label label_freq2;
        private System.Windows.Forms.Label label_freq3;
        private System.Windows.Forms.Label label_freq4;
        private System.Windows.Forms.Label label_freq5;
        private System.Windows.Forms.Button button_Measurement;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_Result;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Button button_Freq1_Set;
        private System.Windows.Forms.Button button_Freq2_Set;
        private System.Windows.Forms.Button button_Freq3_Set;
        private System.Windows.Forms.Button button_Freq4_Set;
        private System.Windows.Forms.Button button_Freq5_Set;
        private System.Windows.Forms.TextBox textBox_save_location;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
    }
}

