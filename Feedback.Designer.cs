namespace Gr8FoodSystem_Final
{
    partial class Feedback
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
            this.cmbOrders = new System.Windows.Forms.ComboBox();
            this.txtFeedback = new System.Windows.Forms.TextBox();
            this.numRating = new System.Windows.Forms.NumericUpDown();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioNeutral = new System.Windows.Forms.RadioButton();
            this.radioBad = new System.Windows.Forms.RadioButton();
            this.radioGood = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numRating)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbOrders
            // 
            this.cmbOrders.FormattingEnabled = true;
            this.cmbOrders.Location = new System.Drawing.Point(97, 39);
            this.cmbOrders.Name = "cmbOrders";
            this.cmbOrders.Size = new System.Drawing.Size(121, 21);
            this.cmbOrders.TabIndex = 0;
            // 
            // txtFeedback
            // 
            this.txtFeedback.Location = new System.Drawing.Point(97, 115);
            this.txtFeedback.Multiline = true;
            this.txtFeedback.Name = "txtFeedback";
            this.txtFeedback.Size = new System.Drawing.Size(400, 120);
            this.txtFeedback.TabIndex = 1;
            this.txtFeedback.TextChanged += new System.EventHandler(this.txtFeedback_TextChanged);
            // 
            // numRating
            // 
            this.numRating.Location = new System.Drawing.Point(495, 39);
            this.numRating.Name = "numRating";
            this.numRating.Size = new System.Drawing.Size(120, 20);
            this.numRating.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Crimson;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(97, 327);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(140, 45);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(492, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rating \r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Feedback Message";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Select Order";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioNeutral);
            this.groupBox1.Controls.Add(this.radioBad);
            this.groupBox1.Controls.Add(this.radioGood);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(97, 258);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 54);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rating";
            // 
            // radioNeutral
            // 
            this.radioNeutral.AutoSize = true;
            this.radioNeutral.Location = new System.Drawing.Point(299, 24);
            this.radioNeutral.Name = "radioNeutral";
            this.radioNeutral.Size = new System.Drawing.Size(80, 24);
            this.radioNeutral.TabIndex = 2;
            this.radioNeutral.TabStop = true;
            this.radioNeutral.Text = "Neutral\r\n";
            this.radioNeutral.UseVisualStyleBackColor = true;
            // 
            // radioBad
            // 
            this.radioBad.AutoSize = true;
            this.radioBad.Location = new System.Drawing.Point(162, 24);
            this.radioBad.Name = "radioBad";
            this.radioBad.Size = new System.Drawing.Size(54, 24);
            this.radioBad.TabIndex = 1;
            this.radioBad.TabStop = true;
            this.radioBad.Text = "Bad\r\n";
            this.radioBad.UseVisualStyleBackColor = true;
            this.radioBad.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioGood
            // 
            this.radioGood.AutoSize = true;
            this.radioGood.Location = new System.Drawing.Point(6, 24);
            this.radioGood.Name = "radioGood";
            this.radioGood.Size = new System.Drawing.Size(65, 24);
            this.radioGood.TabIndex = 0;
            this.radioGood.TabStop = true;
            this.radioGood.Text = "Good\r\n";
            this.radioGood.UseVisualStyleBackColor = true;
            this.radioGood.CheckedChanged += new System.EventHandler(this.radioGood_CheckedChanged);
            // 
            // Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.numRating);
            this.Controls.Add(this.txtFeedback);
            this.Controls.Add(this.cmbOrders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Feedback";
            this.Text = "Select Order";
            this.Load += new System.EventHandler(this.Feedback_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numRating)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOrders;
        private System.Windows.Forms.TextBox txtFeedback;
        private System.Windows.Forms.NumericUpDown numRating;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBad;
        private System.Windows.Forms.RadioButton radioGood;
        private System.Windows.Forms.RadioButton radioNeutral;
    }
}