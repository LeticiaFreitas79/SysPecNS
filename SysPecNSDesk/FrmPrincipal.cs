namespace SysPecNSDesk
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            //Para impedir que o usuário feche a tela de login.
            FrmLogin frmLogin = new();
            //frmLogin.MdiParent = this;
            frmLogin.ShowDialog();
            Text += $"({Program.UsuarioLogado.Email})"; //Junta o que já está no text com as novas informações. Serve para que não seja necessário reescrever.
            toolStripStatusLabel1.Text = $"{Program.UsuarioLogado.Nome} - {Program.UsuarioLogado.Nivel.Nome}";
        }

        private void novoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmUsuario frmUsuario = new();
            frmUsuario.MdiParent = this;
            //Formas de Exibir.
            frmUsuario.Show(); //Apenas mostrar.
                               //frmUsuario.ShowDialog(); //Impede que qualquer outra coisa seja exibida. Serve para executar uma janela em primeiro plano.


        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Confirmação de saída do sistema.
            var msg = MessageBox.Show("Deseja sair?", "Confirmação de saída", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (msg == DialogResult.Yes) Application.Exit(); //As chaves {} não não necessárias quando existe apenas uma instrução.
        }

        private void novoToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            FrmProduto frmProduto = new();
            frmProduto.MdiParent = this;
            //Formas de Exibir.
            frmProduto.Show();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFornecedor frmFornecedor = new();
            frmFornecedor.MdiParent = this;
            //Formas de Exibir.
            frmFornecedor.Show();
        }

        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void novoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            // FrmPedidoNovo frmPedidoNovo = new FrmPedidoNovo();
            FrmPedidoNovo frmPedidoNovo = new();
            frmPedidoNovo.MdiParent = this;
            //Formas de Exibir.
            frmPedidoNovo.Show();

        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente frmCliente = new();
            frmCliente.MdiParent = this;
            //Formas de Exibir.
            frmCliente.Show();
        }
    }
}
