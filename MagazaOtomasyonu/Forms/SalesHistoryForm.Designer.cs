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
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblDescription = new Label();
            pnlSales = new Panel();
            pnlDetails = new Panel();
            dgvSales = new DataGridView();
            dgvSaleDetails = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSaleDetails).BeginInit();
            pnlHeader.SuspendLayout();
            pnlSales.SuspendLayout();
            pnlDetails.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlHeader.Controls.Add(lblDescription);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Location = new Point(24, 20);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1052, 82);
            pnlHeader.TabIndex = 0;
            pnlHeader.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblTitle.Location = new Point(20, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(176, 37);
            lblTitle.TabIndex = 0;
            lblTitle.TabStop = false;
            lblTitle.Text = "Satış Geçmişi";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(22, 51);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(433, 20);
            lblDescription.TabIndex = 1;
            lblDescription.TabStop = false;
            lblDescription.Text = "Tamamlanan satışları ve ürün detaylarını görüntüleyin.";
            // 
            // pnlSales
            // 
            pnlSales.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlSales.Controls.Add(dgvSales);
            pnlSales.Controls.Add(label1);
            pnlSales.Location = new Point(24, 122);
            pnlSales.Name = "pnlSales";
            pnlSales.Size = new Size(1052, 240);
            pnlSales.TabIndex = 1;
            pnlSales.TabStop = false;
            // 
            // pnlDetails
            // 
            pnlDetails.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            pnlDetails.Controls.Add(dgvSaleDetails);
            pnlDetails.Controls.Add(label2);
            pnlDetails.Location = new Point(24, 382);
            pnlDetails.Name = "pnlDetails";
            pnlDetails.Size = new Size(1052, 274);
            pnlDetails.TabIndex = 2;
            pnlDetails.TabStop = false;
            // 
            // dgvSales
            // 
            dgvSales.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            dgvSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSales.Location = new Point(16, 55);
            dgvSales.Name = "dgvSales";
            dgvSales.RowHeadersWidth = 51;
            dgvSales.Size = new Size(1020, 165);
            dgvSales.TabIndex = 0;
            dgvSales.CellClick += dgvSales_CellClick;
            // 
            // dgvSaleDetails
            // 
            dgvSaleDetails.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            dgvSaleDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSaleDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSaleDetails.Location = new Point(16, 55);
            dgvSaleDetails.Name = "dgvSaleDetails";
            dgvSaleDetails.RowHeadersWidth = 51;
            dgvSaleDetails.Size = new Size(1020, 199);
            dgvSaleDetails.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label1.Location = new Point(16, 14);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 10;
            label1.TabStop = false;
            label1.Text = "Satış Geçmişi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label2.Location = new Point(16, 14);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 10;
            label2.TabStop = false;
            label2.Text = "Satış Detayları";
            // 
            // SalesHistoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 700);
            Controls.Add(pnlDetails);
            Controls.Add(pnlSales);
            Controls.Add(pnlHeader);
            MinimumSize = new Size(900, 600);
            Name = "SalesHistoryForm";
            Text = "Satış Geçmişi";
            pnlDetails.ResumeLayout(false);
            pnlSales.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
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
        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblDescription;
        private Panel pnlSales;
        private Panel pnlDetails;
    }
}
