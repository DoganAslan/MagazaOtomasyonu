using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MagazaOtomasyonu.DataAccess;
using MagazaOtomasyonu.Helpers;
using Microsoft.Data.SqlClient;


namespace MagazaOtomasyonu.Forms
{
    public partial class SalesHistoryForm : Form
    {
        private int selectedSaleId = 0;
        public SalesHistoryForm()
        {
            InitializeComponent();
            UiTheme.Apply(this);
            LoadSales();
            dgvSaleDetails.DataSource = null;
        }
        private void LoadSales()
        {
            using SqlConnection connection = DatabaseConnection.GetConnection();
            string query = @"select s.SaleId,c.FirstName+' '+c.LastName as CustomerName,u.FirstName+' '+u.LastName as EmployeeName,pt.PaymentTypeName,s.SaleDate,s.TotalAmount from Sales s inner join Customers c on s.CustomerId=c.CustomerId inner join Users u on s.UserId=u.UserId inner join PaymentTypes pt on s.PaymentTypeId=pt.PaymentTypeId order by s.SaleDate desc";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvSales.DataSource = table;
            dgvSales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSales.MultiSelect = false;
            dgvSales.ReadOnly = true;
            dgvSales.AllowUserToAddRows = false;
            if (dgvSales.Columns["SaleId"] is DataGridViewColumn saleIdColumn)
                saleIdColumn.HeaderText = "Satış No";
            if (dgvSales.Columns["CustomerName"] is DataGridViewColumn customerNameColumn)
                customerNameColumn.HeaderText = "Müşteri";
            if (dgvSales.Columns["EmployeeName"] is DataGridViewColumn employeeNameColumn)
                employeeNameColumn.HeaderText = "Personel";
            if (dgvSales.Columns["PaymentTypeName"] is DataGridViewColumn paymentTypeColumn)
                paymentTypeColumn.HeaderText = "Ödeme Türü";
            if (dgvSales.Columns["SaleDate"] is DataGridViewColumn saleDateColumn)
                saleDateColumn.HeaderText = "Tarih";
            if (dgvSales.Columns["TotalAmount"] is DataGridViewColumn totalAmountColumn)
            {
                totalAmountColumn.HeaderText = "Toplam";
                totalAmountColumn.DefaultCellStyle.Format = "N2";
            }
            dgvSales.ClearSelection();
        }
        private void LoadSaleDetails(int saleId)
        {
            using SqlConnection connection = DatabaseConnection.GetConnection();
            string query = @"select p.ProductName,c.ColorName,s.SizeName,sd.Quantity,sd.UnitPrice,sd.Subtotal from SaleDetails sd inner join ProductVariants pv on sd.VariantId=pv.VariantId inner join Products p on pv.ProductId=p.ProductId inner join Colors c on pv.ColorId=c.ColorId inner join Sizes s on pv.SizeId=s.SizeId where sd.SaleId=@SaleId";
            using SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@SaleId", saleId);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvSaleDetails.DataSource = table;
            dgvSaleDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSaleDetails.MultiSelect = false;
            dgvSaleDetails.ReadOnly = true;
            dgvSaleDetails.AllowUserToAddRows = false;
            if (dgvSaleDetails.Columns["ProductName"] is DataGridViewColumn productNameColumn)
                productNameColumn.HeaderText = "Ürün";
            if (dgvSaleDetails.Columns["ColorName"] is DataGridViewColumn colorNameColumn)
                colorNameColumn.HeaderText = "Renk";
            if (dgvSaleDetails.Columns["SizeName"] is DataGridViewColumn sizeNameColumn)
                sizeNameColumn.HeaderText = "Beden";
            if (dgvSaleDetails.Columns["Quantity"] is DataGridViewColumn quantityColumn)
                quantityColumn.HeaderText = "Adet";
            if (dgvSaleDetails.Columns["UnitPrice"] is DataGridViewColumn unitPriceColumn)
            {
                unitPriceColumn.HeaderText = "Birim Fiyat";
                unitPriceColumn.DefaultCellStyle.Format = "N2";
            }
            if (dgvSaleDetails.Columns["Subtotal"] is DataGridViewColumn subtotalColumn)
            {
                subtotalColumn.HeaderText = "Toplam";
                subtotalColumn.DefaultCellStyle.Format = "N2";
            }
        }

        private void dgvSales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSales.Rows[e.RowIndex];
                selectedSaleId = Convert.ToInt32(row.Cells["SaleId"].Value);
                LoadSaleDetails(selectedSaleId);
            }
        }
    }
}
