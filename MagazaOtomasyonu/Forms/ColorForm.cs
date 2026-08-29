using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MagazaOtomasyonu.DataAccess;
using Microsoft.Data.SqlClient;

namespace MagazaOtomasyonu.Forms
{
    public partial class ColorForm : Form
    {
        public ColorForm()
        {
            InitializeComponent();
            LoadColors();
        }
        private int selectedColorId = 0;
        private void LoadColors()
        {
            using SqlConnection connection = DatabaseConnection.GetConnection();
            string query = "select ColorId,ColorName from Colors";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvColors.DataSource = table;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtColorName.Text))
            {
                MessageBox.Show("Renk adı boş bırakılamaz", "uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using SqlConnection connection = DatabaseConnection.GetConnection();
            string query = "insert into Colors (ColorName) values (@ColorName)";
            using SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue(@"ColorName", txtColorName.Text.Trim());
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Renk başarıyla eklendi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtColorName.Clear();
                selectedColorId = 0;
                LoadColors();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2601 || ex.Number == 2627)
                {
                    MessageBox.Show("Bu renk zaten mevcut.");
                }
                else
                {
                    MessageBox.Show("Renk eklenirken hata oluştu:\n" + ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedColorId == 0)
            {
                MessageBox.Show("Lütfen güncellenecek rengi seçin");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtColorName.Text))
            {
                MessageBox.Show("Renk adı boş bırakılamaz.");
                return;
            }
            using SqlConnection connection = DatabaseConnection.GetConnection();
            string query = @"update Colors set ColorName=@ColorName where ColorId=@ColorId";
            using SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue(@"ColorName", txtColorName.Text.Trim());
            command.Parameters.AddWithValue(@"ColorId", selectedColorId);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Renk başarıyla güncellendi");
                txtColorName.Clear();
                selectedColorId = 0;
                LoadColors();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2601 || ex.Number == 2627)
                {
                    MessageBox.Show("Bu renk zaten mevcut.");
                }
                else
                {
                    MessageBox.Show("Renk güncellenirken hata oluştu:\n" + ex.Message);
                }
            }



        }

        private void dgvColors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvColors.Rows[e.RowIndex];
                selectedColorId = Convert.ToInt32(row.Cells["ColorId"].Value);
                txtColorName.Text =
                    Convert.ToString(row.Cells["ColorName"].Value) ?? string.Empty;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(selectedColorId == 0)
            {
                MessageBox.Show("Lütfen silinecek rengi seçin");
                return;
            }
            DialogResult result = MessageBox.Show("Rengi silmek istediğinizden emin misiniz?","Silme Onayı",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if(result != DialogResult.Yes)
            {
                return;
            }
            using SqlConnection connection = DatabaseConnection.GetConnection();
            string query = "delete from Colors where ColorId=@ColorId";
            using SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue(@"ColorId", selectedColorId);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Renk başarıyla silindi");
                txtColorName.Clear();
                selectedColorId = 0;
                LoadColors();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    MessageBox.Show("Bu renk ürün varyasyonlarında kullanıldığı için silinemez.");
                }
                else
                {
                    MessageBox.Show("Renk silinirken hata oluştu:\n" + ex.Message);
                }
            }



        }
    }
}
