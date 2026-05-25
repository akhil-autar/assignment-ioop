namespace Gr8FoodSystem_Final
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.panelOrderHistory = new System.Windows.Forms.Panel();
            this.btnOrderHistory = new System.Windows.Forms.Label();
            this.panelLogout = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panelDashboard = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelFeedback = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panelOrders = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.labelNotification = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.colFood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelRecentOrders = new System.Windows.Forms.Label();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.panelOrder = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTotalOrders = new System.Windows.Forms.Label();
            this.panelWallet = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.labelWallet = new System.Windows.Forms.Label();
            this.panelWelcome = new System.Windows.Forms.Panel();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panelSidebar.SuspendLayout();
            this.panelOrderHistory.SuspendLayout();
            this.panelLogout.SuspendLayout();
            this.panelDashboard.SuspendLayout();
            this.panelFeedback.SuspendLayout();
            this.panelOrders.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.panelStatus.SuspendLayout();
            this.panelOrder.SuspendLayout();
            this.panelWallet.SuspendLayout();
            this.panelWelcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelSidebar.Controls.Add(this.panelOrderHistory);
            this.panelSidebar.Controls.Add(this.panelLogout);
            this.panelSidebar.Controls.Add(this.panelDashboard);
            this.panelSidebar.Controls.Add(this.panelFeedback);
            this.panelSidebar.Controls.Add(this.panelOrders);
            this.panelSidebar.Controls.Add(this.panelMenu);
            this.panelSidebar.Controls.Add(this.picLogo);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(220, 611);
            this.panelSidebar.TabIndex = 0;
            // 
            // panelOrderHistory
            // 
            this.panelOrderHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelOrderHistory.Controls.Add(this.btnOrderHistory);
            this.panelOrderHistory.Location = new System.Drawing.Point(0, 380);
            this.panelOrderHistory.Name = "panelOrderHistory";
            this.panelOrderHistory.Size = new System.Drawing.Size(180, 51);
            this.panelOrderHistory.TabIndex = 5;
            this.panelOrderHistory.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnOrderHistory
            // 
            this.btnOrderHistory.AutoSize = true;
            this.btnOrderHistory.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderHistory.ForeColor = System.Drawing.Color.White;
            this.btnOrderHistory.Location = new System.Drawing.Point(15, 16);
            this.btnOrderHistory.Name = "btnOrderHistory";
            this.btnOrderHistory.Size = new System.Drawing.Size(152, 22);
            this.btnOrderHistory.TabIndex = 1;
            this.btnOrderHistory.Text = "🗓️ Order History\r\n";
            this.btnOrderHistory.Click += new System.EventHandler(this.btnOrderHistory_Click);
            // 
            // panelLogout
            // 
            this.panelLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelLogout.Controls.Add(this.label6);
            this.panelLogout.Location = new System.Drawing.Point(0, 450);
            this.panelLogout.Name = "panelLogout";
            this.panelLogout.Size = new System.Drawing.Size(180, 50);
            this.panelLogout.TabIndex = 2;
            this.panelLogout.Click += new System.EventHandler(this.panelLogout_Cick);
            this.panelLogout.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogout_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(15, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 22);
            this.label6.TabIndex = 1;
            this.label6.Text = "📤 Logout";
            // 
            // panelDashboard
            // 
            this.panelDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelDashboard.Controls.Add(this.label1);
            this.panelDashboard.Location = new System.Drawing.Point(0, 100);
            this.panelDashboard.Name = "panelDashboard";
            this.panelDashboard.Size = new System.Drawing.Size(180, 50);
            this.panelDashboard.TabIndex = 1;
            this.panelDashboard.Click += new System.EventHandler(this.panelDashboard_Click);
            this.panelDashboard.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDashboard_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = " 📌 Dashboard";
            // 
            // panelFeedback
            // 
            this.panelFeedback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelFeedback.Controls.Add(this.label5);
            this.panelFeedback.Location = new System.Drawing.Point(0, 310);
            this.panelFeedback.Name = "panelFeedback";
            this.panelFeedback.Size = new System.Drawing.Size(180, 50);
            this.panelFeedback.TabIndex = 2;
            this.panelFeedback.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFeedback_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(15, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "📝  Feedback";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panelOrders
            // 
            this.panelOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelOrders.Controls.Add(this.label3);
            this.panelOrders.Location = new System.Drawing.Point(0, 240);
            this.panelOrders.Name = "panelOrders";
            this.panelOrders.Size = new System.Drawing.Size(180, 50);
            this.panelOrders.TabIndex = 3;
            this.panelOrders.Click += new System.EventHandler(this.panelOrders_Click);
            this.panelOrders.Paint += new System.Windows.Forms.PaintEventHandler(this.panelOrders_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "🛒  My Orders";
            this.label3.Click += new System.EventHandler(this.panelOrders_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelMenu.Controls.Add(this.label2);
            this.panelMenu.Location = new System.Drawing.Point(0, 170);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(180, 51);
            this.panelMenu.TabIndex = 2;
            this.panelMenu.Click += new System.EventHandler(this.panelMenu_Click);
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "📋 Browse Menu";
            this.label2.Click += new System.EventHandler(this.panelMenu_Click);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.lblName);
            this.panelTop.Controls.Add(this.labelNotification);
            this.panelTop.Controls.Add(this.txtSearch);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(220, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(808, 70);
            this.panelTop.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(589, 18);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 21);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Duha";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // labelNotification
            // 
            this.labelNotification.AutoSize = true;
            this.labelNotification.Location = new System.Drawing.Point(550, 18);
            this.labelNotification.Name = "labelNotification";
            this.labelNotification.Size = new System.Drawing.Size(33, 21);
            this.labelNotification.TabIndex = 1;
            this.labelNotification.Text = "🔔";
            this.labelNotification.Click += new System.EventHandler(this.labelNotification_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(300, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.ReadOnly = true;
            this.txtSearch.Size = new System.Drawing.Size(200, 29);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelMain.Controls.Add(this.label7);
            this.panelMain.Controls.Add(this.dgvOrders);
            this.panelMain.Controls.Add(this.labelRecentOrders);
            this.panelMain.Controls.Add(this.panelStatus);
            this.panelMain.Controls.Add(this.panelOrder);
            this.panelMain.Controls.Add(this.panelWallet);
            this.panelMain.Controls.Add(this.panelWelcome);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(220, 70);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(808, 541);
            this.panelMain.TabIndex = 3;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(100, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(232, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "You placed 3 orders this week!\r\n";
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrders.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOrders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvOrders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFood,
            this.colQuantity,
            this.colPrice,
            this.colStatus});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrders.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrders.EnableHeadersVisualStyles = false;
            this.dgvOrders.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvOrders.Location = new System.Drawing.Point(100, 290);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.RowHeadersVisible = false;
            this.dgvOrders.Size = new System.Drawing.Size(650, 220);
            this.dgvOrders.TabIndex = 5;
            this.dgvOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrders_CellContentClick);
            this.dgvOrders.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvOrders_CellFormatting);
            // 
            // colFood
            // 
            this.colFood.HeaderText = "Food Name";
            this.colFood.Name = "colFood";
            // 
            // colQuantity
            // 
            this.colQuantity.HeaderText = "Quantity";
            this.colQuantity.Name = "colQuantity";
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Price";
            this.colPrice.Name = "colPrice";
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            // 
            // labelRecentOrders
            // 
            this.labelRecentOrders.AutoSize = true;
            this.labelRecentOrders.Location = new System.Drawing.Point(100, 260);
            this.labelRecentOrders.Name = "labelRecentOrders";
            this.labelRecentOrders.Size = new System.Drawing.Size(116, 21);
            this.labelRecentOrders.TabIndex = 4;
            this.labelRecentOrders.Text = "Recent Orders";
            // 
            // panelStatus
            // 
            this.panelStatus.BackColor = System.Drawing.Color.LightYellow;
            this.panelStatus.Controls.Add(this.label12);
            this.panelStatus.Controls.Add(this.labelStatus);
            this.panelStatus.Location = new System.Drawing.Point(554, 160);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(180, 100);
            this.panelStatus.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(57, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 21);
            this.label12.TabIndex = 1;
            this.label12.Text = "In Progress";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(57, 26);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(86, 21);
            this.labelStatus.TabIndex = 0;
            this.labelStatus.Text = "Last Order";
            // 
            // panelOrder
            // 
            this.panelOrder.BackColor = System.Drawing.Color.PeachPuff;
            this.panelOrder.Controls.Add(this.label10);
            this.panelOrder.Controls.Add(this.lblTotalOrders);
            this.panelOrder.Location = new System.Drawing.Point(320, 160);
            this.panelOrder.Name = "panelOrder";
            this.panelOrder.Size = new System.Drawing.Size(180, 100);
            this.panelOrder.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(57, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 21);
            this.label10.TabIndex = 1;
            this.label10.Text = "5";
            // 
            // lblTotalOrders
            // 
            this.lblTotalOrders.AutoSize = true;
            this.lblTotalOrders.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalOrders.Location = new System.Drawing.Point(57, 26);
            this.lblTotalOrders.Name = "lblTotalOrders";
            this.lblTotalOrders.Size = new System.Drawing.Size(99, 21);
            this.lblTotalOrders.TabIndex = 0;
            this.lblTotalOrders.Text = "Total Orders";
            // 
            // panelWallet
            // 
            this.panelWallet.BackColor = System.Drawing.Color.MintCream;
            this.panelWallet.Controls.Add(this.label9);
            this.panelWallet.Controls.Add(this.labelWallet);
            this.panelWallet.Location = new System.Drawing.Point(100, 160);
            this.panelWallet.Name = "panelWallet";
            this.panelWallet.Size = new System.Drawing.Size(180, 100);
            this.panelWallet.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(57, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 21);
            this.label9.TabIndex = 1;
            this.label9.Text = "RM 120.00";
            // 
            // labelWallet
            // 
            this.labelWallet.AutoSize = true;
            this.labelWallet.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWallet.Location = new System.Drawing.Point(57, 26);
            this.labelWallet.Name = "labelWallet";
            this.labelWallet.Size = new System.Drawing.Size(55, 21);
            this.labelWallet.TabIndex = 0;
            this.labelWallet.Text = "Wallet";
            // 
            // panelWelcome
            // 
            this.panelWelcome.BackColor = System.Drawing.Color.White;
            this.panelWelcome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelWelcome.Controls.Add(this.labelWelcome);
            this.panelWelcome.Location = new System.Drawing.Point(100, 30);
            this.panelWelcome.Name = "panelWelcome";
            this.panelWelcome.Size = new System.Drawing.Size(700, 90);
            this.panelWelcome.TabIndex = 0;
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(20, 20);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(260, 34);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "Welcome Duha,\r\nReady to order something delicious today?\r\n";
            // 
            // picLogo
            // 
  
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(220, 100);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1028, 611);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelSidebar);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerDashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSidebar.ResumeLayout(false);
            this.panelOrderHistory.ResumeLayout(false);
            this.panelOrderHistory.PerformLayout();
            this.panelLogout.ResumeLayout(false);
            this.panelLogout.PerformLayout();
            this.panelDashboard.ResumeLayout(false);
            this.panelDashboard.PerformLayout();
            this.panelFeedback.ResumeLayout(false);
            this.panelFeedback.PerformLayout();
            this.panelOrders.ResumeLayout(false);
            this.panelOrders.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.panelStatus.ResumeLayout(false);
            this.panelStatus.PerformLayout();
            this.panelOrder.ResumeLayout(false);
            this.panelOrder.PerformLayout();
            this.panelWallet.ResumeLayout(false);
            this.panelWallet.PerformLayout();
            this.panelWelcome.ResumeLayout(false);
            this.panelWelcome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel panelDashboard;
        private System.Windows.Forms.Panel panelFeedback;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelOrders;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelLogout;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label labelNotification;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelWelcome;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Panel panelWallet;
        private System.Windows.Forms.Panel panelOrder;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTotalOrders;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelWallet;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelRecentOrders;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFood;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelOrderHistory;
        private System.Windows.Forms.Label btnOrderHistory;
    }
}

