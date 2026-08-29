namespace MagazaOtomasyonu.Forms
{
    partial class SalesForm
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
            lblDescription = new Label();
            lblTitle = new Label();
            pnlEditor = new Panel();
            btnAddToCart = new Button();
            lblPrice = new Label();
            lblStock = new Label();
            txtQuantity = new TextBox();
            label4 = new Label();
            cmbVariant = new ComboBox();
            label3 = new Label();
            cmbPaymentType = new ComboBox();
            label2 = new Label();
            cmbCustomer = new ComboBox();
            label1 = new Label();
            lblSaleInfo = new Label();
            pnlCart = new Panel();
            btnCompleteSale = new Button();
            lblTotal = new Label();
            btnRemoveFromCart = new Button();
            dgvCart = new DataGridView();
            lblCartTitle = new Label();
            pnlHeader.SuspendLayout();
            pnlEditor.SuspendLayout();
            pnlCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlHeader.Controls.Add(lblDescription);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Location = new Point(24, 20);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1132, 82);
            pnlHeader.TabIndex = 0;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(22, 51);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(322, 20);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "Müşteri seçin, ürün ekleyin ve satışı tamamlayın.";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblTitle.Location = new Point(20, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(233, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Satış İşlemleri";
            // 
            // pnlEditor
            // 
            pnlEditor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlEditor.Controls.Add(btnAddToCart);
            pnlEditor.Controls.Add(lblPrice);
            pnlEditor.Controls.Add(lblStock);
            pnlEditor.Controls.Add(txtQuantity);
            pnlEditor.Controls.Add(label4);
            pnlEditor.Controls.Add(cmbVariant);
            pnlEditor.Controls.Add(label3);
            pnlEditor.Controls.Add(cmbPaymentType);
            pnlEditor.Controls.Add(label2);
            pnlEditor.Controls.Add(cmbCustomer);
            pnlEditor.Controls.Add(label1);
            pnlEditor.Controls.Add(lblSaleInfo);
            pnlEditor.Location = new Point(24, 122);
            pnlEditor.Name = "pnlEditor";
            pnlEditor.Size = new Size(360, 534);
            pnlEditor.TabIndex = 1;
            // 
            // btnAddToCart
            // 
            btnAddToCart.Location = new Point(20, 385);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(320, 44);
            btnAddToCart.TabIndex = 4;
            btnAddToCart.Text = "Sepete Ekle";
            btnAddToCart.UseVisualStyleBackColor = true;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblPrice.Location = new Point(180, 335);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(63, 23);
            lblPrice.TabIndex = 16;
            lblPrice.Text = "Fiyat: -";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblStock.Location = new Point(20, 335);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(61, 23);
            lblStock.TabIndex = 15;
            lblStock.Text = "Stok: -";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(20, 290);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(320, 27);
            txtQuantity.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 265);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 14;
            label4.Text = "Adet:";
            // 
            // cmbVariant
            // 
            cmbVariant.FormattingEnabled = true;
            cmbVariant.Location = new Point(20, 220);
            cmbVariant.Name = "cmbVariant";
            cmbVariant.Size = new Size(320, 28);
            cmbVariant.TabIndex = 2;
            cmbVariant.SelectedIndexChanged += cmbVariant_SelectedIndexChanged_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 195);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 13;
            label3.Text = "Ürün:";
            // 
            // cmbPaymentType
            // 
            cmbPaymentType.FormattingEnabled = true;
            cmbPaymentType.Location = new Point(20, 150);
            cmbPaymentType.Name = "cmbPaymentType";
            cmbPaymentType.Size = new Size(320, 28);
            cmbPaymentType.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 125);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 12;
            label2.Text = "Ödeme Türü:";
            // 
            // cmbCustomer
            // 
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new Point(20, 80);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(320, 28);
            cmbCustomer.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 55);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 11;
            label1.Text = "Müşteri:";
            // 
            // lblSaleInfo
            // 
            lblSaleInfo.AutoSize = true;
            lblSaleInfo.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            lblSaleInfo.Location = new Point(16, 14);
            lblSaleInfo.Name = "lblSaleInfo";
            lblSaleInfo.Size = new Size(141, 30);
            lblSaleInfo.TabIndex = 10;
            lblSaleInfo.Text = "Satış Bilgileri";
            // 
            // pnlCart
            // 
            pnlCart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlCart.Controls.Add(btnCompleteSale);
            pnlCart.Controls.Add(lblTotal);
            pnlCart.Controls.Add(btnRemoveFromCart);
            pnlCart.Controls.Add(dgvCart);
            pnlCart.Controls.Add(lblCartTitle);
            pnlCart.Location = new Point(404, 122);
            pnlCart.Name = "pnlCart";
            pnlCart.Size = new Size(752, 534);
            pnlCart.TabIndex = 2;
            // 
            // btnCompleteSale
            // 
            btnCompleteSale.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCompleteSale.Location = new Point(568, 443);
            btnCompleteSale.Name = "btnCompleteSale";
            btnCompleteSale.Size = new Size(160, 44);
            btnCompleteSale.TabIndex = 7;
            btnCompleteSale.Text = "Satışı Tamamla";
            btnCompleteSale.UseVisualStyleBackColor = true;
            btnCompleteSale.Click += btnCompleteSale_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblTotal.Location = new Point(343, 450);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(207, 37);
            lblTotal.TabIndex = 11;
            lblTotal.Text = "Toplam: 0,00 TL";
            // 
            // btnRemoveFromCart
            // 
            btnRemoveFromCart.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnRemoveFromCart.Location = new Point(16, 443);
            btnRemoveFromCart.Name = "btnRemoveFromCart";
            btnRemoveFromCart.Size = new Size(160, 44);
            btnRemoveFromCart.TabIndex = 6;
            btnRemoveFromCart.Text = "Sepetten Sil";
            btnRemoveFromCart.UseVisualStyleBackColor = true;
            btnRemoveFromCart.Click += btnRemoveFromCart_Click;
            // 
            // dgvCart
            // 
            dgvCart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.Location = new Point(16, 55);
            dgvCart.Name = "dgvCart";
            dgvCart.RowHeadersWidth = 51;
            dgvCart.Size = new Size(720, 370);
            dgvCart.TabIndex = 5;
            // 
            // lblCartTitle
            // 
            lblCartTitle.AutoSize = true;
            lblCartTitle.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            lblCartTitle.Location = new Point(16, 14);
            lblCartTitle.Name = "lblCartTitle";
            lblCartTitle.Size = new Size(70, 30);
            lblCartTitle.TabIndex = 10;
            lblCartTitle.Text = "Sepet";
            // 
            // SalesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1180, 700);
            Controls.Add(pnlCart);
            Controls.Add(pnlEditor);
            Controls.Add(pnlHeader);
            MinimumSize = new Size(1000, 620);
            Name = "SalesForm";
            Text = "Satış İşlemleri";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlEditor.ResumeLayout(false);
            pnlEditor.PerformLayout();
            pnlCart.ResumeLayout(false);
            pnlCart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private ComboBox cmbCustomer;
        private ComboBox cmbPaymentType;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtQuantity;
        private Label lblStock;
        private Label lblPrice;
        private Label lblTotal;
        private Button btnCompleteSale;
        private ComboBox cmbVariant;
        private DataGridView dgvCart;
        private Button btnRemoveFromCart;
        private Button btnAddToCart;
        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblDescription;
        private Panel pnlEditor;
        private Label lblSaleInfo;
        private Panel pnlCart;
        private Label lblCartTitle;
    }
}
