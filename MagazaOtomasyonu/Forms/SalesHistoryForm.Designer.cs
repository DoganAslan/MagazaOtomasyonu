namespace MagazaOtomasyonu.Forms
{
    partial class SalesHistoryForm
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
            dgvSales = new DataGridView();
            dgvSaleDetails = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSaleDetails).BeginInit();
            SuspendLayout();
            // 
            // dgvSales
            // 
            dgvSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSales.Location = new Point(35, 38);
            dgvSales.Name = "dgvSales";
            dgvSales.RowHeadersWidth = 51;
            dgvSales.Size = new Size(553, 187);
            dgvSales.TabIndex = 0;
            dgvSales.CellClick += dgvSales_CellClick;
            // 
            // dgvSaleDetails
            // 
            dgvSaleDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSaleDetails.Location = new Point(35, 251);
            dgvSaleDetails.Name = "dgvSaleDetails";
            dgvSaleDetails.RowHeadersWidth = 51;
            dgvSaleDetails.Size = new Size(553, 187);
            dgvSaleDetails.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 9);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 2;
            label1.Text = "Satış Geçmişi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 228);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 3;
            label2.Text = "Satış Detayları";
            // 
            // SalesHistoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(621, 458);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvSaleDetails);
            Controls.Add(dgvSales);
            Name = "SalesHistoryForm";
            Text = "SalesHistoryForm";
            ((System.ComponentModel.ISupportInitialize)dgvSales).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSaleDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSales;
        private DataGridView dgvSaleDetails;
        private Label label1;
        private Label label2;
    }
}