using System;
using System.Data;
using System.Security.Cryptography;
using System.Windows.Forms;
using MagazaOtomasyonu.DataAccess;
using MagazaOtomasyonu.Helpers;
using Microsoft.Data.SqlClient;
namespace MagazaOtomasyonu.Forms
{
    public partial class UserForm : Form
    {
        private int selectedUserId = 0;
        public UserForm()
        {
            InitializeComponent();
            UiTheme.Apply(this);
            LoadRoles();
            LoadUsers();
            ClearForm();
        }
        private void LoadRoles()
        {
            using SqlConnection connection = DatabaseConnection.GetConnection();
            string query = "select RoleId, RoleName from Roles order by RoleName";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cmbRole.DataSource = table;
            cmbRole.DisplayMember = "RoleName";
            cmbRole.ValueMember = "RoleId";
        }
        private void LoadUsers()
        {
            using SqlConnection connection = DatabaseConnection.GetConnection();
            string query = @"select u.UserId,u.Username,u.FirstName,u.LastName,u.RoleId,r.RoleName,u.IsActive from Users u inner join Roles r on u.RoleId=r.RoleId order by u.UserId";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvUsers.DataSource = table;
            if (dgvUsers.Columns["UserId"] is DataGridViewColumn userIdColumn)
            {
                userIdColumn.Visible = false;
            }
            if (dgvUsers.Columns["RoleId"] is DataGridViewColumn roleIdColumn)
            {
                roleIdColumn.Visible = false;
            }
            dgvUsers.ClearSelection();
        }
        private string HashPassword(string password)
        {
            byte[] salt = RandomNumberGenerator.GetBytes(16);
            byte[] hash = Rfc2898DeriveBytes.Pbkdf2(password, salt, 100000, HashAlgorithmName.SHA256, 32);
            return Convert.ToBase64String(salt) + ":" + Convert.ToBase64String(hash);
        }
        private void ClearForm()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            cmbRole.SelectedIndex = -1;
            chkIsActive.Checked = true;
            selectedUserId = 0;
            dgvUsers.ClearSelection();
        }
        private void btnAdd_Click(object sender, EventArgs e)
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
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("Ad boş bırakılamaz.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Soyad boş bırakılamaz.");
                return;
            }
            if (cmbRole.SelectedValue == null)
            {
                MessageBox.Show("Lütfen rol seçin.");
                return;
            }
            string passwordHash = HashPassword(txtPassword.Text);
            using SqlConnection connection = DatabaseConnection.GetConnection();
            string query = @"insert into Users (Username,PasswordHash,FirstName,LastName,RoleId,IsActive) values (@Username,@PasswordHash,@FirstName,@LastName,@RoleId,@IsActive)";
            using SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
            command.Parameters.AddWithValue("@PasswordHash", passwordHash);
            command.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
            command.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
            command.Parameters.AddWithValue("@RoleId", cmbRole.SelectedValue);
            command.Parameters.AddWithValue("@IsActive", chkIsActive.Checked);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Kullanıcı başarıyla eklendi.");
                LoadUsers();
                ClearForm();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2601 || ex.Number == 2627)
                {
                    MessageBox.Show("Bu kullanıcı adı zaten kullanılıyor.");
                }
                else
                {
                    MessageBox.Show("Kullanıcı eklenirken hata oluştu:\n" + ex.Message);
                }
            }
        }
        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUsers.Rows[e.RowIndex];
                selectedUserId = Convert.ToInt32(row.Cells["UserId"].Value);
                txtUsername.Text = row.Cells["Username"].Value?.ToString();
                txtFirstName.Text = row.Cells["FirstName"].Value?.ToString();
                txtLastName.Text = row.Cells["LastName"].Value?.ToString();
                cmbRole.SelectedValue = Convert.ToInt32(row.Cells["RoleId"].Value);
                chkIsActive.Checked = Convert.ToBoolean(row.Cells["IsActive"].Value);
                txtPassword.Clear();
            }
        }
        private void dgvUsers_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            dgvUsers_CellClick(sender, e);
        }
        
        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (selectedUserId == 0)
            {
                MessageBox.Show("Lütfen güncellenecek kullanıcıyı seçin.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Kullanıcı adı boş bırakılamaz.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("Ad boş bırakılamaz.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Soyad boş bırakılamaz.");
                return;
            }
            if (cmbRole.SelectedValue == null)
            {
                MessageBox.Show("Lütfen rol seçin.");
                return;
            }
            bool passwordChanged = !string.IsNullOrWhiteSpace(txtPassword.Text);
            using SqlConnection connection = DatabaseConnection.GetConnection();
            string query;
            if (passwordChanged)
            {
                query = @"update Users set Username=@Username,PasswordHash=@PasswordHash,FirstName=@FirstName,LastName=@LastName,RoleId=@RoleId,IsActive=@IsActive where UserId=@UserId";
            }
            else
            {
                query = @"update Users set Username=@Username,FirstName=@FirstName,LastName=@LastName,RoleId=@RoleId,IsActive=@IsActive where UserId=@UserId";
            }
            using SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
            command.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
            command.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
            command.Parameters.AddWithValue("@RoleId", cmbRole.SelectedValue);
            command.Parameters.AddWithValue("@IsActive", chkIsActive.Checked);
            command.Parameters.AddWithValue("@UserId", selectedUserId);
            if (passwordChanged)
            {
                command.Parameters.AddWithValue("@PasswordHash", HashPassword(txtPassword.Text));
            }
            try
            {
                connection.Open();
                int affectedRows = command.ExecuteNonQuery();
                if (affectedRows > 0)
                {
                    MessageBox.Show("Kullanıcı başarıyla güncellendi.");
                    LoadUsers();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Güncellenecek kullanıcı bulunamadı.");
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2601 || ex.Number == 2627)
                {
                    MessageBox.Show("Bu kullanıcı adı zaten kullanılıyor.");
                }
                else
                {
                    MessageBox.Show("Güncelleme sırasında hata oluştu:\n" + ex.Message);
                }
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (selectedUserId == 0)
            {
                MessageBox.Show("Lütfen silinecek kullanıcıyı seçin.");
                return;
            }
            if (selectedUserId == UserSession.UserId)
            {
                MessageBox.Show("Şu anda giriş yaptığınız kullanıcıyı silemezsiniz.");
                return;
            }
            DialogResult result = MessageBox.Show("Kullanıcıyı silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
            {
                return;
            }
            using SqlConnection connection = DatabaseConnection.GetConnection();
            string query = "delete from Users where UserId=@UserId";
            using SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserId", selectedUserId);
            try
            {
                connection.Open();
                int affectedRows = command.ExecuteNonQuery();
                if (affectedRows > 0)
                {
                    MessageBox.Show("Kullanıcı başarıyla silindi.");
                    LoadUsers();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Silinecek kullanıcı bulunamadı.");
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    MessageBox.Show("Bu kullanıcıya ait satış kayıtları bulunduğu için kullanıcı silinemez. Kullanıcıyı pasif duruma getirebilirsiniz.");
                }
                else
                {
                    MessageBox.Show("Kullanıcı silinirken hata oluştu:\n" + ex.Message);
                }
            }
        }
    }
}
