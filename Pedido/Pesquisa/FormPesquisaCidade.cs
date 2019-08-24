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
    public partial class FormPesquisaCidade : Form
    {
        public FormPesquisaCidade()
        {
            InitializeComponent();
        }

        private void bIncluir_Click(object sender, EventArgs e)
        {
            FormCadastroCidade formCadastroCidade = new FormCadastroCidade();
            formCadastroCidade.Operacao = "Incluir";
            formCadastroCidade.FormPesquisaCidade = this;
            formCadastroCidade.ShowDialog();
            Limpar();
            pesquisar();
        }

        private void bAlterar_Click(object sender, EventArgs e)
        {
            FormCadastroCidade formCadastroCidade = new FormCadastroCidade();
            formCadastroCidade.Operacao = "Alterar";
            formCadastroCidade.IdCidade = int.Parse(dgvCidades.CurrentRow.Cells["colIDCidade"].Value.ToString());
            formCadastroCidade.FormPesquisaCidade = this;
            formCadastroCidade.ShowDialog();
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

                List<Cidade> cidades = new List<Cidade>();
                cidades = banco.ExecuteQuery<Cidade>(Sql()).ToList();

                dgvCidades.Rows.Clear();

                foreach (Cidade cidade in cidades)
                {
                    dgvCidades.Rows.Add(cidade.IDCidade, cidade.Nome, cidade.Estado.UF);
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
            comando.Append("	c.*\n");
            comando.Append("From\n");
            comando.Append("    Cidade c\n");
            comando.Append("Where\n");
            comando.Append("    c.IDCidade <> 0\n");
            if (!String.IsNullOrEmpty(tbIDCidade.Text))
            {
                comando.AppendFormat("    And c.IDCidade = {0}\n", tbIDCidade.Text);
            }
            if (!String.IsNullOrEmpty(tbNome.Text))
            {
                comando.AppendFormat("    And c.Nome Like '%{0}%'\n", tbNome.Text);
            }
            if (!String.IsNullOrEmpty(cbUF.Text))
            {
                comando.AppendFormat("    And c.IDEstado Like '%{0}%'\n", cbUF.SelectedValue);
            }
            comando.AppendFormat("Order by");
            comando.AppendFormat("  c.Nome Asc");
            return comando.ToString();
        }

        private void bExcluir_Click(object sender, EventArgs e)
        {
            if (dgvCidades.RowCount > 0)
            {
                if (MessageBox.Show("Confirma a exclusão da cidade?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BancoDataContext banco = new BancoDataContext();
                    try
                    {
                        banco.Connection.Open();
                        banco.Transaction = banco.Connection.BeginTransaction();

                        Cidade cidade = new Cidade();
                        cidade = (from c in banco.Cidade where c.IDCidade == int.Parse(dgvCidades.CurrentRow.Cells["colIDCidade"].Value.ToString()) select c).SingleOrDefault();

                        if (cidade != null)
                        {
                            banco.Cidade.DeleteOnSubmit(cidade);
                        }

                        banco.SubmitChanges();
                        banco.Transaction.Commit();
                        MessageBox.Show("Cidade excluida com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir a cidade.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            tbIDCidade.Clear();
            tbNome.Clear();
            cbUF.Text = String.Empty;
            dgvCidades.Rows.Clear();
        }

        private void FormPesquisaCidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{Tab}");
        }

        private void FormPesquisaCidade_Shown(object sender, EventArgs e)
        {
            BancoDataContext banco = new BancoDataContext();
            try
            {
                banco.Connection.Open();

                cbUF.DataSource = (from c in banco.Estado select c).ToList();
                cbUF.ValueMember = "IDEstado";
                cbUF.DisplayMember = "UF";
                cbUF.Text = null;
            }
            catch (Exception)
            {                
            }
            finally
            {
                banco.Connection.Close();
            }
        }

        private void bLimparEstado_Click(object sender, EventArgs e)
        {
            cbUF.Text = null;
        }

        private void bFechar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
