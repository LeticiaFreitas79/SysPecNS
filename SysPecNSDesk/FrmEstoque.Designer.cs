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
            btnAdicionar = new Button();
            txtId = new TextBox();
            txtCodBar = new TextBox();
            Nome = new TextBox();
            dudQuantidade = new DomainUpDown();
            dudEstoqueMin = new DomainUpDown();
            dtpUltimaMov = new DateTimePicker();
            lblId = new Label();
            lblCodBar = new Label();
            lblNome = new Label();
            lblQuantidade = new Label();
            lblEstoqueMin = new Label();
            lblUltimaMov = new Label();
            grpProdutoEstoque = new GroupBox();
            clnId = new DataGridViewTextBoxColumn();
            clnCodBar = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnQuantidade = new DataGridViewTextBoxColumn();
            clnEstoqueMin = new DataGridViewTextBoxColumn();
            clnUltimaMovimentacao = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
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
            dgvEstoqueProdutos.Columns.AddRange(new DataGridViewColumn[] { clnId, clnCodBar, clnNome, clnQuantidade, clnEstoqueMin, clnUltimaMovimentacao });
            dgvEstoqueProdutos.Location = new Point(33, 32);
            dgvEstoqueProdutos.Name = "dgvEstoqueProdutos";
            dgvEstoqueProdutos.ReadOnly = true;
            dgvEstoqueProdutos.RowHeadersVisible = false;
            dgvEstoqueProdutos.Size = new Size(534, 150);
            dgvEstoqueProdutos.TabIndex = 0;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(35, 414);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(118, 32);
            btnAdicionar.TabIndex = 2;
            btnAdicionar.Text = "Entrada";
            btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            txtId.Font = new Font("Geometr212 BkCn BT", 9.75F);
            txtId.Location = new Point(17, 50);
            txtId.Name = "txtId";
            txtId.Size = new Size(65, 24);
            txtId.TabIndex = 0;
            // 
            // txtCodBar
            // 
            txtCodBar.Font = new Font("Geometr212 BkCn BT", 9.75F);
            txtCodBar.Location = new Point(88, 50);
            txtCodBar.Name = "txtCodBar";
            txtCodBar.Size = new Size(123, 24);
            txtCodBar.TabIndex = 1;
            // 
            // Nome
            // 
            Nome.Font = new Font("Geometr212 BkCn BT", 9.75F);
            Nome.Location = new Point(217, 51);
            Nome.Name = "Nome";
            Nome.Size = new Size(297, 24);
            Nome.TabIndex = 2;
            // 
            // dudQuantidade
            // 
            dudQuantidade.Font = new Font("Geometr212 BkCn BT", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dudQuantidade.Location = new Point(18, 116);
            dudQuantidade.Name = "dudQuantidade";
            dudQuantidade.Size = new Size(120, 24);
            dudQuantidade.TabIndex = 5;
            // 
            // dudEstoqueMin
            // 
            dudEstoqueMin.Font = new Font("Geometr212 BkCn BT", 9.75F);
            dudEstoqueMin.Location = new Point(152, 116);
            dudEstoqueMin.Name = "dudEstoqueMin";
            dudEstoqueMin.Size = new Size(120, 24);
            dudEstoqueMin.TabIndex = 6;
            // 
            // dtpUltimaMov
            // 
            dtpUltimaMov.Font = new Font("Geometr212 BkCn BT", 9.75F);
            dtpUltimaMov.Location = new Point(282, 116);
            dtpUltimaMov.Name = "dtpUltimaMov";
            dtpUltimaMov.Size = new Size(232, 24);
            dtpUltimaMov.TabIndex = 7;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Geometr212 BkCn BT", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblId.Location = new Point(17, 32);
            lblId.Name = "lblId";
            lblId.Size = new Size(23, 16);
            lblId.TabIndex = 8;
            lblId.Text = "ID";
            // 
            // lblCodBar
            // 
            lblCodBar.AutoSize = true;
            lblCodBar.Font = new Font("Geometr212 BkCn BT", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCodBar.Location = new Point(88, 32);
            lblCodBar.Name = "lblCodBar";
            lblCodBar.Size = new Size(82, 16);
            lblCodBar.TabIndex = 9;
            lblCodBar.Text = "Cód. Barras";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Geometr212 BkCn BT", 9.75F);
            lblNome.Location = new Point(217, 32);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(115, 16);
            lblNome.TabIndex = 10;
            lblNome.Text = "Nome do Produto";
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Font = new Font("Geometr212 BkCn BT", 9.75F);
            lblQuantidade.Location = new Point(17, 98);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(80, 16);
            lblQuantidade.TabIndex = 13;
            lblQuantidade.Text = "Quantidade";
            // 
            // lblEstoqueMin
            // 
            lblEstoqueMin.AutoSize = true;
            lblEstoqueMin.Font = new Font("Geometr212 BkCn BT", 9.75F);
            lblEstoqueMin.Location = new Point(152, 98);
            lblEstoqueMin.Name = "lblEstoqueMin";
            lblEstoqueMin.Size = new Size(110, 16);
            lblEstoqueMin.TabIndex = 14;
            lblEstoqueMin.Text = "Estoque Minímo";
            // 
            // lblUltimaMov
            // 
            lblUltimaMov.AutoSize = true;
            lblUltimaMov.Font = new Font("Geometr212 BkCn BT", 9.75F);
            lblUltimaMov.Location = new Point(282, 97);
            lblUltimaMov.Name = "lblUltimaMov";
            lblUltimaMov.Size = new Size(143, 16);
            lblUltimaMov.TabIndex = 15;
            lblUltimaMov.Text = "última Movimentação";
            // 
            // grpProdutoEstoque
            // 
            grpProdutoEstoque.Controls.Add(lblUltimaMov);
            grpProdutoEstoque.Controls.Add(lblEstoqueMin);
            grpProdutoEstoque.Controls.Add(lblQuantidade);
            grpProdutoEstoque.Controls.Add(lblNome);
            grpProdutoEstoque.Controls.Add(lblCodBar);
            grpProdutoEstoque.Controls.Add(lblId);
            grpProdutoEstoque.Controls.Add(dtpUltimaMov);
            grpProdutoEstoque.Controls.Add(dudEstoqueMin);
            grpProdutoEstoque.Controls.Add(dudQuantidade);
            grpProdutoEstoque.Controls.Add(Nome);
            grpProdutoEstoque.Controls.Add(txtCodBar);
            grpProdutoEstoque.Controls.Add(txtId);
            grpProdutoEstoque.Font = new Font("Geometr415 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpProdutoEstoque.Location = new Point(33, 225);
            grpProdutoEstoque.Name = "grpProdutoEstoque";
            grpProdutoEstoque.Size = new Size(534, 165);
            grpProdutoEstoque.TabIndex = 1;
            grpProdutoEstoque.TabStop = false;
            grpProdutoEstoque.Text = "Atualizar Produto em Estoque";
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
            // button1
            // 
            button1.Location = new Point(173, 414);
            button1.Name = "button1";
            button1.Size = new Size(118, 32);
            button1.TabIndex = 3;
            button1.Text = "Saída ";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(449, 414);
            button2.Name = "button2";
            button2.Size = new Size(118, 32);
            button2.TabIndex = 4;
            button2.Text = "Troca";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(311, 414);
            button3.Name = "button3";
            button3.Size = new Size(118, 32);
            button3.TabIndex = 5;
            button3.Text = "Perda";
            button3.UseVisualStyleBackColor = true;
            // 
            // FrmEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(599, 547);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnAdicionar);
            Controls.Add(grpProdutoEstoque);
            Controls.Add(dgvEstoqueProdutos);
            Name = "FrmEstoque";
            Text = "SysPec | Estoque";
            ((System.ComponentModel.ISupportInitialize)dgvEstoqueProdutos).EndInit();
            grpProdutoEstoque.ResumeLayout(false);
            grpProdutoEstoque.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvEstoqueProdutos;
        private Button btnAdicionar;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnCodBar;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnQuantidade;
        private DataGridViewTextBoxColumn clnEstoqueMin;
        private DataGridViewTextBoxColumn clnUltimaMovimentacao;
        private TextBox txtId;
        private TextBox txtCodBar;
        private TextBox Nome;
        private DomainUpDown dudQuantidade;
        private DomainUpDown dudEstoqueMin;
        private DateTimePicker dtpUltimaMov;
        private Label lblId;
        private Label lblCodBar;
        private Label lblNome;
        private Label lblQuantidade;
        private Label lblEstoqueMin;
        private Label lblUltimaMov;
        private GroupBox grpProdutoEstoque;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}