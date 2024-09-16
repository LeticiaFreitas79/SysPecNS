namespace SysPecNSDesk
{
    partial class FrmEstoque
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
            dgvEstoqueProdutos = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnCodBar = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnQuantidade = new DataGridViewTextBoxColumn();
            clnEstoqueMin = new DataGridViewTextBoxColumn();
            clnUltimaMovimentacao = new DataGridViewTextBoxColumn();
            txtEntradaId = new TextBox();
            txtEntradaCodBar = new TextBox();
            txtEntradaNome = new TextBox();
            dudEntradaQuantidade = new DomainUpDown();
            lblId = new Label();
            lblCodBar = new Label();
            lblNome = new Label();
            lblQuantidade = new Label();
            btnEntradaAtualizar = new Button();
            btnEntradaCancelar = new Button();
            tabControl1 = new TabControl();
            Entrada = new TabPage();
            Saída = new TabPage();
            btnSaidaCancelar = new Button();
            label4 = new Label();
            dudSaidaQuantidade = new DomainUpDown();
            label3 = new Label();
            txtSaidaNome = new TextBox();
            label2 = new Label();
            txtSaidaCodBar = new TextBox();
            label1 = new Label();
            txtSaidaId = new TextBox();
            btnSaidaAtualizar = new Button();
            Perda = new TabPage();
            btnPerdaCancelar = new Button();
            btnPerdaAtualizar = new Button();
            label12 = new Label();
            txtPerdaId = new TextBox();
            dudPerdaQuantidade = new DomainUpDown();
            label9 = new Label();
            label11 = new Label();
            txtPerdaCodBar = new TextBox();
            txtPerdaNome = new TextBox();
            label10 = new Label();
            Troca = new TabPage();
            btnTrocaCancelar = new Button();
            btnTrocaAtualizar = new Button();
            label8 = new Label();
            txtTrocaId = new TextBox();
            dudTrocaQuantidade = new DomainUpDown();
            label5 = new Label();
            label7 = new Label();
            txtTrocaCodBar = new TextBox();
            txtTrocaNome = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEstoqueProdutos).BeginInit();
            tabControl1.SuspendLayout();
            Entrada.SuspendLayout();
            Saída.SuspendLayout();
            Perda.SuspendLayout();
            Troca.SuspendLayout();
            SuspendLayout();
            // 
            // dgvEstoqueProdutos
            // 
            dgvEstoqueProdutos.AllowUserToAddRows = false;
            dgvEstoqueProdutos.AllowUserToDeleteRows = false;
            dgvEstoqueProdutos.BackgroundColor = SystemColors.ActiveCaption;
            dgvEstoqueProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstoqueProdutos.Columns.AddRange(new DataGridViewColumn[] { clnId, clnCodBar, clnNome, clnQuantidade, clnEstoqueMin, clnUltimaMovimentacao });
            dgvEstoqueProdutos.Location = new Point(33, 32);
            dgvEstoqueProdutos.Name = "dgvEstoqueProdutos";
            dgvEstoqueProdutos.ReadOnly = true;
            dgvEstoqueProdutos.RowHeadersVisible = false;
            dgvEstoqueProdutos.Size = new Size(548, 150);
            dgvEstoqueProdutos.TabIndex = 0;
            dgvEstoqueProdutos.CellContentClick += dgvEstoqueProdutos_CellContentClick;
            // 
            // clnId
            // 
            clnId.Frozen = true;
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            clnId.Width = 40;
            // 
            // clnCodBar
            // 
            clnCodBar.Frozen = true;
            clnCodBar.HeaderText = "Cód. Barras";
            clnCodBar.Name = "clnCodBar";
            clnCodBar.ReadOnly = true;
            // 
            // clnNome
            // 
            clnNome.Frozen = true;
            clnNome.HeaderText = "Nome";
            clnNome.Name = "clnNome";
            clnNome.ReadOnly = true;
            clnNome.Width = 125;
            // 
            // clnQuantidade
            // 
            clnQuantidade.Frozen = true;
            clnQuantidade.HeaderText = "Quantidade";
            clnQuantidade.Name = "clnQuantidade";
            clnQuantidade.ReadOnly = true;
            clnQuantidade.Width = 90;
            // 
            // clnEstoqueMin
            // 
            clnEstoqueMin.Frozen = true;
            clnEstoqueMin.HeaderText = "Estoque Mínimo";
            clnEstoqueMin.Name = "clnEstoqueMin";
            clnEstoqueMin.ReadOnly = true;
            clnEstoqueMin.Width = 90;
            // 
            // clnUltimaMovimentacao
            // 
            clnUltimaMovimentacao.Frozen = true;
            clnUltimaMovimentacao.HeaderText = "Última Movimentação";
            clnUltimaMovimentacao.Name = "clnUltimaMovimentacao";
            clnUltimaMovimentacao.ReadOnly = true;
            // 
            // txtEntradaId
            // 
            txtEntradaId.Font = new Font("Geometr212 BkCn BT", 9.75F);
            txtEntradaId.Location = new Point(19, 49);
            txtEntradaId.Name = "txtEntradaId";
            txtEntradaId.Size = new Size(65, 24);
            txtEntradaId.TabIndex = 0;
            // 
            // txtEntradaCodBar
            // 
            txtEntradaCodBar.Font = new Font("Geometr212 BkCn BT", 9.75F);
            txtEntradaCodBar.Location = new Point(90, 49);
            txtEntradaCodBar.Name = "txtEntradaCodBar";
            txtEntradaCodBar.Size = new Size(123, 24);
            txtEntradaCodBar.TabIndex = 1;
            // 
            // txtEntradaNome
            // 
            txtEntradaNome.Font = new Font("Geometr212 BkCn BT", 9.75F);
            txtEntradaNome.Location = new Point(219, 50);
            txtEntradaNome.Name = "txtEntradaNome";
            txtEntradaNome.Size = new Size(297, 24);
            txtEntradaNome.TabIndex = 2;
            // 
            // dudEntradaQuantidade
            // 
            dudEntradaQuantidade.BorderStyle = BorderStyle.FixedSingle;
            dudEntradaQuantidade.Font = new Font("Geometr212 BkCn BT", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dudEntradaQuantidade.Location = new Point(20, 116);
            dudEntradaQuantidade.Name = "dudEntradaQuantidade";
            dudEntradaQuantidade.Size = new Size(295, 24);
            dudEntradaQuantidade.TabIndex = 5;
            dudEntradaQuantidade.SelectedItemChanged += dudQuantidade_SelectedItemChanged;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Geometr212 BkCn BT", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblId.Location = new Point(19, 31);
            lblId.Name = "lblId";
            lblId.Size = new Size(23, 16);
            lblId.TabIndex = 8;
            lblId.Text = "ID";
            // 
            // lblCodBar
            // 
            lblCodBar.AutoSize = true;
            lblCodBar.Font = new Font("Geometr212 BkCn BT", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCodBar.Location = new Point(90, 31);
            lblCodBar.Name = "lblCodBar";
            lblCodBar.Size = new Size(82, 16);
            lblCodBar.TabIndex = 9;
            lblCodBar.Text = "Cód. Barras";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Geometr212 BkCn BT", 9.75F);
            lblNome.Location = new Point(219, 31);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(115, 16);
            lblNome.TabIndex = 10;
            lblNome.Text = "Nome do Produto";
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Font = new Font("Geometr212 BkCn BT", 9.75F);
            lblQuantidade.Location = new Point(19, 97);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(260, 16);
            lblQuantidade.TabIndex = 13;
            lblQuantidade.Text = "Quantidade a ser adicionada no estoque";
            lblQuantidade.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnEntradaAtualizar
            // 
            btnEntradaAtualizar.Font = new Font("Geometr212 BkCn BT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEntradaAtualizar.Location = new Point(334, 90);
            btnEntradaAtualizar.Name = "btnEntradaAtualizar";
            btnEntradaAtualizar.Size = new Size(182, 23);
            btnEntradaAtualizar.TabIndex = 6;
            btnEntradaAtualizar.Text = "Atualizar";
            btnEntradaAtualizar.UseVisualStyleBackColor = true;
            btnEntradaAtualizar.Click += btnEntradaAtualizar_Click;
            // 
            // btnEntradaCancelar
            // 
            btnEntradaCancelar.Font = new Font("Geometr212 BkCn BT", 9F);
            btnEntradaCancelar.Location = new Point(334, 119);
            btnEntradaCancelar.Name = "btnEntradaCancelar";
            btnEntradaCancelar.Size = new Size(182, 23);
            btnEntradaCancelar.TabIndex = 7;
            btnEntradaCancelar.Text = "Cancelar";
            btnEntradaCancelar.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Entrada);
            tabControl1.Controls.Add(Saída);
            tabControl1.Controls.Add(Perda);
            tabControl1.Controls.Add(Troca);
            tabControl1.Cursor = Cursors.Hand;
            tabControl1.Font = new Font("Geometr415 Blk BT", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(33, 221);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(548, 202);
            tabControl1.TabIndex = 8;
            // 
            // Entrada
            // 
            Entrada.BackColor = Color.CadetBlue;
            Entrada.Controls.Add(btnEntradaCancelar);
            Entrada.Controls.Add(btnEntradaAtualizar);
            Entrada.Controls.Add(txtEntradaId);
            Entrada.Controls.Add(lblQuantidade);
            Entrada.Controls.Add(txtEntradaCodBar);
            Entrada.Controls.Add(lblNome);
            Entrada.Controls.Add(txtEntradaNome);
            Entrada.Controls.Add(lblCodBar);
            Entrada.Controls.Add(dudEntradaQuantidade);
            Entrada.Controls.Add(lblId);
            Entrada.Location = new Point(4, 25);
            Entrada.Name = "Entrada";
            Entrada.Padding = new Padding(3);
            Entrada.Size = new Size(540, 173);
            Entrada.TabIndex = 0;
            Entrada.Text = "Entrada";
            // 
            // Saída
            // 
            Saída.BackColor = Color.SteelBlue;
            Saída.Controls.Add(btnSaidaCancelar);
            Saída.Controls.Add(label4);
            Saída.Controls.Add(dudSaidaQuantidade);
            Saída.Controls.Add(label3);
            Saída.Controls.Add(txtSaidaNome);
            Saída.Controls.Add(label2);
            Saída.Controls.Add(txtSaidaCodBar);
            Saída.Controls.Add(label1);
            Saída.Controls.Add(txtSaidaId);
            Saída.Controls.Add(btnSaidaAtualizar);
            Saída.Location = new Point(4, 25);
            Saída.Name = "Saída";
            Saída.Padding = new Padding(3);
            Saída.Size = new Size(540, 173);
            Saída.TabIndex = 1;
            Saída.Text = "Saída";
            // 
            // btnSaidaCancelar
            // 
            btnSaidaCancelar.Font = new Font("Geometr212 BkCn BT", 9F);
            btnSaidaCancelar.Location = new Point(335, 119);
            btnSaidaCancelar.Name = "btnSaidaCancelar";
            btnSaidaCancelar.Size = new Size(182, 23);
            btnSaidaCancelar.TabIndex = 19;
            btnSaidaCancelar.Text = "Cancelar";
            btnSaidaCancelar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Geometr212 BkCn BT", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(20, 31);
            label4.Name = "label4";
            label4.Size = new Size(23, 16);
            label4.TabIndex = 20;
            label4.Text = "ID";
            // 
            // dudSaidaQuantidade
            // 
            dudSaidaQuantidade.BorderStyle = BorderStyle.FixedSingle;
            dudSaidaQuantidade.Font = new Font("Geometr212 BkCn BT", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dudSaidaQuantidade.Location = new Point(21, 116);
            dudSaidaQuantidade.Name = "dudSaidaQuantidade";
            dudSaidaQuantidade.Size = new Size(295, 24);
            dudSaidaQuantidade.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Geometr212 BkCn BT", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(91, 31);
            label3.Name = "label3";
            label3.Size = new Size(82, 16);
            label3.TabIndex = 21;
            label3.Text = "Cód. Barras";
            // 
            // txtSaidaNome
            // 
            txtSaidaNome.Font = new Font("Geometr212 BkCn BT", 9.75F);
            txtSaidaNome.Location = new Point(220, 50);
            txtSaidaNome.Name = "txtSaidaNome";
            txtSaidaNome.Size = new Size(297, 24);
            txtSaidaNome.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Geometr212 BkCn BT", 9.75F);
            label2.Location = new Point(220, 31);
            label2.Name = "label2";
            label2.Size = new Size(115, 16);
            label2.TabIndex = 22;
            label2.Text = "Nome do Produto";
            // 
            // txtSaidaCodBar
            // 
            txtSaidaCodBar.Font = new Font("Geometr212 BkCn BT", 9.75F);
            txtSaidaCodBar.Location = new Point(91, 49);
            txtSaidaCodBar.Name = "txtSaidaCodBar";
            txtSaidaCodBar.Size = new Size(123, 24);
            txtSaidaCodBar.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Geometr212 BkCn BT", 9.75F);
            label1.Location = new Point(20, 97);
            label1.Name = "label1";
            label1.Size = new Size(239, 16);
            label1.TabIndex = 23;
            label1.Text = "Quantidade a ser retirada do estoque";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtSaidaId
            // 
            txtSaidaId.Font = new Font("Geometr212 BkCn BT", 9.75F);
            txtSaidaId.Location = new Point(20, 49);
            txtSaidaId.Name = "txtSaidaId";
            txtSaidaId.Size = new Size(65, 24);
            txtSaidaId.TabIndex = 14;
            // 
            // btnSaidaAtualizar
            // 
            btnSaidaAtualizar.Font = new Font("Geometr212 BkCn BT", 9F);
            btnSaidaAtualizar.Location = new Point(335, 90);
            btnSaidaAtualizar.Name = "btnSaidaAtualizar";
            btnSaidaAtualizar.Size = new Size(182, 23);
            btnSaidaAtualizar.TabIndex = 18;
            btnSaidaAtualizar.Text = "Atualizar";
            btnSaidaAtualizar.UseVisualStyleBackColor = true;
            // 
            // Perda
            // 
            Perda.BackColor = Color.CadetBlue;
            Perda.Controls.Add(btnPerdaCancelar);
            Perda.Controls.Add(btnPerdaAtualizar);
            Perda.Controls.Add(label12);
            Perda.Controls.Add(txtPerdaId);
            Perda.Controls.Add(dudPerdaQuantidade);
            Perda.Controls.Add(label9);
            Perda.Controls.Add(label11);
            Perda.Controls.Add(txtPerdaCodBar);
            Perda.Controls.Add(txtPerdaNome);
            Perda.Controls.Add(label10);
            Perda.Location = new Point(4, 25);
            Perda.Name = "Perda";
            Perda.Padding = new Padding(3);
            Perda.Size = new Size(540, 173);
            Perda.TabIndex = 2;
            Perda.Text = "Perda";
            // 
            // btnPerdaCancelar
            // 
            btnPerdaCancelar.Font = new Font("Geometr212 BkCn BT", 9F);
            btnPerdaCancelar.Location = new Point(338, 122);
            btnPerdaCancelar.Name = "btnPerdaCancelar";
            btnPerdaCancelar.Size = new Size(182, 23);
            btnPerdaCancelar.TabIndex = 39;
            btnPerdaCancelar.Text = "Cancelar";
            btnPerdaCancelar.UseVisualStyleBackColor = true;
            // 
            // btnPerdaAtualizar
            // 
            btnPerdaAtualizar.Font = new Font("Geometr212 BkCn BT", 9F);
            btnPerdaAtualizar.Location = new Point(338, 93);
            btnPerdaAtualizar.Name = "btnPerdaAtualizar";
            btnPerdaAtualizar.Size = new Size(182, 23);
            btnPerdaAtualizar.TabIndex = 38;
            btnPerdaAtualizar.Text = "Atualizar";
            btnPerdaAtualizar.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Geometr212 BkCn BT", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(23, 34);
            label12.Name = "label12";
            label12.Size = new Size(23, 16);
            label12.TabIndex = 40;
            label12.Text = "ID";
            // 
            // txtPerdaId
            // 
            txtPerdaId.Font = new Font("Geometr212 BkCn BT", 9.75F);
            txtPerdaId.Location = new Point(23, 52);
            txtPerdaId.Name = "txtPerdaId";
            txtPerdaId.Size = new Size(65, 24);
            txtPerdaId.TabIndex = 34;
            // 
            // dudPerdaQuantidade
            // 
            dudPerdaQuantidade.BorderStyle = BorderStyle.FixedSingle;
            dudPerdaQuantidade.Font = new Font("Geometr212 BkCn BT", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dudPerdaQuantidade.Location = new Point(24, 119);
            dudPerdaQuantidade.Name = "dudPerdaQuantidade";
            dudPerdaQuantidade.Size = new Size(295, 24);
            dudPerdaQuantidade.TabIndex = 37;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Geometr212 BkCn BT", 9.75F);
            label9.Location = new Point(23, 100);
            label9.Name = "label9";
            label9.Size = new Size(239, 16);
            label9.TabIndex = 43;
            label9.Text = "Quantidade a ser retirada do estoque";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Geometr212 BkCn BT", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(94, 34);
            label11.Name = "label11";
            label11.Size = new Size(82, 16);
            label11.TabIndex = 41;
            label11.Text = "Cód. Barras";
            // 
            // txtPerdaCodBar
            // 
            txtPerdaCodBar.Font = new Font("Geometr212 BkCn BT", 9.75F);
            txtPerdaCodBar.Location = new Point(94, 52);
            txtPerdaCodBar.Name = "txtPerdaCodBar";
            txtPerdaCodBar.Size = new Size(123, 24);
            txtPerdaCodBar.TabIndex = 35;
            // 
            // txtPerdaNome
            // 
            txtPerdaNome.Font = new Font("Geometr212 BkCn BT", 9.75F);
            txtPerdaNome.Location = new Point(223, 53);
            txtPerdaNome.Name = "txtPerdaNome";
            txtPerdaNome.Size = new Size(297, 24);
            txtPerdaNome.TabIndex = 36;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Geometr212 BkCn BT", 9.75F);
            label10.Location = new Point(223, 34);
            label10.Name = "label10";
            label10.Size = new Size(115, 16);
            label10.TabIndex = 42;
            label10.Text = "Nome do Produto";
            // 
            // Troca
            // 
            Troca.BackColor = Color.SteelBlue;
            Troca.Controls.Add(btnTrocaCancelar);
            Troca.Controls.Add(btnTrocaAtualizar);
            Troca.Controls.Add(label8);
            Troca.Controls.Add(txtTrocaId);
            Troca.Controls.Add(dudTrocaQuantidade);
            Troca.Controls.Add(label5);
            Troca.Controls.Add(label7);
            Troca.Controls.Add(txtTrocaCodBar);
            Troca.Controls.Add(txtTrocaNome);
            Troca.Controls.Add(label6);
            Troca.Location = new Point(4, 25);
            Troca.Name = "Troca";
            Troca.Padding = new Padding(3);
            Troca.Size = new Size(540, 173);
            Troca.TabIndex = 3;
            Troca.Text = "Troca";
            // 
            // btnTrocaCancelar
            // 
            btnTrocaCancelar.Font = new Font("Geometr212 BkCn BT", 9F);
            btnTrocaCancelar.Location = new Point(337, 120);
            btnTrocaCancelar.Name = "btnTrocaCancelar";
            btnTrocaCancelar.Size = new Size(182, 23);
            btnTrocaCancelar.TabIndex = 29;
            btnTrocaCancelar.Text = "Cancelar";
            btnTrocaCancelar.UseVisualStyleBackColor = true;
            // 
            // btnTrocaAtualizar
            // 
            btnTrocaAtualizar.Font = new Font("Geometr212 BkCn BT", 9F);
            btnTrocaAtualizar.Location = new Point(337, 91);
            btnTrocaAtualizar.Name = "btnTrocaAtualizar";
            btnTrocaAtualizar.Size = new Size(182, 23);
            btnTrocaAtualizar.TabIndex = 28;
            btnTrocaAtualizar.Text = "Atualizar";
            btnTrocaAtualizar.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Geometr212 BkCn BT", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(22, 32);
            label8.Name = "label8";
            label8.Size = new Size(23, 16);
            label8.TabIndex = 30;
            label8.Text = "ID";
            // 
            // txtTrocaId
            // 
            txtTrocaId.Font = new Font("Geometr212 BkCn BT", 9.75F);
            txtTrocaId.Location = new Point(22, 50);
            txtTrocaId.Name = "txtTrocaId";
            txtTrocaId.Size = new Size(65, 24);
            txtTrocaId.TabIndex = 24;
            // 
            // dudTrocaQuantidade
            // 
            dudTrocaQuantidade.BorderStyle = BorderStyle.FixedSingle;
            dudTrocaQuantidade.Font = new Font("Geometr212 BkCn BT", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dudTrocaQuantidade.Location = new Point(23, 117);
            dudTrocaQuantidade.Name = "dudTrocaQuantidade";
            dudTrocaQuantidade.Size = new Size(295, 24);
            dudTrocaQuantidade.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Geometr212 BkCn BT", 9.75F);
            label5.Location = new Point(22, 98);
            label5.Name = "label5";
            label5.Size = new Size(166, 16);
            label5.TabIndex = 33;
            label5.Text = "Quantidade a ser trocada";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Geometr212 BkCn BT", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(93, 32);
            label7.Name = "label7";
            label7.Size = new Size(82, 16);
            label7.TabIndex = 31;
            label7.Text = "Cód. Barras";
            // 
            // txtTrocaCodBar
            // 
            txtTrocaCodBar.Font = new Font("Geometr212 BkCn BT", 9.75F);
            txtTrocaCodBar.Location = new Point(93, 50);
            txtTrocaCodBar.Name = "txtTrocaCodBar";
            txtTrocaCodBar.Size = new Size(123, 24);
            txtTrocaCodBar.TabIndex = 25;
            // 
            // txtTrocaNome
            // 
            txtTrocaNome.Font = new Font("Geometr212 BkCn BT", 9.75F);
            txtTrocaNome.Location = new Point(222, 51);
            txtTrocaNome.Name = "txtTrocaNome";
            txtTrocaNome.Size = new Size(297, 24);
            txtTrocaNome.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Geometr212 BkCn BT", 9.75F);
            label6.Location = new Point(222, 32);
            label6.Name = "label6";
            label6.Size = new Size(115, 16);
            label6.TabIndex = 32;
            label6.Text = "Nome do Produto";
            // 
            // FrmEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(625, 448);
            Controls.Add(tabControl1);
            Controls.Add(dgvEstoqueProdutos);
            Name = "FrmEstoque";
            Text = "SysPec | Estoque";
            Load += FrmEstoque_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEstoqueProdutos).EndInit();
            tabControl1.ResumeLayout(false);
            Entrada.ResumeLayout(false);
            Entrada.PerformLayout();
            Saída.ResumeLayout(false);
            Saída.PerformLayout();
            Perda.ResumeLayout(false);
            Perda.PerformLayout();
            Troca.ResumeLayout(false);
            Troca.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvEstoqueProdutos;
        private TextBox txtEntradaId;
        private TextBox txtEntradaCodBar;
        private TextBox txtEntradaNome;
        private DomainUpDown dudEntradaQuantidade;
        private Label lblId;
        private Label lblCodBar;
        private Label lblNome;
        private Label lblQuantidade;
        private Button btnEntradaAtualizar;
        private Button btnEntradaCancelar;
        private TabControl tabControl1;
        private TabPage Entrada;
        private TabPage Saída;
        private TabPage Perda;
        private TabPage Troca;
        private Button btnSaidaCancelar;
        private Label label4;
        private DomainUpDown dudSaidaQuantidade;
        private Label label3;
        private TextBox txtSaidaNome;
        private Label label2;
        private TextBox txtSaidaCodBar;
        private Label label1;
        private TextBox txtSaidaId;
        private Button btnSaidaAtualizar;
        private Button btnPerdaCancelar;
        private Button btnPerdaAtualizar;
        private Label label12;
        private TextBox txtPerdaId;
        private DomainUpDown dudPerdaQuantidade;
        private Label label9;
        private Label label11;
        private TextBox txtPerdaCodBar;
        private TextBox txtPerdaNome;
        private Label label10;
        private Button btnTrocaCancelar;
        private Button btnTrocaAtualizar;
        private Label label8;
        private TextBox txtTrocaId;
        private DomainUpDown dudTrocaQuantidade;
        private Label label5;
        private Label label7;
        private TextBox txtTrocaCodBar;
        private TextBox txtTrocaNome;
        private Label label6;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnCodBar;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnQuantidade;
        private DataGridViewTextBoxColumn clnEstoqueMin;
        private DataGridViewTextBoxColumn clnUltimaMovimentacao;
    }
}