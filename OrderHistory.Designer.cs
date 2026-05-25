namespace Gr8FoodSystem_Final
{
    partial class OrderHistory
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
            this.flowHistory = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowHistory
            // 
            this.flowHistory.AutoScroll = true;
            this.flowHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowHistory.Location = new System.Drawing.Point(0, 0);
            this.flowHistory.Name = "flowHistory";
            this.flowHistory.Size = new System.Drawing.Size(800, 450);
            this.flowHistory.TabIndex = 0;
            // 
            // OrderHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowHistory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderHistory";
            this.Text = "OrderHistory";
            this.Load += new System.EventHandler(this.OrderHistory_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowHistory;
    }
}