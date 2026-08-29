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
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblDescription = new Label();
            pnlEditor = new Panel();
            lblEditorTitle = new Label();
            pnlList = new Panel();
            lblListTitle = new Label();
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
            pnlHeader.SuspendLayout();
            pnlEditor.SuspendLayout();
            pnlList.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlHeader.Controls.Add(lblDescription);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Location = new Point(24, 20);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1052, 82);
            pnlHeader.TabIndex = 0;
            pnlHeader.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblTitle.Location = new Point(20, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(245, 37);
            lblTitle.TabIndex = 0;
            lblTitle.TabStop = false;
            lblTitle.Text = "Kullanıcı Yönetimi";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(22, 51);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(330, 20);
            lblDescription.TabIndex = 1;
            lblDescription.TabStop = false;
            lblDescription.Text = "Sistem kullanıcılarını ve rollerini yönetin.";
            // 
            // pnlEditor
            // 
            pnlEditor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom;
            pnlEditor.Controls.Add(btnDelete);
            pnlEditor.Controls.Add(btnUpdate);
            pnlEditor.Controls.Add(btnAdd);
            pnlEditor.Controls.Add(chkIsActive);
            pnlEditor.Controls.Add(label6);
            pnlEditor.Controls.Add(cmbRole);
            pnlEditor.Controls.Add(label5);
            pnlEditor.Controls.Add(txtLastName);
            pnlEditor.Controls.Add(label4);
            pnlEditor.Controls.Add(txtFirstName);
            pnlEditor.Controls.Add(label3);
            pnlEditor.Controls.Add(txtPassword);
            pnlEditor.Controls.Add(label2);
            pnlEditor.Controls.Add(txtUsername);
            pnlEditor.Controls.Add(label1);
            pnlEditor.Controls.Add(lblEditorTitle);
            pnlEditor.Location = new Point(24, 122);
            pnlEditor.Name = "pnlEditor";
            pnlEditor.Size = new Size(360, 548);
            pnlEditor.TabIndex = 1;
            pnlEditor.TabStop = false;
            lblEditorTitle.AutoSize = true;
            lblEditorTitle.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            lblEditorTitle.Location = new Point(20, 14);
            lblEditorTitle.Name = "lblEditorTitle";
            lblEditorTitle.Size = new Size(175, 30);
            lblEditorTitle.TabIndex = 20;
            lblEditorTitle.TabStop = false;
            lblEditorTitle.Text = "Kullanıcı Bilgileri";
            // 
            // pnlList
            // 
            pnlList.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            pnlList.Controls.Add(dgvUsers);
            pnlList.Controls.Add(lblListTitle);
            pnlList.Location = new Point(404, 122);
            pnlList.Name = "pnlList";
            pnlList.Size = new Size(672, 548);
            pnlList.TabIndex = 2;
            pnlList.TabStop = false;
            // 
            // lblListTitle
            // 
            lblListTitle.AutoSize = true;
            lblListTitle.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            lblListTitle.Location = new Point(16, 14);
            lblListTitle.Name = "lblListTitle";
            lblListTitle.Size = new Size(143, 30);
            lblListTitle.TabIndex = 0;
            lblListTitle.TabStop = false;
            lblListTitle.Text = "Kullanıcı Listesi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 52);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 10;
            label1.TabStop = false;
            label1.Text = "Kullanıcı Adı:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(20, 77);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(320, 32);
            txtUsername.TabIndex = 0;
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Location = new Point(95, 422);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(101, 24);
            chkIsActive.TabIndex = 5;
            chkIsActive.Text = "Aktif";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(20, 357);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(320, 32);
            cmbRole.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(20, 147);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(320, 32);
            txtPassword.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 122);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 11;
            label2.TabStop = false;
            label2.Text = "Şifre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 192);
            label3.Name = "label3";
            label3.Size = new Size(31, 20);
            label3.TabIndex = 12;
            label3.TabStop = false;
            label3.Text = "Ad:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(20, 287);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(320, 32);
            txtLastName.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 262);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 13;
            label4.TabStop = false;
            label4.Text = "Soyad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 332);
            label5.Name = "label5";
            label5.Size = new Size(34, 20);
            label5.TabIndex = 14;
            label5.TabStop = false;
            label5.Text = "Rol:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 422);
            label6.Name = "label6";
            label6.Size = new Size(43, 20);
            label6.TabIndex = 15;
            label6.TabStop = false;
            label6.Text = "Aktif:";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(231, 470);
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(89, 40);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // dgvUsers
            // 
            dgvUsers.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(16, 55);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.Size = new Size(640, 476);
            dgvUsers.TabIndex = 9;
            dgvUsers.CellClick += dgvUsers_CellClick_1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(20, 470);
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(101, 40);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(126, 470);
            btnUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(99, 40);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click_1;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(20, 217);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(320, 32);
            txtFirstName.TabIndex = 2;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 700);
            Controls.Add(pnlList);
            Controls.Add(pnlEditor);
            Controls.Add(pnlHeader);
            MinimumSize = new Size(960, 620);
            Name = "UserForm";
            Text = "Kullanıcı Yönetimi";
            pnlList.ResumeLayout(false);
            pnlEditor.ResumeLayout(false);
            pnlEditor.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
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
        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblDescription;
        private Panel pnlEditor;
        private Panel pnlList;
        private Label lblListTitle;
        private Label lblEditorTitle;
    }
}
