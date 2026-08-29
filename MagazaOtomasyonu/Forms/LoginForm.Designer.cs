namespace MagazaOtomasyonu.Forms
{
    partial class LoginForm
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
            pnlLoginCard = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            label1 = new Label();
            btnLogin = new Button();
            txtPassword = new TextBox();
            label2 = new Label();
            txtUsername = new TextBox();
            pnlLoginCard.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLoginCard
            // 
            pnlLoginCard.Controls.Add(btnLogin);
            pnlLoginCard.Controls.Add(txtPassword);
            pnlLoginCard.Controls.Add(label2);
            pnlLoginCard.Controls.Add(txtUsername);
            pnlLoginCard.Controls.Add(label1);
            pnlLoginCard.Controls.Add(lblSubtitle);
            pnlLoginCard.Controls.Add(lblTitle);
            pnlLoginCard.Location = new Point(40, 24);
            pnlLoginCard.Name = "pnlLoginCard";
            pnlLoginCard.Size = new Size(420, 350);
            pnlLoginCard.TabIndex = 0;
            pnlLoginCard.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblTitle.Location = new Point(28, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(214, 37);
            lblTitle.TabIndex = 10;
            lblTitle.TabStop = false;
            lblTitle.Text = "Mağaza Otomasyonu";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Location = new Point(30, 65);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(167, 20);
            lblSubtitle.TabIndex = 11;
            lblSubtitle.TabStop = false;
            lblSubtitle.Text = "Hesabınıza giriş yapın";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 112);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 12;
            label1.TabStop = false;
            label1.Text = "Kullanıcı Adı:";
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnLogin.Location = new Point(30, 263);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(360, 42);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Giriş";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.Location = new Point(30, 216);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(360, 32);
            txtPassword.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 181);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 13;
            label2.TabStop = false;
            label2.Text = "Şifre:";
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUsername.Location = new Point(30, 140);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(360, 32);
            txtUsername.TabIndex = 0;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 430);
            Controls.Add(pnlLoginCard);
            AcceptButton = btnLogin;
            MinimumSize = new Size(500, 430);
            Name = "LoginForm";
            Text = "Giriş";
            pnlLoginCard.ResumeLayout(false);
            pnlLoginCard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnLogin;
        private TextBox txtPassword;
        private Label label2;
        private TextBox txtUsername;
        private Panel pnlLoginCard;
        private Label lblTitle;
        private Label lblSubtitle;
    }
}
