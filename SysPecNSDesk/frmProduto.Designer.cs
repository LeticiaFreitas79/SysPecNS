namespace SysPecNSDesk
{
    partial class FrmProduto
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
            txtId = new TextBox();
            txtCodBar = new TextBox();
            txtValorUnit = new TextBox();
            txtUnidadeVenda = new TextBox();
            txtDescricao = new TextBox();
            txtDesconto = new TextBox();
            cmbCategoria = new ComboBox();
            btnAdicionar = new Button();
            btnEditar = new Button();
            btnConsultar = new Button();
            dgvProdutos = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnCodBar = new DataGridViewTextBoxColumn();
            clnDescricao = new DataGridViewTextBoxColumn();
            clnValorUnit = new DataGridViewTextBoxColumn();
            clnUnidadeVenda = new DataGridViewTextBoxColumn();
            clnCategoria = new DataGridViewTextBoxColumn();
            clnEstoqueMinimo = new DataGridViewTextBoxColumn();
            clnDesconto = new DataGridViewTextBoxColumn();
            clnDataCad = new DataGridViewTextBoxColumn();
            lblId = new Label();
            lblCodBar = new Label();
            lblValorUnit = new Label();
            lblUnidadeVenda = new Label();
            lblEstoqueMinimo = new Label();
            lblDescricao = new Label();
            lblCategoria = new Label();
            lblDesconto = new Label();
            lblProdutos = new Label();
            nudEstoqueMinimo = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudEstoqueMinimo).BeginInit();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(54, 107);
            txtId.Name = "txtId";
            txtId.Size = new Size(58, 23);
            txtId.TabIndex = 0;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // txtCodBar
            // 
            txtCodBar.Location = new Point(118, 107);
            txtCodBar.Name = "txtCodBar";
            txtCodBar.Size = new Size(126, 23);
            txtCodBar.TabIndex = 0;
            // 
            // txtValorUnit
            // 
            txtValorUnit.Location = new Point(54, 167);
            txtValorUnit.Name = "txtValorUnit";
            txtValorUnit.Size = new Size(126, 23);
            txtValorUnit.TabIndex = 1;
            // 
            // txtUnidadeVenda
            // 
            txtUnidadeVenda.Location = new Point(186, 167);
            txtUnidadeVenda.Name = "txtUnidadeVenda";
            txtUnidadeVenda.Size = new Size(127, 23);
            txtUnidadeVenda.TabIndex = 2;
            txtUnidadeVenda.Text = "Ex.: Caixa";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(55, 224);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(365, 23);
            txtDescricao.TabIndex = 4;
            // 
            // txtDesconto
            // 
            txtDesconto.Location = new Point(55, 330);
            txtDesconto.Name = "txtDesconto";
            txtDesconto.Size = new Size(148, 23);
            txtDesconto.TabIndex = 6;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(55, 280);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(365, 23);
            cmbCategoria.TabIndex = 5;
            cmbCategoria.SelectedIndexChanged += cmbCategoria_SelectedIndexChanged;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(55, 411);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(81, 38);
            btnAdicionar.TabIndex = 7;
            btnAdicionar.Text = "&Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(197, 411);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(81, 38);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(339, 411);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(81, 38);
            btnConsultar.TabIndex = 9;
            btnConsultar.Text = "&Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // dgvProdutos
            // 
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Columns.AddRange(new DataGridViewColumn[] { clnId, clnCodBar, clnDescricao, clnValorUnit, clnUnidadeVenda, clnCategoria, clnEstoqueMinimo, clnDesconto, clnDataCad });
            dgvProdutos.Location = new Point(54, 473);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.Size = new Size(794, 150);
            dgvProdutos.TabIndex = 11;
            dgvProdutos.CellContentClick += dataGridView1_CellContentClick;
            // 
            // clnId
            // 
            clnId.Frozen = true;
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            clnId.Width = 50;
            // 
            // clnCodBar
            // 
            clnCodBar.Frozen = true;
            clnCodBar.HeaderText = "Código de Barras";
            clnCodBar.Name = "clnCodBar";
            clnCodBar.ReadOnly = true;
            // 
            // clnDescricao
            // 
            clnDescricao.Frozen = true;
            clnDescricao.HeaderText = "Descrição";
            clnDescricao.Name = "clnDescricao";
            clnDescricao.ReadOnly = true;
            // 
            // clnValorUnit
            // 
            clnValorUnit.Frozen = true;
            clnValorUnit.HeaderText = "Valor Unitário";
            clnValorUnit.Name = "clnValorUnit";
            clnValorUnit.ReadOnly = true;
            clnValorUnit.Width = 80;
            // 
            // clnUnidadeVenda
            // 
            clnUnidadeVenda.Frozen = true;
            clnUnidadeVenda.HeaderText = "Unidade de Venda";
            clnUnidadeVenda.Name = "clnUnidadeVenda";
            clnUnidadeVenda.ReadOnly = true;
            clnUnidadeVenda.Width = 80;
            // 
            // clnCategoria
            // 
            clnCategoria.Frozen = true;
            clnCategoria.HeaderText = "Categoria";
            clnCategoria.Name = "clnCategoria";
            clnCategoria.ReadOnly = true;
            // 
            // clnEstoqueMinimo
            // 
            clnEstoqueMinimo.Frozen = true;
            clnEstoqueMinimo.HeaderText = "Estoque Mínimo";
            clnEstoqueMinimo.Name = "clnEstoqueMinimo";
            clnEstoqueMinimo.ReadOnly = true;
            clnEstoqueMinimo.Width = 80;
            // 
            // clnDesconto
            // 
            clnDesconto.Frozen = true;
            clnDesconto.HeaderText = "Desconto";
            clnDesconto.Name = "clnDesconto";
            clnDesconto.ReadOnly = true;
            clnDesconto.Width = 80;
            // 
            // clnDataCad
            // 
            clnDataCad.Frozen = true;
            clnDataCad.HeaderText = "Data Cadastro";
            clnDataCad.Name = "clnDataCad";
            clnDataCad.ReadOnly = true;
            clnDataCad.Width = 80;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(54, 89);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 12;
            lblId.Text = "ID";
            lblId.Click += label1_Click;
            // 
            // lblCodBar
            // 
            lblCodBar.AutoSize = true;
            lblCodBar.Location = new Point(127, 89);
            lblCodBar.Name = "lblCodBar";
            lblCodBar.Size = new Size(97, 15);
            lblCodBar.TabIndex = 13;
            lblCodBar.Text = "Código de Barras";
            // 
            // lblValorUnit
            // 
            lblValorUnit.AutoSize = true;
            lblValorUnit.Location = new Point(55, 149);
            lblValorUnit.Name = "lblValorUnit";
            lblValorUnit.Size = new Size(78, 15);
            lblValorUnit.TabIndex = 14;
            lblValorUnit.Text = "Valor Unitário";
            // 
            // lblUnidadeVenda
            // 
            lblUnidadeVenda.AutoSize = true;
            lblUnidadeVenda.Location = new Point(186, 149);
            lblUnidadeVenda.Name = "lblUnidadeVenda";
            lblUnidadeVenda.Size = new Size(102, 15);
            lblUnidadeVenda.TabIndex = 15;
            lblUnidadeVenda.Text = "Unidade de Venda";
            // 
            // lblEstoqueMinimo
            // 
            lblEstoqueMinimo.AutoSize = true;
            lblEstoqueMinimo.Location = new Point(319, 149);
            lblEstoqueMinimo.Name = "lblEstoqueMinimo";
            lblEstoqueMinimo.Size = new Size(94, 15);
            lblEstoqueMinimo.TabIndex = 16;
            lblEstoqueMinimo.Text = "Estoque Mínimo";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            lblDescricao.Location = new Point(55, 206);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(58, 15);
            lblDescricao.TabIndex = 17;
            lblDescricao.Text = "Descrição";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(55, 262);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(58, 15);
            lblCategoria.TabIndex = 18;
            lblCategoria.Text = "Categoria";
            // 
            // lblDesconto
            // 
            lblDesconto.AutoSize = true;
            lblDesconto.Location = new Point(56, 312);
            lblDesconto.Name = "lblDesconto";
            lblDesconto.Size = new Size(57, 15);
            lblDesconto.TabIndex = 19;
            lblDesconto.Text = "Desconto";
            // 
            // lblProdutos
            // 
            lblProdutos.AutoSize = true;
            lblProdutos.Font = new Font("Geometr706 BlkCn BT", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProdutos.Location = new Point(49, 25);
            lblProdutos.Name = "lblProdutos";
            lblProdutos.Size = new Size(122, 32);
            lblProdutos.TabIndex = 20;
            lblProdutos.Text = "PRODUTOS";
            // 
            // nudEstoqueMinimo
            // 
            nudEstoqueMinimo.Location = new Point(319, 167);
            nudEstoqueMinimo.Name = "nudEstoqueMinimo";
            nudEstoqueMinimo.Size = new Size(120, 23);
            nudEstoqueMinimo.TabIndex = 21;
            // 
            // FrmProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 661);
            Controls.Add(nudEstoqueMinimo);
            Controls.Add(btnConsultar);
            Controls.Add(btnEditar);
            Controls.Add(btnAdicionar);
            Controls.Add(lblDesconto);
            Controls.Add(lblCategoria);
            Controls.Add(lblDescricao);
            Controls.Add(lblEstoqueMinimo);
            Controls.Add(lblUnidadeVenda);
            Controls.Add(lblValorUnit);
            Controls.Add(lblCodBar);
            Controls.Add(lblId);
            Controls.Add(dgvProdutos);
            Controls.Add(cmbCategoria);
            Controls.Add(txtDesconto);
            Controls.Add(txtDescricao);
            Controls.Add(txtUnidadeVenda);
            Controls.Add(txtValorUnit);
            Controls.Add(txtCodBar);
            Controls.Add(txtId);
            Controls.Add(lblProdutos);
            Name = "FrmProduto";
            Text = "frmProduto";
            Load += FrmProduto_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudEstoqueMinimo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private TextBox txtCodBar;
        private TextBox txtValorUnit;
        private TextBox txtUnidadeVenda;
        private TextBox txtDescricao;
        private TextBox txtDesconto;
        private ComboBox cmbCategoria;
        private Button btnAdicionar;
        private Button btnEditar;
        private Button btnConsultar;
        private DataGridView dgvProdutos;
        private Label lblId;
        private Label lblCodBar;
        private Label lblValorUnit;
        private Label lblUnidadeVenda;
        private Label lblEstoqueMinimo;
        private Label lblDescricao;
        private Label lblCategoria;
        private Label lblDesconto;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnCodBar;
        private DataGridViewTextBoxColumn clnDescricao;
        private DataGridViewTextBoxColumn clnValorUnit;
        private DataGridViewTextBoxColumn clnUnidadeVenda;
        private DataGridViewTextBoxColumn clnCategoria;
        private DataGridViewTextBoxColumn clnEstoqueMinimo;
        private DataGridViewTextBoxColumn clnDesconto;
        private DataGridViewTextBoxColumn clnDataCad;
        private Label lblProdutos;
        private NumericUpDown nudEstoqueMinimo;
    }
}