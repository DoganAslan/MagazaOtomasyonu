namespace MagazaOtomasyonu.Forms
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources are being disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtUsername = new TextBox();
            chkIsActive = new CheckBox();
            cmbRole = new ComboBox();
            txtPassword = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtLastName = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnDelete = new Button();
            dgvUsers = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            txtFirstName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 22);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(125, 19);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(151, 27);
            txtUsername.TabIndex = 1;
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Location = new Point(125, 185);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(101, 24);
            chkIsActive.TabIndex = 2;
            chkIsActive.Text = "checkBox1";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(125, 151);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(151, 28);
            cmbRole.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(125, 52);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(151, 27);
            txtPassword.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 52);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 4;
            label2.Text = "Şifre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 85);
            label3.Name = "label3";
            label3.Size = new Size(31, 20);
            label3.TabIndex = 6;
            label3.Text = "Ad:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(125, 118);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(151, 27);
            txtLastName.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(66, 118);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 8;
            label4.Text = "Soyad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(85, 154);
            label5.Name = "label5";
            label5.Size = new Size(34, 20);
            label5.TabIndex = 10;
            label5.Text = "Rol:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(76, 186);
            label6.Name = "label6";
            label6.Size = new Size(43, 20);
            label6.TabIndex = 12;
            label6.Text = "Aktif:";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(279, 234);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(102, 32);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // dgvUsers
            // 
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(12, 272);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.Size = new Size(868, 166);
            dgvUsers.TabIndex = 16;
            dgvUsers.CellClick += dgvUsers_CellClick_1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(76, 234);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(102, 32);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(184, 234);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(89, 32);
            btnUpdate.TabIndex = 18;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click_1;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(125, 85);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(151, 27);
            txtFirstName.TabIndex = 19;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(892, 450);
            Controls.Add(txtFirstName);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dgvUsers);
            Controls.Add(btnDelete);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtLastName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(cmbRole);
            Controls.Add(chkIsActive);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Name = "UserForm";
            Text = "UserForm";
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUsername;
        private CheckBox chkIsActive;
        private ComboBox cmbRole;
        private TextBox txtPassword;
        private Label label2;
        private Label label3;
        private TextBox txtLastName;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnDelete;
        private DataGridView dgvUsers;
        private Button btnAdd;
        private Button btnUpdate;
        private TextBox txtFirstName;
    }
}
