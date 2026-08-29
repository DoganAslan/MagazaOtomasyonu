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
            lblTotalProducts = new Label();
            cmbReportType = new ComboBox();
            button1 = new Button();
            dgvReport = new DataGridView();
            lblTotalCustomers = new Label();
            lblTodaySales = new Label();
            lblTodayRevenue = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            SuspendLayout();
            // 
            // lblTotalProducts
            // 
            lblTotalProducts.AutoSize = true;
            lblTotalProducts.Location = new Point(32, 38);
            lblTotalProducts.Name = "lblTotalProducts";
            lblTotalProducts.Size = new Size(109, 20);
            lblTotalProducts.TabIndex = 0;
            lblTotalProducts.Text = "Toplam Ürün: 0\n";
            // 
            // cmbReportType
            // 
            cmbReportType.FormattingEnabled = true;
            cmbReportType.Location = new Point(32, 175);
            cmbReportType.Name = "cmbReportType";
            cmbReportType.Size = new Size(229, 28);
            cmbReportType.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(32, 230);
            button1.Name = "button1";
            button1.Size = new Size(156, 29);
            button1.TabIndex = 2;
            button1.Text = "Rapor Göster";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dgvReport
            // 
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReport.Location = new Point(32, 282);
            dgvReport.Name = "dgvReport";
            dgvReport.RowHeadersWidth = 51;
            dgvReport.Size = new Size(497, 134);
            dgvReport.TabIndex = 3;
            // 
            // lblTotalCustomers
            // 
            lblTotalCustomers.AutoSize = true;
            lblTotalCustomers.Location = new Point(32, 73);
            lblTotalCustomers.Name = "lblTotalCustomers";
            lblTotalCustomers.Size = new Size(127, 20);
            lblTotalCustomers.TabIndex = 4;
            lblTotalCustomers.Text = "Toplam Müşteri: 0\n";
            // 
            // lblTodaySales
            // 
            lblTodaySales.AutoSize = true;
            lblTodaySales.Location = new Point(32, 107);
            lblTodaySales.Name = "lblTodaySales";
            lblTodaySales.Size = new Size(116, 20);
            lblTodaySales.TabIndex = 5;
            lblTodaySales.Text = "Bugünkü Satış: 0\n";
            // 
            // lblTodayRevenue
            // 
            lblTodayRevenue.AutoSize = true;
            lblTodayRevenue.Location = new Point(32, 142);
            lblTodayRevenue.Name = "lblTodayRevenue";
            lblTodayRevenue.Size = new Size(150, 20);
            lblTodayRevenue.TabIndex = 6;
            lblTodayRevenue.Text = "Bugünkü Ciro: 0,00 TL";
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTodayRevenue);
            Controls.Add(lblTodaySales);
            Controls.Add(lblTotalCustomers);
            Controls.Add(dgvReport);
            Controls.Add(button1);
            Controls.Add(cmbReportType);
            Controls.Add(lblTotalProducts);
            Name = "ReportForm";
            Text = "ReportForm";
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
    }
}
