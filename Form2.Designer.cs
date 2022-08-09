namespace HeroFitnessClub
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSearch = new System.Windows.Forms.TabPage();
            this.dtgSearch = new System.Windows.Forms.DataGridView();
            this.btnSrch = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabNewC = new System.Windows.Forms.TabPage();
            this.txtIDnum = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtMemNum = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbGoal = new System.Windows.Forms.ComboBox();
            this.btnRegstr = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbPay = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbPack = new System.Windows.Forms.ComboBox();
            this.txtAdCod = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAdrs2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAdrs1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radFem = new System.Windows.Forms.RadioButton();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.txtCell = new System.Windows.Forms.TextBox();
            this.txtEml = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCAge = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCSrn = new System.Windows.Forms.TextBox();
            this.txtCName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPckg = new System.Windows.Forms.TabPage();
            this.dtgPack = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabRpts = new System.Windows.Forms.TabPage();
            this.tabMantn = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSearch)).BeginInit();
            this.tabNewC.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPckg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPack)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSearch);
            this.tabControl1.Controls.Add(this.tabNewC);
            this.tabControl1.Controls.Add(this.tabPckg);
            this.tabControl1.Controls.Add(this.tabRpts);
            this.tabControl1.Controls.Add(this.tabMantn);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1229, 708);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // tabSearch
            // 
            this.tabSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabSearch.BackgroundImage")));
            this.tabSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabSearch.Controls.Add(this.dtgSearch);
            this.tabSearch.Controls.Add(this.btnSrch);
            this.tabSearch.Controls.Add(this.textBox3);
            this.tabSearch.Controls.Add(this.label3);
            this.tabSearch.Controls.Add(this.textBox2);
            this.tabSearch.Controls.Add(this.label2);
            this.tabSearch.Controls.Add(this.textBox1);
            this.tabSearch.Controls.Add(this.label1);
            this.tabSearch.Location = new System.Drawing.Point(4, 25);
            this.tabSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSearch.Size = new System.Drawing.Size(1209, 679);
            this.tabSearch.TabIndex = 0;
            this.tabSearch.Text = "Search";
            this.tabSearch.UseVisualStyleBackColor = true;
            // 
            // dtgSearch
            // 
            this.dtgSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSearch.Location = new System.Drawing.Point(71, 383);
            this.dtgSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgSearch.Name = "dtgSearch";
            this.dtgSearch.RowHeadersWidth = 51;
            this.dtgSearch.Size = new System.Drawing.Size(531, 185);
            this.dtgSearch.TabIndex = 7;
            // 
            // btnSrch
            // 
            this.btnSrch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSrch.Location = new System.Drawing.Point(217, 327);
            this.btnSrch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSrch.Name = "btnSrch";
            this.btnSrch.Size = new System.Drawing.Size(113, 28);
            this.btnSrch.TabIndex = 6;
            this.btnSrch.Text = "Enter";
            this.btnSrch.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(391, 272);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(209, 26);
            this.textBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(278, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Search by Membership Number:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(391, 182);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(209, 26);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search by Surname:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(391, 100);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search by Name:";
            // 
            // tabNewC
            // 
            this.tabNewC.BackColor = System.Drawing.Color.Transparent;
            this.tabNewC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabNewC.BackgroundImage")));
            this.tabNewC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabNewC.Controls.Add(this.txtIDnum);
            this.tabNewC.Controls.Add(this.label17);
            this.tabNewC.Controls.Add(this.txtMemNum);
            this.tabNewC.Controls.Add(this.label16);
            this.tabNewC.Controls.Add(this.label15);
            this.tabNewC.Controls.Add(this.cmbGoal);
            this.tabNewC.Controls.Add(this.btnRegstr);
            this.tabNewC.Controls.Add(this.label14);
            this.tabNewC.Controls.Add(this.cmbPay);
            this.tabNewC.Controls.Add(this.label13);
            this.tabNewC.Controls.Add(this.cmbPack);
            this.tabNewC.Controls.Add(this.txtAdCod);
            this.tabNewC.Controls.Add(this.label12);
            this.tabNewC.Controls.Add(this.txtAdrs2);
            this.tabNewC.Controls.Add(this.label11);
            this.tabNewC.Controls.Add(this.txtAdrs1);
            this.tabNewC.Controls.Add(this.label10);
            this.tabNewC.Controls.Add(this.label7);
            this.tabNewC.Controls.Add(this.panel1);
            this.tabNewC.Controls.Add(this.txtCell);
            this.tabNewC.Controls.Add(this.txtEml);
            this.tabNewC.Controls.Add(this.label8);
            this.tabNewC.Controls.Add(this.label9);
            this.tabNewC.Controls.Add(this.txtCAge);
            this.tabNewC.Controls.Add(this.label6);
            this.tabNewC.Controls.Add(this.txtCSrn);
            this.tabNewC.Controls.Add(this.txtCName);
            this.tabNewC.Controls.Add(this.label5);
            this.tabNewC.Controls.Add(this.label4);
            this.tabNewC.Location = new System.Drawing.Point(4, 25);
            this.tabNewC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabNewC.Name = "tabNewC";
            this.tabNewC.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabNewC.Size = new System.Drawing.Size(1221, 679);
            this.tabNewC.TabIndex = 1;
            this.tabNewC.Text = "New Client";
            // 
            // txtIDnum
            // 
            this.txtIDnum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIDnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDnum.Location = new System.Drawing.Point(175, 175);
            this.txtIDnum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIDnum.Name = "txtIDnum";
            this.txtIDnum.Size = new System.Drawing.Size(248, 26);
            this.txtIDnum.TabIndex = 4;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(49, 180);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(119, 25);
            this.label17.TabIndex = 27;
            this.label17.Text = "ID Number:";
            // 
            // txtMemNum
            // 
            this.txtMemNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMemNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemNum.Location = new System.Drawing.Point(178, 41);
            this.txtMemNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMemNum.Name = "txtMemNum";
            this.txtMemNum.Size = new System.Drawing.Size(245, 26);
            this.txtMemNum.TabIndex = 26;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(15, 41);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(177, 37);
            this.label16.TabIndex = 25;
            this.label16.Text = "Membership No.";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(837, 502);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(120, 26);
            this.label15.TabIndex = 24;
            this.label15.Text = "Body Goal:";
            // 
            // cmbGoal
            // 
            this.cmbGoal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGoal.FormattingEnabled = true;
            this.cmbGoal.Location = new System.Drawing.Point(963, 498);
            this.cmbGoal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbGoal.Name = "cmbGoal";
            this.cmbGoal.Size = new System.Drawing.Size(181, 28);
            this.cmbGoal.TabIndex = 14;
            // 
            // btnRegstr
            // 
            this.btnRegstr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegstr.BackColor = System.Drawing.SystemColors.Control;
            this.btnRegstr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegstr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegstr.Location = new System.Drawing.Point(178, 566);
            this.btnRegstr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegstr.Name = "btnRegstr";
            this.btnRegstr.Size = new System.Drawing.Size(149, 36);
            this.btnRegstr.TabIndex = 15;
            this.btnRegstr.Text = "Register";
            this.btnRegstr.UseVisualStyleBackColor = false;
            this.btnRegstr.Click += new System.EventHandler(this.btnRegstr_Click);
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(417, 498);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(160, 30);
            this.label14.TabIndex = 21;
            this.label14.Text = "Payment Type:";
            // 
            // cmbPay
            // 
            this.cmbPay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPay.FormattingEnabled = true;
            this.cmbPay.Location = new System.Drawing.Point(583, 498);
            this.cmbPay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbPay.Name = "cmbPay";
            this.cmbPay.Size = new System.Drawing.Size(245, 28);
            this.cmbPay.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(66, 494);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 34);
            this.label13.TabIndex = 19;
            this.label13.Text = "Package:";
            // 
            // cmbPack
            // 
            this.cmbPack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbPack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPack.FormattingEnabled = true;
            this.cmbPack.Location = new System.Drawing.Point(178, 498);
            this.cmbPack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbPack.Name = "cmbPack";
            this.cmbPack.Size = new System.Drawing.Size(231, 28);
            this.cmbPack.TabIndex = 12;
            // 
            // txtAdCod
            // 
            this.txtAdCod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAdCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdCod.Location = new System.Drawing.Point(178, 430);
            this.txtAdCod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAdCod.Name = "txtAdCod";
            this.txtAdCod.Size = new System.Drawing.Size(92, 26);
            this.txtAdCod.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(111, 430);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 25);
            this.label12.TabIndex = 16;
            this.label12.Text = "Code:";
            // 
            // txtAdrs2
            // 
            this.txtAdrs2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAdrs2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdrs2.Location = new System.Drawing.Point(178, 380);
            this.txtAdrs2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAdrs2.Name = "txtAdrs2";
            this.txtAdrs2.Size = new System.Drawing.Size(651, 26);
            this.txtAdrs2.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(62, 380);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 25);
            this.label11.TabIndex = 14;
            this.label11.Text = "Address 2:";
            // 
            // txtAdrs1
            // 
            this.txtAdrs1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAdrs1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdrs1.Location = new System.Drawing.Point(178, 326);
            this.txtAdrs1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAdrs1.Name = "txtAdrs1";
            this.txtAdrs1.Size = new System.Drawing.Size(651, 26);
            this.txtAdrs1.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(62, 326);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 25);
            this.label10.TabIndex = 12;
            this.label10.Text = "Address 1:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(75, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 31);
            this.label7.TabIndex = 11;
            this.label7.Text = "Gender";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.radFem);
            this.panel1.Controls.Add(this.radMale);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(178, 247);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 33);
            this.panel1.TabIndex = 7;
            // 
            // radFem
            // 
            this.radFem.AutoSize = true;
            this.radFem.Location = new System.Drawing.Point(201, 6);
            this.radFem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radFem.Name = "radFem";
            this.radFem.Size = new System.Drawing.Size(91, 24);
            this.radFem.TabIndex = 8;
            this.radFem.TabStop = true;
            this.radFem.Text = "Female";
            this.radFem.UseVisualStyleBackColor = true;
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Location = new System.Drawing.Point(4, 4);
            this.radMale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(70, 24);
            this.radMale.TabIndex = 7;
            this.radMale.TabStop = true;
            this.radMale.Text = "Male";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // txtCell
            // 
            this.txtCell.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell.Location = new System.Drawing.Point(963, 178);
            this.txtCell.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCell.Name = "txtCell";
            this.txtCell.Size = new System.Drawing.Size(181, 26);
            this.txtCell.TabIndex = 6;
            // 
            // txtEml
            // 
            this.txtEml.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEml.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEml.Location = new System.Drawing.Point(583, 176);
            this.txtEml.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEml.Name = "txtEml";
            this.txtEml.Size = new System.Drawing.Size(245, 26);
            this.txtEml.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(841, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 22);
            this.label8.TabIndex = 7;
            this.label8.Text = "Cellphone:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(510, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 26);
            this.label9.TabIndex = 6;
            this.label9.Text = "Email:";
            // 
            // txtCAge
            // 
            this.txtCAge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCAge.Location = new System.Drawing.Point(963, 92);
            this.txtCAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCAge.Name = "txtCAge";
            this.txtCAge.Size = new System.Drawing.Size(181, 26);
            this.txtCAge.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(901, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Age:";
            // 
            // txtCSrn
            // 
            this.txtCSrn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCSrn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCSrn.Location = new System.Drawing.Point(583, 92);
            this.txtCSrn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCSrn.Name = "txtCSrn";
            this.txtCSrn.Size = new System.Drawing.Size(247, 26);
            this.txtCSrn.TabIndex = 1;
            // 
            // txtCName
            // 
            this.txtCName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCName.Location = new System.Drawing.Point(178, 92);
            this.txtCName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCName.Name = "txtCName";
            this.txtCName.Size = new System.Drawing.Size(245, 26);
            this.txtCName.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(474, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "Surname:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(98, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name:";
            // 
            // tabPckg
            // 
            this.tabPckg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPckg.BackgroundImage")));
            this.tabPckg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPckg.Controls.Add(this.dtgPack);
            this.tabPckg.Controls.Add(this.groupBox1);
            this.tabPckg.Location = new System.Drawing.Point(4, 25);
            this.tabPckg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPckg.Name = "tabPckg";
            this.tabPckg.Size = new System.Drawing.Size(1209, 679);
            this.tabPckg.TabIndex = 2;
            this.tabPckg.Text = "Packages";
            this.tabPckg.UseVisualStyleBackColor = true;
            // 
            // dtgPack
            // 
            this.dtgPack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtgPack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPack.Location = new System.Drawing.Point(53, 185);
            this.dtgPack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgPack.Name = "dtgPack";
            this.dtgPack.RowHeadersWidth = 51;
            this.dtgPack.Size = new System.Drawing.Size(1033, 373);
            this.dtgPack.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(49, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1037, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Category";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(712, 44);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(83, 21);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Contract";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(376, 50);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(128, 21);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Month to Month";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(69, 49);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(79, 21);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Student";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tabRpts
            // 
            this.tabRpts.Location = new System.Drawing.Point(4, 25);
            this.tabRpts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabRpts.Name = "tabRpts";
            this.tabRpts.Size = new System.Drawing.Size(1209, 679);
            this.tabRpts.TabIndex = 3;
            this.tabRpts.Text = "Reports";
            this.tabRpts.UseVisualStyleBackColor = true;
            // 
            // tabMantn
            // 
            this.tabMantn.Location = new System.Drawing.Point(4, 25);
            this.tabMantn.Name = "tabMantn";
            this.tabMantn.Size = new System.Drawing.Size(1209, 679);
            this.tabMantn.TabIndex = 4;
            this.tabMantn.Text = "Maintenance";
            this.tabMantn.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1229, 708);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "HERO FITNESS CLUB";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabSearch.ResumeLayout(false);
            this.tabSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSearch)).EndInit();
            this.tabNewC.ResumeLayout(false);
            this.tabNewC.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPckg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPack)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSearch;
        private System.Windows.Forms.TabPage tabNewC;
        private System.Windows.Forms.TabPage tabPckg;
        private System.Windows.Forms.TabPage tabRpts;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSrch;
        private System.Windows.Forms.TextBox txtCSrn;
        private System.Windows.Forms.TextBox txtCName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCAge;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCell;
        private System.Windows.Forms.TextBox txtEml;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radFem;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.TextBox txtAdrs1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbPay;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbPack;
        private System.Windows.Forms.TextBox txtAdCod;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtAdrs2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnRegstr;
        private System.Windows.Forms.DataGridView dtgPack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbGoal;
        private System.Windows.Forms.TextBox txtMemNum;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dtgSearch;
        private System.Windows.Forms.TextBox txtIDnum;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TabPage tabMantn;
    }
}