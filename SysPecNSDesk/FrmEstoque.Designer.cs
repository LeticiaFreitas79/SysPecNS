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
            btnAtualizar = new Button();
            btnCancelar = new Button();
            tabControl1 = new TabControl();
            Entrada = new TabPage();
            Saída = new TabPage();
            Perda = new TabPage();
            Troca = new TabPage();
            clnId = new DataGridViewTextBoxColumn();
            clnCodBar = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnQuantidade = new DataGridViewTextBoxColumn();
            clnEstoqueMin = new DataGridViewTextBoxColumn();
            clnUltimaMovimentacao = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvEstoqueProdutos).BeginInit();
            tabControl1.SuspendLayout();
            Entrada.SuspendLayout();
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
            dgvEstoqueProdutos.Size = new Size(654, 150);
            dgvEstoqueProdutos.TabIndex = 0;
            // 
            // txtId
            // 
            txtId.Font = new Font("Geometr212 BkCn BT", 9.75F);
            txtId.Location = new Point(77, 49);
            txtId.Name = "txtId";
            txtId.Size = new Size(65, 24);
            txtId.TabIndex = 0;
            // 
            // txtCodBar
            // 
            txtCodBar.Font = new Font("Geometr212 BkCn BT", 9.75F);
            txtCodBar.Location = new Point(148, 49);
            txtCodBar.Name = "txtCodBar";
            txtCodBar.Size = new Size(123, 24);
            txtCodBar.TabIndex = 1;
            // 
            // Nome
            // 
            Nome.Font = new Font("Geometr212 BkCn BT", 9.75F);
            Nome.Location = new Point(277, 50);
            Nome.Name = "Nome";
            Nome.Size = new Size(297, 24);
            Nome.TabIndex = 2;
            // 
            // dudQuantidade
            // 
            dudQuantidade.BorderStyle = BorderStyle.FixedSingle;
            dudQuantidade.Font = new Font("Geometr212 BkCn BT", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dudQuantidade.Location = new Point(78, 115);
            dudQuantidade.Name = "dudQuantidade";
            dudQuantidade.Size = new Size(120, 24);
            dudQuantidade.TabIndex = 5;
            dudQuantidade.SelectedItemChanged += dudQuantidade_SelectedItemChanged;
            // 
            // dudEstoqueMin
            // 
            dudEstoqueMin.Font = new Font("Geometr212 BkCn BT", 9.75F);
            dudEstoqueMin.Location = new Point(212, 115);
            dudEstoqueMin.Name = "dudEstoqueMin";
            dudEstoqueMin.Size = new Size(120, 24);
            dudEstoqueMin.TabIndex = 6;
            // 
            // dtpUltimaMov
            // 
            dtpUltimaMov.Font = new Font("Geometr212 BkCn BT", 9.75F);
            dtpUltimaMov.Location = new Point(342, 115);
            dtpUltimaMov.Name = "dtpUltimaMov";
            dtpUltimaMov.Size = new Size(232, 24);
            dtpUltimaMov.TabIndex = 7;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Geometr212 BkCn BT", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblId.Location = new Point(77, 31);
            lblId.Name = "lblId";
            lblId.Size = new Size(23, 16);
            lblId.TabIndex = 8;
            lblId.Text = "ID";
            // 
            // lblCodBar
            // 
            lblCodBar.AutoSize = true;
            lblCodBar.Font = new Font("Geometr212 BkCn BT", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCodBar.Location = new Point(148, 31);
            lblCodBar.Name = "lblCodBar";
            lblCodBar.Size = new Size(82, 16);
            lblCodBar.TabIndex = 9;
            lblCodBar.Text = "Cód. Barras";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Geometr212 BkCn BT", 9.75F);
            lblNome.Location = new Point(277, 31);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(115, 16);
            lblNome.TabIndex = 10;
            lblNome.Text = "Nome do Produto";
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Font = new Font("Geometr212 BkCn BT", 9.75F);
            lblQuantidade.Location = new Point(77, 97);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(80, 16);
            lblQuantidade.TabIndex = 13;
            lblQuantidade.Text = "Quantidade";
            // 
            // lblEstoqueMin
            // 
            lblEstoqueMin.AutoSize = true;
            lblEstoqueMin.Font = new Font("Geometr212 BkCn BT", 9.75F);
            lblEstoqueMin.Location = new Point(212, 97);
            lblEstoqueMin.Name = "lblEstoqueMin";
            lblEstoqueMin.Size = new Size(110, 16);
            lblEstoqueMin.TabIndex = 14;
            lblEstoqueMin.Text = "Estoque Minímo";
            // 
            // lblUltimaMov
            // 
            lblUltimaMov.AutoSize = true;
            lblUltimaMov.Font = new Font("Geometr212 BkCn BT", 9.75F);
            lblUltimaMov.Location = new Point(342, 96);
            lblUltimaMov.Name = "lblUltimaMov";
            lblUltimaMov.Size = new Size(143, 16);
            lblUltimaMov.TabIndex = 15;
            lblUltimaMov.Text = "última Movimentação";
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(140, 173);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(182, 23);
            btnAtualizar.TabIndex = 6;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(355, 173);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(182, 23);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Entrada);
            tabControl1.Controls.Add(Saída);
            tabControl1.Controls.Add(Perda);
            tabControl1.Controls.Add(Troca);
            tabControl1.Location = new Point(33, 221);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(654, 260);
            tabControl1.TabIndex = 8;
            // 
            // Entrada
            // 
            Entrada.BackColor = Color.LightSteelBlue;
            Entrada.Controls.Add(lblUltimaMov);
            Entrada.Controls.Add(btnCancelar);
            Entrada.Controls.Add(btnAtualizar);
            Entrada.Controls.Add(dtpUltimaMov);
            Entrada.Controls.Add(lblEstoqueMin);
            Entrada.Controls.Add(txtId);
            Entrada.Controls.Add(lblQuantidade);
            Entrada.Controls.Add(txtCodBar);
            Entrada.Controls.Add(lblNome);
            Entrada.Controls.Add(Nome);
            Entrada.Controls.Add(lblCodBar);
            Entrada.Controls.Add(dudQuantidade);
            Entrada.Controls.Add(lblId);
            Entrada.Controls.Add(dudEstoqueMin);
            Entrada.Location = new Point(4, 24);
            Entrada.Name = "Entrada";
            Entrada.Padding = new Padding(3);
            Entrada.Size = new Size(646, 232);
            Entrada.TabIndex = 0;
            Entrada.Text = "Entrada";
            // 
            // Saída
            // 
            Saída.BackColor = Color.LightSteelBlue;
            Saída.Location = new Point(4, 24);
            Saída.Name = "Saída";
            Saída.Padding = new Padding(3);
            Saída.Size = new Size(646, 232);
            Saída.TabIndex = 1;
            Saída.Text = "Saída";
            // 
            // Perda
            // 
            Perda.BackColor = Color.LightSteelBlue;
            Perda.Location = new Point(4, 24);
            Perda.Name = "Perda";
            Perda.Padding = new Padding(3);
            Perda.Size = new Size(603, 298);
            Perda.TabIndex = 2;
            Perda.Text = "Perda";
            // 
            // Troca
            // 
            Troca.BackColor = Color.LightSteelBlue;
            Troca.Location = new Point(4, 24);
            Troca.Name = "Troca";
            Troca.Padding = new Padding(3);
            Troca.Size = new Size(603, 298);
            Troca.TabIndex = 3;
            Troca.Text = "Troca";
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
            clnCodBar.HeaderText = "Cód. Barras";
            clnCodBar.Name = "clnCodBar";
            clnCodBar.ReadOnly = true;
            clnCodBar.Width = 120;
            // 
            // clnNome
            // 
            clnNome.Frozen = true;
            clnNome.HeaderText = "Nome";
            clnNome.Name = "clnNome";
            clnNome.ReadOnly = true;
            clnNome.Width = 140;
            // 
            // clnQuantidade
            // 
            clnQuantidade.Frozen = true;
            clnQuantidade.HeaderText = "Quantidade";
            clnQuantidade.Name = "clnQuantidade";
            clnQuantidade.ReadOnly = true;
            // 
            // clnEstoqueMin
            // 
            clnEstoqueMin.Frozen = true;
            clnEstoqueMin.HeaderText = "Estoque Mínimo";
            clnEstoqueMin.Name = "clnEstoqueMin";
            clnEstoqueMin.ReadOnly = true;
            clnEstoqueMin.Width = 110;
            // 
            // clnUltimaMovimentacao
            // 
            clnUltimaMovimentacao.Frozen = true;
            clnUltimaMovimentacao.HeaderText = "Última Movimentação";
            clnUltimaMovimentacao.Name = "clnUltimaMovimentacao";
            clnUltimaMovimentacao.ReadOnly = true;
            clnUltimaMovimentacao.Width = 130;
            // 
            // FrmEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(720, 529);
            Controls.Add(tabControl1);
            Controls.Add(dgvEstoqueProdutos);
            Name = "FrmEstoque";
            Text = "SysPec | Estoque";
            Load += FrmEstoque_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEstoqueProdutos).EndInit();
            tabControl1.ResumeLayout(false);
            Entrada.ResumeLayout(false);
            Entrada.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvEstoqueProdutos;
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
        private Button btnAtualizar;
        private Button btnCancelar;
        private TabControl tabControl1;
        private TabPage Entrada;
        private TabPage Saída;
        private TabPage Perda;
        private TabPage Troca;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnCodBar;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnQuantidade;
        private DataGridViewTextBoxColumn clnEstoqueMin;
        private DataGridViewTextBoxColumn clnUltimaMovimentacao;
    }
}