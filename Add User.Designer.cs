namespace assignment
{
    partial class frmAddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUser));
            this.lblBackToHome = new System.Windows.Forms.Label();
            this.pictureBoxBackToHome = new System.Windows.Forms.PictureBox();
            this.lblAddUserPortal = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblErrorPassword = new System.Windows.Forms.Label();
            this.lblErrorUsername = new System.Windows.Forms.Label();
            this.lblErrorPhone = new System.Windows.Forms.Label();
            this.lblPasswordStrength = new System.Windows.Forms.Label();
            this.lblErrorEmail = new System.Windows.Forms.Label();
            this.lblError3 = new System.Windows.Forms.Label();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.lblError = new System.Windows.Forms.Label();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblChooseRole = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackToHome)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBackToHome
            // 
            this.lblBackToHome.AutoSize = true;
            this.lblBackToHome.BackColor = System.Drawing.Color.Transparent;
            this.lblBackToHome.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBackToHome.ForeColor = System.Drawing.Color.DarkRed;
            this.lblBackToHome.Location = new System.Drawing.Point(58, 62);
            this.lblBackToHome.Name = "lblBackToHome";
            this.lblBackToHome.Size = new System.Drawing.Size(150, 23);
            this.lblBackToHome.TabIndex = 1;
            this.lblBackToHome.Text = "Back To Home";
            // 
            // pictureBoxBackToHome
            // 
            this.pictureBoxBackToHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBackToHome.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBackToHome.Image")));
            this.pictureBoxBackToHome.Location = new System.Drawing.Point(12, 54);
            this.pictureBoxBackToHome.Name = "pictureBoxBackToHome";
            this.pictureBoxBackToHome.Size = new System.Drawing.Size(40, 43);
            this.pictureBoxBackToHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBackToHome.TabIndex = 2;
            this.pictureBoxBackToHome.TabStop = false;
            this.pictureBoxBackToHome.Click += new System.EventHandler(this.pictureBoxBackToHome_Click);
            // 
            // lblAddUserPortal
            // 
            this.lblAddUserPortal.AutoSize = true;
            this.lblAddUserPortal.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.lblAddUserPortal.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblAddUserPortal.Location = new System.Drawing.Point(12, 118);
            this.lblAddUserPortal.Name = "lblAddUserPortal";
            this.lblAddUserPortal.Size = new System.Drawing.Size(378, 58);
            this.lblAddUserPortal.TabIndex = 3;
            this.lblAddUserPortal.Text = "Add User Portal";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblErrorPassword);
            this.groupBox1.Controls.Add(this.lblErrorUsername);
            this.groupBox1.Controls.Add(this.lblErrorPhone);
            this.groupBox1.Controls.Add(this.lblPasswordStrength);
            this.groupBox1.Controls.Add(this.lblErrorEmail);
            this.groupBox1.Controls.Add(this.lblError3);
            this.groupBox1.Controls.Add(this.chkShowPassword);
            this.groupBox1.Controls.Add(this.lblError);
            this.groupBox1.Controls.Add(this.btnAddUser);
            this.groupBox1.Controls.Add(this.txtConfirmPassword);
            this.groupBox1.Controls.Add(this.lblConfirmPassword);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.lblPassword);
            this.groupBox1.Controls.Add(this.lblGender);
            this.groupBox1.Controls.Add(this.radioButtonFemale);
            this.groupBox1.Controls.Add(this.radioButtonMale);
            this.groupBox1.Controls.Add(this.txtPhoneNumber);
            this.groupBox1.Controls.Add(this.lblPhoneNumber);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.lblUsername);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.lblChooseRole);
            this.groupBox1.Font = new System.Drawing.Font("Corbel", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(216, 395);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1030, 447);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proceed Here";
            // 
            // lblErrorPassword
            // 
            this.lblErrorPassword.AutoSize = true;
            this.lblErrorPassword.Font = new System.Drawing.Font("Corbel", 6F);
            this.lblErrorPassword.ForeColor = System.Drawing.Color.DarkRed;
            this.lblErrorPassword.Location = new System.Drawing.Point(44, 409);
            this.lblErrorPassword.Name = "lblErrorPassword";
            this.lblErrorPassword.Size = new System.Drawing.Size(0, 14);
            this.lblErrorPassword.TabIndex = 28;
            // 
            // lblErrorUsername
            // 
            this.lblErrorUsername.AutoSize = true;
            this.lblErrorUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorUsername.Font = new System.Drawing.Font("Corbel", 6F);
            this.lblErrorUsername.ForeColor = System.Drawing.Color.DarkRed;
            this.lblErrorUsername.Location = new System.Drawing.Point(394, 128);
            this.lblErrorUsername.Name = "lblErrorUsername";
            this.lblErrorUsername.Size = new System.Drawing.Size(0, 14);
            this.lblErrorUsername.TabIndex = 27;
            // 
            // lblErrorPhone
            // 
            this.lblErrorPhone.AutoSize = true;
            this.lblErrorPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorPhone.Font = new System.Drawing.Font("Corbel", 6F);
            this.lblErrorPhone.ForeColor = System.Drawing.Color.DarkRed;
            this.lblErrorPhone.Location = new System.Drawing.Point(40, 246);
            this.lblErrorPhone.Name = "lblErrorPhone";
            this.lblErrorPhone.Size = new System.Drawing.Size(0, 14);
            this.lblErrorPhone.TabIndex = 26;
            // 
            // lblPasswordStrength
            // 
            this.lblPasswordStrength.AutoSize = true;
            this.lblPasswordStrength.Font = new System.Drawing.Font("Corbel", 6F);
            this.lblPasswordStrength.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPasswordStrength.Location = new System.Drawing.Point(184, 383);
            this.lblPasswordStrength.Name = "lblPasswordStrength";
            this.lblPasswordStrength.Size = new System.Drawing.Size(0, 14);
            this.lblPasswordStrength.TabIndex = 25;
            // 
            // lblErrorEmail
            // 
            this.lblErrorEmail.AutoSize = true;
            this.lblErrorEmail.Font = new System.Drawing.Font("Corbel", 6F);
            this.lblErrorEmail.ForeColor = System.Drawing.Color.DarkRed;
            this.lblErrorEmail.Location = new System.Drawing.Point(771, 129);
            this.lblErrorEmail.Name = "lblErrorEmail";
            this.lblErrorEmail.Size = new System.Drawing.Size(0, 14);
            this.lblErrorEmail.TabIndex = 24;
            // 
            // lblError3
            // 
            this.lblError3.AutoSize = true;
            this.lblError3.BackColor = System.Drawing.Color.Transparent;
            this.lblError3.Font = new System.Drawing.Font("Corbel", 6F);
            this.lblError3.ForeColor = System.Drawing.Color.DarkRed;
            this.lblError3.Location = new System.Drawing.Point(404, 377);
            this.lblError3.Name = "lblError3";
            this.lblError3.Size = new System.Drawing.Size(0, 14);
            this.lblError3.TabIndex = 6;
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.chkShowPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowPassword.Location = new System.Drawing.Point(43, 379);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(121, 21);
            this.chkShowPassword.TabIndex = 9;
            this.chkShowPassword.Text = "Show Password";
            this.chkShowPassword.UseVisualStyleBackColor = false;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Corbel", 6F);
            this.lblError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblError.Location = new System.Drawing.Point(812, 300);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 14);
            this.lblError.TabIndex = 23;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(774, 216);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(188, 81);
            this.btnAddUser.TabIndex = 22;
            this.btnAddUser.Text = "Add New User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(397, 346);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(234, 27);
            this.txtConfirmPassword.TabIndex = 21;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            this.txtConfirmPassword.TextChanged += new System.EventHandler(this.txtConfirmPassword_TextChanged);
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblConfirmPassword.Location = new System.Drawing.Point(392, 315);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(179, 27);
            this.lblConfirmPassword.TabIndex = 20;
            this.lblConfirmPassword.Text = "Confirm Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(43, 346);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(234, 27);
            this.txtPassword.TabIndex = 19;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblPassword.Location = new System.Drawing.Point(38, 315);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(101, 27);
            this.lblPassword.TabIndex = 18;
            this.lblPassword.Text = "Password";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblGender.Location = new System.Drawing.Point(392, 185);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(80, 27);
            this.lblGender.TabIndex = 17;
            this.lblGender.Text = "Gender";
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(513, 220);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(83, 23);
            this.radioButtonFemale.TabIndex = 16;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(397, 217);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(67, 23);
            this.radioButtonMale.TabIndex = 15;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            this.radioButtonMale.CheckedChanged += new System.EventHandler(this.radioButtonMale_CheckedChanged);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(43, 216);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(234, 27);
            this.txtPhoneNumber.TabIndex = 14;
            this.txtPhoneNumber.TextChanged += new System.EventHandler(this.txtPhoneNumber_TextChanged);
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblPhoneNumber.Location = new System.Drawing.Point(38, 185);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(150, 27);
            this.lblPhoneNumber.TabIndex = 13;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(762, 99);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(234, 27);
            this.txtEmail.TabIndex = 12;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblEmail.Location = new System.Drawing.Point(757, 68);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(63, 27);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Email";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(397, 98);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(234, 27);
            this.txtUsername.TabIndex = 10;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblUsername.Location = new System.Drawing.Point(392, 67);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(106, 27);
            this.lblUsername.TabIndex = 9;
            this.lblUsername.Text = "Username";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "System Admin",
            "Manager",
            "Chef 1",
            "Chef 2",
            "Chef 3"});
            this.comboBox1.Location = new System.Drawing.Point(43, 98);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(231, 29);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblChooseRole
            // 
            this.lblChooseRole.AutoSize = true;
            this.lblChooseRole.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblChooseRole.Location = new System.Drawing.Point(38, 68);
            this.lblChooseRole.Name = "lblChooseRole";
            this.lblChooseRole.Size = new System.Drawing.Size(126, 27);
            this.lblChooseRole.TabIndex = 7;
            this.lblChooseRole.Text = "Choose Role";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(374, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmAddUser
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1519, 985);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblAddUserPortal);
            this.Controls.Add(this.pictureBoxBackToHome);
            this.Controls.Add(this.lblBackToHome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddUser";
            this.Text = "Add User";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackToHome)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBackToHome;
        private System.Windows.Forms.PictureBox pictureBoxBackToHome;
        private System.Windows.Forms.Label lblAddUserPortal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblChooseRole;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.Label lblError3;
        private System.Windows.Forms.Label lblErrorEmail;
        private System.Windows.Forms.Label lblPasswordStrength;
        private System.Windows.Forms.Label lblErrorPhone;
        private System.Windows.Forms.Label lblErrorUsername;
        private System.Windows.Forms.Label lblErrorPassword;
    }
}