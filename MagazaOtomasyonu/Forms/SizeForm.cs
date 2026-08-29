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
    public partial class SizeForm : Form
    {
        private int selectedSizeId = 0;
        public SizeForm()
        {
            InitializeComponent();
            UiTheme.Apply(this);
            LoadSizes();
        }

        private void LoadSizes()
        {
            using SqlConnection connection = DatabaseConnection.GetConnection();
            string query = "select SizeId,SizeName from Sizes";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvSizes.DataSource = table;
            if (dgvSizes.Columns["SizeId"] is DataGridViewColumn sizeIdColumn)
            {
                sizeIdColumn.Visible = false;
            }
        }




        private void dgvSizes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSizes.Rows[e.RowIndex];
                selectedSizeId = Convert.ToInt32(row.Cells["SizeId"].Value);
                txtSizeName.Text =
                    Convert.ToString(row.Cells["SizeName"].Value) ?? string.Empty;
            }



        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSizeName.Text))
            {
                MessageBox.Show("Beden adı boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using SqlConnection connection = DatabaseConnection.GetConnection();
            string query = "insert into Sizes (SizeName) values (@SizeName)";
            using SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue(@"SizeName", txtSizeName.Text.Trim());
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Beden başarıyla eklendi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSizeName.Clear();
                selectedSizeId = 0;
                LoadSizes();

            }
            catch (SqlException ex)
            {
                if (ex.Number == 2601 || ex.Number == 2627)
                {
                    MessageBox.Show("Bu beden zaten mevcut.");
                }
                else
                {
                    MessageBox.Show("Beden eklenirken hata oluştu:\n" + ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedSizeId == 0)
            {
                MessageBox.Show("Lütfen güncellenecek bedeni seçin");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSizeName.Text))
            {
                MessageBox.Show("Beden adı boş bırakılamaz.");
                return;
            }

            using SqlConnection connection = DatabaseConnection.GetConnection();
            string query = @"update Sizes set SizeName=@SizeName where SizeId=@SizeId";
            using SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue(@"SizeName", txtSizeName.Text.Trim());
            command.Parameters.AddWithValue(@"SizeId", selectedSizeId);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Beden başarıyla güncellendi.");
                txtSizeName.Clear();
                selectedSizeId = 0;
                LoadSizes();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2601 || ex.Number == 2627)
                {
                    MessageBox.Show("Bu beden zaten mevcut.");
                }
                else
                {
                    MessageBox.Show("Beden güncellenirken hata oluştu:\n" + ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedSizeId == 0)
            {
                MessageBox.Show("Lütfen silinecek bedeni seçin");
                return;
            }
            DialogResult result = MessageBox.Show("Bedeni silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
            {
                return;
            }
            using SqlConnection connection = DatabaseConnection.GetConnection();
            string query = "delete from Sizes where SizeId=@SizeId";
            using SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue(@"SizeId", selectedSizeId);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Beden başarıyla silindi.");
                txtSizeName.Clear();
                selectedSizeId = 0;
                LoadSizes();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    MessageBox.Show("Bu beden ürün varyasyonlarında kullanıldığı için silinemez.");
                }
                else
                {
                    MessageBox.Show("Beden silinirken hata oluştu:\n" + ex.Message);
                }
            }
        }

        
    }
}
