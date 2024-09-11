using SysPecNSLib;
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
    public partial class FrmCliente : Form
    {
        public int ClienteId { get; set; } //Para pegar o ID da outra tela.

        public FrmCliente()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Cria um novo objeto cliente
            Endereco endereco = new(
                Cliente.ObterPorId(ClienteId),
                txtCep.Text,
                txtLogradouro.Text,
                txtNumero.Text,
                txtComplemento.Text,
                txtBairro.Text,
                txtCidade.Text,
                txtUf.Text,
                cmbTipoEndereco.Text
               );

            endereco.Inserir();
            if (endereco.Id > 0)
            {
                //Exibe ID do cliente no formulário, enquanto a caixa de diálogo não for fechada.

                MessageBox.Show($"O endereço foi inserido com sucesso, no cadastro do usuário {endereco.Cliente.Nome}");

                txtCep.Clear();
                txtLogradouro.Clear();
                txtNumero.Clear();
                txtComplemento.Clear();
                txtBairro.Clear();
                txtCidade.Clear();
                txtUf.Clear();

                btnAdicionar.Enabled = true;
                btnSalvar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Falha ao cadastrar o endereço no sistema.");
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Cliente cliente = new(
               txtNome.Text,
               txtCpf.Text,
               txtTelefone.Text,
               txtEmail.Text,
               dtpDataNasc.Value,
               DateTime.Now
               );

            cliente.Inserir();
            if (cliente.Id > 0)
            {
                //Exibe ID do cliente no formulário, enquanto a caixa de diálogo não for fechada.
                txtId.Text = cliente.Id.ToString();
                MessageBox.Show($"O cliente {cliente.Nome}, " + $"foi inserido com sucesso com o ID {cliente.Id}!");

                btnCadastrarEndereco.Enabled = true;
                btnInserir.Enabled = false;

                //Limpa as informações do formulário
                //txtId.Clear();
                txtNome.Clear();
                txtCpf.Clear();
                txtTelefone.Clear();
                txtEmail.Clear();

                //Foca o cursor no campo Nome para a nova inserção
                txtNome.Focus();
                //Recarrega a tabela do formulário para exibir o novo usuário na lista
                FrmCliente_Load(sender, e);

            }
            else
            {
                MessageBox.Show("Falha ao cadastrar o cliente no sistema.");
            }
        }

        private void btnCadastrarEndereco_Click(object sender, EventArgs e)
        {
            this.tabCliente.SelectedTab = TabPageEndereco;
            ClienteId = int.Parse(txtId.Text);
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            btnSalvar.Enabled = true;
            btnAdicionar.Enabled = false;


            txtCep.Clear();
            txtLogradouro.Clear();
            txtNumero.Clear();
            txtComplemento.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtUf.Clear();

            txtCep.Focus();

            Endereco endereco = new(
               Cliente.ObterPorId(ClienteId),
               txtCep.Text,
               txtLogradouro.Text,
               txtNumero.Text,
               txtComplemento.Text,
               txtBairro.Text,
               txtCidade.Text,
               txtUf.Text,
               cmbTipoEndereco.Text



              );
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}