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
            label1 = new Label();
            cmbCustomer = new ComboBox();
            cmbPaymentType = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtQuantity = new TextBox();
            lblStock = new Label();
            lblPrice = new Label();
            lblTotal = new Label();
            btnCompleteSale = new Button();
            cmbVariant = new ComboBox();
            dgvCart = new DataGridView();
            btnRemoveFromCart = new Button();
            btnAddToCart = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 35);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 0;
            label1.Text = "Müşteri:";
            // 
            // cmbCustomer
            // 
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new Point(177, 35);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(219, 28);
            cmbCustomer.TabIndex = 1;
            // 
            // cmbPaymentType
            // 
            cmbPaymentType.FormattingEnabled = true;
            cmbPaymentType.Location = new Point(177, 69);
            cmbPaymentType.Name = "cmbPaymentType";
            cmbPaymentType.Size = new Size(219, 28);
            cmbPaymentType.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 69);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 2;
            label2.Text = "Ödeme Türü:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 103);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 4;
            label3.Text = "Ürün:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 134);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 6;
            label4.Text = "Adet:";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(177, 139);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(219, 27);
            txtQuantity.TabIndex = 7;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(62, 175);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(51, 20);
            lblStock.TabIndex = 8;
            lblStock.Text = "Stok: -";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(62, 209);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(53, 20);
            lblPrice.TabIndex = 9;
            lblPrice.Text = "Fiyat: -";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(62, 403);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(112, 20);
            lblTotal.TabIndex = 12;
            lblTotal.Text = "Toplam: 0,00 TL";
            // 
            // btnCompleteSale
            // 
            btnCompleteSale.Location = new Point(199, 426);
            btnCompleteSale.Name = "btnCompleteSale";
            btnCompleteSale.Size = new Size(129, 29);
            btnCompleteSale.TabIndex = 14;
            btnCompleteSale.Text = "Satışı Tamamla";
            btnCompleteSale.UseVisualStyleBackColor = true;
            btnCompleteSale.Click += btnCompleteSale_Click;
            // 
            // cmbVariant
            // 
            cmbVariant.FormattingEnabled = true;
            cmbVariant.Location = new Point(177, 103);
            cmbVariant.Name = "cmbVariant";
            cmbVariant.Size = new Size(219, 28);
            cmbVariant.TabIndex = 15;
            cmbVariant.SelectedIndexChanged += cmbVariant_SelectedIndexChanged_1;
            // 
            // dgvCart
            // 
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.Location = new Point(62, 232);
            dgvCart.Name = "dgvCart";
            dgvCart.RowHeadersWidth = 51;
            dgvCart.Size = new Size(438, 168);
            dgvCart.TabIndex = 16;
            // 
            // btnRemoveFromCart
            // 
            btnRemoveFromCart.Location = new Point(64, 426);
            btnRemoveFromCart.Name = "btnRemoveFromCart";
            btnRemoveFromCart.Size = new Size(129, 29);
            btnRemoveFromCart.TabIndex = 17;
            btnRemoveFromCart.Text = "Sepetten Sil";
            btnRemoveFromCart.UseVisualStyleBackColor = true;
            btnRemoveFromCart.Click += btnRemoveFromCart_Click;
            // 
            // btnAddToCart
            // 
            btnAddToCart.Location = new Point(202, 197);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(126, 29);
            btnAddToCart.TabIndex = 18;
            btnAddToCart.Text = "Sepete Ekle";
            btnAddToCart.UseVisualStyleBackColor = true;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // SalesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(800, 467);
            Controls.Add(btnAddToCart);
            Controls.Add(btnRemoveFromCart);
            Controls.Add(dgvCart);
            Controls.Add(cmbVariant);
            Controls.Add(btnCompleteSale);
            Controls.Add(lblTotal);
            Controls.Add(lblPrice);
            Controls.Add(lblStock);
            Controls.Add(txtQuantity);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cmbPaymentType);
            Controls.Add(label2);
            Controls.Add(cmbCustomer);
            Controls.Add(label1);
            Name = "SalesForm";
            Text = "SalesForm";
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}
