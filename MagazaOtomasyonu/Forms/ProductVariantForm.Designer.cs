namespace MagazaOtomasyonu.Forms
{
    partial class ProductVariantForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblProduct = new Label();
            lblColor = new Label();
            lblSize = new Label();
            lblStock = new Label();
            cmbProduct = new ComboBox();
            cmbColor = new ComboBox();
            cmbSize = new ComboBox();
            txtStock = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dgvVariants = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvVariants).BeginInit();
            SuspendLayout();
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Location = new Point(37, 31);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(43, 20);
            lblProduct.TabIndex = 0;
            lblProduct.Text = "Ürün:";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new Point(37, 74);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(44, 20);
            lblColor.TabIndex = 2;
            lblColor.Text = "Renk:";
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Location = new Point(37, 115);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(54, 20);
            lblSize.TabIndex = 4;
            lblSize.Text = "Beden:";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(40, 159);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(41, 20);
            lblStock.TabIndex = 6;
            lblStock.Text = "Stok:";
            // 
            // cmbProduct
            // 
            cmbProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Location = new Point(128, 27);
            cmbProduct.Margin = new Padding(3, 4, 3, 4);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(208, 28);
            cmbProduct.TabIndex = 1;
            // 
            // cmbColor
            // 
            cmbColor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbColor.FormattingEnabled = true;
            cmbColor.Location = new Point(128, 70);
            cmbColor.Margin = new Padding(3, 4, 3, 4);
            cmbColor.Name = "cmbColor";
            cmbColor.Size = new Size(208, 28);
            cmbColor.TabIndex = 3;
            // 
            // cmbSize
            // 
            cmbSize.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSize.FormattingEnabled = true;
            cmbSize.Location = new Point(128, 111);
            cmbSize.Margin = new Padding(3, 4, 3, 4);
            cmbSize.Name = "cmbSize";
            cmbSize.Size = new Size(208, 28);
            cmbSize.TabIndex = 5;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(131, 155);
            txtStock.Margin = new Padding(3, 4, 3, 4);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(208, 27);
            txtStock.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(29, 204);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(162, 38);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(197, 204);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(162, 38);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(365, 204);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(172, 38);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvVariants
            // 
            dgvVariants.AllowUserToAddRows = false;
            dgvVariants.AllowUserToDeleteRows = false;
            dgvVariants.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVariants.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVariants.Location = new Point(9, 255);
            dgvVariants.Margin = new Padding(3, 4, 3, 4);
            dgvVariants.MultiSelect = false;
            dgvVariants.Name = "dgvVariants";
            dgvVariants.ReadOnly = true;
            dgvVariants.RowHeadersWidth = 51;
            dgvVariants.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVariants.Size = new Size(564, 242);
            dgvVariants.TabIndex = 11;
            dgvVariants.CellClick += dgvVariants_CellClick;
            // 
            // ProductVariantForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(585, 510);
            Controls.Add(dgvVariants);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtStock);
            Controls.Add(cmbSize);
            Controls.Add(cmbColor);
            Controls.Add(cmbProduct);
            Controls.Add(lblStock);
            Controls.Add(lblSize);
            Controls.Add(lblColor);
            Controls.Add(lblProduct);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ProductVariantForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ürün Varyasyon / Stok Yönetimi";
            ((System.ComponentModel.ISupportInitialize)dgvVariants).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProduct;
        private Label lblColor;
        private Label lblSize;
        private Label lblStock;

        private ComboBox cmbProduct;
        private ComboBox cmbColor;
        private ComboBox cmbSize;

        private TextBox txtStock;

        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;

        private DataGridView dgvVariants;
    }
}
