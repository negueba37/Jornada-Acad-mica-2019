using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pedido.Cadastro
{
    public partial class FormCadastroUsuario : Form
    {
        String operacao;
        int idUsuario;
        public FormCadastroUsuario()
        {
            InitializeComponent();
        }

        public string Operacao { get => operacao; set => operacao = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }

        private void BGravar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                if (MessageBox.Show("Confirma a gravação do usuário?", "Confirmação",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BancoDataContext banco = new BancoDataContext();
                    try
                    {
                        banco.Connection.Open();
                        banco.Transaction = banco.Connection.BeginTransaction();

                        Usuario usuario = new Usuario();

                        if (operacao == "Alterar")
                        {
                            usuario = (from u in banco.Usuario
                                       where
                                           u.IDUsuario == idUsuario
                                       select u
                                        ).SingleOrDefault();
                        }

                        usuario.Login = tbLogin.Text;
                        usuario.Senha = tbSenha.Text;
                        usuario.Status = cbStatus.Checked;

                        if (operacao == "Incluir")
                        {
                            usuario.Status = true;
                            banco.Usuario.InsertOnSubmit(usuario);
                        }

                        banco.SubmitChanges();
                        banco.Transaction.Commit();
                        MessageBox.Show("Usuario gravado com sucesso.", "Confirmação",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        operacao = "Outro";
                        this.Dispose();
                    }
                    catch (SqlException ex)
                    {
                        if (ex.Number == 2627)
                        {
                            MessageBox.Show("Já existe um usuário cadastrado com esse login.",
                                "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            banco.Transaction.Rollback();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao gravar o usuario.", "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        banco.Transaction.Rollback();
                    }
                    finally
                    {
                        banco.Connection.Close();
                    }

                }
            }
        }

        private bool validar()
        {
            bool resposta = true;

            validacao.SetError(tbLogin, String.Empty);
            validacao.SetError(tbSenha, String.Empty);
            validacao.SetError(tbConfirmacao, String.Empty);

            if (tbLogin.Text == "")
            {
                validacao.SetError(tbLogin, "Informe o login do usuário.");
                resposta = false;
            }

            if (tbSenha.Text == "")
            {
                validacao.SetError(tbSenha, "Informe a senha do usuário.");
                resposta = false;
            }

            if (tbConfirmacao.Text == "")
            {
                validacao.SetError(tbConfirmacao, "Informe a confirmação da senha.");
                resposta = false;
            }

            if ((tbConfirmacao.Text != "") && (tbSenha.Text != ""))
            {
                if (tbConfirmacao.Text != tbSenha.Text)
                {
                    validacao.SetError(tbConfirmacao, "A confirmação está diferente da senha.");
                    resposta = false;
                }
            }

            //string.IsNullOrEmpty()

            return resposta;
        }

        private void FormCadastroUsuario_Shown(object sender, EventArgs e)
        {
            if (idUsuario != 0)
            {
                BancoDataContext banco = new BancoDataContext();
                try
                {
                    banco.Connection.Open();

                    Usuario usuario = new Usuario();
                    usuario = (from u in banco.Usuario
                               where u.IDUsuario == idUsuario
                               select u).SingleOrDefault();

                    if (usuario != null)
                    {
                        tbIDUsuario.Text = usuario.IDUsuario.ToString();
                        tbLogin.Text = usuario.Login;
                    }
                }
                catch (Exception)
                {

                }
                finally
                {
                    banco.Connection.Close();
                }
            }
        }

        private void FormCadastroUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCadastroUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (operacao != "Outro")
            {
                if (MessageBox.Show("Confirma o cancelamento da operação?",
                    "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
