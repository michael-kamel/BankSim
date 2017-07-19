namespace game_Simulation
{
    partial class Sim_View
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
            this.sec = new System.Windows.Forms.NumericUpDown();
            this.min = new System.Windows.Forms.NumericUpDown();
            this.hour = new System.Windows.Forms.NumericUpDown();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.clock_Stop = new System.Windows.Forms.Button();
            this.clock_Start = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.teller_Clock = new System.Windows.Forms.Timer(this.components);
            this.btn_options = new System.Windows.Forms.Button();
            this.client_Clock = new System.Windows.Forms.Timer(this.components);
            this.capital_lbl = new System.Windows.Forms.Label();
            this.capital_Money_lbl = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.W_lbl_no = new System.Windows.Forms.Label();
            this.DepositLabel = new System.Windows.Forms.Label();
            this.listView3 = new System.Windows.Forms.ListView();
            this.listView4 = new System.Windows.Forms.ListView();
            this.listView5 = new System.Windows.Forms.ListView();
            this.listView6 = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.served_Holder_Label = new System.Windows.Forms.Label();
            this.tdeposited_Holder_Label = new System.Windows.Forms.Label();
            this.twithdrawn_Holder_Label = new System.Windows.Forms.Label();
            this.title_Holder_Label = new System.Windows.Forms.Label();
            this.title_Label = new System.Windows.Forms.Label();
            this.serving_Label = new System.Windows.Forms.Label();
            this.tdeposit_Label = new System.Windows.Forms.Label();
            this.twithdraw_Label = new System.Windows.Forms.Label();
            this.Teller1_Label = new System.Windows.Forms.Label();
            this.Teller2_Label = new System.Windows.Forms.Label();
            this.Teller3_Label = new System.Windows.Forms.Label();
            this.Teller4_Label = new System.Windows.Forms.Label();
            this.Teller5_Label = new System.Windows.Forms.Label();
            this.ATM_Label = new System.Windows.Forms.Label();
            this.listView7 = new System.Windows.Forms.ListView();
            this.OB_Label = new System.Windows.Forms.Label();
            this.days_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.tellers_ComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tellers_Info_Label = new System.Windows.Forms.Label();
            this.buyTeller_button = new System.Windows.Forms.Button();
            this.buyATM_button = new System.Windows.Forms.Button();
            this.buyOB_button = new System.Windows.Forms.Button();
            this.repu_Label = new System.Windows.Forms.Label();
            this.tellerUpgrade_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hour)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.days_NumericUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sec
            // 
            this.sec.Location = new System.Drawing.Point(389, 7);
            this.sec.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.sec.Name = "sec";
            this.sec.ReadOnly = true;
            this.sec.Size = new System.Drawing.Size(45, 24);
            this.sec.TabIndex = 0;
            // 
            // min
            // 
            this.min.Location = new System.Drawing.Point(334, 7);
            this.min.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.min.Name = "min";
            this.min.ReadOnly = true;
            this.min.Size = new System.Drawing.Size(45, 24);
            this.min.TabIndex = 1;
            // 
            // hour
            // 
            this.hour.Location = new System.Drawing.Point(284, 7);
            this.hour.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.hour.Name = "hour";
            this.hour.ReadOnly = true;
            this.hour.Size = new System.Drawing.Size(45, 24);
            this.hour.TabIndex = 2;
            // 
            // clock
            // 
            this.clock.Interval = 1000;
            this.clock.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // clock_Stop
            // 
            this.clock_Stop.Location = new System.Drawing.Point(123, 7);
            this.clock_Stop.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.clock_Stop.Name = "clock_Stop";
            this.clock_Stop.Size = new System.Drawing.Size(101, 27);
            this.clock_Stop.TabIndex = 3;
            this.clock_Stop.Text = "Stop";
            this.clock_Stop.UseVisualStyleBackColor = true;
            this.clock_Stop.Click += new System.EventHandler(this.clock_Stop_Click);
            // 
            // clock_Start
            // 
            this.clock_Start.Location = new System.Drawing.Point(16, 7);
            this.clock_Start.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.clock_Start.Name = "clock_Start";
            this.clock_Start.Size = new System.Drawing.Size(101, 27);
            this.clock_Start.TabIndex = 4;
            this.clock_Start.Text = "Start";
            this.clock_Start.UseVisualStyleBackColor = true;
            this.clock_Start.Click += new System.EventHandler(this.clock_Start_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.Location = new System.Drawing.Point(117, 58);
            this.listView1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(843, 58);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // teller_Clock
            // 
            this.teller_Clock.Interval = 1;
            this.teller_Clock.Tick += new System.EventHandler(this.teller_Clock_Tick);
            // 
            // btn_options
            // 
            this.btn_options.Location = new System.Drawing.Point(444, 4);
            this.btn_options.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_options.Name = "btn_options";
            this.btn_options.Size = new System.Drawing.Size(101, 27);
            this.btn_options.TabIndex = 14;
            this.btn_options.Text = "Options";
            this.btn_options.UseVisualStyleBackColor = true;
            this.btn_options.Click += new System.EventHandler(this.btn_options_Click);
            // 
            // client_Clock
            // 
            this.client_Clock.Interval = 200;
            this.client_Clock.Tick += new System.EventHandler(this.client_Clock_Tick);
            // 
            // capital_lbl
            // 
            this.capital_lbl.AutoSize = true;
            this.capital_lbl.Location = new System.Drawing.Point(7, 40);
            this.capital_lbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.capital_lbl.Name = "capital_lbl";
            this.capital_lbl.Size = new System.Drawing.Size(57, 18);
            this.capital_lbl.TabIndex = 15;
            this.capital_lbl.Text = "Money:";
            // 
            // capital_Money_lbl
            // 
            this.capital_Money_lbl.AutoSize = true;
            this.capital_Money_lbl.Location = new System.Drawing.Point(67, 40);
            this.capital_Money_lbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.capital_Money_lbl.Name = "capital_Money_lbl";
            this.capital_Money_lbl.Size = new System.Drawing.Size(16, 18);
            this.capital_Money_lbl.TabIndex = 16;
            this.capital_Money_lbl.Text = "0";
            // 
            // listView2
            // 
            this.listView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView2.Location = new System.Drawing.Point(117, 125);
            this.listView2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(845, 58);
            this.listView2.TabIndex = 18;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 36);
            this.label1.TabIndex = 19;
            this.label1.Text = "W:\r\nD:";
            // 
            // W_lbl_no
            // 
            this.W_lbl_no.AutoSize = true;
            this.W_lbl_no.Location = new System.Drawing.Point(270, 40);
            this.W_lbl_no.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.W_lbl_no.Name = "W_lbl_no";
            this.W_lbl_no.Size = new System.Drawing.Size(16, 18);
            this.W_lbl_no.TabIndex = 20;
            this.W_lbl_no.Text = "0";
            // 
            // DepositLabel
            // 
            this.DepositLabel.AutoSize = true;
            this.DepositLabel.Location = new System.Drawing.Point(270, 58);
            this.DepositLabel.Name = "DepositLabel";
            this.DepositLabel.Size = new System.Drawing.Size(16, 18);
            this.DepositLabel.TabIndex = 21;
            this.DepositLabel.Text = "0";
            // 
            // listView3
            // 
            this.listView3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView3.Location = new System.Drawing.Point(117, 190);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(845, 58);
            this.listView3.TabIndex = 22;
            this.listView3.UseCompatibleStateImageBehavior = false;
            // 
            // listView4
            // 
            this.listView4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView4.Location = new System.Drawing.Point(117, 255);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(845, 58);
            this.listView4.TabIndex = 23;
            this.listView4.UseCompatibleStateImageBehavior = false;
            // 
            // listView5
            // 
            this.listView5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView5.Location = new System.Drawing.Point(117, 321);
            this.listView5.Name = "listView5";
            this.listView5.Size = new System.Drawing.Size(845, 58);
            this.listView5.TabIndex = 24;
            this.listView5.UseCompatibleStateImageBehavior = false;
            // 
            // listView6
            // 
            this.listView6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView6.Location = new System.Drawing.Point(117, 386);
            this.listView6.Name = "listView6";
            this.listView6.Size = new System.Drawing.Size(845, 109);
            this.listView6.TabIndex = 25;
            this.listView6.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.repu_Label);
            this.groupBox1.Controls.Add(this.served_Holder_Label);
            this.groupBox1.Controls.Add(this.tdeposited_Holder_Label);
            this.groupBox1.Controls.Add(this.twithdrawn_Holder_Label);
            this.groupBox1.Controls.Add(this.title_Holder_Label);
            this.groupBox1.Controls.Add(this.title_Label);
            this.groupBox1.Controls.Add(this.serving_Label);
            this.groupBox1.Controls.Add(this.tdeposit_Label);
            this.groupBox1.Controls.Add(this.twithdraw_Label);
            this.groupBox1.Controls.Add(this.capital_lbl);
            this.groupBox1.Controls.Add(this.capital_Money_lbl);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.W_lbl_no);
            this.groupBox1.Controls.Add(this.DepositLabel);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(968, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 450);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bank";
            // 
            // served_Holder_Label
            // 
            this.served_Holder_Label.AutoSize = true;
            this.served_Holder_Label.Location = new System.Drawing.Point(139, 328);
            this.served_Holder_Label.Name = "served_Holder_Label";
            this.served_Holder_Label.Size = new System.Drawing.Size(16, 18);
            this.served_Holder_Label.TabIndex = 29;
            this.served_Holder_Label.Text = "0";
            // 
            // tdeposited_Holder_Label
            // 
            this.tdeposited_Holder_Label.AutoSize = true;
            this.tdeposited_Holder_Label.Location = new System.Drawing.Point(139, 303);
            this.tdeposited_Holder_Label.Name = "tdeposited_Holder_Label";
            this.tdeposited_Holder_Label.Size = new System.Drawing.Size(16, 18);
            this.tdeposited_Holder_Label.TabIndex = 28;
            this.tdeposited_Holder_Label.Text = "0";
            // 
            // twithdrawn_Holder_Label
            // 
            this.twithdrawn_Holder_Label.AutoSize = true;
            this.twithdrawn_Holder_Label.Location = new System.Drawing.Point(139, 279);
            this.twithdrawn_Holder_Label.Name = "twithdrawn_Holder_Label";
            this.twithdrawn_Holder_Label.Size = new System.Drawing.Size(16, 18);
            this.twithdrawn_Holder_Label.TabIndex = 27;
            this.twithdrawn_Holder_Label.Text = "0";
            // 
            // title_Holder_Label
            // 
            this.title_Holder_Label.AutoSize = true;
            this.title_Holder_Label.Location = new System.Drawing.Point(136, 237);
            this.title_Holder_Label.Name = "title_Holder_Label";
            this.title_Holder_Label.Size = new System.Drawing.Size(134, 18);
            this.title_Holder_Label.TabIndex = 26;
            this.title_Holder_Label.Text = "Beginner Banker L1";
            // 
            // title_Label
            // 
            this.title_Label.AutoSize = true;
            this.title_Label.Location = new System.Drawing.Point(7, 237);
            this.title_Label.Name = "title_Label";
            this.title_Label.Size = new System.Drawing.Size(40, 18);
            this.title_Label.TabIndex = 25;
            this.title_Label.Text = "Title:";
            // 
            // serving_Label
            // 
            this.serving_Label.AutoSize = true;
            this.serving_Label.Location = new System.Drawing.Point(7, 328);
            this.serving_Label.Name = "serving_Label";
            this.serving_Label.Size = new System.Drawing.Size(101, 18);
            this.serving_Label.TabIndex = 24;
            this.serving_Label.Text = "Serving Score:";
            // 
            // tdeposit_Label
            // 
            this.tdeposit_Label.AutoSize = true;
            this.tdeposit_Label.Location = new System.Drawing.Point(6, 303);
            this.tdeposit_Label.Name = "tdeposit_Label";
            this.tdeposit_Label.Size = new System.Drawing.Size(115, 18);
            this.tdeposit_Label.TabIndex = 23;
            this.tdeposit_Label.Text = "Total Deposited:";
            // 
            // twithdraw_Label
            // 
            this.twithdraw_Label.AutoSize = true;
            this.twithdraw_Label.Location = new System.Drawing.Point(6, 279);
            this.twithdraw_Label.Name = "twithdraw_Label";
            this.twithdraw_Label.Size = new System.Drawing.Size(119, 18);
            this.twithdraw_Label.TabIndex = 22;
            this.twithdraw_Label.Text = "Total Withdrawn:";
            // 
            // Teller1_Label
            // 
            this.Teller1_Label.AutoSize = true;
            this.Teller1_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teller1_Label.Location = new System.Drawing.Point(27, 75);
            this.Teller1_Label.Name = "Teller1_Label";
            this.Teller1_Label.Size = new System.Drawing.Size(83, 26);
            this.Teller1_Label.TabIndex = 27;
            this.Teller1_Label.Text = "Teller 1";
            // 
            // Teller2_Label
            // 
            this.Teller2_Label.AutoSize = true;
            this.Teller2_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teller2_Label.Location = new System.Drawing.Point(27, 146);
            this.Teller2_Label.Name = "Teller2_Label";
            this.Teller2_Label.Size = new System.Drawing.Size(83, 26);
            this.Teller2_Label.TabIndex = 28;
            this.Teller2_Label.Text = "Teller 2";
            // 
            // Teller3_Label
            // 
            this.Teller3_Label.AutoSize = true;
            this.Teller3_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teller3_Label.Location = new System.Drawing.Point(27, 209);
            this.Teller3_Label.Name = "Teller3_Label";
            this.Teller3_Label.Size = new System.Drawing.Size(83, 26);
            this.Teller3_Label.TabIndex = 29;
            this.Teller3_Label.Text = "Teller 3";
            // 
            // Teller4_Label
            // 
            this.Teller4_Label.AutoSize = true;
            this.Teller4_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teller4_Label.Location = new System.Drawing.Point(27, 274);
            this.Teller4_Label.Name = "Teller4_Label";
            this.Teller4_Label.Size = new System.Drawing.Size(83, 26);
            this.Teller4_Label.TabIndex = 30;
            this.Teller4_Label.Text = "Teller 4";
            // 
            // Teller5_Label
            // 
            this.Teller5_Label.AutoSize = true;
            this.Teller5_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teller5_Label.Location = new System.Drawing.Point(27, 337);
            this.Teller5_Label.Name = "Teller5_Label";
            this.Teller5_Label.Size = new System.Drawing.Size(77, 26);
            this.Teller5_Label.TabIndex = 31;
            this.Teller5_Label.Text = "Teller5";
            // 
            // ATM_Label
            // 
            this.ATM_Label.AutoSize = true;
            this.ATM_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ATM_Label.Location = new System.Drawing.Point(27, 404);
            this.ATM_Label.Name = "ATM_Label";
            this.ATM_Label.Size = new System.Drawing.Size(57, 26);
            this.ATM_Label.TabIndex = 32;
            this.ATM_Label.Text = "ATM";
            // 
            // listView7
            // 
            this.listView7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView7.Location = new System.Drawing.Point(117, 515);
            this.listView7.Name = "listView7";
            this.listView7.Size = new System.Drawing.Size(1232, 238);
            this.listView7.TabIndex = 33;
            this.listView7.UseCompatibleStateImageBehavior = false;
            // 
            // OB_Label
            // 
            this.OB_Label.AutoSize = true;
            this.OB_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OB_Label.Location = new System.Drawing.Point(27, 524);
            this.OB_Label.Name = "OB_Label";
            this.OB_Label.Size = new System.Drawing.Size(44, 26);
            this.OB_Label.TabIndex = 34;
            this.OB_Label.Text = "OB";
            // 
            // days_NumericUpDown
            // 
            this.days_NumericUpDown.Location = new System.Drawing.Point(231, 7);
            this.days_NumericUpDown.Name = "days_NumericUpDown";
            this.days_NumericUpDown.ReadOnly = true;
            this.days_NumericUpDown.Size = new System.Drawing.Size(45, 24);
            this.days_NumericUpDown.TabIndex = 35;
            // 
            // tellers_ComboBox
            // 
            this.tellers_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tellers_ComboBox.FormattingEnabled = true;
            this.tellers_ComboBox.Location = new System.Drawing.Point(6, 38);
            this.tellers_ComboBox.Name = "tellers_ComboBox";
            this.tellers_ComboBox.Size = new System.Drawing.Size(157, 25);
            this.tellers_ComboBox.TabIndex = 36;
            this.tellers_ComboBox.SelectedIndexChanged += new System.EventHandler(this.tellers_ComboBox_SelectedIndexChanged);
            this.tellers_ComboBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tellersComboBox_MouseClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buyOB_button);
            this.groupBox2.Controls.Add(this.buyATM_button);
            this.groupBox2.Controls.Add(this.buyTeller_button);
            this.groupBox2.Controls.Add(this.tellerUpgrade_Button);
            this.groupBox2.Controls.Add(this.tellers_Info_Label);
            this.groupBox2.Controls.Add(this.tellers_ComboBox);
            this.groupBox2.Location = new System.Drawing.Point(1319, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 361);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tellers";
            // 
            // tellers_Info_Label
            // 
            this.tellers_Info_Label.AutoSize = true;
            this.tellers_Info_Label.Location = new System.Drawing.Point(6, 88);
            this.tellers_Info_Label.Name = "tellers_Info_Label";
            this.tellers_Info_Label.Size = new System.Drawing.Size(37, 17);
            this.tellers_Info_Label.TabIndex = 37;
            this.tellers_Info_Label.Text = "Info:";
            // 
            // buyTeller_button
            // 
            this.buyTeller_button.Location = new System.Drawing.Point(9, 323);
            this.buyTeller_button.Name = "buyTeller_button";
            this.buyTeller_button.Size = new System.Drawing.Size(83, 32);
            this.buyTeller_button.TabIndex = 39;
            this.buyTeller_button.Text = "Buy Teller";
            this.buyTeller_button.UseVisualStyleBackColor = true;
            this.buyTeller_button.Click += new System.EventHandler(this.buyTeller_button_Click);
            // 
            // buyATM_button
            // 
            this.buyATM_button.Location = new System.Drawing.Point(115, 323);
            this.buyATM_button.Name = "buyATM_button";
            this.buyATM_button.Size = new System.Drawing.Size(75, 32);
            this.buyATM_button.TabIndex = 40;
            this.buyATM_button.Text = "Buy ATM";
            this.buyATM_button.UseVisualStyleBackColor = true;
            this.buyATM_button.Click += new System.EventHandler(this.buyATM_button_Click);
            // 
            // buyOB_button
            // 
            this.buyOB_button.Location = new System.Drawing.Point(222, 323);
            this.buyOB_button.Name = "buyOB_button";
            this.buyOB_button.Size = new System.Drawing.Size(75, 32);
            this.buyOB_button.TabIndex = 41;
            this.buyOB_button.Text = "Buy OB";
            this.buyOB_button.UseVisualStyleBackColor = true;
            this.buyOB_button.Click += new System.EventHandler(this.buyOB_button_Click);
            // 
            // repu_Label
            // 
            this.repu_Label.AutoSize = true;
            this.repu_Label.Location = new System.Drawing.Point(139, 384);
            this.repu_Label.Name = "repu_Label";
            this.repu_Label.Size = new System.Drawing.Size(16, 18);
            this.repu_Label.TabIndex = 30;
            this.repu_Label.Text = "0";
            // 
            // tellerUpgrade_Button
            // 
            this.tellerUpgrade_Button.Location = new System.Drawing.Point(7, 216);
            this.tellerUpgrade_Button.Name = "tellerUpgrade_Button";
            this.tellerUpgrade_Button.Size = new System.Drawing.Size(156, 39);
            this.tellerUpgrade_Button.TabIndex = 38;
            this.tellerUpgrade_Button.Text = "Upgrade";
            this.tellerUpgrade_Button.UseVisualStyleBackColor = true;
            this.tellerUpgrade_Button.Click += new System.EventHandler(this.tellerUpgrade_Button_Click);
            // 
            // Sim_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1639, 790);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.days_NumericUpDown);
            this.Controls.Add(this.OB_Label);
            this.Controls.Add(this.listView7);
            this.Controls.Add(this.ATM_Label);
            this.Controls.Add(this.Teller5_Label);
            this.Controls.Add(this.Teller4_Label);
            this.Controls.Add(this.Teller3_Label);
            this.Controls.Add(this.Teller2_Label);
            this.Controls.Add(this.Teller1_Label);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView6);
            this.Controls.Add(this.listView5);
            this.Controls.Add(this.listView4);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.btn_options);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.clock_Start);
            this.Controls.Add(this.clock_Stop);
            this.Controls.Add(this.hour);
            this.Controls.Add(this.min);
            this.Controls.Add(this.sec);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Sim_View";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Sim_View_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.sec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hour)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.days_NumericUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown sec;
        private System.Windows.Forms.NumericUpDown min;
        private System.Windows.Forms.NumericUpDown hour;
        private System.Windows.Forms.Timer clock;
        private System.Windows.Forms.Button clock_Stop;
        private System.Windows.Forms.Button clock_Start;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Timer teller_Clock;
        private System.Windows.Forms.Button btn_options;
        private System.Windows.Forms.Timer client_Clock;
        private System.Windows.Forms.Label capital_lbl;
        private System.Windows.Forms.Label capital_Money_lbl;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label W_lbl_no;
        private System.Windows.Forms.Label DepositLabel;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.ListView listView5;
        private System.Windows.Forms.ListView listView6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Teller1_Label;
        private System.Windows.Forms.Label Teller2_Label;
        private System.Windows.Forms.Label Teller3_Label;
        private System.Windows.Forms.Label Teller4_Label;
        private System.Windows.Forms.Label Teller5_Label;
        private System.Windows.Forms.Label ATM_Label;
        private System.Windows.Forms.ListView listView7;
        private System.Windows.Forms.Label OB_Label;
        private System.Windows.Forms.Label twithdraw_Label;
        private System.Windows.Forms.Label tdeposit_Label;
        private System.Windows.Forms.Label serving_Label;
        private System.Windows.Forms.Label title_Label;
        private System.Windows.Forms.NumericUpDown days_NumericUpDown;
        private System.Windows.Forms.Label served_Holder_Label;
        private System.Windows.Forms.Label tdeposited_Holder_Label;
        private System.Windows.Forms.Label twithdrawn_Holder_Label;
        private System.Windows.Forms.Label title_Holder_Label;
        private System.Windows.Forms.ComboBox tellers_ComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label tellers_Info_Label;
        private System.Windows.Forms.Button buyOB_button;
        private System.Windows.Forms.Button buyATM_button;
        private System.Windows.Forms.Button buyTeller_button;
        private System.Windows.Forms.Label repu_Label;
        private System.Windows.Forms.Button tellerUpgrade_Button;
    }
}

