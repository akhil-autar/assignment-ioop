namespace assignment
{
    partial class frmUpdateUserProfiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateUserProfiles));
            this.lblRemoveUserPortal = new System.Windows.Forms.Label();
            this.lblBackToHome = new System.Windows.Forms.Label();
            this.pictureBoxBackToHome = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblFindUser = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnFindUser = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gR8FoodDataSet = new assignment.GR8FoodDataSet();
            this.gR8FoodDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new assignment.GR8FoodDataSetTableAdapters.UsersTableAdapter();
            this.lblError = new System.Windows.Forms.Label();
            this.chkConfirmDelete = new System.Windows.Forms.CheckBox();
            this.lblErrorUsername = new System.Windows.Forms.Label();
            this.txtNewUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblChooseRole = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.lblErrorEmail = new System.Windows.Forms.Label();
            this.lblErrorPhone = new System.Windows.Forms.Label();
            this.lblErrorUpdate = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblErrorNewPassword = new System.Windows.Forms.Label();
            this.chkCurrentPassword = new System.Windows.Forms.CheckBox();
            this.chkConfirmPassword = new System.Windows.Forms.CheckBox();
            this.chkNewPassword = new System.Windows.Forms.CheckBox();
            this.lblErrorConfirmPassword = new System.Windows.Forms.Label();
            this.lblErrorCurrentPassword = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmNewPassword = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.lblCurrentPassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackToHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gR8FoodDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gR8FoodDataSetBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRemoveUserPortal
            // 
            this.lblRemoveUserPortal.AutoSize = true;
            this.lblRemoveUserPortal.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.lblRemoveUserPortal.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblRemoveUserPortal.Location = new System.Drawing.Point(26, 116);
            this.lblRemoveUserPortal.Name = "lblRemoveUserPortal";
            this.lblRemoveUserPortal.Size = new System.Drawing.Size(478, 58);
            this.lblRemoveUserPortal.TabIndex = 7;
            this.lblRemoveUserPortal.Text = "Update User Profiles";
            // 
            // lblBackToHome
            // 
            this.lblBackToHome.AutoSize = true;
            this.lblBackToHome.BackColor = System.Drawing.Color.Transparent;
            this.lblBackToHome.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBackToHome.ForeColor = System.Drawing.Color.DarkRed;
            this.lblBackToHome.Location = new System.Drawing.Point(82, 64);
            this.lblBackToHome.Name = "lblBackToHome";
            this.lblBackToHome.Size = new System.Drawing.Size(150, 23);
            this.lblBackToHome.TabIndex = 8;
            this.lblBackToHome.Text = "Back To Home";
            // 
            // pictureBoxBackToHome
            // 
            this.pictureBoxBackToHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBackToHome.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBackToHome.Image")));
            this.pictureBoxBackToHome.Location = new System.Drawing.Point(36, 57);
            this.pictureBoxBackToHome.Name = "pictureBoxBackToHome";
            this.pictureBoxBackToHome.Size = new System.Drawing.Size(40, 43);
            this.pictureBoxBackToHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBackToHome.TabIndex = 9;
            this.pictureBoxBackToHome.TabStop = false;
            this.pictureBoxBackToHome.Click += new System.EventHandler(this.pictureBoxBackToHome_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(499, 125);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lblFindUser
            // 
            this.lblFindUser.AutoSize = true;
            this.lblFindUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFindUser.Location = new System.Drawing.Point(18, 246);
            this.lblFindUser.Name = "lblFindUser";
            this.lblFindUser.Size = new System.Drawing.Size(128, 30);
            this.lblFindUser.TabIndex = 11;
            this.lblFindUser.Text = "Enter User";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(23, 279);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(271, 32);
            this.txtUsername.TabIndex = 12;
            // 
            // btnFindUser
            // 
            this.btnFindUser.Location = new System.Drawing.Point(86, 348);
            this.btnFindUser.Name = "btnFindUser";
            this.btnFindUser.Size = new System.Drawing.Size(96, 40);
            this.btnFindUser.TabIndex = 13;
            this.btnFindUser.Text = "Find User";
            this.btnFindUser.UseVisualStyleBackColor = true;
            this.btnFindUser.Click += new System.EventHandler(this.btnFindUser_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.usersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(376, 246);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1115, 142);
            this.dataGridView1.TabIndex = 14;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.Width = 150;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 150;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "Role";
            this.roleDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            this.roleDataGridViewTextBoxColumn.Width = 150;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 150;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 150;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.Width = 150;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.gR8FoodDataSet;
            // 
            // gR8FoodDataSet
            // 
            this.gR8FoodDataSet.DataSetName = "GR8FoodDataSet";
            this.gR8FoodDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gR8FoodDataSetBindingSource
            // 
            this.gR8FoodDataSetBindingSource.DataSource = this.gR8FoodDataSet;
            this.gR8FoodDataSetBindingSource.Position = 0;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.lblError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblError.Location = new System.Drawing.Point(83, 391);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 15);
            this.lblError.TabIndex = 17;
            // 
            // chkConfirmDelete
            // 
            this.chkConfirmDelete.AutoSize = true;
            this.chkConfirmDelete.Font = new System.Drawing.Font("Century Gothic", 7F);
            this.chkConfirmDelete.Location = new System.Drawing.Point(1266, 42);
            this.chkConfirmDelete.Name = "chkConfirmDelete";
            this.chkConfirmDelete.Size = new System.Drawing.Size(119, 23);
            this.chkConfirmDelete.TabIndex = 18;
            this.chkConfirmDelete.Text = "Confirm User";
            this.chkConfirmDelete.UseVisualStyleBackColor = true;
            this.chkConfirmDelete.CheckedChanged += new System.EventHandler(this.chkConfirmDelete_CheckedChanged);
            // 
            // lblErrorUsername
            // 
            this.lblErrorUsername.AutoSize = true;
            this.lblErrorUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorUsername.Font = new System.Drawing.Font("Corbel", 6F);
            this.lblErrorUsername.ForeColor = System.Drawing.Color.DarkRed;
            this.lblErrorUsername.Location = new System.Drawing.Point(21, 105);
            this.lblErrorUsername.Name = "lblErrorUsername";
            this.lblErrorUsername.Size = new System.Drawing.Size(0, 14);
            this.lblErrorUsername.TabIndex = 30;
            // 
            // txtNewUsername
            // 
            this.txtNewUsername.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewUsername.Location = new System.Drawing.Point(23, 77);
            this.txtNewUsername.Name = "txtNewUsername";
            this.txtNewUsername.Size = new System.Drawing.Size(234, 27);
            this.txtNewUsername.TabIndex = 29;
            this.txtNewUsername.TextChanged += new System.EventHandler(this.txtNewUsername_TextChanged);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblUsername.Location = new System.Drawing.Point(19, 44);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(151, 27);
            this.lblUsername.TabIndex = 28;
            this.lblUsername.Text = "New Username";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(325, 75);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(234, 27);
            this.txtEmail.TabIndex = 32;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblEmail.Location = new System.Drawing.Point(320, 44);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(109, 27);
            this.lblEmail.TabIndex = 31;
            this.lblEmail.Text = "New Email";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(625, 75);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(234, 27);
            this.txtPhoneNumber.TabIndex = 35;
            this.txtPhoneNumber.TextChanged += new System.EventHandler(this.txtPhoneNumber_TextChanged);
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblPhoneNumber.Location = new System.Drawing.Point(620, 44);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(196, 27);
            this.lblPhoneNumber.TabIndex = 34;
            this.lblPhoneNumber.Text = "New Phone Number";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1234, 71);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(179, 57);
            this.btnUpdate.TabIndex = 45;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.comboBox1.Location = new System.Drawing.Point(937, 75);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(231, 29);
            this.comboBox1.TabIndex = 47;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // lblChooseRole
            // 
            this.lblChooseRole.AutoSize = true;
            this.lblChooseRole.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblChooseRole.Location = new System.Drawing.Point(932, 45);
            this.lblChooseRole.Name = "lblChooseRole";
            this.lblChooseRole.Size = new System.Drawing.Size(126, 27);
            this.lblChooseRole.TabIndex = 46;
            this.lblChooseRole.Text = "Update Role";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblGender.Location = new System.Drawing.Point(1229, 40);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(80, 27);
            this.lblGender.TabIndex = 51;
            this.lblGender.Text = "Gender";
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(1350, 75);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(92, 25);
            this.radioButtonFemale.TabIndex = 50;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            this.radioButtonFemale.CheckedChanged += new System.EventHandler(this.radioButtonFemale_CheckedChanged_1);
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(1234, 72);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(74, 25);
            this.radioButtonMale.TabIndex = 49;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            this.radioButtonMale.CheckedChanged += new System.EventHandler(this.radioButtonMale_CheckedChanged_1);
            // 
            // lblErrorEmail
            // 
            this.lblErrorEmail.AutoSize = true;
            this.lblErrorEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.lblErrorEmail.ForeColor = System.Drawing.Color.DarkRed;
            this.lblErrorEmail.Location = new System.Drawing.Point(322, 105);
            this.lblErrorEmail.Name = "lblErrorEmail";
            this.lblErrorEmail.Size = new System.Drawing.Size(0, 15);
            this.lblErrorEmail.TabIndex = 52;
            // 
            // lblErrorPhone
            // 
            this.lblErrorPhone.AutoSize = true;
            this.lblErrorPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.lblErrorPhone.ForeColor = System.Drawing.Color.DarkRed;
            this.lblErrorPhone.Location = new System.Drawing.Point(622, 105);
            this.lblErrorPhone.Name = "lblErrorPhone";
            this.lblErrorPhone.Size = new System.Drawing.Size(0, 15);
            this.lblErrorPhone.TabIndex = 53;
            // 
            // lblErrorUpdate
            // 
            this.lblErrorUpdate.AutoSize = true;
            this.lblErrorUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.lblErrorUpdate.ForeColor = System.Drawing.Color.DarkRed;
            this.lblErrorUpdate.Location = new System.Drawing.Point(1231, 131);
            this.lblErrorUpdate.Name = "lblErrorUpdate";
            this.lblErrorUpdate.Size = new System.Drawing.Size(0, 15);
            this.lblErrorUpdate.TabIndex = 54;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.txtNewUsername);
            this.groupBox1.Controls.Add(this.lblErrorPhone);
            this.groupBox1.Controls.Add(this.lblErrorUsername);
            this.groupBox1.Controls.Add(this.lblUsername);
            this.groupBox1.Controls.Add(this.lblErrorEmail);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.lblGender);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.radioButtonFemale);
            this.groupBox1.Controls.Add(this.radioButtonMale);
            this.groupBox1.Controls.Add(this.txtPhoneNumber);
            this.groupBox1.Controls.Add(this.lblPhoneNumber);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.lblChooseRole);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 437);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1470, 146);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Details";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblErrorUpdate);
            this.groupBox2.Controls.Add(this.lblErrorNewPassword);
            this.groupBox2.Controls.Add(this.chkCurrentPassword);
            this.groupBox2.Controls.Add(this.chkConfirmPassword);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.chkConfirmDelete);
            this.groupBox2.Controls.Add(this.chkNewPassword);
            this.groupBox2.Controls.Add(this.lblErrorConfirmPassword);
            this.groupBox2.Controls.Add(this.lblErrorCurrentPassword);
            this.groupBox2.Controls.Add(this.txtConfirmPassword);
            this.groupBox2.Controls.Add(this.lblConfirmNewPassword);
            this.groupBox2.Controls.Add(this.txtNewPassword);
            this.groupBox2.Controls.Add(this.lblNewPassword);
            this.groupBox2.Controls.Add(this.txtCurrentPassword);
            this.groupBox2.Controls.Add(this.lblCurrentPassword);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 578);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1470, 163);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Password";
            // 
            // lblErrorNewPassword
            // 
            this.lblErrorNewPassword.AutoSize = true;
            this.lblErrorNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorNewPassword.ForeColor = System.Drawing.SystemColors.Control;
            this.lblErrorNewPassword.Location = new System.Drawing.Point(518, 107);
            this.lblErrorNewPassword.Name = "lblErrorNewPassword";
            this.lblErrorNewPassword.Size = new System.Drawing.Size(0, 15);
            this.lblErrorNewPassword.TabIndex = 66;
            // 
            // chkCurrentPassword
            // 
            this.chkCurrentPassword.AutoSize = true;
            this.chkCurrentPassword.BackColor = System.Drawing.Color.Transparent;
            this.chkCurrentPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCurrentPassword.Location = new System.Drawing.Point(26, 110);
            this.chkCurrentPassword.Name = "chkCurrentPassword";
            this.chkCurrentPassword.Size = new System.Drawing.Size(121, 21);
            this.chkCurrentPassword.TabIndex = 65;
            this.chkCurrentPassword.Text = "Show Password";
            this.chkCurrentPassword.UseVisualStyleBackColor = false;
            this.chkCurrentPassword.CheckedChanged += new System.EventHandler(this.chkCurrentPassword_CheckedChanged);
            // 
            // chkConfirmPassword
            // 
            this.chkConfirmPassword.AutoSize = true;
            this.chkConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.chkConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkConfirmPassword.Location = new System.Drawing.Point(628, 110);
            this.chkConfirmPassword.Name = "chkConfirmPassword";
            this.chkConfirmPassword.Size = new System.Drawing.Size(121, 21);
            this.chkConfirmPassword.TabIndex = 64;
            this.chkConfirmPassword.Text = "Show Password";
            this.chkConfirmPassword.UseVisualStyleBackColor = false;
            this.chkConfirmPassword.CheckedChanged += new System.EventHandler(this.chkConfirmPassword_CheckedChanged_1);
            // 
            // chkNewPassword
            // 
            this.chkNewPassword.AutoSize = true;
            this.chkNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.chkNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNewPassword.Location = new System.Drawing.Point(325, 110);
            this.chkNewPassword.Name = "chkNewPassword";
            this.chkNewPassword.Size = new System.Drawing.Size(121, 21);
            this.chkNewPassword.TabIndex = 63;
            this.chkNewPassword.Text = "Show Password";
            this.chkNewPassword.UseVisualStyleBackColor = false;
            this.chkNewPassword.CheckedChanged += new System.EventHandler(this.chkNewPassword_CheckedChanged_1);
            // 
            // lblErrorConfirmPassword
            // 
            this.lblErrorConfirmPassword.AutoSize = true;
            this.lblErrorConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorConfirmPassword.ForeColor = System.Drawing.Color.DarkRed;
            this.lblErrorConfirmPassword.Location = new System.Drawing.Point(622, 107);
            this.lblErrorConfirmPassword.Name = "lblErrorConfirmPassword";
            this.lblErrorConfirmPassword.Size = new System.Drawing.Size(0, 15);
            this.lblErrorConfirmPassword.TabIndex = 62;
            // 
            // lblErrorCurrentPassword
            // 
            this.lblErrorCurrentPassword.AutoSize = true;
            this.lblErrorCurrentPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorCurrentPassword.ForeColor = System.Drawing.Color.DarkRed;
            this.lblErrorCurrentPassword.Location = new System.Drawing.Point(20, 107);
            this.lblErrorCurrentPassword.Name = "lblErrorCurrentPassword";
            this.lblErrorCurrentPassword.Size = new System.Drawing.Size(0, 15);
            this.lblErrorCurrentPassword.TabIndex = 56;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.Location = new System.Drawing.Point(625, 75);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(234, 29);
            this.txtConfirmPassword.TabIndex = 61;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            this.txtConfirmPassword.TextChanged += new System.EventHandler(this.txtConfirmPassword_TextChanged_1);
            // 
            // lblConfirmNewPassword
            // 
            this.lblConfirmNewPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConfirmNewPassword.AutoSize = true;
            this.lblConfirmNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmNewPassword.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblConfirmNewPassword.Location = new System.Drawing.Point(620, 45);
            this.lblConfirmNewPassword.Name = "lblConfirmNewPassword";
            this.lblConfirmNewPassword.Size = new System.Drawing.Size(225, 27);
            this.lblConfirmNewPassword.TabIndex = 60;
            this.lblConfirmNewPassword.Text = "Confirm New Password";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.Location = new System.Drawing.Point(325, 75);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(234, 29);
            this.txtNewPassword.TabIndex = 59;
            this.txtNewPassword.UseSystemPasswordChar = true;
            this.txtNewPassword.TextChanged += new System.EventHandler(this.txtNewPassword_TextChanged_1);
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblNewPassword.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblNewPassword.Location = new System.Drawing.Point(320, 45);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(201, 27);
            this.lblNewPassword.TabIndex = 58;
            this.lblNewPassword.Text = "Enter New Password";
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentPassword.Location = new System.Drawing.Point(24, 75);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.Size = new System.Drawing.Size(234, 29);
            this.txtCurrentPassword.TabIndex = 57;
            this.txtCurrentPassword.UseSystemPasswordChar = true;
            // 
            // lblCurrentPassword
            // 
            this.lblCurrentPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentPassword.AutoSize = true;
            this.lblCurrentPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentPassword.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblCurrentPassword.Location = new System.Drawing.Point(19, 45);
            this.lblCurrentPassword.Name = "lblCurrentPassword";
            this.lblCurrentPassword.Size = new System.Drawing.Size(227, 27);
            this.lblCurrentPassword.TabIndex = 56;
            this.lblCurrentPassword.Text = "Enter Current Password";
            // 
            // frmUpdateUserProfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1503, 860);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnFindUser);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblFindUser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxBackToHome);
            this.Controls.Add(this.lblBackToHome);
            this.Controls.Add(this.lblRemoveUserPortal);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUpdateUserProfiles";
            this.Text = "Update User Profile";
            this.Load += new System.EventHandler(this.frmUpdateUserProfiles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackToHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gR8FoodDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gR8FoodDataSetBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRemoveUserPortal;
        private System.Windows.Forms.Label lblBackToHome;
        private System.Windows.Forms.PictureBox pictureBoxBackToHome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblFindUser;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnFindUser;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource gR8FoodDataSetBindingSource;
        private GR8FoodDataSet gR8FoodDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private GR8FoodDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.CheckBox chkConfirmDelete;
        private System.Windows.Forms.Label lblErrorUsername;
        private System.Windows.Forms.TextBox txtNewUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblChooseRole;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.Label lblErrorEmail;
        private System.Windows.Forms.Label lblErrorPhone;
        private System.Windows.Forms.Label lblErrorUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblConfirmNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.Label lblCurrentPassword;
        private System.Windows.Forms.Label lblErrorConfirmPassword;
        private System.Windows.Forms.Label lblErrorCurrentPassword;
        private System.Windows.Forms.CheckBox chkCurrentPassword;
        private System.Windows.Forms.CheckBox chkConfirmPassword;
        private System.Windows.Forms.CheckBox chkNewPassword;
        private System.Windows.Forms.Label lblErrorNewPassword;
    }
}