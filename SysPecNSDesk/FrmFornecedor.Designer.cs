namespace SysPecNSDesk
{
    partial class FrmFornecedor
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
            lblFornecedores = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            lblid = new Label();
            lblRazaoSocial = new Label();
            lblFantasia = new Label();
            lblcnpj = new Label();
            lblContato = new Label();
            lblTelefone = new Label();
            lblEmail = new Label();
            dataGridView1 = new DataGridView();
            clnid = new DataGridViewTextBoxColumn();
            clnRazaoSocial = new DataGridViewTextBoxColumn();
            clnFantasia = new DataGridViewTextBoxColumn();
            clnCnpj = new DataGridViewTextBoxColumn();
            clnContato = new DataGridViewTextBoxColumn();
            clnTelefone = new DataGridViewTextBoxColumn();
            clnEmail = new DataGridViewTextBoxColumn();
            btnAdd = new Button();
            btnEdit = new Button();
            btnConsultar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblFornecedores
            // 
            lblFornecedores.AutoSize = true;
            lblFornecedores.Font = new Font("Geometr706 BlkCn BT", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFornecedores.Location = new Point(44, 26);
            lblFornecedores.Name = "lblFornecedores";
            lblFornecedores.Size = new Size(188, 39);
            lblFornecedores.TabIndex = 0;
            lblFornecedores.Text = "Fornecedores";
            lblFornecedores.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(44, 104);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(65, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(44, 157);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(227, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(286, 157);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(227, 23);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(44, 209);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 23);
            textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(44, 268);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(188, 23);
            textBox5.TabIndex = 5;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(212, 209);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(301, 23);
            textBox6.TabIndex = 6;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(249, 268);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(264, 23);
            textBox7.TabIndex = 7;
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.Location = new Point(44, 86);
            lblid.Name = "lblid";
            lblid.Size = new Size(18, 15);
            lblid.TabIndex = 8;
            lblid.Text = "ID";
            // 
            // lblRazaoSocial
            // 
            lblRazaoSocial.AutoSize = true;
            lblRazaoSocial.Location = new Point(44, 140);
            lblRazaoSocial.Name = "lblRazaoSocial";
            lblRazaoSocial.Size = new Size(72, 15);
            lblRazaoSocial.TabIndex = 9;
            lblRazaoSocial.Text = "Razão Social";
            // 
            // lblFantasia
            // 
            lblFantasia.AutoSize = true;
            lblFantasia.Location = new Point(286, 140);
            lblFantasia.Name = "lblFantasia";
            lblFantasia.Size = new Size(50, 15);
            lblFantasia.TabIndex = 10;
            lblFantasia.Text = "Fantasia";
            // 
            // lblcnpj
            // 
            lblcnpj.AutoSize = true;
            lblcnpj.Location = new Point(44, 192);
            lblcnpj.Name = "lblcnpj";
            lblcnpj.Size = new Size(34, 15);
            lblcnpj.TabIndex = 11;
            lblcnpj.Text = "CNPJ";
            // 
            // lblContato
            // 
            lblContato.AutoSize = true;
            lblContato.Location = new Point(212, 192);
            lblContato.Name = "lblContato";
            lblContato.Size = new Size(50, 15);
            lblContato.TabIndex = 12;
            lblContato.Text = "Contato";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(44, 250);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(51, 15);
            lblTelefone.TabIndex = 13;
            lblTelefone.Text = "Telefone";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(249, 250);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 14;
            lblEmail.Text = "Email";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { clnid, clnRazaoSocial, clnFantasia, clnCnpj, clnContato, clnTelefone, clnEmail });
            dataGridView1.Location = new Point(44, 410);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(683, 150);
            dataGridView1.TabIndex = 15;
            // 
            // clnid
            // 
            clnid.Frozen = true;
            clnid.HeaderText = "ID";
            clnid.Name = "clnid";
            clnid.ReadOnly = true;
            clnid.Width = 50;
            // 
            // clnRazaoSocial
            // 
            clnRazaoSocial.Frozen = true;
            clnRazaoSocial.HeaderText = "Razão Social";
            clnRazaoSocial.Name = "clnRazaoSocial";
            clnRazaoSocial.ReadOnly = true;
            // 
            // clnFantasia
            // 
            clnFantasia.Frozen = true;
            clnFantasia.HeaderText = "Fantasia";
            clnFantasia.Name = "clnFantasia";
            clnFantasia.ReadOnly = true;
            // 
            // clnCnpj
            // 
            clnCnpj.Frozen = true;
            clnCnpj.HeaderText = "CNPJ";
            clnCnpj.Name = "clnCnpj";
            clnCnpj.ReadOnly = true;
            // 
            // clnContato
            // 
            clnContato.Frozen = true;
            clnContato.HeaderText = "Contato";
            clnContato.Name = "clnContato";
            clnContato.ReadOnly = true;
            // 
            // clnTelefone
            // 
            clnTelefone.Frozen = true;
            clnTelefone.HeaderText = "Telefone";
            clnTelefone.Name = "clnTelefone";
            clnTelefone.ReadOnly = true;
            // 
            // clnEmail
            // 
            clnEmail.Frozen = true;
            clnEmail.HeaderText = "Email";
            clnEmail.Name = "clnEmail";
            clnEmail.ReadOnly = true;
            clnEmail.Width = 130;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Image = Properties.Resources.Add;
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(44, 319);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(99, 53);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "Adicionar";
            btnAdd.TextAlign = ContentAlignment.MiddleRight;
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.Image = Properties.Resources.Edit_Alt;
            btnEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btnEdit.Location = new Point(229, 319);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(99, 53);
            btnEdit.TabIndex = 17;
            btnEdit.Text = "Editar";
            btnEdit.TextAlign = ContentAlignment.MiddleRight;
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            btnConsultar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsultar.Image = Properties.Resources.Search;
            btnConsultar.ImageAlign = ContentAlignment.MiddleLeft;
            btnConsultar.Location = new Point(414, 319);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(99, 53);
            btnConsultar.TabIndex = 18;
            btnConsultar.Text = "Consultar";
            btnConsultar.TextAlign = ContentAlignment.MiddleRight;
            btnConsultar.UseVisualStyleBackColor = true;
            // 
            // FrmFornecedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(784, 593);
            Controls.Add(btnConsultar);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Controls.Add(lblEmail);
            Controls.Add(lblTelefone);
            Controls.Add(lblContato);
            Controls.Add(lblcnpj);
            Controls.Add(lblFantasia);
            Controls.Add(lblRazaoSocial);
            Controls.Add(lblid);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblFornecedores);
            Name = "FrmFornecedor";
            Text = "FrmFornecedor";
            Load += FrmFornecedor_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFornecedores;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label lblid;
        private Label lblRazaoSocial;
        private Label lblFantasia;
        private Label lblcnpj;
        private Label lblContato;
        private Label lblTelefone;
        private Label lblEmail;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn clnid;
        private DataGridViewTextBoxColumn clnRazaoSocial;
        private DataGridViewTextBoxColumn clnFantasia;
        private DataGridViewTextBoxColumn clnCnpj;
        private DataGridViewTextBoxColumn clnContato;
        private DataGridViewTextBoxColumn clnTelefone;
        private DataGridViewTextBoxColumn clnEmail;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnConsultar;
    }
}