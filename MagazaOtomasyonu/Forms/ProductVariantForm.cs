using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using MagazaOtomasyonu.DataAccess;
using MagazaOtomasyonu.Helpers;

namespace MagazaOtomasyonu.Forms
{
    public partial class ProductVariantForm : Form
    {
        private int selectedVariantId = 0;

        public ProductVariantForm()
        {
            InitializeComponent();
            UiTheme.Apply(this);

            LoadProducts();
            LoadColors();
            LoadSizes();
            LoadVariants();

            ClearForm();
        }

        private void LoadProducts()
        {
            using SqlConnection connection = DatabaseConnection.GetConnection();

            string query = @"
                select ProductId, ProductName
                from Products
                where IsActive = 1
                order by ProductName";

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

            DataTable table = new DataTable();

            adapter.Fill(table);

            cmbProduct.DataSource = table;
            cmbProduct.DisplayMember = "ProductName";
            cmbProduct.ValueMember = "ProductId";
        }

        private void LoadColors()
        {
            using SqlConnection connection = DatabaseConnection.GetConnection();

            string query = @"
                select ColorId, ColorName
                from Colors
                order by ColorName";

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

            DataTable table = new DataTable();

            adapter.Fill(table);

            cmbColor.DataSource = table;
            cmbColor.DisplayMember = "ColorName";
            cmbColor.ValueMember = "ColorId";
        }

        private void LoadSizes()
        {
            using SqlConnection connection = DatabaseConnection.GetConnection();

            string query = @"
                select SizeId, SizeName
                from Sizes
                order by SizeName";

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

            DataTable table = new DataTable();

            adapter.Fill(table);

            cmbSize.DataSource = table;
            cmbSize.DisplayMember = "SizeName";
            cmbSize.ValueMember = "SizeId";
        }

        private void LoadVariants()
        {
            using SqlConnection connection = DatabaseConnection.GetConnection();

            string query = @"
                select
                    pv.VariantId,
                    pv.ProductId,
                    p.ProductName,
                    pv.ColorId,
                    c.ColorName,
                    pv.SizeId,
                    s.SizeName,
                    pv.StockQuantity
                from ProductVariants pv
                inner join Products p
                    on pv.ProductId = p.ProductId
                inner join Colors c
                    on pv.ColorId = c.ColorId
                inner join Sizes s
                    on pv.SizeId = s.SizeId
                order by pv.VariantId";

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

            DataTable table = new DataTable();

            adapter.Fill(table);

            dgvVariants.DataSource = table;

            if (dgvVariants.Columns["VariantId"] is DataGridViewColumn variantIdColumn)
                variantIdColumn.Visible = false;

            if (dgvVariants.Columns["ProductId"] is DataGridViewColumn productIdColumn)
                productIdColumn.Visible = false;

            if (dgvVariants.Columns["ColorId"] is DataGridViewColumn colorIdColumn)
                colorIdColumn.Visible = false;

            if (dgvVariants.Columns["SizeId"] is DataGridViewColumn sizeIdColumn)
                sizeIdColumn.Visible = false;
        }

        private void ClearForm()
        {
            cmbProduct.SelectedIndex = -1;
            cmbColor.SelectedIndex = -1;
            cmbSize.SelectedIndex = -1;

            txtStock.Clear();

            selectedVariantId = 0;

            dgvVariants.ClearSelection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbProduct.SelectedValue == null)
            {
                MessageBox.Show("Lütfen ürün seçin.");
                return;
            }

            if (cmbColor.SelectedValue == null)
            {
                MessageBox.Show("Lütfen renk seçin.");
                return;
            }

            if (cmbSize.SelectedValue == null)
            {
                MessageBox.Show("Lütfen beden seçin.");
                return;
            }

            if (!int.TryParse(txtStock.Text, out int stockQuantity))
            {
                MessageBox.Show("Lütfen geçerli bir stok miktarı girin.");
                return;
            }

            if (stockQuantity < 0)
            {
                MessageBox.Show("Stok miktarı negatif olamaz.");
                return;
            }

            using SqlConnection connection = DatabaseConnection.GetConnection();

            string query = @"
                insert into ProductVariants
                (
                    ProductId,
                    ColorId,
                    SizeId,
                    StockQuantity
                )
                values
                (
                    @ProductId,
                    @ColorId,
                    @SizeId,
                    @StockQuantity
                )";

