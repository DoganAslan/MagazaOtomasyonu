using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.AccessControl;
using System.Text;
using System.Windows.Forms;
using MagazaOtomasyonu.DataAccess;
using MagazaOtomasyonu.Helpers;
using Microsoft.Data.SqlClient;

namespace MagazaOtomasyonu.Forms
{
    public partial class CustomerForm : Form
    {
        private int selectedCustomerId = 0;
        public CustomerForm()
        {
            InitializeComponent();
            UiTheme.Apply(this);
            LoadCustomers();
        }
        private void LoadCustomers()
        {
            using SqlConnection connection = DatabaseConnection.GetConnection();

            string query = @"select CustomerId,FirstName,LastName,Phone,Email,CreatedDate from customers order by CustomerId";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvCustomers.DataSource = table;

        }
        private void ClearForm()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            selectedCustomerId = 0;
            dgvCustomers.ClearSelection();
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCustomers.Rows[e.RowIndex];
                selectedCustomerId = Convert.ToInt32(row.Cells["CustomerId"].Value);
                txtFirstName.Text = row.Cells["FirstName"].Value?.ToString();
                txtLastName.Text = row.Cells["LastName"].Value?.ToString();
                txtPhone.Text = row.Cells["Phone"].Value?.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("Ad boş bırakılamaz.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Soyad boş Bırakılamaz.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Telefon numarası boş bırakılamaz.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("E-posta boş bırakılamaz.");
                return;
            }
            using SqlConnection connection = DatabaseConnection.GetConnection();
            string query = @"insert into Customers (FirstName,LastName,Phone,Email) values 
                (@FirstName,@LastName,@Phone,@Email)";
            using SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
            command.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
            command.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim());
            command.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Müşteri başarıyla eklendi.");
                ClearForm();
                LoadCustomers();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Müşteri eklenirken hata oluştu:\n" + ex.Message);
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedCustomerId == 0)
            {
                MessageBox.Show("Lütfen silinecek müşteriyi seçin.");
                return;
            }
            DialogResult result = MessageBox.Show(
                "Müşteriyi silmek istediğinizden emin misiniz?",
                "Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );

            if (result != DialogResult.Yes)
            {
                return;
            }

            using SqlConnection connection = DatabaseConnection.GetConnection();

            string query = "delete from Customers where CustomerId=@CustomerId";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CustomerId", selectedCustomerId);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Müşteri başarıyla silindi");
                ClearForm();
                LoadCustomers();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Silme sırasında hata oluştu:\n" + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(selectedCustomerId == 0)
            {
                MessageBox.Show("Lütfen güncellenecek müşteriyi seçin.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("Müşteri adı boş bırakılamaz.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Müşteri soyadı boş bırakılamaz.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Müşteri telefon numarası boş bırakılamaz.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Müşteri Email boş bırakılamaz.");
                return;
            }
            using SqlConnection connection = DatabaseConnection.GetConnection();
            string query = @"update Customers set FirstName=@FirstName,
            LastName=@LastName,Phone=@Phone,Email=@Email where CustomerId=@CustomerId";
            using SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
            command.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
            command.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim());
            command.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
            command.Parameters.AddWithValue("@CustomerId", selectedCustomerId);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Müşteri başarıyla güncellendi.");
                ClearForm();
                LoadCustomers();
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Güncelleme sırasında hata oluştu:\n" + ex.Message);
            }
        }
    }
}
