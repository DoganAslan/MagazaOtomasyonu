namespace MagazaOtomasyonu.Forms
{
    partial class CustomerForm
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
            dgvCustomers = new DataGridView();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtEmail = new TextBox();
            label4 = new Label();
            txtPhone = new TextBox();
            label3 = new Label();
            txtLastName = new TextBox();
            label2 = new Label();
            txtFirstName = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            SuspendLayout();
            // 
            // dgvCustomers
            // 
            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Location = new Point(12, 239);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.RowHeadersWidth = 51;
            dgvCustomers.Size = new Size(776, 188);
            dgvCustomers.TabIndex = 23;
            dgvCustomers.CellClick += dgvCustomers_CellClick;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(461, 204);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(154, 29);
            btnDelete.TabIndex = 22;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(301, 204);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(154, 29);
            btnUpdate.TabIndex = 21;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(141, 204);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(154, 29);
            btnAdd.TabIndex = 20;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(318, 117);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(189, 27);
            txtEmail.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(232, 120);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 18;
            label4.Text = "E-posta:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(318, 84);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(189, 27);
            txtPhone.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(232, 87);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 16;
            label3.Text = "Telefon:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(318, 51);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(189, 27);
            txtLastName.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(240, 54);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 14;
            label2.Text = "Soyad:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(318, 18);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(189, 27);
            txtFirstName.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(262, 21);
            label1.Name = "label1";
            label1.Size = new Size(31, 20);
            label1.TabIndex = 12;
            label1.Text = "Ad:";
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvCustomers);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(txtPhone);
            Controls.Add(label3);
            Controls.Add(txtLastName);
            Controls.Add(label2);
            Controls.Add(txtFirstName);
            Controls.Add(label1);
            Name = "CustomerForm";
            Text = "Müşteri Yönetimi";
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCustomers;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtPhone;
        private Label label3;
        private TextBox txtLastName;
        private Label label2;
        private TextBox txtFirstName;
        private Label label1;
    }
}
