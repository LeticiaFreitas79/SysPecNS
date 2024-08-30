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
    public partial class FrmUsuario : Form
    {
        //private IEnumerable<object> lista;

        public FrmUsuario()
        {
            InitializeComponent();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void FrmUsuario_Load_1(object sender, EventArgs e)
        {
            //Carregando o ComboBox de Níveis.
            var niveis = Nivel.ObterLista();
            cmbNivel.DataSource = niveis;
            cmbNivel.DisplayMember = "Nome";
            cmbNivel.ValueMember = "Id";

            CarregaGrid();
        }

        private void chkAtivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            //MessageBox.Show
            Usuario usuario = new(
                    txtNome.Text,
                    txtEmail.Text,
                    txtSenha.Text,
                    Nivel.ObterPorId(Convert.ToInt32(cmbNivel.SelectedValue))
                );
            usuario.Inserir();
            if (usuario.Id > 0)
            {
                txtId.Text = usuario.Id.ToString();
                MessageBox.Show($"O usuário {usuario.Nome}, foi gravado com sucesso, com o ID {usuario.Id}");
                txtNome.Clear();
                txtEmail.Clear();
                txtConfSenha.Clear();
                txtSenha.Clear();
                txtNome.Focus();
                FrmUsuario_Load_1(sender, e);
            }
            else
            {
                MessageBox.Show("Falha ao gravar usuário,");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtConfSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            if (txtBusca.Text.Length > 0)
            {
                CarregaGrid(txtBusca.Text);
            }
            else
            {
                CarregaGrid();
            }
        }
        private void CarregaGrid(string nome = "")
        {
            //Preenchendo o DataGrid com os Usuários.
            
            var Lista = Usuario.ObterLista(nome);
            
            dgvUsuarios.Rows.Clear();
            int cont = 0;
            foreach (var usuario in Lista)
            {
                dgvUsuarios.Rows.Add();
                dgvUsuarios.Rows[cont].Cells[0].Value = usuario.Id;
                dgvUsuarios.Rows[cont].Cells[1].Value = usuario.Nome;
                dgvUsuarios.Rows[cont].Cells[2].Value = usuario.Email;
                dgvUsuarios.Rows[cont].Cells[3].Value = usuario.Nivel.Nome;
                dgvUsuarios.Rows[cont].Cells[4].Value = usuario.Ativo;
                cont++;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Deseja continuar o cadastro?", "Confirmação de saída", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (msg == DialogResult.Yes) this.Close();
        }
        private bool VerificaControles()
        {
            if (txtNome.Text != string.Empty
                || txtEmail.Text != string.Empty
                || txtSenha.Text != string.Empty
                || txtConfSenha.Text != string.Empty)
            { 
            return true;
                }
            else
            {
                return false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
