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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 35);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 0;
            label1.Text = "Ürün Adı:";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(108, 32);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(151, 27);
            txtProductName.TabIndex = 1;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(108, 78);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(151, 28);
            cmbCategory.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 81);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 4;
            label2.Text = "Kategori:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 126);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 5;
            label3.Text = "Marka:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 168);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 6;
            label4.Text = "Fiyat:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 209);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 7;
            label5.Text = "Açıklama:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 251);
            label6.Name = "label6";
            label6.Size = new Size(43, 20);
            label6.TabIndex = 8;
            label6.Text = "Aktif:";
            // 
            // cmbBrand
            // 
            cmbBrand.FormattingEnabled = true;
            cmbBrand.Location = new Point(108, 126);
            cmbBrand.Name = "cmbBrand";
            cmbBrand.Size = new Size(151, 28);
            cmbBrand.TabIndex = 9;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(108, 209);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(151, 27);
            txtDescription.TabIndex = 11;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(845, 300);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(260, 39);
            btnDelete.TabIndex = 25;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(579, 300);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(260, 39);
            btnUpdate.TabIndex = 24;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(313, 300);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(260, 39);
            btnAdd.TabIndex = 23;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(300, 32);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.Size = new Size(821, 252);
            dgvProducts.TabIndex = 26;
            dgvProducts.CellClick += dgvProducts_CellClick;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(108, 168);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(151, 27);
            txtPrice.TabIndex = 27;
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Location = new Point(108, 251);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(62, 24);
            chkIsActive.TabIndex = 28;
            chkIsActive.Text = "Aktif";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(1150, 369);
            Controls.Add(chkIsActive);
            Controls.Add(txtPrice);
            Controls.Add(dgvProducts);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtDescription);
            Controls.Add(cmbBrand);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbCategory);
            Controls.Add(txtProductName);
            Controls.Add(label1);
            Name = "ProductForm";
            Text = "ProductForm";
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
    }
}
