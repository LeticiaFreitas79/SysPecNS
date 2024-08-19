namespace SysPecNSDesk
{
    partial class Operacoes
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnConfirma = new Button();
            txtNumero1 = new TextBox();
            lstResultado = new ListBox();
            cmbOperacao = new ComboBox();
            txtNumero2 = new TextBox();
            Operação = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // BtnConfirma
            // 
            BtnConfirma.Enabled = false;
            BtnConfirma.Location = new Point(48, 76);
            BtnConfirma.Name = "BtnConfirma";
            BtnConfirma.Size = new Size(333, 23);
            BtnConfirma.TabIndex = 0;
            BtnConfirma.Text = "&Confirma";
            BtnConfirma.UseVisualStyleBackColor = true;
            BtnConfirma.Click += btnConfirma_Click;
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(175, 47);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(100, 23);
            txtNumero1.TabIndex = 1;
            txtNumero1.TextChanged += txtNumero1_TextChanged;
            // 
            // lstResultado
            // 
            lstResultado.FormattingEnabled = true;
            lstResultado.ItemHeight = 15;
            lstResultado.Location = new Point(48, 105);
            lstResultado.Name = "lstResultado";
            lstResultado.Size = new Size(333, 274);
            lstResultado.TabIndex = 2;
            lstResultado.SelectedIndexChanged += lstResultado_SelectedIndexChanged;
            // 
            // cmbOperacao
            // 
            cmbOperacao.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOperacao.FormattingEnabled = true;
            cmbOperacao.Items.AddRange(new object[] { "Multiplicação", "Divisão", "Adição", "Subtração", "Exponenciação", "Radiciação", "Logaritmo" });
            cmbOperacao.Location = new Point(48, 47);
            cmbOperacao.Name = "cmbOperacao";
            cmbOperacao.Size = new Size(121, 23);
            cmbOperacao.TabIndex = 3;
            cmbOperacao.SelectedIndexChanged += cmbOperacao_SelectedIndexChanged;
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(281, 47);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(100, 23);
            txtNumero2.TabIndex = 4;
            txtNumero2.TextChanged += textBox1_TextChanged;
            // 
            // Operação
            // 
            Operação.AutoSize = true;
            Operação.Location = new Point(48, 28);
            Operação.Name = "Operação";
            Operação.Size = new Size(58, 15);
            Operação.TabIndex = 5;
            Operação.Text = "Operação";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(175, 28);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 6;
            label1.Text = "1° Número";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(282, 24);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 7;
            label2.Text = "2° Número";
            label2.Click += label2_Click;
            // 
            // Operacoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 419);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Operação);
            Controls.Add(txtNumero2);
            Controls.Add(cmbOperacao);
            Controls.Add(lstResultado);
            Controls.Add(txtNumero1);
            Controls.Add(BtnConfirma);
            Name = "Operacoes";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnConfirma;
        private TextBox txtNumero1;
        private ListBox lstResultado;
        private ComboBox cmbOperacao;
        private TextBox txtNumero2;
        private Label Operação;
        private Label label1;
        private Label label2;
    }
}
