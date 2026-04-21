namespace assignment
{
    partial class frmChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangePassword));
            this.pictureBoxBackToHome = new System.Windows.Forms.PictureBox();
            this.lblBackToHome = new System.Windows.Forms.Label();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.txtConfirmNewPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmNewPassword = new System.Windows.Forms.Label();
            this.chkShowPassword2 = new System.Windows.Forms.CheckBox();
            this.btnUpdatePassword = new System.Windows.Forms.Button();
            this.lblCurrentPassword = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblErrorCurrentPassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackToHome)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxBackToHome
            // 
            this.pictureBoxBackToHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBackToHome.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBackToHome.Image")));
            this.pictureBoxBackToHome.Location = new System.Drawing.Point(43, 65);
            this.pictureBoxBackToHome.Name = "pictureBoxBackToHome";
            this.pictureBoxBackToHome.Size = new System.Drawing.Size(40, 43);
            this.pictureBoxBackToHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBackToHome.TabIndex = 4;
            this.pictureBoxBackToHome.TabStop = false;
            this.pictureBoxBackToHome.Click += new System.EventHandler(this.pictureBoxBackToHome_Click);
            // 
            // lblBackToHome
            // 
            this.lblBackToHome.AutoSize = true;
            this.lblBackToHome.BackColor = System.Drawing.Color.Transparent;
            this.lblBackToHome.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBackToHome.ForeColor = System.Drawing.Color.DarkRed;
            this.lblBackToHome.Location = new System.Drawing.Point(89, 73);
            this.lblBackToHome.Name = "lblBackToHome";
            this.lblBackToHome.Size = new System.Drawing.Size(150, 23);
            this.lblBackToHome.TabIndex = 3;
            this.lblBackToHome.Text = "Back To Home";
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentPassword.Location = new System.Drawing.Point(419, 98);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.Size = new System.Drawing.Size(338, 29);
            this.txtCurrentPassword.TabIndex = 5;
            this.txtCurrentPassword.UseSystemPasswordChar = true;
            this.txtCurrentPassword.TextChanged += new System.EventHandler(this.txtCurrentPassword_TextChanged);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.Location = new System.Drawing.Point(419, 224);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(338, 29);
            this.txtNewPassword.TabIndex = 7;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Gadugi", 12F);
            this.lblNewPassword.Location = new System.Drawing.Point(464, 181);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(227, 28);
            this.lblNewPassword.TabIndex = 6;
            this.lblNewPassword.Text = "Enter New Password";
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.chkShowPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowPassword.Location = new System.Drawing.Point(419, 259);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(121, 21);
            this.chkShowPassword.TabIndex = 9;
            this.chkShowPassword.Text = "Show Password";
            this.chkShowPassword.UseVisualStyleBackColor = false;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // txtConfirmNewPassword
            // 
            this.txtConfirmNewPassword.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmNewPassword.Location = new System.Drawing.Point(419, 357);
            this.txtConfirmNewPassword.Name = "txtConfirmNewPassword";
            this.txtConfirmNewPassword.Size = new System.Drawing.Size(338, 29);
            this.txtConfirmNewPassword.TabIndex = 11;
            this.txtConfirmNewPassword.UseSystemPasswordChar = true;
            // 
            // lblConfirmNewPassword
            // 
            this.lblConfirmNewPassword.AutoSize = true;
            this.lblConfirmNewPassword.Font = new System.Drawing.Font("Gadugi", 12F);
            this.lblConfirmNewPassword.Location = new System.Drawing.Point(450, 326);
            this.lblConfirmNewPassword.Name = "lblConfirmNewPassword";
            this.lblConfirmNewPassword.Size = new System.Drawing.Size(258, 28);
            this.lblConfirmNewPassword.TabIndex = 10;
            this.lblConfirmNewPassword.Text = "Confirm New Password";
            // 
            // chkShowPassword2
            // 
            this.chkShowPassword2.AutoSize = true;
            this.chkShowPassword2.BackColor = System.Drawing.Color.Transparent;
            this.chkShowPassword2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowPassword2.Location = new System.Drawing.Point(419, 392);
            this.chkShowPassword2.Name = "chkShowPassword2";
            this.chkShowPassword2.Size = new System.Drawing.Size(121, 21);
            this.chkShowPassword2.TabIndex = 12;
            this.chkShowPassword2.Text = "Show Password";
            this.chkShowPassword2.UseVisualStyleBackColor = false;
            this.chkShowPassword2.CheckedChanged += new System.EventHandler(this.chkShowPassword2_CheckedChanged);
            // 
            // btnUpdatePassword
            // 
            this.btnUpdatePassword.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.btnUpdatePassword.Location = new System.Drawing.Point(491, 468);
            this.btnUpdatePassword.Name = "btnUpdatePassword";
            this.btnUpdatePassword.Size = new System.Drawing.Size(200, 104);
            this.btnUpdatePassword.TabIndex = 13;
            this.btnUpdatePassword.Text = "Update Password";
            this.btnUpdatePassword.UseVisualStyleBackColor = true;
            // 
            // lblCurrentPassword
            // 
            this.lblCurrentPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentPassword.AutoSize = true;
            this.lblCurrentPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentPassword.Font = new System.Drawing.Font("Gadugi", 12F);
            this.lblCurrentPassword.Location = new System.Drawing.Point(464, 67);
            this.lblCurrentPassword.Name = "lblCurrentPassword";
            this.lblCurrentPassword.Size = new System.Drawing.Size(259, 28);
            this.lblCurrentPassword.TabIndex = 0;
            this.lblCurrentPassword.Text = "Enter Current Password";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.lblErrorCurrentPassword);
            this.groupBox1.Controls.Add(this.btnUpdatePassword);
            this.groupBox1.Controls.Add(this.lblCurrentPassword);
            this.groupBox1.Controls.Add(this.chkShowPassword2);
            this.groupBox1.Controls.Add(this.txtCurrentPassword);
            this.groupBox1.Controls.Add(this.txtConfirmNewPassword);
            this.groupBox1.Controls.Add(this.lblConfirmNewPassword);
            this.groupBox1.Controls.Add(this.txtNewPassword);
            this.groupBox1.Controls.Add(this.lblNewPassword);
            this.groupBox1.Controls.Add(this.chkShowPassword);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(243, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1113, 599);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proceed Here";
            // 
            // lblErrorCurrentPassword
            // 
            this.lblErrorCurrentPassword.AutoSize = true;
            this.lblErrorCurrentPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorCurrentPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorCurrentPassword.ForeColor = System.Drawing.Color.DarkRed;
            this.lblErrorCurrentPassword.Location = new System.Drawing.Point(415, 130);
            this.lblErrorCurrentPassword.Name = "lblErrorCurrentPassword";
            this.lblErrorCurrentPassword.Size = new System.Drawing.Size(0, 15);
            this.lblErrorCurrentPassword.TabIndex = 14;
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1703, 936);
            this.Controls.Add(this.pictureBoxBackToHome);
            this.Controls.Add(this.lblBackToHome);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmChangePassword";
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.frmChangePassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackToHome)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxBackToHome;
        private System.Windows.Forms.Label lblBackToHome;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.TextBox txtConfirmNewPassword;
        private System.Windows.Forms.Label lblConfirmNewPassword;
        private System.Windows.Forms.CheckBox chkShowPassword2;
        private System.Windows.Forms.Button btnUpdatePassword;
        private System.Windows.Forms.Label lblCurrentPassword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblErrorCurrentPassword;
    }
}