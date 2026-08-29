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
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            pnlProductManagement = new Panel();
            lblProductManagement = new Label();
            pnlSalesManagement = new Panel();
            lblSalesManagement = new Label();
            pnlManagement = new Panel();
            lblManagement = new Label();
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
            pnlHeader.SuspendLayout();
            pnlProductManagement.SuspendLayout();
            pnlSalesManagement.SuspendLayout();
            pnlManagement.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlHeader.Controls.Add(lblCurrentUser);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Location = new Point(24, 20);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(952, 90);
            pnlHeader.TabIndex = 0;
            pnlHeader.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblTitle.Location = new Point(24, 13);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(220, 37);
            lblTitle.TabIndex = 20;
            lblTitle.TabStop = false;
            lblTitle.Text = "Mağaza Otomasyonu";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.Location = new Point(25, 54);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(201, 23);
            lblSubtitle.TabIndex = 21;
            lblSubtitle.TabStop = false;
            lblSubtitle.Text = "Ürün, stok ve satış yönetimi";
            // 
            // pnlProductManagement
            // 
            pnlProductManagement.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlProductManagement.Controls.Add(btnStock);
            pnlProductManagement.Controls.Add(btnProducts);
            pnlProductManagement.Controls.Add(btnSizes);
            pnlProductManagement.Controls.Add(btnColors);
            pnlProductManagement.Controls.Add(btnBrands);
            pnlProductManagement.Controls.Add(btnCategories);
            pnlProductManagement.Controls.Add(lblProductManagement);
            pnlProductManagement.Location = new Point(24, 130);
            pnlProductManagement.Name = "pnlProductManagement";
            pnlProductManagement.Size = new Size(952, 200);
            pnlProductManagement.TabIndex = 1;
            pnlProductManagement.TabStop = false;
            // 
            // lblProductManagement
            // 
            lblProductManagement.AutoSize = true;
            lblProductManagement.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblProductManagement.Location = new Point(20, 14);
            lblProductManagement.Name = "lblProductManagement";
            lblProductManagement.Size = new Size(150, 23);
            lblProductManagement.TabIndex = 20;
            lblProductManagement.TabStop = false;
            lblProductManagement.Text = "ÜRÜN YÖNETİMİ";
            // 
            // pnlSalesManagement
            // 
            pnlSalesManagement.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlSalesManagement.Controls.Add(btnSalesHistory);
            pnlSalesManagement.Controls.Add(btnSales);
            pnlSalesManagement.Controls.Add(btnCustomers);
            pnlSalesManagement.Controls.Add(lblSalesManagement);
            pnlSalesManagement.Location = new Point(24, 345);
            pnlSalesManagement.Name = "pnlSalesManagement";
            pnlSalesManagement.Size = new Size(952, 120);
            pnlSalesManagement.TabIndex = 2;
            pnlSalesManagement.TabStop = false;
            // 
            // lblSalesManagement
            // 
            lblSalesManagement.AutoSize = true;
            lblSalesManagement.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblSalesManagement.Location = new Point(20, 14);
            lblSalesManagement.Name = "lblSalesManagement";
            lblSalesManagement.Size = new Size(152, 23);
            lblSalesManagement.TabIndex = 20;
            lblSalesManagement.TabStop = false;
            lblSalesManagement.Text = "SATIŞ YÖNETİMİ";
            // 
            // pnlManagement
            // 
            pnlManagement.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlManagement.Controls.Add(btnLogout);
            pnlManagement.Controls.Add(btnReports);
            pnlManagement.Controls.Add(btnUsers);
            pnlManagement.Controls.Add(lblManagement);
            pnlManagement.Location = new Point(24, 470);
            pnlManagement.Name = "pnlManagement";
            pnlManagement.Size = new Size(952, 120);
            pnlManagement.TabIndex = 3;
            pnlManagement.TabStop = false;
            // 
            // lblManagement
            // 
            lblManagement.AutoSize = true;
            lblManagement.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblManagement.Location = new Point(20, 14);
            lblManagement.Name = "lblManagement";
            lblManagement.Size = new Size(92, 23);
            lblManagement.TabIndex = 20;
            lblManagement.TabStop = false;
            lblManagement.Text = "YÖNETİM";
            // 
            // btnProducts
            // 
            btnProducts.Location = new Point(20, 112);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(140, 42);
            btnProducts.TabIndex = 4;
            btnProducts.Text = "Ürünler";
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLogout.Location = new Point(792, 50);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(140, 42);
            btnLogout.TabIndex = 11;
            btnLogout.Text = "Çıkış";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnReports
            // 
            btnReports.Location = new Point(212, 50);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(180, 42);
            btnReports.TabIndex = 10;
            btnReports.Text = "Raporlar";
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // btnSalesHistory
            // 
            btnSalesHistory.Location = new Point(404, 50);
            btnSalesHistory.Name = "btnSalesHistory";
            btnSalesHistory.Size = new Size(180, 42);
            btnSalesHistory.TabIndex = 8;
            btnSalesHistory.Text = "Satış Geçmişi";
            btnSalesHistory.UseVisualStyleBackColor = true;
            btnSalesHistory.Click += btnSalesHistory_Click;
            // 
            // btnSales
            // 
            btnSales.Location = new Point(212, 50);
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(180, 42);
            btnSales.TabIndex = 7;
            btnSales.Text = "Satışlar";
            btnSales.UseVisualStyleBackColor = true;
            btnSales.Click += btnSales_Click;
            // 
            // lblCurrentUser
            // 
            lblCurrentUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCurrentUser.AutoSize = false;
            lblCurrentUser.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblCurrentUser.Location = new Point(652, 29);
            lblCurrentUser.Name = "lblCurrentUser";
            lblCurrentUser.Size = new Size(276, 32);
            lblCurrentUser.TabIndex = 22;
            lblCurrentUser.TabStop = false;
            lblCurrentUser.Text = "Güncel Kullanıcı";
            lblCurrentUser.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnColors
            // 
            btnColors.Location = new Point(324, 55);
            btnColors.Name = "btnColors";
            btnColors.Size = new Size(140, 42);
            btnColors.TabIndex = 2;
            btnColors.Text = "Renkler";
            btnColors.UseVisualStyleBackColor = true;
            btnColors.Click += btnColors_Click;
            // 
            // btnBrands
            // 
            btnBrands.Location = new Point(172, 55);
            btnBrands.Name = "btnBrands";
            btnBrands.Size = new Size(140, 42);
            btnBrands.TabIndex = 1;
            btnBrands.Text = "Markalar";
            btnBrands.UseVisualStyleBackColor = true;
            btnBrands.Click += btnBrands_Click;
            // 
            // btnCategories
            // 
            btnCategories.Location = new Point(20, 55);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(140, 42);
            btnCategories.TabIndex = 0;
            btnCategories.Text = "Kategoriler";
            btnCategories.UseVisualStyleBackColor = true;
            btnCategories.Click += btnCategories_Click;
            // 
            // btnSizes
            // 
            btnSizes.Location = new Point(476, 55);
            btnSizes.Name = "btnSizes";
            btnSizes.Size = new Size(140, 42);
            btnSizes.TabIndex = 3;
            btnSizes.Text = "Bedenler";
            btnSizes.UseVisualStyleBackColor = true;
            btnSizes.Click += btnSizes_Click;
            // 
            // btnStock
            // 
            btnStock.Location = new Point(172, 112);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(140, 42);
            btnStock.TabIndex = 5;
            btnStock.Text = "Stok";
            btnStock.UseVisualStyleBackColor = true;
            btnStock.Click += btnStock_Click;
            // 
            // btnCustomers
            // 
            btnCustomers.Location = new Point(20, 50);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(180, 42);
            btnCustomers.TabIndex = 6;
            btnCustomers.Text = "Müşteriler";
            btnCustomers.UseVisualStyleBackColor = true;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // btnUsers
            // 
            btnUsers.Location = new Point(20, 50);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(180, 42);
            btnUsers.TabIndex = 9;
            btnUsers.Text = "Kullanıcılar";
            btnUsers.UseVisualStyleBackColor = true;
            btnUsers.Click += btnUsers_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 600);
            Controls.Add(pnlManagement);
            Controls.Add(pnlSalesManagement);
            Controls.Add(pnlProductManagement);
            Controls.Add(pnlHeader);
            MinimumSize = new Size(900, 600);
            Name = "MainForm";
            Text = "Mağaza Otomasyonu";
            pnlManagement.ResumeLayout(false);
            pnlManagement.PerformLayout();
            pnlSalesManagement.ResumeLayout(false);
            pnlSalesManagement.PerformLayout();
            pnlProductManagement.ResumeLayout(false);
            pnlProductManagement.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
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
        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private Panel pnlProductManagement;
        private Label lblProductManagement;
        private Panel pnlSalesManagement;
        private Label lblSalesManagement;
        private Panel pnlManagement;
        private Label lblManagement;
    }
}
