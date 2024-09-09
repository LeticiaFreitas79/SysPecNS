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
            groupBox1 = new GroupBox();
            btnInserePedido = new Button();
            txtIdCliente = new TextBox();
            label1 = new Label();
            textBox3 = new TextBox();
            txtUsuario = new TextBox();
            lblUsuario = new Label();
            groupBox2 = new GroupBox();
            lblNovoPedido = new Label();
            txtIdPedido = new TextBox();
            lblNumero = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnInserePedido);
            groupBox1.Controls.Add(txtIdCliente);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Controls.Add(lblUsuario);
            groupBox1.Font = new Font("Geometr212 BkCn BT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(23, 86);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(465, 222);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Identificação";
            // 
            // btnInserePedido
            // 
            btnInserePedido.Font = new Font("Geometr212 BkCn BT", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInserePedido.Location = new Point(368, 105);
            btnInserePedido.Name = "btnInserePedido";
            btnInserePedido.Size = new Size(66, 23);
            btnInserePedido.TabIndex = 5;
            btnInserePedido.Text = "Abrir";
            btnInserePedido.UseVisualStyleBackColor = true;
            btnInserePedido.Click += btnInserePedido_Click;
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(107, 99);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(55, 31);
            txtIdCliente.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Geometr212 BkCn BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(36, 105);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 3;
            label1.Text = "Cliente";
            label1.Click += label1_Click_1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(168, 99);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(194, 31);
            textBox3.TabIndex = 2;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(107, 46);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(327, 31);
            txtUsuario.TabIndex = 1;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Geometr212 BkCn BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(33, 52);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(68, 20);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuário";
            // 
            // groupBox2
            // 
            groupBox2.Font = new Font("Geometr212 BkCn BT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(23, 345);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(465, 248);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Itens do Pedido";
            // 
            // lblNovoPedido
            // 
            lblNovoPedido.AutoSize = true;
            lblNovoPedido.Font = new Font("Geometr212 BkCn BT", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNovoPedido.Location = new Point(23, 22);
            lblNovoPedido.Name = "lblNovoPedido";
            lblNovoPedido.Size = new Size(177, 26);
            lblNovoPedido.TabIndex = 2;
            lblNovoPedido.Text = "NOVO PEDIDO";
            lblNovoPedido.Click += label1_Click;
            // 
            // txtIdPedido
            // 
            txtIdPedido.Location = new Point(340, 25);
            txtIdPedido.Name = "txtIdPedido";
            txtIdPedido.Size = new Size(100, 23);
            txtIdPedido.TabIndex = 3;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Geometr212 BkCn BT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumero.Location = new Point(265, 27);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(69, 19);
            lblNumero.TabIndex = 4;
            lblNumero.Text = "Número:";
            // 
            // FrmPedidoNovo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 629);
            Controls.Add(lblNumero);
            Controls.Add(txtIdPedido);
            Controls.Add(lblNovoPedido);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmPedidoNovo";
            Text = "FrmPedidoNovo";
            Load += FrmPedidoNovo_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label lblNovoPedido;
        private TextBox txtUsuario;
        private Label lblUsuario;
        private TextBox txtIdPedido;
        private Label lblNumero;
        private TextBox textBox3;
        private Label label1;
        private Button btnInserePedido;
        private TextBox txtIdCliente;
    }
}