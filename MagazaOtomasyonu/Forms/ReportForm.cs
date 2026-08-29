using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;
using MagazaOtomasyonu.DataAccess;
using Microsoft.Data.SqlClient;

namespace MagazaOtomasyonu.Forms
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
            LoadSummary();
            LoadReportTypes();
            dgvReport.ReadOnly = true;
            dgvReport.AllowUserToAddRows = false;
            dgvReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void LoadSummary()
        {
            using SqlConnection connection = DatabaseConnection.GetConnection();
            connection.Open();
            string productQuery = "select count(*) from Products where IsActive=1";
            using SqlCommand productCommand = new SqlCommand(productQuery, connection);
            int totalProducts = Convert.ToInt32(productCommand.ExecuteScalar());
            string customerQuery = "select count(*) from Customers";
            using SqlCommand customerCommand = new SqlCommand(customerQuery, connection);
            int totalCustomers = Convert.ToInt32(customerCommand.ExecuteScalar());
            string salesQuery = "select count(*) from Sales where cast(SaleDate as date)=cast(getdate() as date)";
            using SqlCommand salesCommand = new SqlCommand(salesQuery, connection);
            int todaySales = Convert.ToInt32(salesCommand.ExecuteScalar());
            string revenueQuery = "select isnull(sum(TotalAmount),0) from Sales where cast(SaleDate as date)=cast(getdate() as date)";
            using SqlCommand revenueCommand = new SqlCommand(revenueQuery, connection);
            decimal todayRevenue = Convert.ToDecimal(revenueCommand.ExecuteScalar());
            lblTotalProducts.Text = "Toplam Ürün: " + totalProducts;
            lblTotalCustomers.Text = "Toplam Müşteri: " + totalCustomers;
            lblTodaySales.Text = "Bugünkü Satış: " + todaySales;
            lblTodayRevenue.Text = "Bugünkü Ciro: " + todayRevenue.ToString("N2") + " TL";
        }
        private void LoadReportTypes()
        {
            cmbReportType.Items.Clear();
            cmbReportType.Items.Add("Düşük Stoklu Ürünler");
            cmbReportType.Items.Add("En Çok Satan Ürünler");
            cmbReportType.Items.Add("Günlük Satışlar");
            cmbReportType.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbReportType.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen rapor türü seçin.");
                return;
            }
            string selectedReport = cmbReportType.SelectedItem?.ToString() ?? string.Empty;
            if (selectedReport == "Düşük Stoklu Ürünler")
            {
                LoadLowStockReport();
            }
            else if (selectedReport == "En Çok Satan Ürünler")
            {
                LoadBestSellingProducts();
            }
            else if (selectedReport == "Günlük Satışlar")
            {
                LoadDailySales();
            }
        }
        private void LoadLowStockReport()
        {
            using SqlConnection connection = DatabaseConnection.GetConnection();
            string query = @"select p.ProductName as Urun,c.ColorName as Renk,s.SizeName as Beden,pv.StockQuantity as Stok from ProductVariants pv inner join Products p on pv.ProductId=p.ProductId inner join Colors c on pv.ColorId=c.ColorId inner join Sizes s on pv.SizeId=s.SizeId where pv.StockQuantity<=5 order by pv.StockQuantity asc";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvReport.DataSource = table;
        }
        private void LoadBestSellingProducts()
        {
            using SqlConnection connection = DatabaseConnection.GetConnection();
            string query = @"select p.ProductName as Urun,sum(sd.Quantity) as SatilanAdet,sum(sd.Subtotal) as ToplamCiro from SaleDetails sd inner join ProductVariants pv on sd.VariantId=pv.VariantId inner join Products p on pv.ProductId=p.ProductId group by p.ProductId,p.ProductName order by SatilanAdet desc";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvReport.DataSource = table;
            if (dgvReport.Columns["ToplamCiro"] is DataGridViewColumn totalRevenueColumn)
            {
                totalRevenueColumn.DefaultCellStyle.Format = "N2";
            }
        }
        private void LoadDailySales()
        {
            using SqlConnection connection = DatabaseConnection.GetConnection();
            string query = @"select cast(SaleDate as date) as Tarih,count(*) as SatisAdedi,sum(TotalAmount) as ToplamCiro from Sales group by cast(SaleDate as date) order by Tarih desc";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvReport.DataSource = table;
            if (dgvReport.Columns["ToplamCiro"] is DataGridViewColumn totalRevenueColumn)
            {
                totalRevenueColumn.DefaultCellStyle.Format = "N2";
            }
        }
    }
}
