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
    public partial class BrandForm : Form
    {
       

        public BrandForm()
        {
            InitializeComponent();
            UiTheme.Apply(this);
            LoadBrands();
        }

        private void LoadBrands()
        {
            using SqlConnection connection = DatabaseConnection.GetConnection();
            string query = "select BrandId,BrandName from Brands";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvBrands.DataSource = table;
            if (dgvBrands.Columns["BrandId"] is DataGridViewColumn brandIdColumn)
            {
                brandIdColumn.Visible = false;
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBrandName.Text))
            {
                MessageBox.Show("Marka adı boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using SqlConnection connection = DatabaseConnection.GetConnection();
            string query = "insert into Brands (BrandName) values (@BrandName)";
            using SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue(@"BrandName", txtBrandName.Text.Trim());
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Marka başarıyla eklendi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBrandName.Clear();
                selectedBrandId = 0;
                LoadBrands();

            }
            catch (SqlException ex)
            {
                if (ex.Number == 2601 || ex.Number == 2627)
                {
                    MessageBox.Show("Bu marka zaten mevcut.");
                }
                else
                {
                    MessageBox.Show("Marka eklenirken hata oluştu:\n" + ex.Message);
                }
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedBrandId == 0)
            {
                MessageBox.Show("Lütfen güncellenecek markayı seçin");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtBrandName.Text))
            {
                MessageBox.Show("Marka adı boş bırakılamaz.");
                return;
            }

            using SqlConnection connection = DatabaseConnection.GetConnection();
            string query = @"update Brands set BrandName=@BrandName where BrandId=@BrandId";
            using SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue(@"BrandName", txtBrandName.Text.Trim());
            command.Parameters.AddWithValue(@"BrandId", selectedBrandId);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Marka başarıyla güncellendi.");
                txtBrandName.Clear();
                selectedBrandId = 0;
                LoadBrands();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2601 || ex.Number == 2627)
                {
                    MessageBox.Show("Bu marka zaten mevcut.");
                }
                else
                {
                    MessageBox.Show("Marka güncellenirken hata oluştu:\n" + ex.Message);
                }
            }
        }

        private int selectedBrandId = 0;
        private void dgvBrands_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBrands.Rows[e.RowIndex];
                selectedBrandId = Convert.ToInt32(row.Cells["BrandId"].Value);
                txtBrandName.Text =
                    Convert.ToString(row.Cells["BrandName"].Value) ?? string.Empty;

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(selectedBrandId == 0)
            {
                MessageBox.Show("Lütfen silinecek markayı seçin");
                return;
            }
            DialogResult result = MessageBox.Show("Markayı silmek istediğinizden emin misiniz?","Silme Onayı",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if(result != DialogResult.Yes)
            {
                return;
            }
            using SqlConnection connection = DatabaseConnection.GetConnection();
            string query = "delete from Brands where BrandId=@BrandId";
            using SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue(@"BrandId", selectedBrandId);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Marka başarıyla silindi.");
                txtBrandName.Clear();
                selectedBrandId = 0;
                LoadBrands();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    MessageBox.Show("Bu marka ürünlerde kullanıldığı için silinemez.");
                }
                else
                {
                    MessageBox.Show("Marka silinirken hata oluştu:\n" + ex.Message);
                }
            }
        }
    }
}
