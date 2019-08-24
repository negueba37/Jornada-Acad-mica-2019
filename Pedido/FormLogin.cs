using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Pedido
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            lbMensagem.Visible = true;
            lbMensagem.Text = String.Empty;
            epErros.SetError(tbLogin, String.Empty);
            epErros.SetError(tbSenha, String.Empty);

            Boolean valido = true;

            if (string.IsNullOrEmpty(tbLogin.Text))
            {                
                epErros.SetError(tbLogin, "Informe o login do usuário.");
                valido = false;
            }

            if (string.IsNullOrEmpty(tbSenha.Text))
            {
                epErros.SetError(tbSenha, "Informe a senha do usuário.");
                valido = false;
            }

            if (valido)
            {
                BancoDataContext banco = new BancoDataContext();
                try
                {
                    banco.Connection.Open();

                    Usuario usuario = new Usuario();
                    usuario = (from u in banco.Usuario where u.Login == tbLogin.Text && u.Senha == tbSenha.Text select u).SingleOrDefault();

                    if (usuario != null)
                    {
                        Cache.idUsuario = usuario.IDUsuario;
                        Cache.login = usuario.Login;

                        FormMenu formMenu = new FormMenu();
                        formMenu.Show();
                        this.Hide();
                    }
                    else
                    {
                        lbMensagem.Text = "Usuário de senha não encontrado. \nTente novamente.";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(String.Format("Erro ao realizar o login.\n{0}",ex.ToString()),"Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                finally
                {
                    banco.Connection.Close();
                }
            }
            else
            {
                tbLogin.Focus();
            }           
        }

        private void tbLogin_Enter(object sender, EventArgs e)
        {
            if (lbMensagem.Visible)
                lbMensagem.Visible = false;
            epErros.SetError(tbLogin, String.Empty);
        }

        private void tbSenha_Enter(object sender, EventArgs e)
        {
            if (lbMensagem.Visible)
                lbMensagem.Visible = false;
            epErros.SetError(tbSenha, String.Empty);
        }

        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }
    }
}
