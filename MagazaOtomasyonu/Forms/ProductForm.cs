using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using MagazaOtomasyonu.DataAccess;


namespace MagazaOtomasyonu.Forms
{
    public partial class ProductForm : Form
    {
        private int selectedProductId = 0;
        public ProductForm()
        {
            InitializeComponent();
            LoadCategories();
            LoadBrands();
            LoadProducts();
        }
        private void ClearForm()
        {
            txtProductName.Clear();
            txtPrice.Clear();
            txtDescription.Clear();

            cmbCategory.SelectedIndex = -1;
            cmbBrand.SelectedIndex = -1;

            chkIsActive.Checked = true;

            selectedProductId = 0;
        }

        private void LoadCategories()
        {
            using SqlConnection connection = DatabaseConnection.GetConnection();
            string query = "select CategoryId,CategoryName from Categories order by CategoryName";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cmbCategory.DataSource = table;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryId";
        }
        private void LoadBrands()
        {
            using SqlConnection connection = DatabaseConnection.GetConnection();
            string query = "select BrandId,BrandName from Brands order by BrandName";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cmbBrand.DataSource = table;
            cmbBrand.DisplayMember = "BrandName";
            cmbBrand.ValueMember = "BrandId";
        }
        private void LoadProducts()
        {
            using SqlConnection connection = DatabaseConnection.GetConnection();
            string query = @"select
                                p.ProductId,
                                p.ProductName, 
                                p.CategoryId,        
                                c.CategoryName,
                                p.BrandId,
                                b.BrandName,            
                                p.Price,
                                p.Description,
                                p.IsActive
                            from Products p 
                            inner join Categories c on p.CategoryId = c.CategoryId
                            inner join Brands b on p.BrandId = b.BrandId order by p.ProductId";

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvProducts.DataSource = table;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Ürün adı boş bırakılamaz.");
                return;
            }

            if (cmbCategory.SelectedValue == null)
            {
                MessageBox.Show("Lütfen kategori seçin.");
                return;
            }

            if (cmbBrand.SelectedValue == null)
            {
                MessageBox.Show("Lütfen marka seçin.");
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Lütfen geçerli bir fiyat girin.");
                return;
            }

            if (price < 0)
            {
                MessageBox.Show("Fiyat negatif olamaz.");
                return;
            }

            using SqlConnection connection = DatabaseConnection.GetConnection();

            string query = @"
        insert into Products
        (
            ProductName,
            CategoryId,
            BrandId,
            Price,
            Description,
            IsActive
        )
        values
        (
            @ProductName,
            @CategoryId,
            @BrandId,
            @Price,
            @Description,
            @IsActive
        )";

            using SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ProductName", txtProductName.Text.Trim());
            command.Parameters.AddWithValue("@CategoryId", cmbCategory.SelectedValue);
            command.Parameters.AddWithValue("@BrandId", cmbBrand.SelectedValue);
            command.Parameters.AddWithValue("@Price", price);
            command.Parameters.AddWithValue("@Description", txtDescription.Text.Trim());
            command.Parameters.AddWithValue("@IsActive", chkIsActive.Checked);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();

                MessageBox.Show("Ürün başarıyla eklendi.");

                ClearForm();
                LoadProducts();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ürün eklenirken hata oluştu:\n" + ex.Message);
            }
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProducts.Rows[e.RowIndex];

                selectedProductId = Convert.ToInt32(row.Cells["ProductId"].Value);

                txtProductName.Text =
                    Convert.ToString(row.Cells["ProductName"].Value) ?? string.Empty;

                cmbCategory.SelectedValue =
                    Convert.ToInt32(row.Cells["CategoryId"].Value);

                cmbBrand.SelectedValue =
                    Convert.ToInt32(row.Cells["BrandId"].Value);

                txtPrice.Text =
                    Convert.ToString(row.Cells["Price"].Value) ?? string.Empty;

                txtDescription.Text =
                    row.Cells["Description"].Value?.ToString();

                chkIsActive.Checked =
                    Convert.ToBoolean(row.Cells["IsActive"].Value);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedProductId == 0)
            {
                MessageBox.Show("Lütfen güncellenecek ürünü seçin.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Ürün adı boş bırakılamaz.");
                return;
            }

            if (cmbCategory.SelectedValue == null)
            {
                MessageBox.Show("Lütfen kategori seçin.");
                return;
            }

            if (cmbBrand.SelectedValue == null)
            {
                MessageBox.Show("Lütfen marka seçin.");
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Lütfen geçerli bir fiyat girin.");
                return;
            }

            if (price < 0)
            {
                MessageBox.Show("Fiyat negatif olamaz.");
                return;
            }

            using SqlConnection connection = DatabaseConnection.GetConnection();

            string query = @"
        update Products
        set
            ProductName = @ProductName,
            CategoryId = @CategoryId,
            BrandId = @BrandId,
            Price = @Price,
            Description = @Description,
            IsActive = @IsActive
        where ProductId = @ProductId";

            using SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ProductName", txtProductName.Text.Trim());
            command.Parameters.AddWithValue("@CategoryId", cmbCategory.SelectedValue);
            command.Parameters.AddWithValue("@BrandId", cmbBrand.SelectedValue);
            command.Parameters.AddWithValue("@Price", price);
            command.Parameters.AddWithValue("@Description", txtDescription.Text.Trim());
            command.Parameters.AddWithValue("@IsActive", chkIsActive.Checked);
            command.Parameters.AddWithValue("@ProductId", selectedProductId);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();

                MessageBox.Show("Ürün başarıyla güncellendi.");

                ClearForm();
                LoadProducts();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Güncelleme sırasında hata oluştu:\n" + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedProductId == 0)
            {
                MessageBox.Show("Lütfen silinecek ürünü seçin.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Ürünü silmek istediğinizden emin misiniz?",
                "Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result != DialogResult.Yes)
            {
                return;
            }

            using SqlConnection connection = DatabaseConnection.GetConnection();

            string query = "delete from Products where ProductId = @ProductId";

            using SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ProductId", selectedProductId);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();

                MessageBox.Show("Ürün başarıyla silindi.");

                ClearForm();
                LoadProducts();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    MessageBox.Show("Bu ürüne ait varyasyon veya stok kaydı bulunduğu için ürün silinemez. Ürünü pasif duruma getirebilirsiniz.");
                }
                else
                {
                    MessageBox.Show("Ürün silinirken hata oluştu:\n" + ex.Message);
                }
            }
        }
    }
}
