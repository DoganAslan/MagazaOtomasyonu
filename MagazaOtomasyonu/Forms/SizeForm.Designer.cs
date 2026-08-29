namespace MagazaOtomasyonu.Forms
{
    partial class SizeForm
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
            dgvSizes = new DataGridView();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtSizeName = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSizes).BeginInit();
            SuspendLayout();
            // 
            // dgvSizes
            // 
            dgvSizes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSizes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSizes.Location = new Point(12, 262);
            dgvSizes.Name = "dgvSizes";
            dgvSizes.RowHeadersWidth = 51;
            dgvSizes.Size = new Size(420, 219);
            dgvSizes.TabIndex = 23;
            dgvSizes.CellClick += dgvSizes_CellClick;
//            dgvSizes.CellContentClick += dgvSizes_CellContentClick;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(141, 164);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(168, 39);
            btnDelete.TabIndex = 22;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(141, 119);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(168, 39);
            btnUpdate.TabIndex = 21;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(141, 74);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(168, 39);
            btnAdd.TabIndex = 20;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtSizeName
            // 
            txtSizeName.Location = new Point(141, 29);
            txtSizeName.Name = "txtSizeName";
            txtSizeName.Size = new Size(168, 27);
            txtSizeName.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 32);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 18;
            label2.Text = "Beden Adı:";
            // 
            // SizeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(441, 489);
            Controls.Add(dgvSizes);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtSizeName);
            Controls.Add(label2);
            Name = "SizeForm";
            Text = "SizeForm";
            ((System.ComponentModel.ISupportInitialize)dgvSizes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSizes;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private TextBox txtSizeName;
        private Label label2;
    }
}
