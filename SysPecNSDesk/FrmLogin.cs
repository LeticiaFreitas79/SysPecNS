using SysPecNSLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysPecNSDesk
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Encerra a aplicação.
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text!=string.Empty && txtSenha.Text!=string.Empty) //Se os campos de Email e Senha NÃO estiverem vazios, faça:
            {
                var usuario = Usuario.EfetuarLogin(txtEmail.Text, txtSenha.Text); //EfetuarLogin é um método sendo referenciado. (?) O texto dentro dos parenteses serve para indicar que os campos no formulário devem ser preenchidos.
                if (usuario.Id > 0) //Serve para identificar se o usuário já existe no banco de dados, de acordo com os dados informados no formulário.
                {
                    if (usuario.Ativo) //Se o usuário for ativo no sistema, faça:
                    {
                        Program.UsuarioLogado = usuario; //O usuário
                        //A classe program é a primeira classe a ser executada no sistema. 
                        Close();
                    }

                    else //Se o usuário for inativo, faça:
                    {
                        MessageBox.Show("Seu usuário está inativo. \n Procure a gerência.");
                        Application.Exit(); //Fecha a aplicação inteira, ou seja, a tela de login e a tela principal.
                    }
                }
                else
                {
                    MessageBox.Show("Usuário ou Senha Inválidos ou Inexistente. \n Procure a gerência.");
                }
            }      
            else
            {
                MessageBox.Show("Você deve preencher os campos de Email e Senha");
                txtEmail.Focus(); //Devolve o foco do cursor para o campo de email.
            }
        } //Fim do evento  click Entrar.
    }
}
