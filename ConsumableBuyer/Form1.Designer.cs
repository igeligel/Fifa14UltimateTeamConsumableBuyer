namespace ConsumableBuy
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.BT_Login = new System.Windows.Forms.Button();
            this.TbMail = new System.Windows.Forms.TextBox();
            this.TbPassword = new System.Windows.Forms.TextBox();
            this.TbSecurity = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cB_art = new System.Windows.Forms.ComboBox();
            this.BT_start = new System.Windows.Forms.Button();
            this.dG_Prices = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dG_Prices)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_Login
            // 
            this.BT_Login.Location = new System.Drawing.Point(12, 90);
            this.BT_Login.Name = "BT_Login";
            this.BT_Login.Size = new System.Drawing.Size(250, 72);
            this.BT_Login.TabIndex = 0;
            this.BT_Login.Text = "Login";
            this.BT_Login.UseVisualStyleBackColor = true;
            this.BT_Login.Click += new System.EventHandler(this.BT_Login_Click);
            // 
            // TbMail
            // 
            this.TbMail.Location = new System.Drawing.Point(12, 12);
            this.TbMail.Name = "TbMail";
            this.TbMail.Size = new System.Drawing.Size(250, 20);
            this.TbMail.TabIndex = 1;
            // 
            // TbPassword
            // 
            this.TbPassword.Location = new System.Drawing.Point(12, 38);
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.Size = new System.Drawing.Size(250, 20);
            this.TbPassword.TabIndex = 2;
            // 
            // TbSecurity
            // 
            this.TbSecurity.Location = new System.Drawing.Point(12, 64);
            this.TbSecurity.Name = "TbSecurity";
            this.TbSecurity.Size = new System.Drawing.Size(250, 20);
            this.TbSecurity.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 168);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(485, 407);
            this.listBox1.TabIndex = 4;
            // 
            // cB_art
            // 
            this.cB_art.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_art.FormattingEnabled = true;
            this.cB_art.Items.AddRange(new object[] {
            "Fitness",
            "Contracts",
            "Manager Leagues",
            "Positions",
            "Chemistry Styles"});
            this.cB_art.Location = new System.Drawing.Point(268, 90);
            this.cB_art.Name = "cB_art";
            this.cB_art.Size = new System.Drawing.Size(229, 21);
            this.cB_art.TabIndex = 5;
            // 
            // BT_start
            // 
            this.BT_start.Location = new System.Drawing.Point(268, 117);
            this.BT_start.Name = "BT_start";
            this.BT_start.Size = new System.Drawing.Size(229, 45);
            this.BT_start.TabIndex = 6;
            this.BT_start.Text = "Starten";
            this.BT_start.UseVisualStyleBackColor = true;
            this.BT_start.Click += new System.EventHandler(this.BT_start_Click);
            // 
            // dG_Prices
            // 
            this.dG_Prices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dG_Prices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dG_Prices.Location = new System.Drawing.Point(720, 12);
            this.dG_Prices.Name = "dG_Prices";
            this.dG_Prices.Size = new System.Drawing.Size(376, 563);
            this.dG_Prices.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Item";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ResID";
            this.Column2.Name = "Column2";
            this.Column2.Width = 75;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Price";
            this.Column3.Name = "Column3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 588);
            this.Controls.Add(this.dG_Prices);
            this.Controls.Add(this.BT_start);
            this.Controls.Add(this.cB_art);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.TbSecurity);
            this.Controls.Add(this.TbPassword);
            this.Controls.Add(this.TbMail);
            this.Controls.Add(this.BT_Login);
            this.Name = "Form1";
            this.Text = "ConsumableBidder";
            ((System.ComponentModel.ISupportInitialize)(this.dG_Prices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_Login;
        private System.Windows.Forms.TextBox TbMail;
        private System.Windows.Forms.TextBox TbPassword;
        private System.Windows.Forms.TextBox TbSecurity;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox cB_art;
        private System.Windows.Forms.Button BT_start;
        private System.Windows.Forms.DataGridView dG_Prices;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;

    }
}

