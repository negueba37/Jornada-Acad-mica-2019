using Pedido.Cadastro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pedido.Pesquisa
{
    public partial class FormPesquisaUsuario : Form
    {
        public FormPesquisaUsuario()
        {
            InitializeComponent();
        }

        private void BIncluir_Click(object sender, EventArgs e)
        {
            FormCadastroUsuario formCadastroUsuario = new FormCadastroUsuario();
            formCadastroUsuario.Operacao = "Incluir";
            formCadastroUsuario.ShowDialog();
            pesquisar();
        }

        private void BAlterar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.RowCount != 0)
            {
                FormCadastroUsuario formCadastroUsuario = new FormCadastroUsuario();
                formCadastroUsuario.Operacao = "Alterar";
                formCadastroUsuario.IdUsuario = int.Parse(dgvUsuarios.CurrentRow.Cells["colIDUsuario"].Value.ToString());
                formCadastroUsuario.ShowDialog();
                pesquisar();
            }
        }

        private void BFechar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BPesquisar_Click(object sender, EventArgs e)
        {
            pesquisar(); 
        }

        private void pesquisar()
        {
            BancoDataContext banco = new BancoDataContext();
            try
            {
                banco.Connection.Open();
                StringBuilder sql = new StringBuilder();
                sql.Append("Select\n");
                sql.Append("    *\n");
                sql.Append("From\n");
                sql.Append("    Usuario u\n");
                sql.Append("Where\n");
                sql.Append("    u.IDUsuario <> 0\n");

                if (!string.IsNullOrEmpty(tbIDUsuario.Text))
                {
                    sql.AppendFormat("  And u.IDUsuario = {0}\n", tbIDUsuario.Text);
                }

                if (!string.IsNullOrEmpty(cbStatus.Text))
                {
                    sql.AppendFormat("  And u.Status = {0}\n",
                        cbStatus.Text == "Ativo" ? 1 : 0);
                }

                if (!string.IsNullOrEmpty(tbLogin.Text))
                {
                    sql.AppendFormat("  And u.Login like '%{0}%'\n", tbLogin.Text);
                }

                sql.Append("Order By\n");
                sql.Append("    u.Login Asc\n");

                List<Usuario> usuarios = new List<Usuario>();
                usuarios = banco.ExecuteQuery<Usuario>(sql.ToString()).ToList();

                dgvUsuarios.Rows.Clear();

                foreach (Usuario usuario in usuarios)
                {
                    dgvUsuarios.Rows.Add(
                        usuario.IDUsuario,
                        usuario.Status,
                        usuario.Login);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                banco.Connection.Close();
            }
        }

        private void BExcluir_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.RowCount != 0)
            {
                if (MessageBox.Show("Confirma e exclusão do usuário?", "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BancoDataContext banco = new BancoDataContext();
                    try
                    {
                        banco.Connection.Open();
                        banco.Transaction = banco.Connection.BeginTransaction();

                        Usuario usuario = new Usuario();
                        usuario = (from u in banco.Usuario
                                   where u.IDUsuario == int.Parse(dgvUsuarios.CurrentRow.
                                   Cells["colIDUsuario"].Value.ToString())
                                   select u).SingleOrDefault();
                        if (usuario != null)
                        {
                            banco.Usuario.DeleteOnSubmit(usuario);
                        }

                        banco.SubmitChanges();
                        banco.Transaction.Commit();
                        MessageBox.Show("Usuário excluido com sucesso!", "Confirmação",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(string.Format("Erro ao excluir usuário.\nDetalhe do erro:{0}",
                            ex.Message.ToString()), "Erro",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                        banco.Transaction.Rollback();
                    }
                    finally
                    {
                        banco.Connection.Close();
                        pesquisar();
                    }
                }
            }
        }

        private void FormPesquisaUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }
    }
}
