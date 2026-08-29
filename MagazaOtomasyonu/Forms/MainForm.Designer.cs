namespace MagazaOtomasyonu.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources are being disposed; otherwise, false.</param>
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
            btnProducts = new Button();
            btnLogout = new Button();
            btnReports = new Button();
            btnSalesHistory = new Button();
            btnSales = new Button();
            lblCurrentUser = new Label();
            btnColors = new Button();
            btnBrands = new Button();
            btnCategories = new Button();
            btnSizes = new Button();
            btnStock = new Button();
            btnCustomers = new Button();
            btnUsers = new Button();
            SuspendLayout();
            // 
            // btnProducts
            // 
            btnProducts.Location = new Point(12, 93);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(148, 29);
            btnProducts.TabIndex = 4;
            btnProducts.Text = "Ürünler";
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(474, 128);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(148, 29);
            btnLogout.TabIndex = 11;
            btnLogout.Text = "Çıkış";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnReports
            // 
            btnReports.Location = new Point(320, 128);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(148, 29);
            btnReports.TabIndex = 10;
            btnReports.Text = "Raporlar";
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // btnSalesHistory
            // 
            btnSalesHistory.Location = new Point(166, 128);
            btnSalesHistory.Name = "btnSalesHistory";
            btnSalesHistory.Size = new Size(148, 29);
            btnSalesHistory.TabIndex = 9;
            btnSalesHistory.Text = "Satış Geçmişi";
            btnSalesHistory.UseVisualStyleBackColor = true;
            btnSalesHistory.Click += btnSalesHistory_Click;
            // 
            // btnSales
            // 
            btnSales.Location = new Point(12, 128);
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(148, 29);
            btnSales.TabIndex = 8;
            btnSales.Text = "Satışlar";
            btnSales.UseVisualStyleBackColor = true;
            btnSales.Click += btnSales_Click;
            // 
            // lblCurrentUser
            // 
            lblCurrentUser.AutoSize = true;
            lblCurrentUser.Location = new Point(12, 19);
            lblCurrentUser.Name = "lblCurrentUser";
            lblCurrentUser.Size = new Size(114, 20);
            lblCurrentUser.TabIndex = 16;
            lblCurrentUser.Text = "Güncel Kullanıcı";
            // 
            // btnColors
            // 
            btnColors.Location = new Point(320, 58);
            btnColors.Name = "btnColors";
            btnColors.Size = new Size(148, 29);
            btnColors.TabIndex = 19;
            btnColors.Text = "Renkler";
            btnColors.UseVisualStyleBackColor = true;
            btnColors.Click += btnColors_Click;
            // 
            // btnBrands
            // 
            btnBrands.Location = new Point(166, 58);
            btnBrands.Name = "btnBrands";
            btnBrands.Size = new Size(148, 29);
            btnBrands.TabIndex = 18;
            btnBrands.Text = "Markalar";
            btnBrands.UseVisualStyleBackColor = true;
            btnBrands.Click += btnBrands_Click;
            // 
            // btnCategories
            // 
            btnCategories.Location = new Point(12, 58);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(148, 29);
            btnCategories.TabIndex = 17;
            btnCategories.Text = "Kategoriler";
            btnCategories.UseVisualStyleBackColor = true;
            btnCategories.Click += btnCategories_Click;
            // 
            // btnSizes
            // 
            btnSizes.Location = new Point(474, 58);
            btnSizes.Name = "btnSizes";
            btnSizes.Size = new Size(148, 29);
            btnSizes.TabIndex = 20;
            btnSizes.Text = "Bedenler";
            btnSizes.UseVisualStyleBackColor = true;
            btnSizes.Click += btnSizes_Click;
            // 
            // btnStock
            // 
            btnStock.Location = new Point(166, 93);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(148, 29);
            btnStock.TabIndex = 21;
            btnStock.Text = "Stok";
            btnStock.UseVisualStyleBackColor = true;
            btnStock.Click += btnStock_Click;
            // 
            // btnCustomers
            // 
            btnCustomers.Location = new Point(320, 93);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(148, 29);
            btnCustomers.TabIndex = 22;
            btnCustomers.Text = "Müşteriler";
            btnCustomers.UseVisualStyleBackColor = true;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // btnUsers
            // 
            btnUsers.Location = new Point(474, 93);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(148, 29);
            btnUsers.TabIndex = 23;
            btnUsers.Text = "Kullanıcılar";
            btnUsers.UseVisualStyleBackColor = true;
            btnUsers.Click += btnUsers_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(645, 183);
            Controls.Add(btnUsers);
            Controls.Add(btnCustomers);
            Controls.Add(btnStock);
            Controls.Add(btnSizes);
            Controls.Add(btnColors);
            Controls.Add(btnBrands);
            Controls.Add(btnCategories);
            Controls.Add(lblCurrentUser);
            Controls.Add(btnLogout);
            Controls.Add(btnReports);
            Controls.Add(btnSalesHistory);
            Controls.Add(btnSales);
            Controls.Add(btnProducts);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUsers;
        private Button btnProducts;
        private Button btnLogout;
        private Button btnReports;
        private Button btnSalesHistory;
        private Button btnSales;
        private Label lblCurrentUser;
        private Button btnColors;
        private Button btnBrands;
        private Button btnCategories;
        private Button btnSizes;
        private Button btnStock;
        private Button btnCustomers;
    }
}
