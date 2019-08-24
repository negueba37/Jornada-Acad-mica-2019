using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pedido.Movimento;

namespace Pedido.Pesquisa
{
    public partial class FormPesquisaPedido : Form
    {
        public FormPesquisaPedido()
        {
            InitializeComponent();
        }

        private void bIncluir_Click(object sender, EventArgs e)
        {
            FormMovimentoPedido formMovimentoPedido = new FormMovimentoPedido();
            formMovimentoPedido.Operacao = "Incluir";            
            formMovimentoPedido.ShowDialog();
            limpar();
            pesquisar();
        }

        private void bAlterar_Click(object sender, EventArgs e)
        {
            FormMovimentoPedido formMovimentoPedido = new FormMovimentoPedido();
            formMovimentoPedido.Operacao = "Alterar";            
            formMovimentoPedido.IdPedido = int.Parse(dgvPedidos.CurrentRow.Cells["colIDPedido"].Value.ToString());
            formMovimentoPedido.ShowDialog();
            limpar();
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
                List<Pedido> pedidos = new List<Pedido>();
                pedidos = banco.ExecuteQuery<Pedido>(sql()).ToList();

                dgvPedidos.Rows.Clear();

                foreach (Pedido pedido in pedidos)
                {
                    dgvPedidos.Rows.Add(
                        pedido.IDPedido,
                        pedido.IDPessoa,
                        pedido.Pessoa.Nome_RazaoSocial,
                        pedido.Status,
                        pedido.Data,
                        pedido.Total,
                        pedido.Pessoa.Cidade.Nome,
                        pedido.Pessoa.Cidade.Estado.UF);
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

        private string sql()
        {
            StringBuilder comando = new StringBuilder();
            comando.Append("Select\n");
            comando.Append("    p.*\n");
            comando.Append("From\n");
            comando.Append("    Pedido p\n");
            comando.Append("    Inner Join Pessoa pe On p.IDPessoa = pe.IDPessoa\n");
            comando.Append("    Inner Join Cidade c On pe.IDCidade = c.IDCidade\n");
            comando.Append("    Inner Join Estado e On c.IDEstado = e.IDEstado\n");
            comando.Append("Where\n");
            comando.Append("    p.IDPedido <> 0\n");
            if (!String.IsNullOrEmpty(tbIDPedido.Text))
            {
                comando.AppendFormat("  And p.IDPedido = {0}\n", tbIDPedido.Text);
            }
            if (!String.IsNullOrEmpty(cbStatus.Text))
            {
                comando.AppendFormat("  And p.Status = '{0}'\n", cbStatus.Text);
            }
            if (!String.IsNullOrEmpty(tbNome_RazaoSocial.Text))
            {
                comando.AppendFormat("  And pe.Nome_RazaoSocial Like '%{0}%'\n", tbNome_RazaoSocial.Text);
            }
            if (!String.IsNullOrEmpty(tbApelido_Fantasia.Text))
            {
                comando.AppendFormat("  And pe.Apelido_Fantasia Like '%{0}%'\n", tbApelido_Fantasia.Text);
            }
            if (!String.IsNullOrEmpty(tbCPF_CNPJ.Text))
            {
                comando.AppendFormat("  And pe.CPF_CNPJ Like '%{0}%'\n", tbCPF_CNPJ.Text);
            }
            if (!String.IsNullOrEmpty(tbRG_InscricaoEstadual.Text))
            {
                comando.AppendFormat("  And pe.RG_InscricaoEstadual Like '%{0}%'\n", tbRG_InscricaoEstadual.Text);
            }
            if (!String.IsNullOrEmpty(tbCidade.Text))
            {
                comando.AppendFormat("  And c.Nome Like '%{0}%'\n", tbCidade.Text);
            }
            if (!String.IsNullOrEmpty(tbUF.Text))
            {
                comando.AppendFormat("  And e.UF Like '%{0}%'\n", tbUF.Text);
            }
            if (IsDate(mtbDataInicio.Text) && IsDate(mtbDataInicio.Text))
            {
                comando.AppendFormat("  And p.Data Between '{0}' And '{1}'\n", mtbDataInicio.Text, mtbDataInicio.Text);
            }
            comando.Append("Order By\n");
            comando.Append("    p.IDPedido Desc\n");
            return comando.ToString();
        }

        private bool IsDate(String date)
        {
            try
            {
                DateTime dt = DateTime.Parse(date);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void bExcluir_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.RowCount > 0)
            {
                if (MessageBox.Show("Confirma a exclusão do pedido?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BancoDataContext banco = new BancoDataContext();
                    try
                    {
                        banco.Connection.Open();
                        banco.Transaction = banco.Connection.BeginTransaction();

                        Pedido pedido = new Pedido();
                        pedido = (from p in banco.Pedido where p.IDPedido == int.Parse(dgvPedidos.CurrentRow.Cells["colIDPedido"].Value.ToString()) select p).SingleOrDefault();

                        if (pedido != null)
                        {
                            banco.PedidoProduto.DeleteAllOnSubmit(pedido.PedidoProduto.ToList());
                            banco.Pedido.DeleteOnSubmit(pedido);
                        }

                        banco.SubmitChanges();
                        banco.Transaction.Commit();

                        MessageBox.Show("Pedido excluido com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir o pedido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void limpar()
        {
            tbIDPedido.Clear();
            cbStatus.Text = String.Empty;
            tbNome_RazaoSocial.Clear();
            tbApelido_Fantasia.Clear();
            tbCPF_CNPJ.Clear();
            tbRG_InscricaoEstadual.Clear();
            tbCidade.Clear();
            tbUF.Clear();
            mtbDataInicio.Clear();
            mtbDataFim.Clear();
            dgvPedidos.Rows.Clear();
        }

        private void FormPesquisaPedido_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }

        private void bFechar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
