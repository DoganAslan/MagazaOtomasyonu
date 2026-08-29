namespace MagazaOtomasyonu.Forms
{
    partial class BrandForm
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
            dgvBrands = new DataGridView();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtBrandName = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBrands).BeginInit();
            SuspendLayout();
            // 
            // dgvBrands
            // 
            dgvBrands.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBrands.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBrands.Location = new Point(12, 188);
            dgvBrands.Name = "dgvBrands";
            dgvBrands.RowHeadersWidth = 51;
            dgvBrands.Size = new Size(422, 290);
            dgvBrands.TabIndex = 11;
            dgvBrands.CellClick += dgvBrands_CellClick;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(139, 143);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(168, 39);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(139, 98);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(168, 39);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(139, 53);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(168, 39);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtBrandName
            // 
            txtBrandName.Location = new Point(139, 8);
            txtBrandName.Name = "txtBrandName";
            txtBrandName.Size = new Size(168, 27);
            txtBrandName.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 11);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 6;
            label2.Text = "Marka Adı:";
            // 
            // BrandForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(443, 487);
            Controls.Add(dgvBrands);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtBrandName);
            Controls.Add(label2);
            Name = "BrandForm";
            Text = "BrandForm";
            ((System.ComponentModel.ISupportInitialize)dgvBrands).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBrands;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private TextBox txtBrandName;
        private Label label2;
    }
}