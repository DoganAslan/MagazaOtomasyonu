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
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblDescription = new Label();
            pnlEditor = new Panel();
            lblEditorTitle = new Label();
            pnlList = new Panel();
            lblListTitle = new Label();
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
            lblTitle.Size = new Size(238, 37);
            lblTitle.TabIndex = 0;
            lblTitle.TabStop = false;
            lblTitle.Text = "Müşteri Yönetimi";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(22, 51);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(312, 20);
            lblDescription.TabIndex = 1;
            lblDescription.TabStop = false;
            lblDescription.Text = "Müşteri bilgilerini ekleyin ve düzenleyin.";
            // 
            // pnlEditor
            // 
            pnlEditor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom;
            pnlEditor.Controls.Add(btnDelete);
            pnlEditor.Controls.Add(btnUpdate);
            pnlEditor.Controls.Add(btnAdd);
            pnlEditor.Controls.Add(txtEmail);
            pnlEditor.Controls.Add(label4);
            pnlEditor.Controls.Add(txtPhone);
            pnlEditor.Controls.Add(label3);
            pnlEditor.Controls.Add(txtLastName);
            pnlEditor.Controls.Add(label2);
            pnlEditor.Controls.Add(txtFirstName);
            pnlEditor.Controls.Add(label1);
            pnlEditor.Controls.Add(lblEditorTitle);
            pnlEditor.Location = new Point(24, 122);
            pnlEditor.Name = "pnlEditor";
            pnlEditor.Size = new Size(330, 534);
            pnlEditor.TabIndex = 1;
            pnlEditor.TabStop = false;
            lblEditorTitle.AutoSize = true;
            lblEditorTitle.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            lblEditorTitle.Location = new Point(20, 14);
            lblEditorTitle.Name = "lblEditorTitle";
            lblEditorTitle.Size = new Size(168, 30);
            lblEditorTitle.TabIndex = 20;
            lblEditorTitle.TabStop = false;
            lblEditorTitle.Text = "Müşteri Bilgileri";
            // 
            // pnlList
            // 
            pnlList.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            pnlList.Controls.Add(dgvCustomers);
            pnlList.Controls.Add(lblListTitle);
            pnlList.Location = new Point(374, 122);
            pnlList.Name = "pnlList";
            pnlList.Size = new Size(702, 534);
            pnlList.TabIndex = 2;
            pnlList.TabStop = false;
            // 
            // lblListTitle
            // 
            lblListTitle.AutoSize = true;
            lblListTitle.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            lblListTitle.Location = new Point(16, 14);
            lblListTitle.Name = "lblListTitle";
            lblListTitle.Size = new Size(144, 30);
            lblListTitle.TabIndex = 0;
            lblListTitle.TabStop = false;
            lblListTitle.Text = "Müşteri Listesi";
            // 
            // dgvCustomers
            // 
            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            dgvCustomers.Location = new Point(16, 55);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.RowHeadersWidth = 51;
            dgvCustomers.Size = new Size(668, 460);
            dgvCustomers.TabIndex = 7;
            dgvCustomers.CellClick += dgvCustomers_CellClick;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(20, 440);
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(288, 40);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(20, 394);
            btnUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(288, 40);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(20, 348);
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(288, 40);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(20, 290);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(288, 32);
            txtEmail.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 266);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 13;
            label4.TabStop = false;
            label4.Text = "E-posta:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(20, 220);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(288, 32);
            txtPhone.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 196);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 12;
            label3.TabStop = false;
            label3.Text = "Telefon:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(20, 150);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(288, 32);
            txtLastName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 126);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 11;
            label2.TabStop = false;
            label2.Text = "Soyad:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(20, 80);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(288, 32);
            txtFirstName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 56);
            label1.Name = "label1";
            label1.Size = new Size(31, 20);
            label1.TabIndex = 10;
            label1.TabStop = false;
            label1.Text = "Ad:";
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 680);
            Controls.Add(pnlList);
            Controls.Add(pnlEditor);
            Controls.Add(pnlHeader);
            MinimumSize = new Size(960, 600);
            Name = "CustomerForm";
            Text = "Müşteri Yönetimi";
            pnlList.ResumeLayout(false);
            pnlEditor.ResumeLayout(false);
            pnlEditor.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
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
        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblDescription;
        private Panel pnlEditor;
        private Panel pnlList;
        private Label lblListTitle;
        private Label lblEditorTitle;
    }
}
