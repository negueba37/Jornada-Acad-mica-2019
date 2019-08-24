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
    public partial class FormPesquisaTamanho : Form
    {
        public FormPesquisaTamanho()
        {
            InitializeComponent();
        }

        private void bIncluir_Click(object sender, EventArgs e)
        {
            FormCadastroTamanho formCadastroTamanho = new FormCadastroTamanho();
            formCadastroTamanho.Operacao = "Incluir";
            formCadastroTamanho.FormPesquisaTamanho = this;
            formCadastroTamanho.ShowDialog();
            Limpar();
            pesquisar();
        }

        private void bAlterar_Click(object sender, EventArgs e)
        {
            FormCadastroTamanho formCadastroTamanho = new FormCadastroTamanho();
            formCadastroTamanho.Operacao = "Alterar";
            formCadastroTamanho.IdTamanho = int.Parse(dgvTamanhos.CurrentRow.Cells["colIDTamanho"].Value.ToString());
            formCadastroTamanho.FormPesquisaTamanho = this;
            formCadastroTamanho.ShowDialog();
            Limpar();
            pesquisar();
        }

        private void bPesquisar_Click(object sender, EventArgs e)
        {
            pesquisar();
        }

        private void pesquisar()
        {
            BancoDataContext banco = new BancoDataContext();
            try
            {
                banco.Connection.Open();

                List<Tamanho> tamanhos = new List<Tamanho>();
                tamanhos = banco.ExecuteQuery<Tamanho>(Sql()).ToList();

                dgvTamanhos.Rows.Clear();

                foreach (Tamanho tamanho in tamanhos)
                {
                    dgvTamanhos.Rows.Add(tamanho.IDTamanho, tamanho.Status, tamanho.Descricao);
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

        private string Sql()
        {
            StringBuilder comando = new StringBuilder();
            comando.Append("Select\n");
            comando.Append("	t.*\n");
            comando.Append("From\n");
            comando.Append("    Tamanho t\n");
            comando.Append("Where\n");
            comando.Append("    t.IDTamanho <> 0\n");
            if (!String.IsNullOrEmpty(tbIDTamanho.Text))
            {
                comando.AppendFormat("    And t.IDTamanho = {0}\n", tbIDTamanho.Text);
            }
            if (!String.IsNullOrEmpty(tbDescricao.Text))
            {
                comando.AppendFormat("    And t.Descricao Like '%{0}%'\n", tbDescricao.Text);
            }
            if (!String.IsNullOrEmpty(cbStatus.Text))
            {
                comando.AppendFormat("    And t.Status = {0}\n", cbStatus.Text == "Ativo" ? 1 : 0);
            }
            comando.AppendFormat("Order by");
            comando.AppendFormat("  t.Descricao Asc");
            return comando.ToString();
        }

        private void bExcluir_Click(object sender, EventArgs e)
        {
            if (dgvTamanhos.RowCount > 0)
            {
                if (MessageBox.Show("Confirma a exclusão do tamanho?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BancoDataContext banco = new BancoDataContext();
                    try
                    {
                        banco.Connection.Open();
                        banco.Transaction = banco.Connection.BeginTransaction();

                        Tamanho tamanho = new Tamanho();
                        tamanho = (from c in banco.Tamanho where c.IDTamanho == int.Parse(dgvTamanhos.CurrentRow.Cells["colIDTamanho"].Value.ToString()) select c).SingleOrDefault();

                        if (tamanho != null)
                        {
                            banco.Tamanho.DeleteOnSubmit(tamanho);
                        }

                        banco.SubmitChanges();
                        banco.Transaction.Commit();
                        MessageBox.Show("Tamanho excluido com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir o tamanho.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void Limpar()
        {
            tbIDTamanho.Clear();
            tbDescricao.Clear();
            cbStatus.Text = String.Empty;
            dgvTamanhos.Rows.Clear();
        }

        private void FormPesquisaTamanho_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{Tab}");
        }

        private void bFechar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
