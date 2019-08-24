using Pedido.Cadastro;
using Pedido.Pesquisa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pedido.Movimento
{
    public partial class FormMovimentoPedido : Form
    {
        string operacao;
        int idPedido;
        public string Operacao { get => operacao; set => operacao = value; }
        public int IdPedido { get => idPedido; set => idPedido = value; }

        public FormMovimentoPedido()
        {
            InitializeComponent();

            BancoDataContext banco = new BancoDataContext();
            try
            {
                banco.Connection.Open();

                cbIDCor.DataSource = (from c in banco.Cor where c.Status == true select c).ToList();
                cbIDCor.ValueMember = "IDCor";
                cbIDCor.DisplayMember = "Descricao";
                cbIDCor.Text = null;

                cbIDTamanho.DataSource = (from t in banco.Tamanho
                                          where t.Status ==
                  true
                                          select t).ToList();
                cbIDTamanho.ValueMember = "IDTamanho";
                cbIDTamanho.DisplayMember = "Descricao";
                cbIDTamanho.Text = null;
            }
            catch (Exception)
            {

            }
            finally
            {
                banco.Connection.Close();
            }
        }

        private void TbIDPessoa_TextChanged(object sender, EventArgs e)
        {
            tbIDPessoa.Tag = false;
            tbNomeRazaoSocial.Clear();
            tbApelido_Fantasia.Clear();
            tbTipo.Clear();
            tbCPF_CNPJ.Clear();
            tbRG_IncricaoEstadual.Clear();
            tbCidade.Clear();
            tbUF.Clear();
            mtbCEP.Clear();
            tbEndereco.Clear();
            tbNumero.Clear();
            tbBairro.Clear();
            tbComplemento.Clear();
            mtbTelefone.Clear();
            mtbCelular.Clear();
            tbEmail.Clear();

            BancoDataContext banco = new BancoDataContext();
            try
            {
                banco.Connection.Open();
                Pessoa pessoa = new Pessoa();
                pessoa = (from p in banco.Pessoa where p.IDPessoa == int.Parse(tbIDPessoa.Text) select p).SingleOrDefault();

                if (pessoa != null)
                {
                    tbIDPessoa.Tag = true;
                    tbNomeRazaoSocial.Text = pessoa.Nome_RazaoSocial;
                    tbApelido_Fantasia.Text = pessoa.Apelido_Fantasia;
                    tbTipo.Text = pessoa.Tipo.ToString();
                    tbCPF_CNPJ.Text = pessoa.CPF_CNPJ;
                    tbRG_IncricaoEstadual.Text = pessoa.RG_InscricaoEstadual;
                    tbCidade.Text = pessoa.Cidade.Nome;
                    tbUF.Text = pessoa.Cidade.Estado.UF;
                    mtbCEP.Text = pessoa.CEP;
                    tbEndereco.Text = pessoa.Endereco;
                    tbNumero.Text = pessoa.Numero;
                    tbBairro.Text = pessoa.Bairro;
                    tbComplemento.Text = pessoa.Complemento;
                    mtbTelefone.Text = pessoa.Telefone;
                    mtbCelular.Text = pessoa.Celular;
                    tbEmail.Text = pessoa.Email;

                    if (Convert.ToString(pessoa.Tipo) == "J")
                    {
                        lbNomeRazaoSocial.Text = "Razão Social";
                        lbCPF_CNPJ.Text = "CNPJ";
                        lbRG_IncricaoEstadual.Text = "Inscrição Estadual";
                    }
                    else
                    {
                        lbNomeRazaoSocial.Text = "Nome";
                        lbCPF_CNPJ.Text = "CPF";
                        lbRG_IncricaoEstadual.Text = "RG";
                    }
                }
                else
                    tbNomeRazaoSocial.Text = "Cliente não encontrado.";
            }
            catch (Exception)
            {
            }
            finally
            {
                banco.Connection.Close();
            }
        }

        private void TbIDProduto_TextChanged(object sender, EventArgs e)
        {
            tbIDProduto.Tag = false;
            tbProduto.Clear();
            tbReferencia.Clear();

            BancoDataContext banco = new BancoDataContext();
            try
            {
                banco.Connection.Open();
                Produto produto = new Produto();
                produto = (from p in banco.Produto where p.IDProduto == int.Parse(tbIDProduto.Text) && p.Status == true select p).SingleOrDefault();

                if (produto != null)
                {
                    tbIDProduto.Tag = true;
                    tbProduto.Text = produto.Descricao;
                    tbReferencia.Text = produto.Referencia;
                    cbIDTamanho.DataSource = (from pt in produto.ProdutoTamanho where pt.Tamanho.Status = true select pt.Tamanho).ToList();
                    cbIDTamanho.ValueMember = "IDTamanho";
                    cbIDTamanho.DisplayMember = "Descricao";
                    cbIDTamanho.Text = null;
                }
                else
                {
                    tbProduto.Text = "Produto não encontrado.";
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

        private void BPesquisarPessoa_Click(object sender, EventArgs e)
        {
            FormPesquisaPessoa formPesquisaPessoa = new FormPesquisaPessoa();
            formPesquisaPessoa.FormMovimentoPedido = this;
            formPesquisaPessoa.ShowDialog();
        }

        private void BPesquisarProduto_Click(object sender, EventArgs e)
        {
            FormPesquisaProduto formPesquisaProduto = new FormPesquisaProduto();
            formPesquisaProduto.FormMovimentoPedido = this;
            formPesquisaProduto.ShowDialog();
        }

        private void BCadastrarCor_Click(object sender, EventArgs e)
        {
            FormCadastroCor formCadastroCor = new FormCadastroCor();
            formCadastroCor.FormMovimentoPedido = this;
            formCadastroCor.Operacao = "Incluir";
            formCadastroCor.ShowDialog();
        }

        private void CbIDTamanho_SelectedIndexChanged(object sender, EventArgs e)
        {
            BancoDataContext banco = new BancoDataContext();
            try
            {
                banco.Connection.Open();
                ProdutoTamanho produtoTamanho = new ProdutoTamanho();
                produtoTamanho = (from pt in banco.ProdutoTamanho
                                  where pt.IDProduto
  == int.Parse(tbIDProduto.Text) && pt.IDTamanho ==
  int.Parse(cbIDTamanho.SelectedValue.ToString())
                                  select pt).SingleOrDefault();
                if (produtoTamanho != null)
                {
                    tbPreco.Text = String.Format("{0:C2}", produtoTamanho.Preco);
                }
                else
                    tbPreco.Text = "0.0";
            }
            catch (Exception ex)
            {

            }
            finally
            {
                banco.Connection.Close();
            }
        }

        private void TbQuantidade_TextChanged(object sender, EventArgs e)
        {
            totalProduto();
        }
        private void totalProduto()
        {
            try
            {
                tbTotalProduto.Text = String.Format("{0:c2}",
                    decimal.Parse(tbQuantidade.Text) *
                    decimal.Parse(tbPreco.Text.Replace("R$", "")));
            }
            catch (Exception)
            {
            }
        }

        private void TbQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar))
            {
                if (!Char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void TbQuantidade_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbQuantidade.Text))
            {
                tbQuantidade.Text = "0";
            }
            tbQuantidade.Text = String.Format("{0:n0}", decimal.Parse(tbQuantidade.Text));
        }

        private void TbPreco_TextChanged(object sender, EventArgs e)
        {
            moeda(tbPreco);
            totalProduto();
        }
        private void moeda(TextBox textBox)
        {
            string n = String.Empty;
            double v = 0;
            try
            {
                n = textBox.Text.Replace(",", "").Replace(".", "").Replace("R$ ", "");
                if (n.Equals(""))
                    n = "";
                n = n.PadLeft(3, char.Parse("0"));
                if (n.Length > 3 && n.Substring(0, 1) == "0")
                    n = n.Substring(1, n.Length - 1);
                v = double.Parse(n) / 100;
                textBox.Text = String.Format("{0:c}", v);
                textBox.SelectionStart = textBox.Text.Length;
            }
            catch (Exception)
            {
            }
        }

        private void TbPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar))
            {
                if (!Char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void adicionarPedidoProduto(PedidoProduto pedidoProduto)
        {
            bool adicionar = true;
            foreach (DataGridViewRow row in dgvPedidoProduto.Rows)
            {
                if (int.Parse(row.Cells["colIDProduto"].Value.ToString()) == pedidoProduto.IDProduto
                    && int.Parse(row.Cells["colIDCor"].Value.ToString()) == pedidoProduto.IDCor
                    && int.Parse(row.Cells["colIDTamanho"].Value.ToString()) == pedidoProduto.IDTamanho)
                {
                    adicionar = false;
                    break;
                }
            }

            if (adicionar)
            {
                dgvPedidoProduto.Rows.Add(
                    pedidoProduto.IDProduto,
                    pedidoProduto.Produto.Descricao,
                    pedidoProduto.Produto.Referencia,
                    pedidoProduto.IDCor,
                    pedidoProduto.Cor.Descricao,
                    pedidoProduto.IDTamanho,
                    pedidoProduto.Tamanho.Descricao,
                    (int)pedidoProduto.Quantidade,
                    pedidoProduto.Preco,
                    pedidoProduto.Total,
                    pedidoProduto.Observacao);
                tbTotal.Text = String.Format("{0:C2}", decimal.Parse(tbTotal.Text.Replace("R$", "")) + pedidoProduto.Total);
            }
            else
                MessageBox.Show("O produto já foi adicionado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void adicionarPedidoProduto(List<PedidoProduto> pedidoProdutos)
        {
            dgvPedidoProduto.Rows.Clear();

            foreach (PedidoProduto pedidoProduto in pedidoProdutos)
            {
                adicionarPedidoProduto(pedidoProduto);
            }
        }

        private void BAdicionar_Click(object sender, EventArgs e)
        {
            if (validarProduto())
            {
                BancoDataContext banco = new BancoDataContext();
                try
                {
                    banco.Connection.Open();
                    PedidoProduto pedidoProduto = new PedidoProduto();
                    pedidoProduto.IDProduto = int.Parse(tbIDProduto.Text);
                    pedidoProduto.Produto = (from p in banco.Produto where p.IDProduto == int.Parse(tbIDProduto.Text) select p).SingleOrDefault();
                    pedidoProduto.IDCor = int.Parse(cbIDCor.SelectedValue.ToString());
                    pedidoProduto.Cor = (from c in banco.Cor where c.IDCor == pedidoProduto.IDCor select c).SingleOrDefault();
                    pedidoProduto.IDTamanho = int.Parse(cbIDTamanho.SelectedValue.ToString());
                    pedidoProduto.Tamanho = (from t in banco.Tamanho where t.IDTamanho == pedidoProduto.IDTamanho select t).SingleOrDefault();
                    pedidoProduto.Quantidade = int.Parse(tbQuantidade.Text);
                    pedidoProduto.Preco = decimal.Parse(tbPreco.Text.Replace("R$", ""));
                    pedidoProduto.Total = decimal.Parse(tbTotalProduto.Text.Replace("R$", ""));
                    pedidoProduto.Observacao = tbObservacaoProduto.Text;
                    adicionarPedidoProduto(pedidoProduto);
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    banco.Connection.Close();

                    tbIDProduto.Clear();
                    cbIDCor.SelectedValue = String.Empty;
                    cbIDTamanho.SelectedValue = String.Empty;
                    tbQuantidade.Text = "0";
                    tbPreco.Clear();
                    tbReferencia.Clear();
                    tbObservacaoProduto.Clear();
                    tbIDProduto.Focus();
                }
            }
        }

        private bool validarProduto()
        {
            Validacao.SetError(tbIDProduto, String.Empty);
            Validacao.SetError(cbIDCor, String.Empty);
            Validacao.SetError(tbPreco, String.Empty);
            Validacao.SetError(tbQuantidade, String.Empty);
            Validacao.SetError(cbIDTamanho, String.Empty);

            bool resposta = true;

            if (decimal.Parse(tbPreco.Text.Replace("R$", "")) == 0)
            {
                Validacao.SetError(tbPreco, "Informe o preço do produto.");
                resposta = false;
                tbPreco.Focus();
            }

            if (decimal.Parse(tbQuantidade.Text) == 0)
            {
                Validacao.SetError(tbQuantidade, "Informe a quantidade de produtos.");
                resposta = false;
                tbQuantidade.Focus();
            }

            if (cbIDTamanho.SelectedValue == null)
            {
                Validacao.SetError(cbIDTamanho, "Informe a tamanho do produto.");
                resposta = false;
                cbIDTamanho.Focus();
            }

            if (cbIDCor.SelectedValue == null)
            {
                Validacao.SetError(cbIDCor, "Informe a cor do produto.");
                resposta = false;
                cbIDCor.Focus();
            }

            if (!Convert.ToBoolean(tbIDProduto.Tag))
            {
                Validacao.SetError(tbIDProduto, "Informe o produto.");
                resposta = false;
                tbIDProduto.Focus();
            }

            return resposta;
        }

        private void BRemover_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma a retirada do produto da lista?",
                "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.Yes)
            {
                tbTotal.Text = String.Format("{0:C2}",
                    decimal.Parse(tbTotal.Text.Replace("R$", "")) -
                    decimal.Parse(dgvPedidoProduto.CurrentRow.Cells["colTotal"].Value.ToString()));
                dgvPedidoProduto.Rows.Remove(dgvPedidoProduto.CurrentRow);
            }
        }

        private void BGravar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                if (MessageBox.Show("Confirma a gravação do pedido?",
                    "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    BancoDataContext banco = new BancoDataContext();
                    try
                    {
                        banco.Connection.Open();
                        banco.Transaction = banco.Connection.BeginTransaction();

                        Pedido pedido = new Pedido();

                        if (operacao == "Alterar")
                        {
                            pedido = (from p in banco.Pedido where p.IDPedido == 
                                      idPedido select p).Single();
                            banco.PedidoProduto.DeleteAllOnSubmit(pedido.PedidoProduto);
                        }

                        pedido.IDPessoa = int.Parse(tbIDPessoa.Text);
                        pedido.IDUsuario = Cache.idUsuario;
                        pedido.Data = DateTime.Parse(tbData.Text);
                        pedido.Total = decimal.Parse(tbTotal.Text.Replace("R$", ""));
                        pedido.Status = cbStatus.Text;
                        pedido.Observacao = tbObservacaoPedido.Text.Trim();

                        foreach (DataGridViewRow row in dgvPedidoProduto.Rows)
                        {
                            PedidoProduto pedidoProduto = new PedidoProduto();
                            pedidoProduto.IDProduto = int.Parse(row.Cells["colIDProduto"].Value.ToString());
                            pedidoProduto.IDCor = int.Parse(row.Cells["colIDCor"].Value.ToString());
                            pedidoProduto.IDTamanho = int.Parse(row.Cells["colIDTamanho"].Value.ToString());
                            pedidoProduto.Quantidade = int.Parse(row.Cells["colQuantidade"].Value.ToString());
                            pedidoProduto.Preco = decimal.Parse(row.Cells["colPreco"].Value.ToString().Replace("R$", ""));
                            pedidoProduto.Total = decimal.Parse(row.Cells["colTotal"].Value.ToString().Replace("R$", ""));
                            pedidoProduto.Observacao = row.Cells["colObservacao"].Value.ToString();

                            pedido.PedidoProduto.Add(pedidoProduto);
                        }

                        if (operacao == "Incluir")
                        {
                            pedido.Status = "Aberto";
                            banco.Pedido.InsertOnSubmit(pedido);
                        }

                        banco.SubmitChanges();
                        banco.Transaction.Commit();

                        MessageBox.Show("Pedido gravado com sucesso.", "Atenção",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao gravar o pedido.", "Atenção", MessageBoxButtons.OK, 
                            MessageBoxIcon.Error);
                        banco.Transaction.Rollback();
                    }
                    finally
                    {
                        banco.Connection.Close();
                        this.Dispose();
                        operacao = "Outro";
                    }
                }
            }
        }

        private bool validar()
        {
            Validacao.SetError(tbIDPedido, String.Empty);
            Validacao.SetError(tbIDProduto, String.Empty);

            bool resposta = true;

            if (!Convert.ToBoolean(tbIDPessoa.Tag))
            {
                Validacao.SetError(tbIDPedido, "Informe o cliente do pedido.");
                resposta = false;
                tbIDPessoa.Focus();
            }

            if (dgvPedidoProduto.RowCount == 0)
            {
                MessageBox.Show("Informe o produto do pedido.", "Confirmação",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                Validacao.SetError(tbIDProduto, "Informe o produto do pedido.");
                resposta = false;
            }

            return resposta;
        }

        private void efetuaConsulta()
        {
            BancoDataContext banco = new BancoDataContext();
            try
            {
                banco.Connection.Open();
                Pedido pedido = new Pedido();
                pedido = (from p in banco.Pedido where p.IDPedido == idPedido select p).SingleOrDefault();

                if (pedido != null)
                {
                    adicionarPedidoProduto(pedido.PedidoProduto.ToList());
                    tbIDPedido.Text = pedido.IDPedido.ToString();
                    tbIDPessoa.Text = pedido.IDPessoa.ToString();
                    tbUsuario.Text = pedido.Usuario.Login;
                    cbStatus.Text = pedido.Status;
                    tbData.Text = pedido.Data.ToShortDateString();
                    tbTotal.Text = String.Format("{0:C2}", pedido.Total);
                    tbObservacaoPedido.Text = pedido.Observacao;
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

        private void FormMovimentoPedido_Shown(object sender, EventArgs e)
        {
            cbStatus.Text = "Aberto";
            tbData.Text = DateTime.Now.ToShortDateString();
            tbUsuario.Text = Cache.login;
            tbIDPessoa.Focus();
            efetuaConsulta();
        }

        private void FormMovimentoPedido_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (operacao != "Outro")
            {
                if (MessageBox.Show("Confirma o cancelamento da operação?", 
                    "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void FormMovimentoPedido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }
    }
}
