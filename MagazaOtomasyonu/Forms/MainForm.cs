using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MagazaOtomasyonu.Forms;
using MagazaOtomasyonu.Helpers;

namespace MagazaOtomasyonu.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            UiTheme.Apply(this);
            lblSubtitle.ForeColor = UiTheme.TextSecondary;
            lblProductManagement.ForeColor = UiTheme.TextSecondary;
            lblSalesManagement.ForeColor = UiTheme.TextSecondary;
            lblManagement.ForeColor = UiTheme.TextSecondary;
            lblCurrentUser.ForeColor = UiTheme.TextSecondary;
            ShowCurrentUser();
            ApplyPermissions();
        }
        private void ShowCurrentUser()
        {
            lblCurrentUser.Text = UserSession.FirstName + " " + UserSession.LastName + " - " + UserSession.RoleName;
        }
        private void ApplyPermissions()
        {
            bool isAdmin = UserSession.RoleName == "Yönetici";
            btnCategories.Enabled = isAdmin;
            btnBrands.Enabled = isAdmin;
            btnColors.Enabled = isAdmin;
            btnSizes.Enabled = isAdmin;
            btnProducts.Enabled = isAdmin;
            btnUsers.Enabled = isAdmin;
            btnCustomers.Enabled = true;
            btnStock.Enabled = isAdmin;
            btnReports.Enabled = isAdmin;
            btnSales.Enabled = true;
            btnLogout.Enabled = true;
            btnSalesHistory.Enabled = true;
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            CategoryForm form = new CategoryForm();
            form.ShowDialog();
        }

        private void btnBrands_Click(object sender, EventArgs e)
        {
            BrandForm form = new BrandForm();
            form.ShowDialog();
        }

        private void btnColors_Click(object sender, EventArgs e)
        {
            ColorForm form = new ColorForm();
            form.ShowDialog();
        }

        private void btnSizes_Click(object sender, EventArgs e)
        {
            SizeForm form = new SizeForm();
            form.ShowDialog();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ProductForm form = new ProductForm();
            form.ShowDialog();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            ProductVariantForm form = new ProductVariantForm();
            form.ShowDialog();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            SalesForm form = new SalesForm();
            form.ShowDialog();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            CustomerForm form = new CustomerForm();
            form.ShowDialog();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            UserForm form = new UserForm();
            form.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnSalesHistory_Click(object sender, EventArgs e)
        {


            SalesHistoryForm form = new SalesHistoryForm();
            form.ShowDialog();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportForm form = new ReportForm();
            form.ShowDialog();
        }
    }
}

