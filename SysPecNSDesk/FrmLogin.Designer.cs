namespace SysPecNSDesk
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            lblLogin = new Label();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            btnEntrar = new Button();
            btnCancelar = new Button();
            label2 = new Label();
            lblEmail = new Label();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Yu Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.Location = new Point(51, 24);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(200, 27);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "SYSPEÇAS LOGIN";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(29, 98);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(243, 23);
            txtEmail.TabIndex = 1;
            txtEmail.Text = "paulo@gmail.com";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(29, 152);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(243, 23);
            txtSenha.TabIndex = 2;
            txtSenha.Text = "123456";
            txtSenha.UseSystemPasswordChar = true;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(29, 202);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(117, 23);
            btnEntrar.TabIndex = 3;
            btnEntrar.Text = "&Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(155, 202);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(117, 23);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 134);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 5;
            label2.Text = "Senha";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(29, 80);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email";
            // 
            // FrmLogin
            // 
            AcceptButton = btnEntrar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            CancelButton = btnCancelar;
            ClientSize = new Size(302, 260);
            ControlBox = false;
            Controls.Add(lblEmail);
            Controls.Add(label2);
            Controls.Add(btnCancelar);
            Controls.Add(btnEntrar);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(lblLogin);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogin;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private Button btnEntrar;
        private Button btnCancelar;
        private Label label2;
        private Label lblEmail;
    }
}