using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MagazaOtomasyonu.DataAccess;
using Microsoft.Data.SqlClient;
using MagazaOtomasyonu.Helpers;

namespace MagazaOtomasyonu.Forms
{
    public partial class SalesForm : Form
    {
        private DataTable cartTable = new DataTable();
        public SalesForm()
        {
            InitializeComponent();
            InitializeCart();
            LoadCustomers();
            LoadPaymentTypes();
            LoadVariants();
            cmbCustomer.SelectedIndex = -1;
            cmbPaymentType.SelectedIndex = -1;
            cmbVariant.SelectedIndex = -1;
            lblStock.Text = "Stok: -";
            lblPrice.Text = "Fiyat: -";
            lblTotal.Text = "Toplam: 0,00 TL";
        }
        private void LoadCustomers()
        {
            using SqlConnection connection = DatabaseConnection.GetConnection();
            string query = @"select CustomerId,FirstName+' '+LastName as CustomerName from Customers order by FirstName,LastName";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cmbCustomer.DataSource = table;
            cmbCustomer.DisplayMember = "CustomerName";
            cmbCustomer.ValueMember = "CustomerId";
        }
        private void LoadPaymentTypes()
        {
            using SqlConnection connection = DatabaseConnection.GetConnection();
            string query = "select PaymentTypeId,PaymentTypeName from PaymentTypes order by PaymentTypeName";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cmbPaymentType.DataSource = table;
            cmbPaymentType.DisplayMember = "PaymentTypeName";
            cmbPaymentType.ValueMember = "PaymentTypeId";
        }
        private void LoadVariants()
        {
            using SqlConnection connection = DatabaseConnection.GetConnection();
            string query = @"select pv.VariantId,p.ProductName+' - '+c.ColorName+' - '+s.SizeName as VariantName,p.Price,pv.StockQuantity from ProductVariants pv inner join Products p on pv.ProductId=p.ProductId inner join Colors c on pv.ColorId=c.ColorId inner join Sizes s on pv.SizeId=s.SizeId where p.IsActive=1 and pv.StockQuantity>0 order by p.ProductName,c.ColorName,s.SizeName";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cmbVariant.DataSource = table;
            cmbVariant.DisplayMember = "VariantName";
            cmbVariant.ValueMember = "VariantId";
        }

        private void InitializeCart()
        {
            cartTable.Columns.Add("VariantId", typeof(int));
            cartTable.Columns.Add("Ürün", typeof(string));
            cartTable.Columns.Add("Adet", typeof(int));
            cartTable.Columns.Add("BirimFiyat", typeof(decimal));
            cartTable.Columns.Add("Toplam", typeof(decimal));
            dgvCart.DataSource = cartTable;
            if (dgvCart.Columns["VariantId"] is DataGridViewColumn variantIdColumn)
            {
                variantIdColumn.Visible = false;
            }
            dgvCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCart.MultiSelect = false;
            dgvCart.ReadOnly = true;
            dgvCart.AllowUserToAddRows = false;
        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            if (dgvCart.CurrentRow == null)
            {
                MessageBox.Show("Lütfen sepetten silinecek ürünü seçin.");
                return;
            }
            int variantId = Convert.ToInt32(dgvCart.CurrentRow.Cells["VariantId"].Value);
            DataRow[] rows = cartTable.Select("VariantId = " + variantId);
            if (rows.Length > 0)
            {
                cartTable.Rows.Remove(rows[0]);
            }
            UpdateTotal();
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (cmbVariant.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen ürün seçin.");
                return;
            }
            if (!int.TryParse(txtQuantity.Text, out int quantity))
            {
                MessageBox.Show("Lütfen geçerli bir adet girin.");
                return;
            }
            if (quantity <= 0)
            {
                MessageBox.Show("Adet 0'dan büyük olmalıdır.");
                return;
            }
            if (cmbVariant.SelectedItem is not DataRowView row)
            {
                return;
            }
            int variantId = Convert.ToInt32(row["VariantId"]);
            string variantName = Convert.ToString(row["VariantName"]) ?? string.Empty;
            decimal price = Convert.ToDecimal(row["Price"]);
            int stock = Convert.ToInt32(row["StockQuantity"]);
            DataRow[] existingRows = cartTable.Select("VariantId = " + variantId);
            if (existingRows.Length > 0)
            {
                DataRow existingRow = existingRows[0];
                int currentQuantity = Convert.ToInt32(existingRow["Adet"]);
                int newQuantity = currentQuantity + quantity;
                if (newQuantity > stock)
                {
                    MessageBox.Show("Yetersiz stok. Mevcut stok: " + stock);
                    return;
                }
                existingRow["Adet"] = newQuantity;
                existingRow["Toplam"] = newQuantity * price;
            }
            else
            {
                if (quantity > stock)
                {
                    MessageBox.Show("Yetersiz stok. Mevcut stok: " + stock);
                    return;
                }
                cartTable.Rows.Add(variantId, variantName, quantity, price, quantity * price);
            }
            UpdateTotal();
            txtQuantity.Clear();
        }

