namespace prac
{
    partial class WalletReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WalletReport));
            this.dgvWalletTrans = new System.Windows.Forms.DataGridView();
            this.lblMonthYear = new System.Windows.Forms.Label();
            this.pnlWalletReport = new System.Windows.Forms.Panel();
            this.lblWalletSubtitle = new System.Windows.Forms.Label();
            this.lblHeadingWalletTrans = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.cmbUser = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.pnlTotalTopup = new System.Windows.Forms.Panel();
            this.picTopUp = new System.Windows.Forms.PictureBox();
            this.lblTtlTopupNo = new System.Windows.Forms.Label();
            this.lblTotalTopup = new System.Windows.Forms.Label();
            this.pnlNetBalance = new System.Windows.Forms.Panel();
            this.picBalance = new System.Windows.Forms.PictureBox();
            this.lblNetBalanceNo = new System.Windows.Forms.Label();
            this.lblNetBalance = new System.Windows.Forms.Label();
            this.pnlTotalTransaction = new System.Windows.Forms.Panel();
            this.picTransaction = new System.Windows.Forms.PictureBox();
            this.lblTtlTransactionNo = new System.Windows.Forms.Label();
            this.lblTotalTransaction = new System.Windows.Forms.Label();
            this.pnlTotalUse = new System.Windows.Forms.Panel();
            this.picUsage = new System.Windows.Forms.PictureBox();
            this.lblTtlUsageNo = new System.Windows.Forms.Label();
            this.lblTotalUse = new System.Windows.Forms.Label();
            this.lblTransactionHistory = new System.Windows.Forms.Label();
            this.picTransactionHistory = new System.Windows.Forms.PictureBox();
            this.btnDasboard = new System.Windows.Forms.Button();
            this.btnUpdProf = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnFeedback = new System.Windows.Forms.Button();
            this.btnWallet = new System.Windows.Forms.Button();
            this.pnlSidebarWallet = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.tlpnlDetailsWallet = new System.Windows.Forms.TableLayoutPanel();
            this.tlpnlInnerWallet = new System.Windows.Forms.TableLayoutPanel();
            this.pnlWalletFilterReset = new System.Windows.Forms.Panel();
            this.tlpnlWalletCards = new System.Windows.Forms.TableLayoutPanel();
            this.pnlWalletTrans = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWalletTrans)).BeginInit();
            this.pnlWalletReport.SuspendLayout();
            this.pnlTotalTopup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTopUp)).BeginInit();
            this.pnlNetBalance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBalance)).BeginInit();
            this.pnlTotalTransaction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTransaction)).BeginInit();
            this.pnlTotalUse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTransactionHistory)).BeginInit();
            this.pnlSidebarWallet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.tlpnlDetailsWallet.SuspendLayout();
            this.tlpnlInnerWallet.SuspendLayout();
            this.pnlWalletFilterReset.SuspendLayout();
            this.tlpnlWalletCards.SuspendLayout();
            this.pnlWalletTrans.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvWalletTrans
            // 
            this.dgvWalletTrans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWalletTrans.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvWalletTrans.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvWalletTrans.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvWalletTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWalletTrans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWalletTrans.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvWalletTrans.Location = new System.Drawing.Point(0, 0);
            this.dgvWalletTrans.Name = "dgvWalletTrans";
            this.dgvWalletTrans.ReadOnly = true;
            this.dgvWalletTrans.RowHeadersVisible = false;
            this.dgvWalletTrans.Size = new System.Drawing.Size(821, 319);
            this.dgvWalletTrans.TabIndex = 1;
            this.dgvWalletTrans.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWalletTrans_CellContentClick);
            // 
            // lblMonthYear
            // 
            this.lblMonthYear.AutoSize = true;
            this.lblMonthYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMonthYear.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthYear.Location = new System.Drawing.Point(280, 0);
            this.lblMonthYear.Name = "lblMonthYear";
            this.lblMonthYear.Size = new System.Drawing.Size(272, 26);
            this.lblMonthYear.TabIndex = 2;
            this.lblMonthYear.Text = "Select Month and Year:";
            // 
            // pnlWalletReport
            // 
            this.pnlWalletReport.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.pnlWalletReport.Controls.Add(this.lblWalletSubtitle);
            this.pnlWalletReport.Controls.Add(this.lblHeadingWalletTrans);
            this.pnlWalletReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlWalletReport.Location = new System.Drawing.Point(0, 0);
            this.pnlWalletReport.Name = "pnlWalletReport";
            this.pnlWalletReport.Size = new System.Drawing.Size(984, 50);
            this.pnlWalletReport.TabIndex = 3;
            // 
            // lblWalletSubtitle
            // 
            this.lblWalletSubtitle.AutoSize = true;
            this.lblWalletSubtitle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWalletSubtitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblWalletSubtitle.Location = new System.Drawing.Point(4, 31);
            this.lblWalletSubtitle.Name = "lblWalletSubtitle";
            this.lblWalletSubtitle.Size = new System.Drawing.Size(349, 19);
            this.lblWalletSubtitle.TabIndex = 10;
            this.lblWalletSubtitle.Text = "View and analyze wallet transactions for your customers.";
            // 
            // lblHeadingWalletTrans
            // 
            this.lblHeadingWalletTrans.AutoSize = true;
            this.lblHeadingWalletTrans.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadingWalletTrans.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHeadingWalletTrans.Location = new System.Drawing.Point(12, 9);
            this.lblHeadingWalletTrans.Name = "lblHeadingWalletTrans";
            this.lblHeadingWalletTrans.Size = new System.Drawing.Size(243, 24);
            this.lblHeadingWalletTrans.TabIndex = 0;
            this.lblHeadingWalletTrans.Text = "Wallet Transaction Report";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCustomer.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(3, 0);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(271, 26);
            this.lblCustomer.TabIndex = 4;
            this.lblCustomer.Text = "Select Customer:";
            // 
            // cmbUser
            // 
            this.cmbUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUser.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.Location = new System.Drawing.Point(3, 29);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(271, 23);
            this.cmbUser.TabIndex = 5;
            this.cmbUser.Text = " 👤 --Select Customer--";
            this.cmbUser.SelectedIndexChanged += new System.EventHandler(this.cmbUser_SelectedIndexChanged);
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDate.CustomFormat = "MM/yyy";
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(280, 29);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(272, 22);
            this.dtpDate.TabIndex = 6;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.ForestGreen;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Location = new System.Drawing.Point(13, 29);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(107, 26);
            this.btnFilter.TabIndex = 7;
            this.btnFilter.Text = " ⌕ Filter";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.IndianRed;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(126, 29);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(99, 25);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = " ⟳ Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // pnlTotalTopup
            // 
            this.pnlTotalTopup.BackColor = System.Drawing.Color.Honeydew;
            this.pnlTotalTopup.Controls.Add(this.picTopUp);
            this.pnlTotalTopup.Controls.Add(this.lblTtlTopupNo);
            this.pnlTotalTopup.Controls.Add(this.lblTotalTopup);
            this.pnlTotalTopup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTotalTopup.Location = new System.Drawing.Point(3, 3);
            this.pnlTotalTopup.Name = "pnlTotalTopup";
            this.pnlTotalTopup.Size = new System.Drawing.Size(197, 110);
            this.pnlTotalTopup.TabIndex = 13;
            // 
            // picTopUp
            // 
            this.picTopUp.ErrorImage = null;
            this.picTopUp.Image = ((System.Drawing.Image)(resources.GetObject("picTopUp.Image")));
            this.picTopUp.InitialImage = null;
            this.picTopUp.Location = new System.Drawing.Point(9, 20);
            this.picTopUp.Name = "picTopUp";
            this.picTopUp.Size = new System.Drawing.Size(66, 62);
            this.picTopUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTopUp.TabIndex = 9;
            this.picTopUp.TabStop = false;
            // 
            // lblTtlTopupNo
            // 
            this.lblTtlTopupNo.AutoSize = true;
            this.lblTtlTopupNo.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTtlTopupNo.Location = new System.Drawing.Point(97, 58);
            this.lblTtlTopupNo.Name = "lblTtlTopupNo";
            this.lblTtlTopupNo.Size = new System.Drawing.Size(54, 24);
            this.lblTtlTopupNo.TabIndex = 5;
            this.lblTtlTopupNo.Text = "$400";
            // 
            // lblTotalTopup
            // 
            this.lblTotalTopup.AutoSize = true;
            this.lblTotalTopup.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTopup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTotalTopup.Location = new System.Drawing.Point(81, 20);
            this.lblTotalTopup.Name = "lblTotalTopup";
            this.lblTotalTopup.Size = new System.Drawing.Size(101, 21);
            this.lblTotalTopup.TabIndex = 4;
            this.lblTotalTopup.Text = "Total Top-up\r\n";
            // 
            // pnlNetBalance
            // 
            this.pnlNetBalance.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.pnlNetBalance.Controls.Add(this.picBalance);
            this.pnlNetBalance.Controls.Add(this.lblNetBalanceNo);
            this.pnlNetBalance.Controls.Add(this.lblNetBalance);
            this.pnlNetBalance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNetBalance.Location = new System.Drawing.Point(409, 3);
            this.pnlNetBalance.Name = "pnlNetBalance";
            this.pnlNetBalance.Size = new System.Drawing.Size(197, 110);
            this.pnlNetBalance.TabIndex = 14;
            // 
            // picBalance
            // 
            this.picBalance.ErrorImage = null;
            this.picBalance.Image = ((System.Drawing.Image)(resources.GetObject("picBalance.Image")));
            this.picBalance.InitialImage = null;
            this.picBalance.Location = new System.Drawing.Point(10, 20);
            this.picBalance.Name = "picBalance";
            this.picBalance.Size = new System.Drawing.Size(66, 62);
            this.picBalance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBalance.TabIndex = 11;
            this.picBalance.TabStop = false;
            // 
            // lblNetBalanceNo
            // 
            this.lblNetBalanceNo.AutoSize = true;
            this.lblNetBalanceNo.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetBalanceNo.Location = new System.Drawing.Point(113, 58);
            this.lblNetBalanceNo.Name = "lblNetBalanceNo";
            this.lblNetBalanceNo.Size = new System.Drawing.Size(43, 24);
            this.lblNetBalanceNo.TabIndex = 7;
            this.lblNetBalanceNo.Text = "$20";
            // 
            // lblNetBalance
            // 
            this.lblNetBalance.AutoSize = true;
            this.lblNetBalance.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetBalance.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblNetBalance.Location = new System.Drawing.Point(82, 20);
            this.lblNetBalance.Name = "lblNetBalance";
            this.lblNetBalance.Size = new System.Drawing.Size(97, 21);
            this.lblNetBalance.TabIndex = 5;
            this.lblNetBalance.Text = "Net Balance";
            // 
            // pnlTotalTransaction
            // 
            this.pnlTotalTransaction.BackColor = System.Drawing.Color.LavenderBlush;
            this.pnlTotalTransaction.Controls.Add(this.picTransaction);
            this.pnlTotalTransaction.Controls.Add(this.lblTtlTransactionNo);
            this.pnlTotalTransaction.Controls.Add(this.lblTotalTransaction);
            this.pnlTotalTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTotalTransaction.Location = new System.Drawing.Point(612, 3);
            this.pnlTotalTransaction.Name = "pnlTotalTransaction";
            this.pnlTotalTransaction.Size = new System.Drawing.Size(200, 110);
            this.pnlTotalTransaction.TabIndex = 14;
            // 
            // picTransaction
            // 
            this.picTransaction.ErrorImage = null;
            this.picTransaction.Image = ((System.Drawing.Image)(resources.GetObject("picTransaction.Image")));
            this.picTransaction.InitialImage = null;
            this.picTransaction.Location = new System.Drawing.Point(6, 20);
            this.picTransaction.Name = "picTransaction";
            this.picTransaction.Size = new System.Drawing.Size(66, 62);
            this.picTransaction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTransaction.TabIndex = 11;
            this.picTransaction.TabStop = false;
            // 
            // lblTtlTransactionNo
            // 
            this.lblTtlTransactionNo.AutoSize = true;
            this.lblTtlTransactionNo.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTtlTransactionNo.Location = new System.Drawing.Point(112, 54);
            this.lblTtlTransactionNo.Name = "lblTtlTransactionNo";
            this.lblTtlTransactionNo.Size = new System.Drawing.Size(54, 24);
            this.lblTtlTransactionNo.TabIndex = 8;
            this.lblTtlTransactionNo.Text = "$250";
            // 
            // lblTotalTransaction
            // 
            this.lblTotalTransaction.AutoSize = true;
            this.lblTotalTransaction.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTransaction.ForeColor = System.Drawing.Color.Purple;
            this.lblTotalTransaction.Location = new System.Drawing.Point(72, 20);
            this.lblTotalTransaction.Name = "lblTotalTransaction";
            this.lblTotalTransaction.Size = new System.Drawing.Size(131, 21);
            this.lblTotalTransaction.TabIndex = 6;
            this.lblTotalTransaction.Text = "Total Transaction";
            // 
            // pnlTotalUse
            // 
            this.pnlTotalUse.BackColor = System.Drawing.Color.Lavender;
            this.pnlTotalUse.Controls.Add(this.picUsage);
            this.pnlTotalUse.Controls.Add(this.lblTtlUsageNo);
            this.pnlTotalUse.Controls.Add(this.lblTotalUse);
            this.pnlTotalUse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTotalUse.Location = new System.Drawing.Point(206, 3);
            this.pnlTotalUse.Name = "pnlTotalUse";
            this.pnlTotalUse.Size = new System.Drawing.Size(197, 110);
            this.pnlTotalUse.TabIndex = 14;
            // 
            // picUsage
            // 
            this.picUsage.ErrorImage = null;
            this.picUsage.Image = ((System.Drawing.Image)(resources.GetObject("picUsage.Image")));
            this.picUsage.InitialImage = null;
            this.picUsage.Location = new System.Drawing.Point(5, 20);
            this.picUsage.Name = "picUsage";
            this.picUsage.Size = new System.Drawing.Size(66, 62);
            this.picUsage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUsage.TabIndex = 10;
            this.picUsage.TabStop = false;
            // 
            // lblTtlUsageNo
            // 
            this.lblTtlUsageNo.AutoSize = true;
            this.lblTtlUsageNo.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTtlUsageNo.Location = new System.Drawing.Point(98, 58);
            this.lblTtlUsageNo.Name = "lblTtlUsageNo";
            this.lblTtlUsageNo.Size = new System.Drawing.Size(54, 24);
            this.lblTtlUsageNo.TabIndex = 6;
            this.lblTtlUsageNo.Text = "$100";
            // 
            // lblTotalUse
            // 
            this.lblTotalUse.AutoSize = true;
            this.lblTotalUse.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalUse.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTotalUse.Location = new System.Drawing.Point(77, 20);
            this.lblTotalUse.Name = "lblTotalUse";
            this.lblTotalUse.Size = new System.Drawing.Size(94, 21);
            this.lblTotalUse.TabIndex = 2;
            this.lblTotalUse.Text = "Total Usage\r\n";
            // 
            // lblTransactionHistory
            // 
            this.lblTransactionHistory.AutoSize = true;
            this.lblTransactionHistory.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionHistory.Location = new System.Drawing.Point(199, 248);
            this.lblTransactionHistory.Name = "lblTransactionHistory";
            this.lblTransactionHistory.Size = new System.Drawing.Size(176, 25);
            this.lblTransactionHistory.TabIndex = 14;
            this.lblTransactionHistory.Text = "Transaction History";
            // 
            // picTransactionHistory
            // 
            this.picTransactionHistory.ErrorImage = null;
            this.picTransactionHistory.Image = ((System.Drawing.Image)(resources.GetObject("picTransactionHistory.Image")));
            this.picTransactionHistory.InitialImage = null;
            this.picTransactionHistory.Location = new System.Drawing.Point(160, 238);
            this.picTransactionHistory.Name = "picTransactionHistory";
            this.picTransactionHistory.Size = new System.Drawing.Size(33, 35);
            this.picTransactionHistory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTransactionHistory.TabIndex = 10;
            this.picTransactionHistory.TabStop = false;
            // 
            // btnDasboard
            // 
            this.btnDasboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDasboard.FlatAppearance.BorderSize = 0;
            this.btnDasboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDasboard.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDasboard.ForeColor = System.Drawing.Color.White;
            this.btnDasboard.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDasboard.Location = new System.Drawing.Point(-24, 109);
            this.btnDasboard.Name = "btnDasboard";
            this.btnDasboard.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnDasboard.Size = new System.Drawing.Size(184, 60);
            this.btnDasboard.TabIndex = 7;
            this.btnDasboard.Text = " ≡  Dashboard";
            this.btnDasboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDasboard.UseVisualStyleBackColor = false;
            this.btnDasboard.Click += new System.EventHandler(this.btnDasboard_Click);
            // 
            // btnUpdProf
            // 
            this.btnUpdProf.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdProf.FlatAppearance.BorderSize = 0;
            this.btnUpdProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdProf.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdProf.ForeColor = System.Drawing.Color.White;
            this.btnUpdProf.Location = new System.Drawing.Point(-5, 287);
            this.btnUpdProf.Name = "btnUpdProf";
            this.btnUpdProf.Size = new System.Drawing.Size(162, 59);
            this.btnUpdProf.TabIndex = 3;
            this.btnUpdProf.Text = "👤 Update Profile";
            this.btnUpdProf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdProf.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(0, 483);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(157, 62);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = " ➜] Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnFeedback
            // 
            this.btnFeedback.BackColor = System.Drawing.Color.Transparent;
            this.btnFeedback.FlatAppearance.BorderSize = 0;
            this.btnFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFeedback.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeedback.ForeColor = System.Drawing.Color.White;
            this.btnFeedback.Location = new System.Drawing.Point(-27, 164);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnFeedback.Size = new System.Drawing.Size(187, 59);
            this.btnFeedback.TabIndex = 1;
            this.btnFeedback.Text = " 💬 Manage Feedback\r\n";
            this.btnFeedback.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFeedback.UseVisualStyleBackColor = false;
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);
            // 
            // btnWallet
            // 
            this.btnWallet.BackColor = System.Drawing.Color.Transparent;
            this.btnWallet.FlatAppearance.BorderSize = 0;
            this.btnWallet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWallet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWallet.ForeColor = System.Drawing.Color.White;
            this.btnWallet.Location = new System.Drawing.Point(-27, 221);
            this.btnWallet.Name = "btnWallet";
            this.btnWallet.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnWallet.Size = new System.Drawing.Size(181, 60);
            this.btnWallet.TabIndex = 3;
            this.btnWallet.Text = "📝 Wallet Report";
            this.btnWallet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWallet.UseVisualStyleBackColor = false;
            this.btnWallet.Click += new System.EventHandler(this.btnWallet_Click);
            // 
            // pnlSidebarWallet
            // 
            this.pnlSidebarWallet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(78)))), ((int)(((byte)(65)))));
            this.pnlSidebarWallet.Controls.Add(this.picLogo);
            this.pnlSidebarWallet.Controls.Add(this.btnDasboard);
            this.pnlSidebarWallet.Controls.Add(this.btnFeedback);
            this.pnlSidebarWallet.Controls.Add(this.btnWallet);
            this.pnlSidebarWallet.Controls.Add(this.btnUpdProf);
            this.pnlSidebarWallet.Controls.Add(this.btnLogout);
            this.pnlSidebarWallet.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebarWallet.Location = new System.Drawing.Point(0, 50);
            this.pnlSidebarWallet.Name = "pnlSidebarWallet";
            this.pnlSidebarWallet.Size = new System.Drawing.Size(157, 545);
            this.pnlSidebarWallet.TabIndex = 15;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.ErrorImage = null;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.InitialImage = null;
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(154, 107);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 8;
            this.picLogo.TabStop = false;
            // 
            // tlpnlDetailsWallet
            // 
            this.tlpnlDetailsWallet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpnlDetailsWallet.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tlpnlDetailsWallet.ColumnCount = 2;
            this.tlpnlDetailsWallet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpnlDetailsWallet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpnlDetailsWallet.Controls.Add(this.tlpnlInnerWallet, 0, 0);
            this.tlpnlDetailsWallet.Controls.Add(this.pnlWalletFilterReset, 1, 0);
            this.tlpnlDetailsWallet.Location = new System.Drawing.Point(163, 50);
            this.tlpnlDetailsWallet.Name = "tlpnlDetailsWallet";
            this.tlpnlDetailsWallet.RowCount = 1;
            this.tlpnlDetailsWallet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpnlDetailsWallet.Size = new System.Drawing.Size(813, 66);
            this.tlpnlDetailsWallet.TabIndex = 17;
            // 
            // tlpnlInnerWallet
            // 
            this.tlpnlInnerWallet.ColumnCount = 2;
            this.tlpnlInnerWallet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpnlInnerWallet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpnlInnerWallet.Controls.Add(this.lblCustomer, 0, 0);
            this.tlpnlInnerWallet.Controls.Add(this.lblMonthYear, 1, 0);
            this.tlpnlInnerWallet.Controls.Add(this.cmbUser, 0, 1);
            this.tlpnlInnerWallet.Controls.Add(this.dtpDate, 1, 1);
            this.tlpnlInnerWallet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpnlInnerWallet.Location = new System.Drawing.Point(7, 7);
            this.tlpnlInnerWallet.Margin = new System.Windows.Forms.Padding(7);
            this.tlpnlInnerWallet.Name = "tlpnlInnerWallet";
            this.tlpnlInnerWallet.RowCount = 2;
            this.tlpnlInnerWallet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpnlInnerWallet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpnlInnerWallet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpnlInnerWallet.Size = new System.Drawing.Size(555, 52);
            this.tlpnlInnerWallet.TabIndex = 0;
            // 
            // pnlWalletFilterReset
            // 
            this.pnlWalletFilterReset.Controls.Add(this.btnReset);
            this.pnlWalletFilterReset.Controls.Add(this.btnFilter);
            this.pnlWalletFilterReset.Location = new System.Drawing.Point(572, 3);
            this.pnlWalletFilterReset.Name = "pnlWalletFilterReset";
            this.pnlWalletFilterReset.Size = new System.Drawing.Size(237, 60);
            this.pnlWalletFilterReset.TabIndex = 1;
            // 
            // tlpnlWalletCards
            // 
            this.tlpnlWalletCards.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpnlWalletCards.BackColor = System.Drawing.Color.Ivory;
            this.tlpnlWalletCards.ColumnCount = 4;
            this.tlpnlWalletCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpnlWalletCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpnlWalletCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpnlWalletCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpnlWalletCards.Controls.Add(this.pnlTotalTransaction, 3, 0);
            this.tlpnlWalletCards.Controls.Add(this.pnlTotalTopup, 0, 0);
            this.tlpnlWalletCards.Controls.Add(this.pnlNetBalance, 2, 0);
            this.tlpnlWalletCards.Controls.Add(this.pnlTotalUse, 1, 0);
            this.tlpnlWalletCards.Location = new System.Drawing.Point(163, 119);
            this.tlpnlWalletCards.Name = "tlpnlWalletCards";
            this.tlpnlWalletCards.RowCount = 1;
            this.tlpnlWalletCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpnlWalletCards.Size = new System.Drawing.Size(815, 116);
            this.tlpnlWalletCards.TabIndex = 0;
            // 
            // pnlWalletTrans
            // 
            this.pnlWalletTrans.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlWalletTrans.Controls.Add(this.dgvWalletTrans);
            this.pnlWalletTrans.Location = new System.Drawing.Point(163, 276);
            this.pnlWalletTrans.Name = "pnlWalletTrans";
            this.pnlWalletTrans.Size = new System.Drawing.Size(821, 319);
            this.pnlWalletTrans.TabIndex = 16;
            // 
            // WalletReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 595);
            this.Controls.Add(this.tlpnlWalletCards);
            this.Controls.Add(this.tlpnlDetailsWallet);
            this.Controls.Add(this.picTransactionHistory);
            this.Controls.Add(this.pnlWalletTrans);
            this.Controls.Add(this.lblTransactionHistory);
            this.Controls.Add(this.pnlSidebarWallet);
            this.Controls.Add(this.pnlWalletReport);
            this.Name = "WalletReport";
            this.Text = "Wallet transaction report";
            this.Load += new System.EventHandler(this.WalletReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWalletTrans)).EndInit();
            this.pnlWalletReport.ResumeLayout(false);
            this.pnlWalletReport.PerformLayout();
            this.pnlTotalTopup.ResumeLayout(false);
            this.pnlTotalTopup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTopUp)).EndInit();
            this.pnlNetBalance.ResumeLayout(false);
            this.pnlNetBalance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBalance)).EndInit();
            this.pnlTotalTransaction.ResumeLayout(false);
            this.pnlTotalTransaction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTransaction)).EndInit();
            this.pnlTotalUse.ResumeLayout(false);
            this.pnlTotalUse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTransactionHistory)).EndInit();
            this.pnlSidebarWallet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.tlpnlDetailsWallet.ResumeLayout(false);
            this.tlpnlInnerWallet.ResumeLayout(false);
            this.tlpnlInnerWallet.PerformLayout();
            this.pnlWalletFilterReset.ResumeLayout(false);
            this.tlpnlWalletCards.ResumeLayout(false);
            this.pnlWalletTrans.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvWalletTrans;
        private System.Windows.Forms.Label lblMonthYear;
        private System.Windows.Forms.Panel pnlWalletReport;
        private System.Windows.Forms.Label lblHeadingWalletTrans;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.ComboBox cmbUser;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblWalletSubtitle;
        private System.Windows.Forms.Label lblTotalTopup;
        private System.Windows.Forms.Label lblTotalUse;
        private System.Windows.Forms.Panel pnlTotalTransaction;
        private System.Windows.Forms.Panel pnlNetBalance;
        private System.Windows.Forms.Panel pnlTotalUse;
        private System.Windows.Forms.Panel pnlTotalTopup;
        private System.Windows.Forms.Label lblNetBalance;
        private System.Windows.Forms.Label lblTotalTransaction;
        private System.Windows.Forms.Label lblTtlTransactionNo;
        private System.Windows.Forms.Label lblTtlTopupNo;
        private System.Windows.Forms.Label lblTtlUsageNo;
        private System.Windows.Forms.Label lblNetBalanceNo;
        private System.Windows.Forms.PictureBox picTopUp;
        private System.Windows.Forms.PictureBox picBalance;
        private System.Windows.Forms.PictureBox picUsage;
        private System.Windows.Forms.PictureBox picTransaction;
        private System.Windows.Forms.PictureBox picTransactionHistory;
        private System.Windows.Forms.Label lblTransactionHistory;
        private System.Windows.Forms.Button btnUpdProf;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnFeedback;
        private System.Windows.Forms.Button btnWallet;
        private System.Windows.Forms.Button btnDasboard;
        private System.Windows.Forms.Panel pnlSidebarWallet;
        private System.Windows.Forms.TableLayoutPanel tlpnlDetailsWallet;
        private System.Windows.Forms.TableLayoutPanel tlpnlInnerWallet;
        private System.Windows.Forms.Panel pnlWalletFilterReset;
        private System.Windows.Forms.TableLayoutPanel tlpnlWalletCards;
        private System.Windows.Forms.Panel pnlWalletTrans;
        private System.Windows.Forms.PictureBox picLogo;
    }
}