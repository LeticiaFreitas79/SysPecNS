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
    public partial class FrmEstoque : Form
    {
        public FrmEstoque()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            CarregaGrid(); //
        }

        private void CarregaGrid (string nome = "") //
        {
            var lista = Produto.ObterLista(nome);
            dgvEstoqueProdutos.Rows.Clear(); // Limpar as colunas após clicar no botão 'adicionar'
            int cont = 0;
            foreach (var produto in lista) //Adicionar as informações da tabela do Banco de Dados no DataGrid 'dgvEstoqueProdutos'.
            {
                dgvEstoqueProdutos.Rows.Add();
                dgvEstoqueProdutos.Rows[cont].Cells[0].Value = produto.Id;
                dgvEstoqueProdutos.Rows[cont].Cells[1].Value = produto.CodBar;
                dgvEstoqueProdutos.Rows[cont].Cells[2].Value = produto.Nome;
                dgvEstoqueProdutos.Rows[cont].Cells[3].Value = produto.Quantidade;
                dgvEstoqueProdutos.Rows[cont].Cells[4].Value = produto.EstoqueMinimo;
                dgvEstoqueProdutos.Rows[cont].Cells[5].Value = produto.UltimaMovimentacao;
                cont++;
            }
        }

        private void FrmEstoque_Load(object sender, EventArgs e)
        {

        }

        private void dudQuantidade_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void btnEntradaAtualizar_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvEstoqueProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
 
        }
    }
}
