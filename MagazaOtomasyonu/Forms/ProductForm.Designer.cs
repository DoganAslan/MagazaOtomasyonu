namespace MagazaOtomasyonu.Forms
{
    partial class ProductForm
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
            pnlProductInfo = new Panel();
            pnlProductList = new Panel();
            lblPageTitle = new Label();
            lblPageDescription = new Label();
            lblProductInfo = new Label();
            lblProductList = new Label();
            label1 = new Label();
            txtProductName = new TextBox();
            cmbCategory = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cmbBrand = new ComboBox();
            txtDescription = new TextBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            dgvProducts = new DataGridView();
            txtPrice = new TextBox();
            chkIsActive = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            pnlProductInfo.SuspendLayout();
            pnlProductList.SuspendLayout();
            SuspendLayout();
            // 
            // pnlProductInfo
            // 
            pnlProductInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom;
            pnlProductInfo.Controls.Add(btnDelete);
            pnlProductInfo.Controls.Add(btnUpdate);
            pnlProductInfo.Controls.Add(btnAdd);
            pnlProductInfo.Controls.Add(chkIsActive);
            pnlProductInfo.Controls.Add(label6);
            pnlProductInfo.Controls.Add(txtDescription);
            pnlProductInfo.Controls.Add(label5);
            pnlProductInfo.Controls.Add(txtPrice);
            pnlProductInfo.Controls.Add(label4);
            pnlProductInfo.Controls.Add(cmbBrand);
            pnlProductInfo.Controls.Add(label3);
            pnlProductInfo.Controls.Add(cmbCategory);
            pnlProductInfo.Controls.Add(label2);
            pnlProductInfo.Controls.Add(txtProductName);
            pnlProductInfo.Controls.Add(label1);
            pnlProductInfo.Controls.Add(lblProductInfo);
            pnlProductInfo.Location = new Point(24, 104);
            pnlProductInfo.Name = "pnlProductInfo";
            pnlProductInfo.Size = new Size(310, 540);
            pnlProductInfo.TabIndex = 0;
            pnlProductInfo.TabStop = false;
            // 
            // lblProductInfo
            // 
            lblProductInfo.AutoSize = true;
            lblProductInfo.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            lblProductInfo.Location = new Point(20, 17);
            lblProductInfo.Name = "lblProductInfo";
            lblProductInfo.Size = new Size(145, 30);
            lblProductInfo.TabIndex = 20;
            lblProductInfo.Text = "Ürün Bilgileri";
            // 
            // pnlProductList
            // 
            pnlProductList.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            pnlProductList.Controls.Add(dgvProducts);
            pnlProductList.Controls.Add(lblProductList);
            pnlProductList.Location = new Point(356, 104);
            pnlProductList.Name = "pnlProductList";
            pnlProductList.Size = new Size(770, 540);
            pnlProductList.TabIndex = 1;
            pnlProductList.TabStop = false;
            // 
            // lblProductList
            // 
            lblProductList.AutoSize = true;
            lblProductList.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            lblProductList.Location = new Point(20, 17);
            lblProductList.Name = "lblProductList";
            lblProductList.Size = new Size(125, 30);
            lblProductList.TabIndex = 20;
            lblProductList.Text = "Ürün Listesi";
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblPageTitle.Location = new Point(24, 20);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(180, 37);
            lblPageTitle.TabIndex = 10;
            lblPageTitle.Text = "Ürün Yönetimi";
            // 
            // lblPageDescription
            // 
            lblPageDescription.AutoSize = true;
            lblPageDescription.Font = new Font("Segoe UI", 10F);
            lblPageDescription.Location = new Point(25, 61);
            lblPageDescription.Name = "lblPageDescription";
            lblPageDescription.Size = new Size(313, 23);
            lblPageDescription.TabIndex = 11;
            lblPageDescription.Text = "Ürünleri ekleyin, düzenleyin ve yönetin.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 62);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 10;
            label1.TabStop = false;
            label1.Text = "Ürün Adı:";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(20, 86);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(268, 32);
            txtProductName.TabIndex = 0;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(20, 156);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(268, 32);
            cmbCategory.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 132);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 11;
            label2.TabStop = false;
            label2.Text = "Kategori:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 202);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 12;
            label3.TabStop = false;
            label3.Text = "Marka:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 272);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 13;
            label4.TabStop = false;
            label4.Text = "Fiyat:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 342);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 14;
            label5.TabStop = false;
            label5.Text = "Açıklama:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 416);
            label6.Name = "label6";
            label6.Size = new Size(43, 20);
            label6.TabIndex = 15;
            label6.TabStop = false;
            label6.Text = "Aktif:";
            // 
            // cmbBrand
            // 
            cmbBrand.FormattingEnabled = true;
            cmbBrand.Location = new Point(20, 226);
            cmbBrand.Name = "cmbBrand";
            cmbBrand.Size = new Size(268, 32);
            cmbBrand.TabIndex = 2;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(20, 366);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(268, 32);
            txtDescription.TabIndex = 4;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(220, 470);
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(70, 42);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(110, 470);
            btnUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 42);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(20, 470);
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(80, 42);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            dgvProducts.Location = new Point(20, 60);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.Size = new Size(728, 460);
            dgvProducts.TabIndex = 9;
            dgvProducts.CellClick += dgvProducts_CellClick;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(20, 296);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(268, 32);
            txtPrice.TabIndex = 3;
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Location = new Point(90, 414);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(62, 24);
            chkIsActive.TabIndex = 5;
            chkIsActive.Text = "Aktif";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 680);
            Controls.Add(lblPageDescription);
            Controls.Add(lblPageTitle);
            Controls.Add(pnlProductList);
            Controls.Add(pnlProductInfo);
            MinimumSize = new Size(1000, 620);
            Name = "ProductForm";
            Text = "Ürün Yönetimi";
            pnlProductList.ResumeLayout(false);
            pnlProductList.PerformLayout();
            pnlProductInfo.ResumeLayout(false);
            pnlProductInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtProductName;
        private ComboBox cmbCategory;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cmbBrand;
        private TextBox txtDescription;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private DataGridView dgvProducts;
        private TextBox txtPrice;
        private CheckBox chkIsActive;
        private Panel pnlProductInfo;
        private Panel pnlProductList;
        private Label lblPageTitle;
        private Label lblPageDescription;
        private Label lblProductInfo;
        private Label lblProductList;
    }
}
