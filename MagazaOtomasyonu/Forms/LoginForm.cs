using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using MagazaOtomasyonu.DataAccess;
using MagazaOtomasyonu.Helpers;
using Microsoft.Data.SqlClient;

namespace MagazaOtomasyonu.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private bool VerifyPassword(string password, string storedPassword)
        {
            string[] parts = storedPassword.Split(':');
            if (parts.Length != 2)
            {
                return false;
            }
            byte[] salt = Convert.FromBase64String(parts[0]);
            byte[] storedHash = Convert.FromBase64String(parts[1]);
            byte[] enteredHash = Rfc2898DeriveBytes.Pbkdf2(password, salt, 100000, HashAlgorithmName.SHA256, 32);
            return CryptographicOperations.FixedTimeEquals(storedHash, enteredHash);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Kullanıcı adı boş bırakılamaz.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Şifre boş bırakılamaz.");
                return;
            }
            using SqlConnection connection = DatabaseConnection.GetConnection();
            string query = @"select u.UserId,u.Username,u.PasswordHash,u.FirstName,u.LastName,u.IsActive,r.RoleName from Users u inner join Roles r on u.RoleId=r.RoleId where u.Username=@Username";
            using SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
            try
            {
                connection.Open();
                using SqlDataReader reader = command.ExecuteReader();
                if (!reader.Read())
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
                    return;
                }
                bool isActive = Convert.ToBoolean(reader["IsActive"]);
                if (!isActive)
                {
                    MessageBox.Show("Bu kullanıcı hesabı pasif durumda.");
                    return;
                }
                string? passwordHash = reader["PasswordHash"]?.ToString();
                if (string.IsNullOrEmpty(passwordHash) || !VerifyPassword(txtPassword.Text, passwordHash))
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
                    return;
                }
                UserSession.UserId = Convert.ToInt32(reader["UserId"]);
                UserSession.Username = Convert.ToString(reader["Username"]) ?? string.Empty;
                UserSession.FirstName = Convert.ToString(reader["FirstName"]) ?? string.Empty;
                UserSession.LastName = Convert.ToString(reader["LastName"]) ?? string.Empty;
                UserSession.RoleName = Convert.ToString(reader["RoleName"]) ?? string.Empty;
                MessageBox.Show("Giriş başarılı.");
                MainForm mainForm = new MainForm();
                Hide();
                mainForm.ShowDialog();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Giriş sırasında hata oluştu:\n" + ex.Message);
            }
        }
    }
}
