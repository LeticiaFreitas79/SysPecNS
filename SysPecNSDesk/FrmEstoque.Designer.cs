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
            btnEntrada = new Button();
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
            btnSaida = new Button();
            btnTroca = new Button();
            btnPerda = new Button();
            btnAtualizar = new Button();
            btnCancelar = new Button();
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
            clnQuantidade.Width = 90;
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
            clnUltimaMovimentacao.Width = 120;
            // 
            // btnEntrada
            // 
            btnEntrada.BackColor = SystemColors.ButtonFace;
            btnEntrada.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrada.ForeColor = SystemColors.ActiveCaptionText;
            btnEntrada.ImageAlign = ContentAlignment.MiddleLeft;
            btnEntrada.Location = new Point(35, 413);
            btnEntrada.Name = "btnEntrada";
            btnEntrada.Size = new Size(118, 35);
            btnEntrada.TabIndex = 2;
            btnEntrada.Text = "Entrada";
            btnEntrada.UseVisualStyleBackColor = false;
            btnEntrada.Click += btnAdicionar_Click;
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
            // btnSaida
            // 
            btnSaida.BackColor = SystemColors.ButtonFace;
            btnSaida.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaida.ImageAlign = ContentAlignment.MiddleLeft;
            btnSaida.Location = new Point(173, 413);
            btnSaida.Name = "btnSaida";
            btnSaida.Size = new Size(118, 35);
            btnSaida.TabIndex = 3;
            btnSaida.Text = "Saída ";
            btnSaida.UseVisualStyleBackColor = false;
            // 
            // btnTroca
            // 
            btnTroca.BackColor = SystemColors.ButtonFace;
            btnTroca.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTroca.ImageAlign = ContentAlignment.MiddleLeft;
            btnTroca.Location = new Point(449, 413);
            btnTroca.Name = "btnTroca";
            btnTroca.Size = new Size(118, 35);
            btnTroca.TabIndex = 4;
            btnTroca.Text = "Troca";
            btnTroca.UseVisualStyleBackColor = false;
            // 
            // btnPerda
            // 
            btnPerda.BackColor = SystemColors.ButtonFace;
            btnPerda.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPerda.ImageAlign = ContentAlignment.MiddleLeft;
            btnPerda.Location = new Point(311, 413);
            btnPerda.Name = "btnPerda";
            btnPerda.Size = new Size(118, 35);
            btnPerda.TabIndex = 5;
            btnPerda.Text = "Perda";
            btnPerda.UseVisualStyleBackColor = false;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(72, 469);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(182, 23);
            btnAtualizar.TabIndex = 6;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(347, 469);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(182, 23);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(1032, 523);
            Controls.Add(btnCancelar);
            Controls.Add(btnAtualizar);
            Controls.Add(btnPerda);
            Controls.Add(btnTroca);
            Controls.Add(btnSaida);
            Controls.Add(btnEntrada);
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
        private Button btnEntrada;
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
        private Button btnSaida;
        private Button btnTroca;
        private Button btnPerda;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnCodBar;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnQuantidade;
        private DataGridViewTextBoxColumn clnEstoqueMin;
        private DataGridViewTextBoxColumn clnUltimaMovimentacao;
        private Button btnAtualizar;
        private Button btnCancelar;
    }
}