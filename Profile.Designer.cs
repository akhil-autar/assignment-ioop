namespace Gr8FoodSystem_Final
{
    partial class Profile
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
            this.panelProfileCard = new System.Windows.Forms.Panel();
            this.lblWallet = new System.Windows.Forms.Label();
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.panelLogout = new System.Windows.Forms.Panel();
            this.labelLogout = new System.Windows.Forms.Label();
            this.panelChange = new System.Windows.Forms.Panel();
            this.lblChangePassword = new System.Windows.Forms.Label();
            this.labelAccountSettings = new System.Windows.Forms.Label();
            this.panelProfileCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelSettings.SuspendLayout();
            this.panelLogout.SuspendLayout();
            this.panelChange.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelProfileCard
            // 
            this.panelProfileCard.BackColor = System.Drawing.Color.White;
            this.panelProfileCard.Controls.Add(this.lblWallet);
            this.panelProfileCard.Controls.Add(this.btnEditProfile);
            this.panelProfileCard.Controls.Add(this.lblPhone);
            this.panelProfileCard.Controls.Add(this.lblEmail);
            this.panelProfileCard.Controls.Add(this.lblUsername);
            this.panelProfileCard.Controls.Add(this.pictureBox1);
            this.panelProfileCard.Location = new System.Drawing.Point(36, 24);
            this.panelProfileCard.Name = "panelProfileCard";
            this.panelProfileCard.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.panelProfileCard.Size = new System.Drawing.Size(600, 180);
            this.panelProfileCard.TabIndex = 0;
            // 
            // lblWallet
            // 
            this.lblWallet.AutoSize = true;
            this.lblWallet.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWallet.Location = new System.Drawing.Point(142, 137);
            this.lblWallet.Name = "lblWallet";
            this.lblWallet.Size = new System.Drawing.Size(137, 17);
            this.lblWallet.TabIndex = 6;
            this.lblWallet.Text = "Wallet Balance: Rm 0";
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.BackColor = System.Drawing.Color.Silver;
            this.btnEditProfile.FlatAppearance.BorderSize = 0;
            this.btnEditProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProfile.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProfile.ForeColor = System.Drawing.Color.White;
            this.btnEditProfile.Location = new System.Drawing.Point(450, 70);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(120, 35);
            this.btnEditProfile.TabIndex = 5;
            this.btnEditProfile.Text = "Edit Profile";
            this.btnEditProfile.UseVisualStyleBackColor = false;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.Gray;
            this.lblPhone.Location = new System.Drawing.Point(140, 110);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(98, 17);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "+60 123456789";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.Gray;
            this.lblEmail.Location = new System.Drawing.Point(140, 85);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(125, 19);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "duha@email.com";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblUsername.Location = new System.Drawing.Point(140, 50);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(108, 25);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Duha Bulla";
            // 
            // pictureBox1
            // 

            this.pictureBox1.Location = new System.Drawing.Point(20, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelSettings
            // 
            this.panelSettings.BackColor = System.Drawing.Color.White;
            this.panelSettings.Controls.Add(this.panelLogout);
            this.panelSettings.Controls.Add(this.panelChange);
            this.panelSettings.Controls.Add(this.labelAccountSettings);
            this.panelSettings.Location = new System.Drawing.Point(36, 227);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(600, 200);
            this.panelSettings.TabIndex = 6;
            // 
            // panelLogout
            // 
            this.panelLogout.Controls.Add(this.labelLogout);
            this.panelLogout.Location = new System.Drawing.Point(20, 125);
            this.panelLogout.Name = "panelLogout";
            this.panelLogout.Size = new System.Drawing.Size(550, 40);
            this.panelLogout.TabIndex = 5;
            // 
            // labelLogout
            // 
            this.labelLogout.AutoSize = true;
            this.labelLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelLogout.ForeColor = System.Drawing.Color.Red;
            this.labelLogout.Location = new System.Drawing.Point(20, 10);
            this.labelLogout.Name = "labelLogout";
            this.labelLogout.Size = new System.Drawing.Size(56, 19);
            this.labelLogout.TabIndex = 3;
            this.labelLogout.Text = "Logout";
            this.labelLogout.Click += new System.EventHandler(this.labelLogout_Click);
            this.labelLogout.MouseEnter += new System.EventHandler(this.labelLogout_MouseEnter);
            this.labelLogout.MouseLeave += new System.EventHandler(this.labelLogout_MouseLeave);
            // 
            // panelChange
            // 
            this.panelChange.Controls.Add(this.lblChangePassword);
            this.panelChange.Location = new System.Drawing.Point(20, 68);
            this.panelChange.Name = "panelChange";
            this.panelChange.Size = new System.Drawing.Size(550, 40);
            this.panelChange.TabIndex = 4;
            // 
            // lblChangePassword
            // 
            this.lblChangePassword.AutoSize = true;
            this.lblChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblChangePassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblChangePassword.Location = new System.Drawing.Point(20, 11);
            this.lblChangePassword.Name = "lblChangePassword";
            this.lblChangePassword.Size = new System.Drawing.Size(127, 19);
            this.lblChangePassword.TabIndex = 2;
            this.lblChangePassword.Text = "Change Password";
            this.lblChangePassword.MouseEnter += new System.EventHandler(this.labelChangePassword_MouseEnter);
            this.lblChangePassword.MouseLeave += new System.EventHandler(this.labelChangePassword_MouseLeave);
            // 
            // labelAccountSettings
            // 
            this.labelAccountSettings.AutoSize = true;
            this.labelAccountSettings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAccountSettings.Location = new System.Drawing.Point(20, 10);
            this.labelAccountSettings.Name = "labelAccountSettings";
            this.labelAccountSettings.Size = new System.Drawing.Size(139, 21);
            this.labelAccountSettings.TabIndex = 1;
            this.labelAccountSettings.Text = "Account Settings";
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelSettings);
            this.Controls.Add(this.panelProfileCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Profile";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            this.panelProfileCard.ResumeLayout(false);
            this.panelProfileCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelSettings.ResumeLayout(false);
            this.panelSettings.PerformLayout();
            this.panelLogout.ResumeLayout(false);
            this.panelLogout.PerformLayout();
            this.panelChange.ResumeLayout(false);
            this.panelChange.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelProfileCard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.Label labelAccountSettings;
        private System.Windows.Forms.Label labelLogout;
        private System.Windows.Forms.Label lblChangePassword;
        private System.Windows.Forms.Panel panelChange;
        private System.Windows.Forms.Panel panelLogout;
        private System.Windows.Forms.Label lblWallet;
    }
}