namespace assignment
{
    partial class frmRemoveUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRemoveUser));
            this.lblRemoveUserPortal = new System.Windows.Forms.Label();
            this.pictureBoxBackToHome = new System.Windows.Forms.PictureBox();
            this.lblBackToHome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblFindUser = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gR8FoodDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gR8FoodDataSet = new assignment.GR8FoodDataSet();
            this.usersTableAdapter = new assignment.GR8FoodDataSetTableAdapters.UsersTableAdapter();
            this.lblError = new System.Windows.Forms.Label();
            this.btnFindUser = new System.Windows.Forms.Button();
            this.chkConfirmDelete = new System.Windows.Forms.CheckBox();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.lblError2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackToHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gR8FoodDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gR8FoodDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRemoveUserPortal
            // 
            this.lblRemoveUserPortal.AutoSize = true;
            this.lblRemoveUserPortal.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.lblRemoveUserPortal.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblRemoveUserPortal.Location = new System.Drawing.Point(25, 127);
            this.lblRemoveUserPortal.Name = "lblRemoveUserPortal";
            this.lblRemoveUserPortal.Size = new System.Drawing.Size(472, 58);
            this.lblRemoveUserPortal.TabIndex = 6;
            this.lblRemoveUserPortal.Text = "Remove User Portal";
            // 
            // pictureBoxBackToHome
            // 
            this.pictureBoxBackToHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBackToHome.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBackToHome.Image")));
            this.pictureBoxBackToHome.Location = new System.Drawing.Point(35, 60);
            this.pictureBoxBackToHome.Name = "pictureBoxBackToHome";
            this.pictureBoxBackToHome.Size = new System.Drawing.Size(40, 43);
            this.pictureBoxBackToHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBackToHome.TabIndex = 5;
            this.pictureBoxBackToHome.TabStop = false;
            this.pictureBoxBackToHome.Click += new System.EventHandler(this.pictureBoxBackToHome_Click);
            // 
            // lblBackToHome
            // 
            this.lblBackToHome.AutoSize = true;
            this.lblBackToHome.BackColor = System.Drawing.Color.Transparent;
            this.lblBackToHome.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBackToHome.ForeColor = System.Drawing.Color.DarkRed;
            this.lblBackToHome.Location = new System.Drawing.Point(79, 69);
            this.lblBackToHome.Name = "lblBackToHome";
            this.lblBackToHome.Size = new System.Drawing.Size(150, 23);
            this.lblBackToHome.TabIndex = 4;
            this.lblBackToHome.Text = "Back To Home";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(503, 135);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lblFindUser
            // 
            this.lblFindUser.AutoSize = true;
            this.lblFindUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFindUser.Location = new System.Drawing.Point(30, 287);
            this.lblFindUser.Name = "lblFindUser";
            this.lblFindUser.Size = new System.Drawing.Size(118, 30);
            this.lblFindUser.TabIndex = 8;
            this.lblFindUser.Text = "Find User";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(35, 320);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(271, 32);
            this.txtUsername.TabIndex = 9;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
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
            this.roleDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.usersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(399, 287);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1164, 209);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            this.usernameDataGridViewTextBoxColumn.Width = 150;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "Role";
            this.roleDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            this.roleDataGridViewTextBoxColumn.ReadOnly = true;
            this.roleDataGridViewTextBoxColumn.Width = 150;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 150;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneDataGridViewTextBoxColumn.Width = 150;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            this.genderDataGridViewTextBoxColumn.Width = 150;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.gR8FoodDataSetBindingSource;
            // 
            // gR8FoodDataSetBindingSource
            // 
            this.gR8FoodDataSetBindingSource.DataSource = this.gR8FoodDataSet;
            this.gR8FoodDataSetBindingSource.Position = 0;
            // 
            // gR8FoodDataSet
            // 
            this.gR8FoodDataSet.DataSetName = "GR8FoodDataSet";
            this.gR8FoodDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblError.Location = new System.Drawing.Point(44, 355);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 15);
            this.lblError.TabIndex = 11;
            // 
            // btnFindUser
            // 
            this.btnFindUser.Location = new System.Drawing.Point(103, 413);
            this.btnFindUser.Name = "btnFindUser";
            this.btnFindUser.Size = new System.Drawing.Size(117, 45);
            this.btnFindUser.TabIndex = 12;
            this.btnFindUser.Text = "Find User";
            this.btnFindUser.UseVisualStyleBackColor = true;
            this.btnFindUser.Click += new System.EventHandler(this.btnFindUser_Click);
            // 
            // chkConfirmDelete
            // 
            this.chkConfirmDelete.AutoSize = true;
            this.chkConfirmDelete.Font = new System.Drawing.Font("Century Gothic", 7F);
            this.chkConfirmDelete.Location = new System.Drawing.Point(100, 742);
            this.chkConfirmDelete.Name = "chkConfirmDelete";
            this.chkConfirmDelete.Size = new System.Drawing.Size(119, 23);
            this.chkConfirmDelete.TabIndex = 13;
            this.chkConfirmDelete.Text = "Confirm User";
            this.chkConfirmDelete.UseVisualStyleBackColor = true;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(66, 771);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(192, 70);
            this.btnDeleteUser.TabIndex = 14;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // lblError2
            // 
            this.lblError2.AutoSize = true;
            this.lblError2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.lblError2.ForeColor = System.Drawing.Color.DarkRed;
            this.lblError2.Location = new System.Drawing.Point(44, 844);
            this.lblError2.Name = "lblError2";
            this.lblError2.Size = new System.Drawing.Size(0, 15);
            this.lblError2.TabIndex = 15;
            // 
            // frmRemoveUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1610, 921);
            this.Controls.Add(this.lblError2);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.chkConfirmDelete);
            this.Controls.Add(this.btnFindUser);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblFindUser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblRemoveUserPortal);
            this.Controls.Add(this.pictureBoxBackToHome);
            this.Controls.Add(this.lblBackToHome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRemoveUser";
            this.Text = "Remove User";
            this.Load += new System.EventHandler(this.Remove_User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackToHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gR8FoodDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gR8FoodDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRemoveUserPortal;
        private System.Windows.Forms.PictureBox pictureBoxBackToHome;
        private System.Windows.Forms.Label lblBackToHome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblFindUser;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource gR8FoodDataSetBindingSource;
        private GR8FoodDataSet gR8FoodDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private GR8FoodDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnFindUser;
        private System.Windows.Forms.CheckBox chkConfirmDelete;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Label lblError2;
    }
}