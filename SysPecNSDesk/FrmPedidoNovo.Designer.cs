namespace SysPecNSDesk
{
    partial class FrmPedidoNovo
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedidoNovo));
            grbIdentificacao = new GroupBox();
            label1 = new Label();
            btnConsultaCliente = new Button();
            btnInserePedido = new Button();
            txtIdCliente = new TextBox();
            textBox3 = new TextBox();
            txtUsuario = new TextBox();
            lblUsuario = new Label();
            grbItens = new GroupBox();
            btnReal = new RadioButton();
            btnPorcentagem = new RadioButton();
            txtDesconto = new TextBox();
            dgvItensPedido = new DataGridView();
            clnseq2 = new DataGridViewTextBoxColumn();
            clnCodBar2 = new DataGridViewTextBoxColumn();
            clnDescricao2 = new DataGridViewTextBoxColumn();
            clnValorUnit2 = new DataGridViewTextBoxColumn();
            clnQuantidade2 = new DataGridViewTextBoxColumn();
            clnDesconto2 = new DataGridViewTextBoxColumn();
            clnTotal2 = new DataGridViewTextBoxColumn();
            txtValorUnit = new TextBox();
            txtQuantidade = new TextBox();
            txtDescricao = new TextBox();
            txtCodBar = new TextBox();
            label6 = new Label();
            lblQuantidade = new Label();
            lblValorUnit = new Label();
            lblDescricao = new Label();
            lblCodBar = new Label();
            btnAdicionar = new Button();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            txtTotal = new TextBox();
            txtDescontoPedido = new TextBox();
            txtDescontoItem = new TextBox();
            txtSubTotal = new TextBox();
            btnFechar = new Button();
            txtTotalPedido = new TextBox();
            lblTotal = new Label();
            lblNovoPedido = new Label();
            txtIdPedido = new TextBox();
            lblNumero = new Label();
            pictureBox1 = new PictureBox();
            txtValorDesconto = new TextBox();
            grbIdentificacao.SuspendLayout();
            grbItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItensPedido).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // grbIdentificacao
            // 
            grbIdentificacao.Controls.Add(label1);
            grbIdentificacao.Controls.Add(btnConsultaCliente);
            grbIdentificacao.Controls.Add(btnInserePedido);
            grbIdentificacao.Controls.Add(txtIdCliente);
            grbIdentificacao.Controls.Add(textBox3);
            grbIdentificacao.Controls.Add(txtUsuario);
            grbIdentificacao.Controls.Add(lblUsuario);
            grbIdentificacao.Font = new Font("Geometr212 BkCn BT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbIdentificacao.Location = new Point(23, 66);
            grbIdentificacao.Name = "grbIdentificacao";
            grbIdentificacao.Size = new Size(552, 171);
            grbIdentificacao.TabIndex = 2;
            grbIdentificacao.TabStop = false;
            grbIdentificacao.Text = "Identificação";
            grbIdentificacao.Enter += grbIdentificacao_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Geometr212 BkCn BT", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 95);
            label1.Name = "label1";
            label1.Size = new Size(50, 16);
            label1.TabIndex = 7;
            label1.Text = "Cliente";
            // 
            // btnConsultaCliente
            // 
            btnConsultaCliente.BackColor = Color.Transparent;
            btnConsultaCliente.Image = Properties.Resources.Search;
            btnConsultaCliente.Location = new Point(356, 112);
            btnConsultaCliente.Name = "btnConsultaCliente";
            btnConsultaCliente.Size = new Size(63, 26);
            btnConsultaCliente.TabIndex = 6;
            btnConsultaCliente.UseVisualStyleBackColor = false;
            // 
            // btnInserePedido
            // 
            btnInserePedido.Font = new Font("Geometr212 BkCn BT", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInserePedido.Location = new Point(450, 74);
            btnInserePedido.Name = "btnInserePedido";
            btnInserePedido.Size = new Size(66, 44);
            btnInserePedido.TabIndex = 5;
            btnInserePedido.Text = "Abrir";
            btnInserePedido.UseVisualStyleBackColor = true;
            btnInserePedido.Click += btnInserePedido_Click;
            // 
            // txtIdCliente
            // 
            txtIdCliente.Font = new Font("Geometr212 BkCn BT", 9.75F);
            txtIdCliente.Location = new Point(30, 114);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(80, 24);
            txtIdCliente.TabIndex = 4;
            txtIdCliente.TextChanged += txtIdCliente_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Geometr212 BkCn BT", 9.75F);
            textBox3.Location = new Point(116, 114);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(234, 24);
            textBox3.TabIndex = 2;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Geometr212 BkCn BT", 9.75F);
            txtUsuario.Location = new Point(30, 54);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(389, 24);
            txtUsuario.TabIndex = 1;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Geometr212 BkCn BT", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(30, 35);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(56, 16);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuário";
            // 
            // grbItens
            // 
            grbItens.Controls.Add(txtValorDesconto);
            grbItens.Controls.Add(btnReal);
            grbItens.Controls.Add(btnPorcentagem);
            grbItens.Controls.Add(txtDesconto);
            grbItens.Controls.Add(dgvItensPedido);
            grbItens.Controls.Add(txtValorUnit);
            grbItens.Controls.Add(txtQuantidade);
            grbItens.Controls.Add(txtDescricao);
            grbItens.Controls.Add(txtCodBar);
            grbItens.Controls.Add(label6);
            grbItens.Controls.Add(lblQuantidade);
            grbItens.Controls.Add(lblValorUnit);
            grbItens.Controls.Add(lblDescricao);
            grbItens.Controls.Add(lblCodBar);
            grbItens.Controls.Add(btnAdicionar);
            grbItens.Font = new Font("Geometr212 BkCn BT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbItens.Location = new Point(23, 253);
            grbItens.Name = "grbItens";
            grbItens.Size = new Size(754, 429);
            grbItens.TabIndex = 1;
            grbItens.TabStop = false;
            grbItens.Text = "Itens do Pedido";
            // 
            // btnReal
            // 
            btnReal.AutoSize = true;
            btnReal.Font = new Font("Geometr212 BkCn BT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReal.Location = new Point(434, 124);
            btnReal.Name = "btnReal";
            btnReal.Size = new Size(41, 19);
            btnReal.TabIndex = 15;
            btnReal.TabStop = true;
            btnReal.Text = "R$";
            btnReal.UseVisualStyleBackColor = true;
            // 
            // btnPorcentagem
            // 
            btnPorcentagem.AutoSize = true;
            btnPorcentagem.Font = new Font("Geometr212 BkCn BT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPorcentagem.Location = new Point(479, 124);
            btnPorcentagem.Name = "btnPorcentagem";
            btnPorcentagem.Size = new Size(37, 19);
            btnPorcentagem.TabIndex = 14;
            btnPorcentagem.TabStop = true;
            btnPorcentagem.Text = "%";
            btnPorcentagem.UseVisualStyleBackColor = true;
            // 
            // txtDesconto
            // 
            txtDesconto.Font = new Font("Geometr212 BkCn BT", 9.75F);
            txtDesconto.Location = new Point(291, 121);
            txtDesconto.Name = "txtDesconto";
            txtDesconto.Size = new Size(133, 24);
            txtDesconto.TabIndex = 13;
            // 
            // dgvItensPedido
            // 
            dgvItensPedido.AllowUserToAddRows = false;
            dgvItensPedido.AllowUserToDeleteRows = false;
            dgvItensPedido.BackgroundColor = Color.LightSteelBlue;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Geometr212 BkCn BT", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvItensPedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvItensPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItensPedido.Columns.AddRange(new DataGridViewColumn[] { clnseq2, clnCodBar2, clnDescricao2, clnValorUnit2, clnQuantidade2, clnDesconto2, clnTotal2 });
            dgvItensPedido.Location = new Point(13, 160);
            dgvItensPedido.Name = "dgvItensPedido";
            dgvItensPedido.ReadOnly = true;
            dgvItensPedido.RowHeadersVisible = false;
            dgvItensPedido.Size = new Size(728, 250);
            dgvItensPedido.TabIndex = 12;
            dgvItensPedido.CellContentClick += dgvItensPedido_CellContentClick;
            // 
            // clnseq2
            // 
            clnseq2.Frozen = true;
            clnseq2.HeaderText = "#SEQ";
            clnseq2.Name = "clnseq2";
            clnseq2.ReadOnly = true;
            clnseq2.Width = 60;
            // 
            // clnCodBar2
            // 
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clnCodBar2.DefaultCellStyle = dataGridViewCellStyle2;
            clnCodBar2.Frozen = true;
            clnCodBar2.HeaderText = "Cód. Barras";
            clnCodBar2.Name = "clnCodBar2";
            clnCodBar2.ReadOnly = true;
            // 
            // clnDescricao2
            // 
            clnDescricao2.Frozen = true;
            clnDescricao2.HeaderText = "Descrição";
            clnDescricao2.Name = "clnDescricao2";
            clnDescricao2.ReadOnly = true;
            clnDescricao2.Width = 200;
            // 
            // clnValorUnit2
            // 
            clnValorUnit2.Frozen = true;
            clnValorUnit2.HeaderText = "Valor Unit.";
            clnValorUnit2.Name = "clnValorUnit2";
            clnValorUnit2.ReadOnly = true;
            clnValorUnit2.Width = 80;
            // 
            // clnQuantidade2
            // 
            clnQuantidade2.Frozen = true;
            clnQuantidade2.HeaderText = "Quant.";
            clnQuantidade2.Name = "clnQuantidade2";
            clnQuantidade2.ReadOnly = true;
            clnQuantidade2.Width = 80;
            // 
            // clnDesconto2
            // 
            clnDesconto2.Frozen = true;
            clnDesconto2.HeaderText = "Desconto";
            clnDesconto2.Name = "clnDesconto2";
            clnDesconto2.ReadOnly = true;
            clnDesconto2.Width = 85;
            // 
            // clnTotal2
            // 
            clnTotal2.Frozen = true;
            clnTotal2.HeaderText = "Total";
            clnTotal2.Name = "clnTotal2";
            clnTotal2.ReadOnly = true;
            clnTotal2.Width = 120;
            // 
            // txtValorUnit
            // 
            txtValorUnit.Font = new Font("Geometr212 BkCn BT", 9.75F);
            txtValorUnit.Location = new Point(13, 121);
            txtValorUnit.Name = "txtValorUnit";
            txtValorUnit.Size = new Size(133, 24);
            txtValorUnit.TabIndex = 4;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Font = new Font("Geometr212 BkCn BT", 9.75F);
            txtQuantidade.Location = new Point(152, 121);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(133, 24);
            txtQuantidade.TabIndex = 3;
            txtQuantidade.Text = "1";
            // 
            // txtDescricao
            // 
            txtDescricao.Font = new Font("Geometr212 BkCn BT", 9.75F);
            txtDescricao.Location = new Point(206, 58);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(534, 24);
            txtDescricao.TabIndex = 2;
            // 
            // txtCodBar
            // 
            txtCodBar.Font = new Font("Geometr212 BkCn BT", 9.75F);
            txtCodBar.Location = new Point(13, 58);
            txtCodBar.Name = "txtCodBar";
            txtCodBar.Size = new Size(171, 24);
            txtCodBar.TabIndex = 1;
            txtCodBar.Leave += txtCodBar_Leave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Geometr212 BkCn BT", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(291, 104);
            label6.Name = "label6";
            label6.Size = new Size(57, 14);
            label6.TabIndex = 10;
            label6.Text = "Desconto";
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Font = new Font("Geometr212 BkCn BT", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuantidade.Location = new Point(152, 104);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(42, 14);
            lblQuantidade.TabIndex = 9;
            lblQuantidade.Text = "Quant.";
            // 
            // lblValorUnit
            // 
            lblValorUnit.AutoSize = true;
            lblValorUnit.Font = new Font("Geometr212 BkCn BT", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblValorUnit.Location = new Point(13, 104);
            lblValorUnit.Name = "lblValorUnit";
            lblValorUnit.Size = new Size(63, 14);
            lblValorUnit.TabIndex = 8;
            lblValorUnit.Text = "Valor Unit.";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Font = new Font("Geometr212 BkCn BT", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescricao.Location = new Point(206, 41);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(59, 14);
            lblDescricao.TabIndex = 7;
            lblDescricao.Text = "Descrição";
            lblDescricao.Click += label3_Click;
            // 
            // lblCodBar
            // 
            lblCodBar.AutoSize = true;
            lblCodBar.Font = new Font("Geometr212 BkCn BT", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCodBar.Location = new Point(13, 41);
            lblCodBar.Name = "lblCodBar";
            lblCodBar.Size = new Size(96, 14);
            lblCodBar.TabIndex = 6;
            lblCodBar.Text = "Código de Barras";
            lblCodBar.Click += label2_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Font = new Font("Geometr212 BkCn BT", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdicionar.Location = new Point(608, 119);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(133, 28);
            btnAdicionar.TabIndex = 0;
            btnAdicionar.Text = "Adicionar Produto";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Geometr212 BkCn BT", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(541, 705);
            label10.Name = "label10";
            label10.Size = new Size(34, 14);
            label10.TabIndex = 22;
            label10.Text = "Total";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Geometr212 BkCn BT", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(410, 705);
            label9.Name = "label9";
            label9.Size = new Size(57, 14);
            label9.TabIndex = 21;
            label9.Text = "Desconto";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Geometr212 BkCn BT", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(281, 705);
            label8.Name = "label8";
            label8.Size = new Size(87, 14);
            label8.TabIndex = 20;
            label8.Text = "Desconto Itens";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Geometr212 BkCn BT", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(152, 705);
            label7.Name = "label7";
            label7.Size = new Size(58, 14);
            label7.TabIndex = 19;
            label7.Text = "Sub Total";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(539, 722);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(105, 23);
            txtTotal.TabIndex = 18;
            txtTotal.TextChanged += textBox6_TextChanged;
            // 
            // txtDescontoPedido
            // 
            txtDescontoPedido.Location = new Point(410, 722);
            txtDescontoPedido.Name = "txtDescontoPedido";
            txtDescontoPedido.Size = new Size(105, 23);
            txtDescontoPedido.TabIndex = 17;
            // 
            // txtDescontoItem
            // 
            txtDescontoItem.Location = new Point(281, 722);
            txtDescontoItem.Name = "txtDescontoItem";
            txtDescontoItem.ReadOnly = true;
            txtDescontoItem.Size = new Size(105, 23);
            txtDescontoItem.TabIndex = 16;
            // 
            // txtSubTotal
            // 
            txtSubTotal.Location = new Point(152, 722);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.ReadOnly = true;
            txtSubTotal.Size = new Size(105, 23);
            txtSubTotal.TabIndex = 15;
            // 
            // btnFechar
            // 
            btnFechar.Font = new Font("Geometr212 BkCn BT", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFechar.Location = new Point(668, 722);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(105, 23);
            btnFechar.TabIndex = 14;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // txtTotalPedido
            // 
            txtTotalPedido.Location = new Point(23, 722);
            txtTotalPedido.Name = "txtTotalPedido";
            txtTotalPedido.ReadOnly = true;
            txtTotalPedido.Size = new Size(105, 23);
            txtTotalPedido.TabIndex = 13;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Geometr212 BkCn BT", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(23, 705);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(90, 14);
            lblTotal.TabIndex = 12;
            lblTotal.Text = "Total do Pedido";
            lblTotal.Click += label7_Click;
            // 
            // lblNovoPedido
            // 
            lblNovoPedido.AutoSize = true;
            lblNovoPedido.Font = new Font("Geometr212 BkCn BT", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNovoPedido.Location = new Point(23, 22);
            lblNovoPedido.Name = "lblNovoPedido";
            lblNovoPedido.Size = new Size(177, 26);
            lblNovoPedido.TabIndex = 0;
            lblNovoPedido.Text = "NOVO PEDIDO";
            lblNovoPedido.Click += label1_Click;
            // 
            // txtIdPedido
            // 
            txtIdPedido.Font = new Font("Geometr212 BkCn BT", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdPedido.Location = new Point(475, 46);
            txtIdPedido.Name = "txtIdPedido";
            txtIdPedido.Size = new Size(100, 24);
            txtIdPedido.TabIndex = 3;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Geometr212 BkCn BT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumero.Location = new Point(400, 48);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(69, 19);
            lblNumero.TabIndex = 4;
            lblNumero.Text = "Número:";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(594, 78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 159);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // txtValorDesconto
            // 
            txtValorDesconto.BackColor = Color.LightSlateGray;
            txtValorDesconto.BorderStyle = BorderStyle.None;
            txtValorDesconto.Font = new Font("Geometr212 BkCn BT", 9.75F);
            txtValorDesconto.ForeColor = Color.Red;
            txtValorDesconto.Location = new Point(524, 122);
            txtValorDesconto.Name = "txtValorDesconto";
            txtValorDesconto.Size = new Size(70, 17);
            txtValorDesconto.TabIndex = 16;
            txtValorDesconto.TextChanged += textBox1_TextChanged;
            // 
            // FrmPedidoNovo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(800, 776);
            Controls.Add(pictureBox1);
            Controls.Add(lblNumero);
            Controls.Add(txtIdPedido);
            Controls.Add(lblNovoPedido);
            Controls.Add(grbItens);
            Controls.Add(label10);
            Controls.Add(grbIdentificacao);
            Controls.Add(label9);
            Controls.Add(btnFechar);
            Controls.Add(label8);
            Controls.Add(lblTotal);
            Controls.Add(label7);
            Controls.Add(txtTotalPedido);
            Controls.Add(txtTotal);
            Controls.Add(txtSubTotal);
            Controls.Add(txtDescontoPedido);
            Controls.Add(txtDescontoItem);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmPedidoNovo";
            Text = "SysPec | Novo Pedido";
            Load += FrmPedidoNovo_Load;
            grbIdentificacao.ResumeLayout(false);
            grbIdentificacao.PerformLayout();
            grbItens.ResumeLayout(false);
            grbItens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItensPedido).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbIdentificacao;
        private GroupBox grbItens;
        private Label lblNovoPedido;
        private TextBox txtUsuario;
        private Label lblUsuario;
        private TextBox txtIdPedido;
        private Label lblNumero;
        private TextBox textBox3;
        private TextBox txtIdCliente;
        private Button btnAdicionar;
        private TextBox txtQuantidade;
        private TextBox txtDescricao;
        private TextBox txtValorUnit;
        private Label lblCodBar;
        private TextBox txtDesconto;
        private TextBox txtCodBar;
        private DataGridViewTextBoxColumn clnseq2;
        private DataGridViewTextBoxColumn clnCodBar2;
        private DataGridViewTextBoxColumn clnDescricao2;
        private DataGridViewTextBoxColumn clnValorUnit2;
        private DataGridViewTextBoxColumn clnQuantidade2;
        private DataGridViewTextBoxColumn clnDesconto2;
        private DataGridViewTextBoxColumn clnTotal2;
        private RadioButton btnPorcentagem;
        private RadioButton btnReal;
        private Label label1;
        private Button btnConsultaCliente;
        private Button btnInserePedido;
        private PictureBox pictureBox1;
        private Label lblDescricao;
        private Label label6;
        private Label lblQuantidade;
        private Label lblValorUnit;
        private Label lblTotal;
        private TextBox txtTotalPedido;
        private TextBox txtSubTotal;
        private Button btnFechar;
        private TextBox txtTotal;
        private TextBox txtDescontoPedido;
        private TextBox txtDescontoItem;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private DataGridView dgvItensPedido;
        private TextBox txtValorDesconto;
        //private TextBox txtDesconto;
    }
}