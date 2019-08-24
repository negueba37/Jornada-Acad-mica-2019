using Pedido.Cadastro;
using Pedido.Movimento;
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
    public partial class FormPesquisaCor : Form
    {
        public FormPesquisaCor()
        {
            InitializeComponent();
        }

        private void bIncluir_Click(object sender, EventArgs e)
        {
            FormCadastroCor formCadastroCor = new FormCadastroCor();
            formCadastroCor.Operacao = "Incluir";
            formCadastroCor.FormPesquisaCor = this;
            formCadastroCor.ShowDialog();
            Limpar();
            pesquisar();
        }

        private void bAlterar_Click(object sender, EventArgs e)
        {
            FormCadastroCor formCadastroCor = new FormCadastroCor();
            formCadastroCor.Operacao = "Alterar";
            formCadastroCor.IdCor = int.Parse(dgvCores.CurrentRow.Cells["colIDCor"].Value.ToString());
            formCadastroCor.FormPesquisaCor = this;
            formCadastroCor.ShowDialog();
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

                List<Cor> cores = new List<Cor>();
                cores = banco.ExecuteQuery<Cor>(Sql()).ToList();

                dgvCores.Rows.Clear();

                foreach (Cor cor in cores)
                {
                    dgvCores.Rows.Add(cor.IDCor, cor.Status, cor.Descricao);
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
            comando.Append("    Cor c\n");
            comando.Append("Where\n");
            comando.Append("    c.IDCor <> 0\n");
            if (!String.IsNullOrEmpty(tbIDCor.Text))
            {
                comando.AppendFormat("    And c.IDCor = {0}\n", tbIDCor.Text);
            }
            if (!String.IsNullOrEmpty(tbDescricao.Text))
            {
                comando.AppendFormat("    And c.Descricao Like '%{0}%'\n", tbDescricao.Text);
            }
            if (!String.IsNullOrEmpty(cbStatus.Text))
            {
                comando.AppendFormat("    And c.Status = {0}\n",  cbStatus.Text == "Ativo" ? 1 : 0);
            }
            comando.AppendFormat("Order by");
            comando.AppendFormat("  c.Descricao Asc");
            return comando.ToString();
        }

        private void bExcluir_Click(object sender, EventArgs e)
        {
            if (dgvCores.RowCount > 0)
            {
                if (MessageBox.Show("Confirma a exclusão da cor?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BancoDataContext banco = new BancoDataContext();
                    try
                    {
                        banco.Connection.Open();
                        banco.Transaction = banco.Connection.BeginTransaction();

                        Cor cor = new Cor();
                        cor = (from c in banco.Cor where c.IDCor == int.Parse(dgvCores.CurrentRow.Cells["colIDCor"].Value.ToString()) select c).SingleOrDefault();

                        if (cor != null)
                        {
                            banco.Cor.DeleteOnSubmit(cor);
                        }

                        banco.SubmitChanges();
                        banco.Transaction.Commit();
                        MessageBox.Show("Cor excluida com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir a cor.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            tbIDCor.Clear();
            tbDescricao.Clear();
            cbStatus.Text = String.Empty;
            dgvCores.Rows.Clear();
        }

        private void FormPesquisaCor_KeyDown(object sender, KeyEventArgs e)
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
