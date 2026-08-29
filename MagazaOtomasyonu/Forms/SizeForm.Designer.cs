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
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblDescription = new Label();
            pnlEditor = new Panel();
            lblEditorTitle = new Label();
            pnlList = new Panel();
            lblListTitle = new Label();
            dgvSizes = new DataGridView();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtSizeName = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSizes).BeginInit();
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
            pnlHeader.Size = new Size(712, 82);
            pnlHeader.TabIndex = 0;
            pnlHeader.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblTitle.Location = new Point(20, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(212, 37);
            lblTitle.TabIndex = 0;
            lblTitle.TabStop = false;
            lblTitle.Text = "Beden Yönetimi";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(22, 51);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(333, 20);
            lblDescription.TabIndex = 1;
            lblDescription.TabStop = false;
            lblDescription.Text = "Ürün bedenlerini ekleyin ve yönetin.";
            // 
            // pnlEditor
            // 
            pnlEditor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom;
            pnlEditor.Controls.Add(btnDelete);
            pnlEditor.Controls.Add(btnUpdate);
            pnlEditor.Controls.Add(btnAdd);
            pnlEditor.Controls.Add(txtSizeName);
            pnlEditor.Controls.Add(label2);
            pnlEditor.Controls.Add(lblEditorTitle);
            pnlEditor.Location = new Point(24, 122);
            pnlEditor.Name = "pnlEditor";
            pnlEditor.Size = new Size(260, 454);
            pnlEditor.TabIndex = 1;
            pnlEditor.TabStop = false;
            lblEditorTitle.AutoSize = true;
            lblEditorTitle.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            lblEditorTitle.Location = new Point(16, 14);
            lblEditorTitle.Name = "lblEditorTitle";
            lblEditorTitle.Size = new Size(160, 30);
            lblEditorTitle.TabIndex = 20;
            lblEditorTitle.TabStop = false;
            lblEditorTitle.Text = "Beden Bilgileri";
            // 
            // pnlList
            // 
            pnlList.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            pnlList.Controls.Add(dgvSizes);
            pnlList.Controls.Add(lblListTitle);
            pnlList.Location = new Point(304, 122);
            pnlList.Name = "pnlList";
            pnlList.Size = new Size(432, 454);
            pnlList.TabIndex = 2;
            pnlList.TabStop = false;
            // 
            // lblListTitle
            // 
            lblListTitle.AutoSize = true;
            lblListTitle.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            lblListTitle.Location = new Point(16, 14);
            lblListTitle.Name = "lblListTitle";
            lblListTitle.Size = new Size(119, 30);
            lblListTitle.TabIndex = 0;
            lblListTitle.TabStop = false;
            lblListTitle.Text = "Beden Listesi";
            // 
            // dgvSizes
            // 
            dgvSizes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            dgvSizes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSizes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSizes.Location = new Point(16, 55);
            dgvSizes.Name = "dgvSizes";
            dgvSizes.RowHeadersWidth = 51;
            dgvSizes.Size = new Size(398, 383);
            dgvSizes.TabIndex = 4;
            dgvSizes.CellClick += dgvSizes_CellClick;
//            dgvSizes.CellContentClick += dgvSizes_CellContentClick;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(16, 217);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(226, 40);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(16, 171);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(226, 40);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(16, 125);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(226, 40);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtSizeName
            // 
            txtSizeName.Location = new Point(16, 81);
            txtSizeName.Name = "txtSizeName";
            txtSizeName.Size = new Size(226, 32);
            txtSizeName.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 56);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 10;
            label2.TabStop = false;
            label2.Text = "Beden Adı:";
            // 
            // SizeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 600);
            Controls.Add(pnlList);
            Controls.Add(pnlEditor);
            Controls.Add(pnlHeader);
            MinimumSize = new Size(700, 520);
            Name = "SizeForm";
            Text = "Beden Yönetimi";
            pnlList.ResumeLayout(false);
            pnlEditor.ResumeLayout(false);
            pnlEditor.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
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
        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblDescription;
        private Panel pnlEditor;
        private Panel pnlList;
        private Label lblListTitle;
        private Label lblEditorTitle;
    }
}
