using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pedido.Cadastro;
using Pedido.Movimento;

namespace Pedido.Pesquisa
{
    public partial class FormPesquisaProduto : Form
    {
        FormMovimentoPedido formMovimentoPedido;

        public FormMovimentoPedido FormMovimentoPedido
        {
            get
            {
                return formMovimentoPedido;
            }

            set
            {
                formMovimentoPedido = value;
            }
        }

        public FormPesquisaProduto()
        {
            InitializeComponent();
        }

        private void bIncluir_Click(object sender, EventArgs e)
        {
            FormCadastroProduto formCadastroProduto = new FormCadastroProduto();
            formCadastroProduto.Operacao = "Incluir";
            formCadastroProduto.FormPesquisaProduto = this;
            formCadastroProduto.ShowDialog();
            Limpar();
            pesquisar();
        }

        private void bAlterar_Click(object sender, EventArgs e)
        {
            FormCadastroProduto formCadastroProduto = new FormCadastroProduto();
            formCadastroProduto.Operacao = "Alterar";
            formCadastroProduto.IdProduto = int.Parse(dgvProdutos.CurrentRow.Cells["colIDProduto"].Value.ToString());
            formCadastroProduto.FormPesquisaProduto = this;
            formCadastroProduto.ShowDialog();
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

                List<Produto> produtos = new List<Produto>();
                produtos = banco.ExecuteQuery<Produto>(Sql()).ToList();

                dgvProdutos.Rows.Clear();

                foreach (Produto produto in produtos)
                {
                    dgvProdutos.Rows.Add(produto.IDProduto, produto.Status, produto.Referencia, produto.Descricao);
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
            comando.Append("	p.*\n");
            comando.Append("From\n");
            comando.Append("    Produto p\n");
            comando.Append("Where\n");
            comando.Append("    p.IDProduto <> 0\n");
            if (!String.IsNullOrEmpty(tbIDProduto.Text))
            {
                comando.AppendFormat("    And p.IDProduto = {0}\n", tbIDProduto.Text);
            }
            if (!String.IsNullOrEmpty(tbDescricao.Text))
            {
                comando.AppendFormat("    And p.Descricao Like '%{0}%'\n", tbDescricao.Text);
            }
            if (!String.IsNullOrEmpty(cbStatus.Text))
            {
                comando.AppendFormat("    And p.Status = {0}\n", cbStatus.Text == "Ativo" ? 1 : 0);
            }
            if (!String.IsNullOrEmpty(tbReferencia.Text))
            {
                comando.AppendFormat("    And p.Referencia Like '%{0}%'\n", tbReferencia.Text);
            }

            comando.AppendFormat("Order by");
            comando.AppendFormat("  p.Descricao Asc");
            return comando.ToString();
        }

        private void bExcluir_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.RowCount > 0)
            {
                if (MessageBox.Show("Confirma a exclusão do produto?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BancoDataContext banco = new BancoDataContext();
                    try
                    {
                        banco.Connection.Open();
                        banco.Transaction = banco.Connection.BeginTransaction();

                        Produto produto = new Produto();
                        produto = (from c in banco.Produto where c.IDProduto == int.Parse(dgvProdutos.CurrentRow.Cells["colIDProduto"].Value.ToString()) select c).SingleOrDefault();

                        if (produto != null)
                        {
                            banco.ProdutoTamanho.DeleteAllOnSubmit(produto.ProdutoTamanho);
                            banco.Produto.DeleteOnSubmit(produto);
                        }

                        banco.SubmitChanges();
                        banco.Transaction.Commit();
                        MessageBox.Show("Produto excluido com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir o produto.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            tbIDProduto.Clear();
            tbDescricao.Clear();
            cbStatus.Text = String.Empty;
            tbReferencia.Clear();
            dgvProdutos.Rows.Clear();
        }

        private void FormPesquisaProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{Tab}");
        }

        private void bFechar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgvProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvProdutos.RowCount > 0)
            {
                int idProduto = int.Parse(dgvProdutos.CurrentRow.Cells["colIDProduto"].Value.ToString());
                if(FormMovimentoPedido != null)
                {
                    formMovimentoPedido.tbIDProduto.Text = String.Empty;
                    formMovimentoPedido.tbIDProduto.Text = idProduto.ToString();
                    this.Dispose();
                }
            }
        }
    }
}
