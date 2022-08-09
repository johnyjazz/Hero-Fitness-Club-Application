namespace HeroFitnessClub
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnLgn = new System.Windows.Forms.Button();
            this.SignupBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(1071, 113);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(130, 29);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Username:";
            // 
            // txtUser
            // 
            this.txtUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUser.Location = new System.Drawing.Point(1240, 120);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(189, 22);
            this.txtUser.TabIndex = 1;
            // 
            // lblPass
            // 
            this.lblPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(1071, 197);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(126, 29);
            this.lblPass.TabIndex = 1;
            this.lblPass.Text = "Password:";
            // 
            // txtPass
            // 
            this.txtPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPass.Location = new System.Drawing.Point(1240, 197);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(189, 22);
            this.txtPass.TabIndex = 2;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // btnLgn
            // 
            this.btnLgn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLgn.Location = new System.Drawing.Point(1177, 252);
            this.btnLgn.Name = "btnLgn";
            this.btnLgn.Size = new System.Drawing.Size(112, 37);
            this.btnLgn.TabIndex = 3;
            this.btnLgn.Text = "Login";
            this.btnLgn.UseVisualStyleBackColor = true;
            this.btnLgn.Click += new System.EventHandler(this.btnLgn_Click);
            // 
            // SignupBtn
            // 
            this.SignupBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SignupBtn.Location = new System.Drawing.Point(1326, 252);
            this.SignupBtn.Name = "SignupBtn";
            this.SignupBtn.Size = new System.Drawing.Size(112, 37);
            this.SignupBtn.TabIndex = 4;
            this.SignupBtn.Text = "Signup";
            this.SignupBtn.UseVisualStyleBackColor = true;
            this.SignupBtn.Click += new System.EventHandler(this.SignupBtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1469, 827);
            this.Controls.Add(this.SignupBtn);
            this.Controls.Add(this.btnLgn);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUser);
            this.Name = "Login";
            this.Text = "HERO FITNESS CLUB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnLgn;
        private System.Windows.Forms.Button SignupBtn;
    }
}