        private void UpdateTotal()
        {
            decimal total = 0;
            foreach (DataRow row in cartTable.Rows)
            {
                total += Convert.ToDecimal(row["Toplam"]);
            }
            lblTotal.Text = "Toplam: " + total.ToString("N2") + " TL";
        }

        private void btnCompleteSale_Click(object sender, EventArgs e)
        {
            if (cmbCustomer.SelectedValue == null)
            {
                MessageBox.Show("Lütfen müşteri seçin.");
                return;
            }
            if (cmbPaymentType.SelectedValue == null)
            {
                MessageBox.Show("Lütfen ödeme türü seçin.");
                return;
            }
            if (cartTable.Rows.Count == 0)
            {
                MessageBox.Show("Sepet boş.");
                return;
            }
            decimal totalAmount = 0;
            foreach (DataRow row in cartTable.Rows)
            {
                totalAmount += Convert.ToDecimal(row["Toplam"]);
            }
            using SqlConnection connection = DatabaseConnection.GetConnection();
            connection.Open();
            using SqlTransaction transaction = connection.BeginTransaction();
            try
            {
                string saleQuery = @"insert into Sales (CustomerId,UserId,PaymentTypeId,TotalAmount) values (@CustomerId,@UserId,@PaymentTypeId,@TotalAmount); select cast(scope_identity() as INT);";
                using SqlCommand saleCommand = new SqlCommand(saleQuery, connection, transaction);
                saleCommand.Parameters.AddWithValue("@CustomerId", cmbCustomer.SelectedValue);
                saleCommand.Parameters.AddWithValue("@UserId", UserSession.UserId);
                saleCommand.Parameters.AddWithValue("@PaymentTypeId", cmbPaymentType.SelectedValue);
                saleCommand.Parameters.AddWithValue("@TotalAmount", totalAmount);
                int saleId = Convert.ToInt32(saleCommand.ExecuteScalar());
                foreach (DataRow row in cartTable.Rows)
                {
                    int variantId = Convert.ToInt32(row["VariantId"]);
                    int quantity = Convert.ToInt32(row["Adet"]);
                    decimal unitPrice = Convert.ToDecimal(row["BirimFiyat"]);
                    decimal subtotal = Convert.ToDecimal(row["Toplam"]);
                    string stockQuery = @"update ProductVariants set StockQuantity=StockQuantity-@Quantity where VariantId=@VariantId and StockQuantity>=@Quantity";
                    using SqlCommand stockCommand = new SqlCommand(stockQuery, connection, transaction);
                    stockCommand.Parameters.AddWithValue("@Quantity", quantity);
                    stockCommand.Parameters.AddWithValue("@VariantId", variantId);
                    int affectedRows = stockCommand.ExecuteNonQuery();
                    if (affectedRows == 0)
                    {
                        throw new Exception("Ürünlerden birinin stoğu yetersiz.");
                    }
                    string detailQuery = @"insert into SaleDetails (SaleId,VariantId,Quantity,UnitPrice,Subtotal) values (@SaleId,@VariantId,@Quantity,@UnitPrice,@Subtotal)";
                    using SqlCommand detailCommand = new SqlCommand(detailQuery, connection, transaction);
                    detailCommand.Parameters.AddWithValue("@SaleId", saleId);
                    detailCommand.Parameters.AddWithValue("@VariantId", variantId);
                    detailCommand.Parameters.AddWithValue("@Quantity", quantity);
                    detailCommand.Parameters.AddWithValue("@UnitPrice", unitPrice);
                    detailCommand.Parameters.AddWithValue("@Subtotal", subtotal);
                    detailCommand.ExecuteNonQuery();
                }
                transaction.Commit();
                MessageBox.Show("Satış başarıyla tamamlandı.\nSatış No: " + saleId);
                cartTable.Clear();
                UpdateTotal();
                txtQuantity.Clear();
                cmbCustomer.SelectedIndex = -1;
                cmbPaymentType.SelectedIndex = -1;
                cmbVariant.SelectedIndex = -1;
                lblStock.Text = "Stok: -";
                lblPrice.Text = "Fiyat: -";
                LoadVariants();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Satış tamamlanamadı:\n" + ex.Message);
            }
        }

        private void cmbVariant_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbVariant.SelectedIndex == -1)
            {
                lblStock.Text = "Stok: -";
                lblPrice.Text = "Fiyat: -";
                return;
            }

            if (cmbVariant.SelectedItem is DataRowView row)
            {
                int stock = Convert.ToInt32(row["StockQuantity"]);
                decimal price = Convert.ToDecimal(row["Price"]);

                lblStock.Text = "Stok: " + stock;
                lblPrice.Text = "Fiyat: " + price.ToString("N2") + " TL";
            }
        }
    }
}

    

