
namespace HeroFitnessClub
{
    partial class MakePayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MakePayment));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCard = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblpayName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.errorProviderCardNum = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCardName = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblAmount = new System.Windows.Forms.Label();
            this.errorProviderDate = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCardNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCardName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDate)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(184, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(257, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // lblCard
            // 
            this.lblCard.AutoSize = true;
            this.lblCard.Location = new System.Drawing.Point(86, 78);
            this.lblCard.Name = "lblCard";
            this.lblCard.Size = new System.Drawing.Size(92, 17);
            this.lblCard.TabIndex = 1;
            this.lblCard.Text = "Card Number";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(184, 137);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(257, 22);
            this.textBox2.TabIndex = 1;
            this.textBox2.Validating += new System.ComponentModel.CancelEventHandler(this.textBox2_Validating);
            // 
            // lblpayName
            // 
            this.lblpayName.AutoSize = true;
            this.lblpayName.Location = new System.Drawing.Point(59, 137);
            this.lblpayName.Name = "lblpayName";
            this.lblpayName.Size = new System.Drawing.Size(119, 17);
            this.lblpayName.TabIndex = 1;
            this.lblpayName.Text = "Cardholder Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Expiration Date";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(184, 201);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(44, 22);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(261, 201);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(70, 22);
            this.numericUpDown2.TabIndex = 3;
            this.numericUpDown2.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.numericUpDown2.Validating += new System.ComponentModel.CancelEventHandler(this.numericUpDown2_Validating);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(484, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 148);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(360, 343);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(165, 44);
            this.btnPay.TabIndex = 5;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // errorProviderCardNum
            // 
            this.errorProviderCardNum.ContainerControl = this;
            // 
            // errorProviderCardName
            // 
            this.errorProviderCardName.ContainerControl = this;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(88, 288);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(90, 17);
            this.lblAmount.TabIndex = 6;
            this.lblAmount.Text = "Amount Due:";
            // 
            // errorProviderDate
            // 
            this.errorProviderDate.ContainerControl = this;
            // 
            // MakePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(920, 466);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblpayName);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblCard);
            this.Controls.Add(this.textBox1);
            this.Name = "MakePayment";
            this.Text = "Make Payment";
            this.Load += new System.EventHandler(this.MakePayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCardNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCardName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblCard;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblpayName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.ErrorProvider errorProviderCardNum;
        private System.Windows.Forms.ErrorProvider errorProviderCardName;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.ErrorProvider errorProviderDate;
    }
}