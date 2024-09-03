using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (msg == DialogResult.Yes) Application.Exit(); //As chaves não não necessárias quando existe apenas uma instrução.
        }

        private void novoToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            FrmProduto frmProduto = new();
            frmProduto.MdiParent = this;
            //Formas de Exibir.
            frmProduto.Show();
        }
    }
}