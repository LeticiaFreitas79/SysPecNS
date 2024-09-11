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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedidoNovo));
            grbIdentificacao = new GroupBox();
            btnInserePedido = new Button();
            txtIdCliente = new TextBox();
            label1 = new Label();
            textBox3 = new TextBox();
            txtUsuario = new TextBox();
            lblUsuario = new Label();
            grbItens = new GroupBox();
            txtDesconto = new TextBox();
            txtValorUnit = new TextBox();
            txtQuantidade = new TextBox();
            txtDescricao = new TextBox();
            txtCodBar = new TextBox();
            dgvItensPedido = new DataGridView();
            clnSeq = new DataGridViewTextBoxColumn();
            clnCodBar = new DataGridViewTextBoxColumn();
            clnDescricao = new DataGridViewTextBoxColumn();
            clnValorUnit = new DataGridViewTextBoxColumn();
            clnQuantidade = new DataGridViewTextBoxColumn();
            clnDescontoItem = new DataGridViewTextBoxColumn();
            clnTotalItem = new DataGridViewTextBoxColumn();
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
            grbIdentificacao.SuspendLayout();
            grbItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItensPedido).BeginInit();
            SuspendLayout();
            // 
            // grbIdentificacao
            // 
            grbIdentificacao.Controls.Add(btnInserePedido);
            grbIdentificacao.Controls.Add(txtIdCliente);
            grbIdentificacao.Controls.Add(label1);
            grbIdentificacao.Controls.Add(textBox3);
            grbIdentificacao.Controls.Add(txtUsuario);
            grbIdentificacao.Controls.Add(lblUsuario);
            grbIdentificacao.Font = new Font("Geometr212 BkCn BT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbIdentificacao.Location = new Point(23, 66);
            grbIdentificacao.Name = "grbIdentificacao";
            grbIdentificacao.Size = new Size(453, 171);
            grbIdentificacao.TabIndex = 2;
            grbIdentificacao.TabStop = false;
            grbIdentificacao.Text = "Identificação";
            // 
            // btnInserePedido
            // 
            btnInserePedido.Font = new Font("Geometr212 BkCn BT", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInserePedido.Location = new Point(353, 119);
            btnInserePedido.Name = "btnInserePedido";
            btnInserePedido.Size = new Size(66, 31);
            btnInserePedido.TabIndex = 5;
            btnInserePedido.Text = "Abrir";
            btnInserePedido.UseVisualStyleBackColor = true;
            btnInserePedido.Click += btnInserePedido_Click;
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(30, 119);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(80, 31);
            txtIdCliente.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Geometr212 BkCn BT", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 98);
            label1.Name = "label1";
            label1.Size = new Size(50, 16);
            label1.TabIndex = 3;
            label1.Text = "Cliente";
            label1.Click += label1_Click_1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(113, 119);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(234, 31);
            textBox3.TabIndex = 2;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(30, 54);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(389, 31);
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
            grbItens.Controls.Add(txtDesconto);
            grbItens.Controls.Add(txtValorUnit);
            grbItens.Controls.Add(txtQuantidade);
            grbItens.Controls.Add(txtDescricao);
            grbItens.Controls.Add(txtCodBar);
            grbItens.Controls.Add(dgvItensPedido);
            grbItens.Controls.Add(label6);
            grbItens.Controls.Add(lblQuantidade);
            grbItens.Controls.Add(lblValorUnit);
            grbItens.Controls.Add(lblDescricao);
            grbItens.Controls.Add(lblCodBar);
            grbItens.Controls.Add(btnAdicionar);
            grbItens.Font = new Font("Geometr212 BkCn BT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbItens.Location = new Point(23, 253);
            grbItens.Name = "grbItens";
            grbItens.Size = new Size(754, 379);
            grbItens.TabIndex = 1;
            grbItens.TabStop = false;
            grbItens.Text = "Itens do Pedido";
            // 
            // txtDesconto
            // 
            txtDesconto.Font = new Font("Geometr212 BkCn BT", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDesconto.Location = new Point(534, 69);
            txtDesconto.Name = "txtDesconto";
            txtDesconto.Size = new Size(80, 24);
            txtDesconto.TabIndex = 5;
            txtDesconto.Text = "0";
            // 
            // txtValorUnit
            // 
            txtValorUnit.Location = new Point(362, 69);
            txtValorUnit.Name = "txtValorUnit";
            txtValorUnit.Size = new Size(80, 31);
            txtValorUnit.TabIndex = 4;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(448, 69);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(80, 31);
            txtQuantidade.TabIndex = 3;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(141, 69);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(215, 31);
            txtDescricao.TabIndex = 2;
            // 
            // txtCodBar
            // 
            txtCodBar.Location = new Point(20, 69);
            txtCodBar.Name = "txtCodBar";
            txtCodBar.Size = new Size(115, 31);
            txtCodBar.TabIndex = 1;
            txtCodBar.Leave += txtCodBar_Leave;
            // 
            // dgvItensPedido
            // 
            dgvItensPedido.AllowUserToAddRows = false;
            dgvItensPedido.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new Font("Microsoft Tai Le", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvItensPedido.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvItensPedido.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvItensPedido.BackgroundColor = Color.LightSteelBlue;
            dgvItensPedido.BorderStyle = BorderStyle.None;
            dgvItensPedido.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvItensPedido.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dgvItensPedido.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvItensPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItensPedido.Columns.AddRange(new DataGridViewColumn[] { clnSeq, clnCodBar, clnDescricao, clnValorUnit, clnQuantidade, clnDescontoItem, clnTotalItem });
            dgvItensPedido.Cursor = Cursors.Hand;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Geometr212 BkCn BT", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvItensPedido.DefaultCellStyle = dataGridViewCellStyle3;
            dgvItensPedido.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvItensPedido.GridColor = Color.Gainsboro;
            dgvItensPedido.ImeMode = ImeMode.NoControl;
            dgvItensPedido.Location = new Point(20, 109);
            dgvItensPedido.Name = "dgvItensPedido";
            dgvItensPedido.ReadOnly = true;
            dgvItensPedido.Size = new Size(708, 247);
            dgvItensPedido.TabIndex = 11;
            // 
            // clnSeq
            // 
            clnSeq.FillWeight = 20F;
            clnSeq.Frozen = true;
            clnSeq.HeaderText = "#SEQ";
            clnSeq.Name = "clnSeq";
            clnSeq.ReadOnly = true;
            clnSeq.Width = 90;
            // 
            // clnCodBar
            // 
            clnCodBar.Frozen = true;
            clnCodBar.HeaderText = "Cód. Barras";
            clnCodBar.Name = "clnCodBar";
            clnCodBar.ReadOnly = true;
            clnCodBar.Width = 130;
            // 
            // clnDescricao
            // 
            clnDescricao.Frozen = true;
            clnDescricao.HeaderText = "Descrição";
            clnDescricao.Name = "clnDescricao";
            clnDescricao.ReadOnly = true;
            clnDescricao.Width = 127;
            // 
            // clnValorUnit
            // 
            clnValorUnit.HeaderText = "Valor Unit.";
            clnValorUnit.Name = "clnValorUnit";
            clnValorUnit.ReadOnly = true;
            clnValorUnit.Width = 122;
            // 
            // clnQuantidade
            // 
            clnQuantidade.HeaderText = "Quantidade";
            clnQuantidade.Name = "clnQuantidade";
            clnQuantidade.ReadOnly = true;
            clnQuantidade.Width = 138;
            // 
            // clnDescontoItem
            // 
            clnDescontoItem.HeaderText = "Desconto Item";
            clnDescontoItem.Name = "clnDescontoItem";
            clnDescontoItem.ReadOnly = true;
            clnDescontoItem.Width = 155;
            // 
            // clnTotalItem
            // 
            dataGridViewCellStyle2.Font = new Font("MS Outlook", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 2);
            clnTotalItem.DefaultCellStyle = dataGridViewCellStyle2;
            clnTotalItem.HeaderText = "Total";
            clnTotalItem.Name = "clnTotalItem";
            clnTotalItem.ReadOnly = true;
            clnTotalItem.Width = 82;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Geometr212 BkCn BT", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(534, 52);
            label6.Name = "label6";
            label6.Size = new Size(57, 14);
            label6.TabIndex = 10;
            label6.Text = "Desconto";
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Font = new Font("Geometr212 BkCn BT", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuantidade.Location = new Point(448, 52);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(42, 14);
            lblQuantidade.TabIndex = 9;
            lblQuantidade.Text = "Quant.";
            // 
            // lblValorUnit
            // 
            lblValorUnit.AutoSize = true;
            lblValorUnit.Font = new Font("Geometr212 BkCn BT", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblValorUnit.Location = new Point(362, 52);
            lblValorUnit.Name = "lblValorUnit";
            lblValorUnit.Size = new Size(63, 14);
            lblValorUnit.TabIndex = 8;
            lblValorUnit.Text = "Valor Unit.";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Font = new Font("Geometr212 BkCn BT", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescricao.Location = new Point(141, 52);
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
            lblCodBar.Location = new Point(20, 52);
            lblCodBar.Name = "lblCodBar";
            lblCodBar.Size = new Size(96, 14);
            lblCodBar.TabIndex = 6;
            lblCodBar.Text = "Código de Barras";
            lblCodBar.Click += label2_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Font = new Font("Geometr212 BkCn BT", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdicionar.Location = new Point(620, 52);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(108, 51);
            btnAdicionar.TabIndex = 0;
            btnAdicionar.Text = "Adicionar Produto";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Geometr212 BkCn BT", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(564, 645);
            label10.Name = "label10";
            label10.Size = new Size(34, 14);
            label10.TabIndex = 22;
            label10.Text = "Total";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Geometr212 BkCn BT", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(445, 645);
            label9.Name = "label9";
            label9.Size = new Size(57, 14);
            label9.TabIndex = 21;
            label9.Text = "Desconto";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Geometr212 BkCn BT", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(326, 645);
            label8.Name = "label8";
            label8.Size = new Size(87, 14);
            label8.TabIndex = 20;
            label8.Text = "Desconto Itens";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Geometr212 BkCn BT", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(207, 645);
            label7.Name = "label7";
            label7.Size = new Size(58, 14);
            label7.TabIndex = 19;
            label7.Text = "Sub Total";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(564, 661);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(105, 23);
            txtTotal.TabIndex = 18;
            txtTotal.TextChanged += textBox6_TextChanged;
            // 
            // txtDescontoPedido
            // 
            txtDescontoPedido.Location = new Point(445, 662);
            txtDescontoPedido.Name = "txtDescontoPedido";
            txtDescontoPedido.Size = new Size(105, 23);
            txtDescontoPedido.TabIndex = 17;
            // 
            // txtDescontoItem
            // 
            txtDescontoItem.Location = new Point(326, 662);
            txtDescontoItem.Name = "txtDescontoItem";
            txtDescontoItem.ReadOnly = true;
            txtDescontoItem.Size = new Size(105, 23);
            txtDescontoItem.TabIndex = 16;
            // 
            // txtSubTotal
            // 
            txtSubTotal.Location = new Point(207, 662);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.ReadOnly = true;
            txtSubTotal.Size = new Size(105, 23);
            txtSubTotal.TabIndex = 15;
            // 
            // btnFechar
            // 
            btnFechar.Font = new Font("Geometr212 BkCn BT", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFechar.Location = new Point(676, 661);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(75, 32);
            btnFechar.TabIndex = 14;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            // 
            // txtTotalPedido
            // 
            txtTotalPedido.Location = new Point(43, 662);
            txtTotalPedido.Name = "txtTotalPedido";
            txtTotalPedido.ReadOnly = true;
            txtTotalPedido.Size = new Size(150, 23);
            txtTotalPedido.TabIndex = 13;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Geometr212 BkCn BT", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(43, 645);
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
            txtIdPedido.Location = new Point(376, 18);
            txtIdPedido.Name = "txtIdPedido";
            txtIdPedido.Size = new Size(100, 23);
            txtIdPedido.TabIndex = 3;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Geometr212 BkCn BT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumero.Location = new Point(301, 20);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(69, 19);
            lblNumero.TabIndex = 4;
            lblNumero.Text = "Número:";
            // 
            // FrmPedidoNovo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(802, 709);
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
        private Label label1;
        private Button btnInserePedido;
        private TextBox txtIdCliente;
        private Button btnAdicionar;
        private TextBox txtQuantidade;
        private TextBox txtDescricao;
        private TextBox txtCodBar;
        private TextBox txtValorUnit;
        private Label lblCodBar;
        private TextBox txtDesconto;
        private Label lblDescricao;
        private Label label6;
        private Label lblQuantidade;
        private Label lblValorUnit;
        private DataGridView dgvItensPedido;
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
        private DataGridViewTextBoxColumn clnSeq;
        private DataGridViewTextBoxColumn clnCodBar;
        private DataGridViewTextBoxColumn clnDescricao;
        private DataGridViewTextBoxColumn clnValorUnit;
        private DataGridViewTextBoxColumn clnQuantidade;
        private DataGridViewTextBoxColumn clnDescontoItem;
        private DataGridViewTextBoxColumn clnTotalItem;
    }
}