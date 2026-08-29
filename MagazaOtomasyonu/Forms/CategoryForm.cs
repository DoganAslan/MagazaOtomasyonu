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
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
            UiTheme.Apply(this);
            LoadCategories();
        }

        private void LoadCategories()
        {
            using SqlConnection connection = DatabaseConnection.GetConnection();
            string query = "select CategoryId, CategoryName from Categories";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvCategories.DataSource = table;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCategoryName.Text))
            {
                MessageBox.Show("Kategori adı boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using SqlConnection connection = DatabaseConnection.GetConnection();
            string query = "insert into Categories (CategoryName) values (@CategoryName)";
            using SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CategoryName", txtCategoryName.Text.Trim());
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Kategori başarıyla eklendi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCategoryName.Clear();
                selectedCategoryId = 0;
                LoadCategories();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2601 || ex.Number == 2627)
                {
                    MessageBox.Show("Bu kategori zaten mevcut.");
                }
                else
                {
                    MessageBox.Show("Kategori eklenirken hata oluştu:\n" + ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedCategoryId == 0)
            {
                MessageBox.Show("Lütfen güncellenecek kategoriyi seçin.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtCategoryName.Text))
            {
                MessageBox.Show("Kategori adı boş bırakılamaz.");
                return;
            }

            using SqlConnection connection = DatabaseConnection.GetConnection();
            string query = @"update Categories set CategoryName=@CategoryName where CategoryId = @CategoryId ";
            using SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CategoryName", txtCategoryName.Text.Trim());
            command.Parameters.AddWithValue("@CategoryId", selectedCategoryId);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Kategori başarıyla güncellendi.");
                txtCategoryName.Clear();
                selectedCategoryId = 0;
                LoadCategories();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2601 || ex.Number == 2627)
                {
                    MessageBox.Show("Bu kategori zaten mevcut.");
                }
                else
                {
                    MessageBox.Show("Kategori güncellenirken hata oluştu:\n" + ex.Message);
                }

            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedCategoryId == 0)
            {
                MessageBox.Show("Lütfen silinecek kategoryi seçin");
                return;
            }
            DialogResult result = MessageBox.Show("Bu kategoriyi silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
            {
                return;
            }
            using SqlConnection connection = DatabaseConnection.GetConnection();
            string query = "delete from Categories where CategoryId=@CategoryId";
            using SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue(@"CategoryId", selectedCategoryId);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Kategori başarıyla silindi");
                txtCategoryName.Clear();
                selectedCategoryId = 0;
                LoadCategories();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    MessageBox.Show("Bu kategori ürünlerde kullanıldığı için silinemez.");
                }
                else
                {
                    MessageBox.Show("Kategori silinirken hata oluştu:\n" + ex.Message);
                }
            }
        }


        private int selectedCategoryId = 0;
        private void dgvCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCategories.Rows[e.RowIndex];

                selectedCategoryId =
                    Convert.ToInt32(row.Cells["CategoryId"].Value);
                txtCategoryName.Text =
                    Convert.ToString(row.Cells["CategoryName"].Value) ?? string.Empty;
            }
        }

    }
}
