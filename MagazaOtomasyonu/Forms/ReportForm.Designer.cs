namespace MagazaOtomasyonu.Forms
{
    partial class ReportForm
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
            pnlSummaryProducts = new Panel();
            pnlSummaryCustomers = new Panel();
            pnlSummarySales = new Panel();
            pnlSummaryRevenue = new Panel();
            pnlReport = new Panel();
            lblReportType = new Label();
            lblTotalProducts = new Label();
            cmbReportType = new ComboBox();
            button1 = new Button();
            dgvReport = new DataGridView();
            lblTotalCustomers = new Label();
            lblTodaySales = new Label();
            lblTodayRevenue = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            pnlHeader.SuspendLayout();
            pnlSummaryProducts.SuspendLayout();
            pnlSummaryCustomers.SuspendLayout();
            pnlSummarySales.SuspendLayout();
            pnlSummaryRevenue.SuspendLayout();
            pnlReport.SuspendLayout();
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
            lblTitle.Size = new Size(108, 37);
            lblTitle.TabIndex = 0;
            lblTitle.TabStop = false;
            lblTitle.Text = "Raporlar";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(22, 51);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(383, 20);
            lblDescription.TabIndex = 1;
            lblDescription.TabStop = false;
            lblDescription.Text = "Mağaza performansını ve stok durumunu inceleyin.";
            // 
            // pnlSummaryProducts
            // 
            pnlSummaryProducts.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            pnlSummaryProducts.Controls.Add(lblTotalProducts);
            pnlSummaryProducts.Location = new Point(24, 122);
            pnlSummaryProducts.Name = "pnlSummaryProducts";
            pnlSummaryProducts.Size = new Size(244, 92);
            pnlSummaryProducts.TabIndex = 1;
            pnlSummaryProducts.TabStop = false;
            // 
            // pnlSummaryCustomers
            // 
            pnlSummaryCustomers.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            pnlSummaryCustomers.Controls.Add(lblTotalCustomers);
            pnlSummaryCustomers.Location = new Point(288, 122);
            pnlSummaryCustomers.Name = "pnlSummaryCustomers";
            pnlSummaryCustomers.Size = new Size(244, 92);
            pnlSummaryCustomers.TabIndex = 2;
            pnlSummaryCustomers.TabStop = false;
            // 
            // pnlSummarySales
            // 
            pnlSummarySales.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            pnlSummarySales.Controls.Add(lblTodaySales);
            pnlSummarySales.Location = new Point(552, 122);
            pnlSummarySales.Name = "pnlSummarySales";
            pnlSummarySales.Size = new Size(244, 92);
            pnlSummarySales.TabIndex = 3;
            pnlSummarySales.TabStop = false;
            // 
            // pnlSummaryRevenue
            // 
            pnlSummaryRevenue.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            pnlSummaryRevenue.Controls.Add(lblTodayRevenue);
            pnlSummaryRevenue.Location = new Point(816, 122);
            pnlSummaryRevenue.Name = "pnlSummaryRevenue";
            pnlSummaryRevenue.Size = new Size(260, 92);
            pnlSummaryRevenue.TabIndex = 4;
            pnlSummaryRevenue.TabStop = false;
            // 
            // pnlReport
            // 
            pnlReport.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            pnlReport.Controls.Add(dgvReport);
            pnlReport.Controls.Add(button1);
            pnlReport.Controls.Add(cmbReportType);
            pnlReport.Controls.Add(lblReportType);
            pnlReport.Location = new Point(24, 234);
            pnlReport.Name = "pnlReport";
            pnlReport.Size = new Size(1052, 422);
            pnlReport.TabIndex = 5;
            pnlReport.TabStop = false;
            // 
            // lblReportType
            // 
            lblReportType.AutoSize = true;
            lblReportType.Location = new Point(20, 18);
            lblReportType.Name = "lblReportType";
            lblReportType.Size = new Size(82, 20);
            lblReportType.TabIndex = 10;
            lblReportType.TabStop = false;
            lblReportType.Text = "Rapor Türü:";
            // 
            // lblTotalProducts
            // 
            lblTotalProducts.AutoSize = false;
            lblTotalProducts.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblTotalProducts.Location = new Point(16, 25);
            lblTotalProducts.Name = "lblTotalProducts";
            lblTotalProducts.Size = new Size(212, 42);
            lblTotalProducts.TabIndex = 0;
            lblTotalProducts.TabStop = false;
            lblTotalProducts.TextAlign = ContentAlignment.MiddleLeft;
            lblTotalProducts.Text = "Toplam Ürün: 0\n";
            // 
            // cmbReportType
            // 
            cmbReportType.FormattingEnabled = true;
            cmbReportType.Location = new Point(20, 43);
            cmbReportType.Name = "cmbReportType";
            cmbReportType.Size = new Size(300, 32);
            cmbReportType.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(332, 43);
            button1.Name = "button1";
            button1.Size = new Size(160, 40);
            button1.TabIndex = 1;
            button1.Text = "Rapor Göster";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dgvReport
            // 
            dgvReport.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReport.Location = new Point(20, 100);
            dgvReport.Name = "dgvReport";
            dgvReport.RowHeadersWidth = 51;
            dgvReport.Size = new Size(1012, 302);
            dgvReport.TabIndex = 2;
            // 
            // lblTotalCustomers
            // 
            lblTotalCustomers.AutoSize = false;
            lblTotalCustomers.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblTotalCustomers.Location = new Point(16, 25);
            lblTotalCustomers.Name = "lblTotalCustomers";
            lblTotalCustomers.Size = new Size(212, 42);
            lblTotalCustomers.TabIndex = 0;
            lblTotalCustomers.TabStop = false;
            lblTotalCustomers.TextAlign = ContentAlignment.MiddleLeft;
            lblTotalCustomers.Text = "Toplam Müşteri: 0\n";
            // 
            // lblTodaySales
            // 
            lblTodaySales.AutoSize = false;
            lblTodaySales.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblTodaySales.Location = new Point(16, 25);
            lblTodaySales.Name = "lblTodaySales";
            lblTodaySales.Size = new Size(212, 42);
            lblTodaySales.TabIndex = 0;
            lblTodaySales.TabStop = false;
            lblTodaySales.TextAlign = ContentAlignment.MiddleLeft;
            lblTodaySales.Text = "Bugünkü Satış: 0\n";
            // 
            // lblTodayRevenue
            // 
            lblTodayRevenue.AutoSize = false;
            lblTodayRevenue.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblTodayRevenue.Location = new Point(16, 25);
            lblTodayRevenue.Name = "lblTodayRevenue";
            lblTodayRevenue.Size = new Size(228, 42);
            lblTodayRevenue.TabIndex = 0;
            lblTodayRevenue.TabStop = false;
            lblTodayRevenue.TextAlign = ContentAlignment.MiddleLeft;
            lblTodayRevenue.Text = "Bugünkü Ciro: 0,00 TL";
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 700);
            Controls.Add(pnlReport);
            Controls.Add(pnlSummaryRevenue);
            Controls.Add(pnlSummarySales);
            Controls.Add(pnlSummaryCustomers);
            Controls.Add(pnlSummaryProducts);
            Controls.Add(pnlHeader);
            MinimumSize = new Size(1100, 600);
            Name = "ReportForm";
            Text = "Raporlar";
            pnlReport.ResumeLayout(false);
            pnlReport.PerformLayout();
            pnlSummaryRevenue.ResumeLayout(false);
            pnlSummarySales.ResumeLayout(false);
            pnlSummaryCustomers.ResumeLayout(false);
            pnlSummaryProducts.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTotalProducts;
        private ComboBox cmbReportType;
        private Button button1;
        private DataGridView dgvReport;
        private Label lblTotalCustomers;
        private Label lblTodaySales;
        private Label lblTodayRevenue;
        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblDescription;
        private Panel pnlSummaryProducts;
        private Panel pnlSummaryCustomers;
        private Panel pnlSummarySales;
        private Panel pnlSummaryRevenue;
        private Panel pnlReport;
        private Label lblReportType;
    }
}
