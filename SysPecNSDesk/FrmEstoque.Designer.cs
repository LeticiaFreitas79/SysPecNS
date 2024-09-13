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
            grpProdutoEstoque = new GroupBox();
            txtId = new TextBox();
            txtCodBar = new TextBox();
            Nome = new TextBox();
            txtDescricao = new TextBox();
            cmbCategoria = new ComboBox();
            dudQuantidade = new DomainUpDown();
            dudEstoqueMin = new DomainUpDown();
            dtpUltimaMov = new DateTimePicker();
            lblId = new Label();
            lblCodBar = new Label();
            lblNome = new Label();
            lblDescricao = new Label();
            lblCategoria = new Label();
            lblQuantidade = new Label();
            lblEstoqueMin = new Label();
            lblUltimaMov = new Label();
            clnId = new DataGridViewTextBoxColumn();
            clnCodBar = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnDescricao = new DataGridViewTextBoxColumn();
            clnCategoria = new DataGridViewTextBoxColumn();
            clnQuantidade = new DataGridViewTextBoxColumn();
            clnEstoqueMin = new DataGridViewTextBoxColumn();
            clnUltimaMovimentacao = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvEstoqueProdutos).BeginInit();
            grpProdutoEstoque.SuspendLayout();
            SuspendLayout();
            // 
            // dgvEstoqueProdutos
            // 
            dgvEstoqueProdutos.AllowUserToAddRows = false;
            dgvEstoqueProdutos.AllowUserToDeleteRows = false;
            dgvEstoqueProdutos.BackgroundColor = SystemColors.ActiveCaption;
            dgvEstoqueProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstoqueProdutos.Columns.AddRange(new DataGridViewColumn[] { clnId, clnCodBar, clnNome, clnDescricao, clnCategoria, clnQuantidade, clnEstoqueMin, clnUltimaMovimentacao });
            dgvEstoqueProdutos.Location = new Point(33, 32);
            dgvEstoqueProdutos.Name = "dgvEstoqueProdutos";
            dgvEstoqueProdutos.ReadOnly = true;
            dgvEstoqueProdutos.RowHeadersVisible = false;
            dgvEstoqueProdutos.Size = new Size(718, 150);
            dgvEstoqueProdutos.TabIndex = 0;
            // 
            // grpProdutoEstoque
            // 
            grpProdutoEstoque.Controls.Add(lblUltimaMov);
            grpProdutoEstoque.Controls.Add(lblEstoqueMin);
            grpProdutoEstoque.Controls.Add(lblQuantidade);
            grpProdutoEstoque.Controls.Add(lblCategoria);
            grpProdutoEstoque.Controls.Add(lblDescricao);
            grpProdutoEstoque.Controls.Add(lblNome);
            grpProdutoEstoque.Controls.Add(lblCodBar);
            grpProdutoEstoque.Controls.Add(lblId);
            grpProdutoEstoque.Controls.Add(dtpUltimaMov);
            grpProdutoEstoque.Controls.Add(dudEstoqueMin);
            grpProdutoEstoque.Controls.Add(dudQuantidade);
            grpProdutoEstoque.Controls.Add(cmbCategoria);
            grpProdutoEstoque.Controls.Add(txtDescricao);
            grpProdutoEstoque.Controls.Add(Nome);
            grpProdutoEstoque.Controls.Add(txtCodBar);
            grpProdutoEstoque.Controls.Add(txtId);
            grpProdutoEstoque.Font = new Font("Geometr415 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpProdutoEstoque.Location = new Point(33, 225);
            grpProdutoEstoque.Name = "grpProdutoEstoque";
            grpProdutoEstoque.Size = new Size(718, 250);
            grpProdutoEstoque.TabIndex = 1;
            grpProdutoEstoque.TabStop = false;
            grpProdutoEstoque.Text = "Produto em Estoque";
            // 
            // txtId
            // 
            txtId.Font = new Font("Geometr212 BkCn BT", 9.75F);
            txtId.Location = new Point(37, 50);
            txtId.Name = "txtId";
            txtId.Size = new Size(65, 24);
            txtId.TabIndex = 0;
            // 
            // txtCodBar
            // 
            txtCodBar.Font = new Font("Geometr212 BkCn BT", 9.75F);
            txtCodBar.Location = new Point(123, 50);
            txtCodBar.Name = "txtCodBar";
            txtCodBar.Size = new Size(157, 24);
            txtCodBar.TabIndex = 1;
            // 
            // Nome
            // 
            Nome.Font = new Font("Geometr212 BkCn BT", 9.75F);
            Nome.Location = new Point(302, 50);
            Nome.Name = "Nome";
            Nome.Size = new Size(394, 24);
            Nome.TabIndex = 2;
            // 
            // txtDescricao
            // 
            txtDescricao.Font = new Font("Geometr212 BkCn BT", 9.75F);
            txtDescricao.Location = new Point(37, 122);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(421, 24);
            txtDescricao.TabIndex = 3;
            // 
            // cmbCategoria
            // 
            cmbCategoria.Font = new Font("Geometr212 BkCn BT", 9.75F);
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(477, 122);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(219, 24);
            cmbCategoria.TabIndex = 4;
            // 
            // dudQuantidade
            // 
            dudQuantidade.Font = new Font("Geometr212 BkCn BT", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dudQuantidade.Location = new Point(38, 201);
            dudQuantidade.Name = "dudQuantidade";
            dudQuantidade.Size = new Size(120, 24);
            dudQuantidade.TabIndex = 5;
            // 
            // dudEstoqueMin
            // 
            dudEstoqueMin.Font = new Font("Geometr212 BkCn BT", 9.75F);
            dudEstoqueMin.Location = new Point(183, 201);
            dudEstoqueMin.Name = "dudEstoqueMin";
            dudEstoqueMin.Size = new Size(120, 24);
            dudEstoqueMin.TabIndex = 6;
            // 
            // dtpUltimaMov
            // 
            dtpUltimaMov.Font = new Font("Geometr212 BkCn BT", 9.75F);
            dtpUltimaMov.Location = new Point(400, 201);
            dtpUltimaMov.Name = "dtpUltimaMov";
            dtpUltimaMov.Size = new Size(296, 24);
            dtpUltimaMov.TabIndex = 7;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Geometr212 BkCn BT", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblId.Location = new Point(37, 32);
            lblId.Name = "lblId";
            lblId.Size = new Size(23, 16);
            lblId.TabIndex = 8;
            lblId.Text = "ID";
            // 
            // lblCodBar
            // 
            lblCodBar.AutoSize = true;
            lblCodBar.Font = new Font("Geometr212 BkCn BT", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCodBar.Location = new Point(123, 32);
            lblCodBar.Name = "lblCodBar";
            lblCodBar.Size = new Size(82, 16);
            lblCodBar.TabIndex = 9;
            lblCodBar.Text = "Cód. Barras";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Geometr212 BkCn BT", 9.75F);
            lblNome.Location = new Point(302, 32);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(115, 16);
            lblNome.TabIndex = 10;
            lblNome.Text = "Nome do Produto";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Font = new Font("Geometr212 BkCn BT", 9.75F);
            lblDescricao.Location = new Point(39, 106);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(70, 16);
            lblDescricao.TabIndex = 11;
            lblDescricao.Text = "Descrição";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Geometr212 BkCn BT", 9.75F);
            lblCategoria.Location = new Point(477, 103);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(67, 16);
            lblCategoria.TabIndex = 12;
            lblCategoria.Text = "Categoria";
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Font = new Font("Geometr212 BkCn BT", 9.75F);
            lblQuantidade.Location = new Point(39, 183);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(80, 16);
            lblQuantidade.TabIndex = 13;
            lblQuantidade.Text = "Quantidade";
            // 
            // lblEstoqueMin
            // 
            lblEstoqueMin.AutoSize = true;
            lblEstoqueMin.Font = new Font("Geometr212 BkCn BT", 9.75F);
            lblEstoqueMin.Location = new Point(182, 182);
            lblEstoqueMin.Name = "lblEstoqueMin";
            lblEstoqueMin.Size = new Size(110, 16);
            lblEstoqueMin.TabIndex = 14;
            lblEstoqueMin.Text = "Estoque Minímo";
            // 
            // lblUltimaMov
            // 
            lblUltimaMov.AutoSize = true;
            lblUltimaMov.Font = new Font("Geometr212 BkCn BT", 9.75F);
            lblUltimaMov.Location = new Point(400, 182);
            lblUltimaMov.Name = "lblUltimaMov";
            lblUltimaMov.Size = new Size(143, 16);
            lblUltimaMov.TabIndex = 15;
            lblUltimaMov.Text = "última Movimentação";
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
            // 
            // clnDescricao
            // 
            clnDescricao.Frozen = true;
            clnDescricao.HeaderText = "Descrição";
            clnDescricao.Name = "clnDescricao";
            clnDescricao.ReadOnly = true;
            clnDescricao.Width = 120;
            // 
            // clnCategoria
            // 
            clnCategoria.Frozen = true;
            clnCategoria.HeaderText = "Categoria";
            clnCategoria.Name = "clnCategoria";
            clnCategoria.ReadOnly = true;
            // 
            // clnQuantidade
            // 
            clnQuantidade.Frozen = true;
            clnQuantidade.HeaderText = "Quantidade";
            clnQuantidade.Name = "clnQuantidade";
            clnQuantidade.ReadOnly = true;
            clnQuantidade.Width = 80;
            // 
            // clnEstoqueMin
            // 
            clnEstoqueMin.Frozen = true;
            clnEstoqueMin.HeaderText = "Estoque Mínimo";
            clnEstoqueMin.Name = "clnEstoqueMin";
            clnEstoqueMin.ReadOnly = true;
            clnEstoqueMin.Width = 80;
            // 
            // clnUltimaMovimentacao
            // 
            clnUltimaMovimentacao.Frozen = true;
            clnUltimaMovimentacao.HeaderText = "Última Movimentação";
            clnUltimaMovimentacao.Name = "clnUltimaMovimentacao";
            clnUltimaMovimentacao.ReadOnly = true;
            clnUltimaMovimentacao.Width = 95;
            // 
            // FrmEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(785, 517);
            Controls.Add(grpProdutoEstoque);
            Controls.Add(dgvEstoqueProdutos);
            Name = "FrmEstoque";
            Text = "FrmEstoque";
            ((System.ComponentModel.ISupportInitialize)dgvEstoqueProdutos).EndInit();
            grpProdutoEstoque.ResumeLayout(false);
            grpProdutoEstoque.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvEstoqueProdutos;
        private GroupBox grpProdutoEstoque;
        private DateTimePicker dtpUltimaMov;
        private DomainUpDown dudEstoqueMin;
        private DomainUpDown dudQuantidade;
        private ComboBox cmbCategoria;
        private TextBox txtDescricao;
        private TextBox Nome;
        private TextBox txtCodBar;
        private TextBox txtId;
        private Label lblUltimaMov;
        private Label lblEstoqueMin;
        private Label lblQuantidade;
        private Label lblCategoria;
        private Label lblDescricao;
        private Label lblNome;
        private Label lblCodBar;
        private Label lblId;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnCodBar;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnDescricao;
        private DataGridViewTextBoxColumn clnCategoria;
        private DataGridViewTextBoxColumn clnQuantidade;
        private DataGridViewTextBoxColumn clnEstoqueMin;
        private DataGridViewTextBoxColumn clnUltimaMovimentacao;
    }
}