            using SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ProductId", cmbProduct.SelectedValue);
            command.Parameters.AddWithValue("@ColorId", cmbColor.SelectedValue);
            command.Parameters.AddWithValue("@SizeId", cmbSize.SelectedValue);
            command.Parameters.AddWithValue("@StockQuantity", stockQuantity);

            try
            {
                connection.Open();

                command.ExecuteNonQuery();

                MessageBox.Show("Varyasyon başarıyla eklendi.");

                LoadVariants();
                ClearForm();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2601 || ex.Number == 2627)
                {
                    MessageBox.Show(
                        "Bu ürün varyasyonu zaten mevcut.");
                }
                else
                {
                    MessageBox.Show(
                        "Varyasyon eklenirken hata oluştu:\n" + ex.Message);
                }
            }
        }

        private void dgvVariants_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvVariants.Rows[e.RowIndex];

                selectedVariantId =
                    Convert.ToInt32(row.Cells["VariantId"].Value);

                cmbProduct.SelectedValue =
                    Convert.ToInt32(row.Cells["ProductId"].Value);

                cmbColor.SelectedValue =
                    Convert.ToInt32(row.Cells["ColorId"].Value);

                cmbSize.SelectedValue =
                    Convert.ToInt32(row.Cells["SizeId"].Value);

                txtStock.Text =
                    Convert.ToString(row.Cells["StockQuantity"].Value) ?? string.Empty;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedVariantId == 0)
            {
                MessageBox.Show("Lütfen güncellenecek varyasyonu seçin.");
                return;
            }

            if (cmbProduct.SelectedValue == null)
            {
                MessageBox.Show("Lütfen ürün seçin.");
                return;
            }

            if (cmbColor.SelectedValue == null)
            {
                MessageBox.Show("Lütfen renk seçin.");
                return;
            }

            if (cmbSize.SelectedValue == null)
            {
                MessageBox.Show("Lütfen beden seçin.");
                return;
            }

            if (!int.TryParse(txtStock.Text, out int stockQuantity))
            {
                MessageBox.Show("Lütfen geçerli bir stok miktarı girin.");
                return;
            }

            if (stockQuantity < 0)
            {
                MessageBox.Show("Stok miktarı negatif olamaz.");
                return;
            }

            using SqlConnection connection = DatabaseConnection.GetConnection();

            string query = @"
                update ProductVariants
                set
                    ProductId = @ProductId,
                    ColorId = @ColorId,
                    SizeId = @SizeId,
                    StockQuantity = @StockQuantity
                where VariantId = @VariantId";

            using SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue(
                "@ProductId",
                cmbProduct.SelectedValue);

            command.Parameters.AddWithValue(
                "@ColorId",
                cmbColor.SelectedValue);

            command.Parameters.AddWithValue(
                "@SizeId",
                cmbSize.SelectedValue);

            command.Parameters.AddWithValue(
                "@StockQuantity",
                stockQuantity);

            command.Parameters.AddWithValue(
                "@VariantId",
                selectedVariantId);

            try
            {
                connection.Open();

                command.ExecuteNonQuery();

                MessageBox.Show("Varyasyon başarıyla güncellendi.");

                LoadVariants();
                ClearForm();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2601 || ex.Number == 2627)
                {
                    MessageBox.Show(
                        "Bu ürün varyasyonu zaten mevcut.");
                }
                else
                {
                    MessageBox.Show(
                        "Güncelleme sırasında hata oluştu:\n" + ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedVariantId == 0)
            {
                MessageBox.Show("Lütfen silinecek varyasyonu seçin.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bu varyasyonu silmek istediğinizden emin misiniz?",
                "Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
            {
                return;
            }

            using SqlConnection connection = DatabaseConnection.GetConnection();

            string query = @"
                delete from ProductVariants
                where VariantId = @VariantId";

            using SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue(
                "@VariantId",
                selectedVariantId);

            try
            {
                connection.Open();

                command.ExecuteNonQuery();

                MessageBox.Show("Varyasyon başarıyla silindi.");

                LoadVariants();
                ClearForm();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    MessageBox.Show("Bu ürün varyasyonu geçmiş satışlarda kullanıldığı için silinemez.");
                }
                else
                {
                    MessageBox.Show("Varyasyon silinirken hata oluştu:\n" + ex.Message);
                }
            }
        }
    }
}
