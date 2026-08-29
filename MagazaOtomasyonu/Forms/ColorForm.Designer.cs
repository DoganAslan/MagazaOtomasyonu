namespace MagazaOtomasyonu.Forms
{
    partial class ColorForm
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
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtColorName = new TextBox();
            label2 = new Label();
            dgvColors = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvColors).BeginInit();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(126, 158);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(168, 39);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(126, 113);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(168, 39);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(126, 68);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(168, 39);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtColorName
            // 
            txtColorName.Location = new Point(126, 23);
            txtColorName.Name = "txtColorName";
            txtColorName.Size = new Size(168, 27);
            txtColorName.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 26);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 12;
            label2.Text = "Renk Adı:";
            // 
            // dgvColors
            // 
            dgvColors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvColors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvColors.Location = new Point(12, 258);
            dgvColors.Name = "dgvColors";
            dgvColors.RowHeadersWidth = 51;
            dgvColors.Size = new Size(420, 201);
            dgvColors.TabIndex = 17;
            dgvColors.CellClick += dgvColors_CellClick;
            // 
            // ColorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(444, 472);
            Controls.Add(dgvColors);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtColorName);
            Controls.Add(label2);
            Name = "ColorForm";
            Text = "ColorForm";
            ((System.ComponentModel.ISupportInitialize)dgvColors).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private TextBox txtColorName;
        private Label label2;
        private DataGridView dgvColors;
    }
}
