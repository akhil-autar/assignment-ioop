namespace assignment
{
    partial class frmSalesReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalesReport));
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblTotalOrders = new System.Windows.Forms.Label();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.lblTotalItems = new System.Windows.Forms.Label();
            this.lblResultCount = new System.Windows.Forms.Label();
            this.dgvSalesReport = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesReport)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(115, 293);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(196, 28);
            this.cmbYear.TabIndex = 0;
            // 
            // cmbMonth
            // 
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(115, 168);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(196, 28);
            this.cmbMonth.TabIndex = 1;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(115, 230);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(196, 28);
            this.cmbCategory.TabIndex = 2;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(115, 363);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(114, 58);
            this.btnFilter.TabIndex = 3;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(299, 363);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(114, 58);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblTotalOrders
            // 
            this.lblTotalOrders.AutoSize = true;
            this.lblTotalOrders.Location = new System.Drawing.Point(868, 176);
            this.lblTotalOrders.Name = "lblTotalOrders";
            this.lblTotalOrders.Size = new System.Drawing.Size(107, 20);
            this.lblTotalOrders.TabIndex = 5;
            this.lblTotalOrders.Text = "lblTotalOrders";
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.AutoSize = true;
            this.lblTotalRevenue.Location = new System.Drawing.Point(885, 262);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(123, 20);
            this.lblTotalRevenue.TabIndex = 6;
            this.lblTotalRevenue.Text = "lblTotalRevenue";
            // 
            // lblTotalItems
            // 
            this.lblTotalItems.AutoSize = true;
            this.lblTotalItems.Location = new System.Drawing.Point(869, 346);
            this.lblTotalItems.Name = "lblTotalItems";
            this.lblTotalItems.Size = new System.Drawing.Size(99, 20);
            this.lblTotalItems.TabIndex = 7;
            this.lblTotalItems.Text = "lblTotalItems";
            // 
            // lblResultCount
            // 
            this.lblResultCount.AutoSize = true;
            this.lblResultCount.Location = new System.Drawing.Point(880, 413);
            this.lblResultCount.Name = "lblResultCount";
            this.lblResultCount.Size = new System.Drawing.Size(113, 20);
            this.lblResultCount.TabIndex = 8;
            this.lblResultCount.Text = "lblResultCount";
            // 
            // dgvSalesReport
            // 
            this.dgvSalesReport.AllowUserToAddRows = false;
            this.dgvSalesReport.AllowUserToDeleteRows = false;
            this.dgvSalesReport.AllowUserToOrderColumns = true;
            this.dgvSalesReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesReport.Location = new System.Drawing.Point(635, 496);
            this.dgvSalesReport.Name = "dgvSalesReport";
            this.dgvSalesReport.ReadOnly = true;
            this.dgvSalesReport.RowHeadersWidth = 62;
            this.dgvSalesReport.RowTemplate.Height = 28;
            this.dgvSalesReport.Size = new System.Drawing.Size(960, 260);
            this.dgvSalesReport.TabIndex = 9;
            // 
            // frmSalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1785, 847);
            this.Controls.Add(this.dgvSalesReport);
            this.Controls.Add(this.lblResultCount);
            this.Controls.Add(this.lblTotalItems);
            this.Controls.Add(this.lblTotalRevenue);
            this.Controls.Add(this.lblTotalOrders);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.cmbYear);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSalesReport";
            this.Text = "SalesReport";
            this.Load += new System.EventHandler(this.frmSalesReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblTotalOrders;
        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.Label lblTotalItems;
        private System.Windows.Forms.Label lblResultCount;
        private System.Windows.Forms.DataGridView dgvSalesReport;
    }
}