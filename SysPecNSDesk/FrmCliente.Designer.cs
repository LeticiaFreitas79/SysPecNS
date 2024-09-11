namespace SysPecNSDesk
{
    partial class FrmCliente
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
            grbCadastroCliente = new GroupBox();
            tabCliente = new TabControl();
            TabPageCliente = new TabPage();
            lblTelefone = new Label();
            lblEmail = new Label();
            lblCpf = new Label();
            lblDataNasc = new Label();
            lblNome = new Label();
            lblId = new Label();
            btnCadastrarEndereco = new Button();
            btnInserir = new Button();
            dtpDataNasc = new DateTimePicker();
            txtId = new TextBox();
            txtNome = new TextBox();
            txtCpf = new TextBox();
            txtTelefone = new TextBox();
            txtEmail = new TextBox();
            TabPageEndereco = new TabPage();
            cmbTipoEndereco = new ComboBox();
            txtUf = new TextBox();
            txtComplemento = new TextBox();
            txtBairro = new TextBox();
            txtCidade = new TextBox();
            txtNumero = new TextBox();
            txtLogradouro = new TextBox();
            txtCep = new TextBox();
            btnFechar = new Button();
            btnAdicionar = new Button();
            btnSalvar = new Button();
            lblBairro = new Label();
            lblTipoEndereco = new Label();
            lblUf = new Label();
            lblCidade = new Label();
            lblComplemento = new Label();
            lblNumero = new Label();
            lblLogradouro = new Label();
            lblCep = new Label();
            grbCadastroCliente.SuspendLayout();
            tabCliente.SuspendLayout();
            TabPageCliente.SuspendLayout();
            TabPageEndereco.SuspendLayout();
            SuspendLayout();
            // 
            // grbCadastroCliente
            // 
            grbCadastroCliente.Controls.Add(tabCliente);
            grbCadastroCliente.Cursor = Cursors.SizeAll;
            grbCadastroCliente.Font = new Font("Geometr212 BkCn BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbCadastroCliente.Location = new Point(27, 28);
            grbCadastroCliente.Name = "grbCadastroCliente";
            grbCadastroCliente.Size = new Size(529, 401);
            grbCadastroCliente.TabIndex = 0;
            grbCadastroCliente.TabStop = false;
            grbCadastroCliente.Text = "Cadastro de Cliente";
            // 
            // tabCliente
            // 
            tabCliente.Controls.Add(TabPageCliente);
            tabCliente.Controls.Add(TabPageEndereco);
            tabCliente.Font = new Font("Geometr212 BkCn BT", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabCliente.Location = new Point(6, 22);
            tabCliente.Name = "tabCliente";
            tabCliente.SelectedIndex = 0;
            tabCliente.Size = new Size(517, 373);
            tabCliente.TabIndex = 0;
            // 
            // TabPageCliente
            // 
            TabPageCliente.BackColor = Color.LightSteelBlue;
            TabPageCliente.Controls.Add(lblTelefone);
            TabPageCliente.Controls.Add(lblEmail);
            TabPageCliente.Controls.Add(lblCpf);
            TabPageCliente.Controls.Add(lblDataNasc);
            TabPageCliente.Controls.Add(lblNome);
            TabPageCliente.Controls.Add(lblId);
            TabPageCliente.Controls.Add(btnCadastrarEndereco);
            TabPageCliente.Controls.Add(btnInserir);
            TabPageCliente.Controls.Add(dtpDataNasc);
            TabPageCliente.Controls.Add(txtId);
            TabPageCliente.Controls.Add(txtNome);
            TabPageCliente.Controls.Add(txtCpf);
            TabPageCliente.Controls.Add(txtTelefone);
            TabPageCliente.Controls.Add(txtEmail);
            TabPageCliente.Location = new Point(4, 25);
            TabPageCliente.Name = "TabPageCliente";
            TabPageCliente.Padding = new Padding(3);
            TabPageCliente.Size = new Size(509, 344);
            TabPageCliente.TabIndex = 0;
            TabPageCliente.Text = "Cliente";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Geometr212 BkCn BT", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTelefone.Location = new Point(366, 177);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(60, 16);
            lblTelefone.TabIndex = 13;
            lblTelefone.Text = "Telefone";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Geometr212 BkCn BT", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(19, 177);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(45, 16);
            lblEmail.TabIndex = 12;
            lblEmail.Text = "Email";
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Font = new Font("Geometr212 BkCn BT", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCpf.Location = new Point(310, 113);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(35, 16);
            lblCpf.TabIndex = 11;
            lblCpf.Text = "CPF";
            // 
            // lblDataNasc
            // 
            lblDataNasc.AutoSize = true;
            lblDataNasc.Font = new Font("Geometr212 BkCn BT", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDataNasc.Location = new Point(19, 113);
            lblDataNasc.Name = "lblDataNasc";
            lblDataNasc.Size = new Size(135, 16);
            lblDataNasc.TabIndex = 10;
            lblDataNasc.Text = "Data de Nascimento";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Geometr212 BkCn BT", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(100, 46);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(105, 16);
            lblNome.TabIndex = 9;
            lblNome.Text = "Nome Completo";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Geometr212 BkCn BT", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblId.Location = new Point(19, 46);
            lblId.Name = "lblId";
            lblId.Size = new Size(23, 16);
            lblId.TabIndex = 8;
            lblId.Text = "ID";
            // 
            // btnCadastrarEndereco
            // 
            btnCadastrarEndereco.Font = new Font("Geometr212 BkCn BT", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastrarEndereco.Location = new Point(144, 260);
            btnCadastrarEndereco.Name = "btnCadastrarEndereco";
            btnCadastrarEndereco.Size = new Size(171, 25);
            btnCadastrarEndereco.TabIndex = 7;
            btnCadastrarEndereco.Text = "Cadastrar Endereço";
            btnCadastrarEndereco.UseVisualStyleBackColor = true;
            btnCadastrarEndereco.Click += btnCadastrarEndereco_Click_1;
            // 
            // btnInserir
            // 
            btnInserir.Font = new Font("Geometr212 BkCn BT", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInserir.Location = new Point(321, 260);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(166, 25);
            btnInserir.TabIndex = 6;
            btnInserir.Text = "Inserir Cliente";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // dtpDataNasc
            // 
            dtpDataNasc.Font = new Font("Geometr212 BkCn BT", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDataNasc.Location = new Point(19, 132);
            dtpDataNasc.Name = "dtpDataNasc";
            dtpDataNasc.Size = new Size(271, 21);
            dtpDataNasc.TabIndex = 5;
            // 
            // txtId
            // 
            txtId.Location = new Point(19, 65);
            txtId.Name = "txtId";
            txtId.Size = new Size(61, 24);
            txtId.TabIndex = 4;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(100, 65);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(387, 24);
            txtNome.TabIndex = 3;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(310, 132);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(177, 24);
            txtCpf.TabIndex = 2;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(366, 196);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(121, 24);
            txtTelefone.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(19, 196);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(326, 24);
            txtEmail.TabIndex = 0;
            // 
            // TabPageEndereco
            // 
            TabPageEndereco.BackColor = Color.LightSteelBlue;
            TabPageEndereco.Controls.Add(cmbTipoEndereco);
            TabPageEndereco.Controls.Add(txtUf);
            TabPageEndereco.Controls.Add(txtComplemento);
            TabPageEndereco.Controls.Add(txtBairro);
            TabPageEndereco.Controls.Add(txtCidade);
            TabPageEndereco.Controls.Add(txtNumero);
            TabPageEndereco.Controls.Add(txtLogradouro);
            TabPageEndereco.Controls.Add(txtCep);
            TabPageEndereco.Controls.Add(btnFechar);
            TabPageEndereco.Controls.Add(btnAdicionar);
            TabPageEndereco.Controls.Add(btnSalvar);
            TabPageEndereco.Controls.Add(lblBairro);
            TabPageEndereco.Controls.Add(lblTipoEndereco);
            TabPageEndereco.Controls.Add(lblUf);
            TabPageEndereco.Controls.Add(lblCidade);
            TabPageEndereco.Controls.Add(lblComplemento);
            TabPageEndereco.Controls.Add(lblNumero);
            TabPageEndereco.Controls.Add(lblLogradouro);
            TabPageEndereco.Controls.Add(lblCep);
            TabPageEndereco.Location = new Point(4, 25);
            TabPageEndereco.Name = "TabPageEndereco";
            TabPageEndereco.Padding = new Padding(3);
            TabPageEndereco.Size = new Size(509, 344);
            TabPageEndereco.TabIndex = 1;
            TabPageEndereco.Text = "Endereço";
            // 
            // cmbTipoEndereco
            // 
            cmbTipoEndereco.FormattingEnabled = true;
            cmbTipoEndereco.Location = new Point(337, 224);
            cmbTipoEndereco.Name = "cmbTipoEndereco";
            cmbTipoEndereco.Size = new Size(153, 24);
            cmbTipoEndereco.TabIndex = 18;
            // 
            // txtUf
            // 
            txtUf.Location = new Point(256, 224);
            txtUf.Name = "txtUf";
            txtUf.Size = new Size(65, 24);
            txtUf.TabIndex = 17;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(17, 224);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(224, 24);
            txtComplemento.TabIndex = 16;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(220, 163);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(270, 24);
            txtBairro.TabIndex = 15;
            txtBairro.TextChanged += textBox6_TextChanged;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(17, 163);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(188, 24);
            txtCidade.TabIndex = 14;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(388, 104);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(102, 24);
            txtNumero.TabIndex = 13;
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(17, 104);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(365, 24);
            txtLogradouro.TabIndex = 12;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(17, 45);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(100, 24);
            txtCep.TabIndex = 11;
            // 
            // btnFechar
            // 
            btnFechar.Font = new Font("Geometr212 BkCn BT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFechar.Location = new Point(374, 280);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(92, 39);
            btnFechar.TabIndex = 10;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Font = new Font("Geometr212 BkCn BT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdicionar.Location = new Point(169, 280);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(169, 39);
            btnAdicionar.TabIndex = 9;
            btnAdicionar.Text = "Adicionar Novo Endereço";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Geometr212 BkCn BT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(27, 280);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(108, 39);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar Endereço";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click_1;
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Font = new Font("Geometr212 BkCn BT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBairro.Location = new Point(220, 145);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(41, 15);
            lblBairro.TabIndex = 7;
            lblBairro.Text = "Bairro";
            // 
            // lblTipoEndereco
            // 
            lblTipoEndereco.AutoSize = true;
            lblTipoEndereco.Font = new Font("Geometr212 BkCn BT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipoEndereco.Location = new Point(337, 206);
            lblTipoEndereco.Name = "lblTipoEndereco";
            lblTipoEndereco.Size = new Size(107, 15);
            lblTipoEndereco.TabIndex = 6;
            lblTipoEndereco.Text = "Tipo de Endereço";
            // 
            // lblUf
            // 
            lblUf.AutoSize = true;
            lblUf.Font = new Font("Geometr212 BkCn BT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUf.Location = new Point(256, 206);
            lblUf.Name = "lblUf";
            lblUf.Size = new Size(25, 15);
            lblUf.TabIndex = 5;
            lblUf.Text = "UF";
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Font = new Font("Geometr212 BkCn BT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCidade.Location = new Point(17, 145);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(46, 15);
            lblCidade.TabIndex = 4;
            lblCidade.Text = "Cidade";
            lblCidade.Click += label5_Click;
            // 
            // lblComplemento
            // 
            lblComplemento.AutoSize = true;
            lblComplemento.Font = new Font("Geometr212 BkCn BT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblComplemento.Location = new Point(17, 206);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(86, 15);
            lblComplemento.TabIndex = 3;
            lblComplemento.Text = "Complemento";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumero.Location = new Point(388, 86);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(21, 15);
            lblNumero.TabIndex = 2;
            lblNumero.Text = "N°";
            // 
            // lblLogradouro
            // 
            lblLogradouro.AutoSize = true;
            lblLogradouro.Font = new Font("Geometr212 BkCn BT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLogradouro.Location = new Point(17, 86);
            lblLogradouro.Name = "lblLogradouro";
            lblLogradouro.Size = new Size(72, 15);
            lblLogradouro.TabIndex = 1;
            lblLogradouro.Text = "Logradouro";
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.Font = new Font("Geometr212 BkCn BT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCep.Location = new Point(17, 27);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(34, 15);
            lblCep.TabIndex = 0;
            lblCep.Text = "CEP";
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(592, 477);
            Controls.Add(grbCadastroCliente);
            Name = "FrmCliente";
            Text = "FrmCliente";
            Load += FrmCliente_Load;
            grbCadastroCliente.ResumeLayout(false);
            tabCliente.ResumeLayout(false);
            TabPageCliente.ResumeLayout(false);
            TabPageCliente.PerformLayout();
            TabPageEndereco.ResumeLayout(false);
            TabPageEndereco.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbCadastroCliente;
        private TabControl tabCliente;
        private TabPage TabPageCliente;
        private TabPage TabPageEndereco;
        private TextBox txtEmail;
        private Label lblNumero;
        private Label lblLogradouro;
        private Label lblCep;
        private Label lblCidade;
        private Label lblComplemento;
        private TextBox txtNumero;
        private TextBox txtLogradouro;
        private TextBox txtCep;
        private Button btnFechar;
        private Button btnAdicionar;
        private Button btnSalvar;
        private Label lblBairro;
        private Label lblTipoEndereco;
        private Label lblUf;
        private TextBox txtBairro;
        private TextBox txtCidade;
        private TextBox txtUf;
        private TextBox txtComplemento;
        private ComboBox cmbTipoEndereco;
        private Button btnInserir;
        private DateTimePicker dtpDataNasc;
        private TextBox txtId;
        private TextBox txtNome;
        private TextBox txtCpf;
        private TextBox txtTelefone;
        private Button btnCadastrarEndereco;
        private Label lblTelefone;
        private Label lblEmail;
        private Label lblCpf;
        private Label lblDataNasc;
        private Label lblNome;
        private Label lblId;
    }
}