namespace assignment
{
    partial class frmUpdateOwnProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateOwnProfile));
            this.pictureBoxBackToHome = new System.Windows.Forms.PictureBox();
            this.lblBackToHome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblRemoveUserPortal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackToHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxBackToHome
            // 
            this.pictureBoxBackToHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBackToHome.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBackToHome.Image")));
            this.pictureBoxBackToHome.Location = new System.Drawing.Point(43, 66);
            this.pictureBoxBackToHome.Name = "pictureBoxBackToHome";
            this.pictureBoxBackToHome.Size = new System.Drawing.Size(40, 43);
            this.pictureBoxBackToHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBackToHome.TabIndex = 13;
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
            this.lblBackToHome.TabIndex = 12;
            this.lblBackToHome.Text = "Back To Home";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(626, 139);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // lblRemoveUserPortal
            // 
            this.lblRemoveUserPortal.AutoSize = true;
            this.lblRemoveUserPortal.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.lblRemoveUserPortal.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblRemoveUserPortal.Location = new System.Drawing.Point(33, 130);
            this.lblRemoveUserPortal.Name = "lblRemoveUserPortal";
            this.lblRemoveUserPortal.Size = new System.Drawing.Size(581, 58);
            this.lblRemoveUserPortal.TabIndex = 14;
            this.lblRemoveUserPortal.Text = "Update Own User Profile";
            // 
            // frmUpdateOwnProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1882, 992);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblRemoveUserPortal);
            this.Controls.Add(this.pictureBoxBackToHome);
            this.Controls.Add(this.lblBackToHome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUpdateOwnProfile";
            this.Text = "update_Own_Profile";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackToHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBackToHome;
        private System.Windows.Forms.Label lblBackToHome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblRemoveUserPortal;
    }
}