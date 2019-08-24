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

namespace Pedido.Cadastro
{
    public partial class FormCadastroProduto : Form
    {
        public FormCadastroProduto()
        {
            InitializeComponent();

            BancoDataContext banco = new BancoDataContext();
            try
            {
                banco.Connection.Open();
                cbIDTamanho.DataSource = (from t in banco.Tamanho where t.Status == true select t).ToList();
                cbIDTamanho.ValueMember = "IDTamanho";
                cbIDTamanho.DisplayMember = "Descricao";
                cbIDTamanho.Text = null;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                banco.Connection.Close();
            }
        }

        string operacao;
        int idProduto;
        FormPesquisaProduto formPesquisaProduto;

        public string Operacao
        {
            get
            {
                return operacao;
            }

            set
            {
                operacao = value;
            }
        }

        public int IdProduto
        {
            get
            {
                return idProduto;
            }

            set
            {
                idProduto = value;
                efetuaConsulta();
            }
        }

        public FormPesquisaProduto FormPesquisaProduto
        {
            get
            {
                return formPesquisaProduto;
            }

            set
            {
                formPesquisaProduto = value;
            }
        }

        private void bGravar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                if (MessageBox.Show("Confirma a gravação do produto?", "Cofirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool erro = false;
                    BancoDataContext banco = new BancoDataContext();
                    try
                    {
                        banco.Connection.Open();
                        banco.Transaction = banco.Connection.BeginTransaction();

                        Produto produto = new Produto();

                        if (operacao == "Alterar")
                        {
                            produto = (from p in banco.Produto where p.IDProduto == idProduto select p).SingleOrDefault();
                            banco.ProdutoTamanho.DeleteAllOnSubmit(produto.ProdutoTamanho);
                        }

                        produto.Descricao = tbDescricao.Text;
                        produto.Status = cbStatus.Checked;
                        produto.Referencia = tbReferencia.Text;

                        foreach (DataGridViewRow row in dgvProdutoTamanho.Rows)
                        {
                            ProdutoTamanho produtoTamanho = new ProdutoTamanho();
                            produtoTamanho.IDTamanho = int.Parse(row.Cells["colIDTamanho"].Value.ToString());
                            produtoTamanho.Preco = decimal.Parse(row.Cells["colPreco"].Value.ToString());
                            produto.ProdutoTamanho.Add(produtoTamanho);
                        }

                        if (operacao == "Incluir")
                        {
                            produto.Status = true;
                            banco.Produto.InsertOnSubmit(produto);
                        }

                        banco.SubmitChanges();
                        banco.Transaction.Commit();

                        MessageBox.Show("Produto gravado com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao gravar o produto.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        banco.Transaction.Rollback();
                        erro = true;
                    }
                    finally
                    {
                        banco.Connection.Close();
                        if (!erro)
                        {
                            operacao = "Outro";
                            this.Dispose();
                        }
                    }
                }
            }
        }

        private Boolean validar()
        {
            Validacao.SetError(tbDescricao, String.Empty);
            Validacao.SetError(tbReferencia, String.Empty);
            Boolean resposta = true;

            if (String.IsNullOrEmpty(tbDescricao.Text))
            {
                Validacao.SetError(tbDescricao, "Informe a descrição do produto.");
                resposta = false;
            }

            if (String.IsNullOrEmpty(tbReferencia.Text))
            {
                Validacao.SetError(tbReferencia, "Informe a referência do produto.");
                resposta = false;
            }

            return resposta;
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void efetuaConsulta()
        {
            BancoDataContext banco = new BancoDataContext();
            try
            {
                banco.Connection.Open();
                Produto produto = new Produto();
                produto = (from p in banco.Produto where p.IDProduto == IdProduto select p).SingleOrDefault();

                if (produto != null)
                {
                    tbIDProduto.Text = produto.IDProduto.ToString();
                    tbDescricao.Text = produto.Descricao;
                    cbStatus.Checked = produto.Status;
                    tbReferencia.Text = produto.Referencia;

                    adicionarProdutoTamanho(produto.ProdutoTamanho.ToList());
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

        private void FormCadastroProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }

        private void bCadastrarTamanho_Click(object sender, EventArgs e)
        {
            FormCadastroTamanho formCadastroTamanho = new FormCadastroTamanho();
            formCadastroTamanho.FormCadastroProduto = this;
            formCadastroTamanho.Operacao = "Incluir";
            formCadastroTamanho.ShowDialog();
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

        private void tbPreco_TextChanged(object sender, EventArgs e)
        {
            moeda(tbPreco);
        }

        private void adicionarProdutoTamanho(ProdutoTamanho produtoTamanho)
        {
            bool adicionar = true;
            foreach (DataGridViewRow row in dgvProdutoTamanho.Rows)
            {
                if (int.Parse(row.Cells["colIDTamanho"].Value.ToString()) == produtoTamanho.IDTamanho)
                {
                    adicionar = false;
                    break;
                }
            }

            if (adicionar)
            {
                dgvProdutoTamanho.Rows.Add(produtoTamanho.IDTamanho, produtoTamanho.Tamanho.Descricao, produtoTamanho.Preco);
            }
        }

        private void adicionarProdutoTamanho(List<ProdutoTamanho> produtosTamanhos)
        {
            dgvProdutoTamanho.Rows.Clear();
            foreach (ProdutoTamanho produtoTamanho in produtosTamanhos)
            {
                adicionarProdutoTamanho(produtoTamanho);
            }
        }

        private bool validarProdutoTamanho()
        {
            Validacao.SetError(tbPreco, string.Empty);
            Validacao.SetError(cbIDTamanho, String.Empty);

            bool resposta = true;

            if (decimal.Parse(tbPreco.Text.Replace("R$", "")) == 0)
            {
                Validacao.SetError(tbPreco, "Informe o preço do produto.");
                resposta = false;
                tbPreco.Focus();
            }

            if (cbIDTamanho.SelectedValue == null)
            {
                Validacao.SetError(cbIDTamanho, "Informe o tamanho do produto.");
                resposta = false;
                cbIDTamanho.Focus();
            }

            return resposta;
        }

        private void bRemover_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma a retirada do tamanho da lista?", "Cofirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dgvProdutoTamanho.Rows.Remove(dgvProdutoTamanho.CurrentRow);
            }
        }

        private void FormCadastroProduto_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (operacao != "Outro")
            {
                if (MessageBox.Show("Confirma o cancelamento da operação?", "Cofirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void tbPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void bAdicionar_Click(object sender, EventArgs e)
        {
            if (validarProdutoTamanho())
            {
                BancoDataContext banco = new BancoDataContext();
                try
                {
                    banco.Connection.Open();
                    ProdutoTamanho produtoTamanho = new ProdutoTamanho();
                    produtoTamanho.IDTamanho = int.Parse(cbIDTamanho.SelectedValue.ToString());
                    produtoTamanho.Tamanho = (from t in banco.Tamanho where t.IDTamanho == produtoTamanho.IDTamanho select t).SingleOrDefault();
                    produtoTamanho.Preco = decimal.Parse(tbPreco.Text.Replace("R$", ""));

                    adicionarProdutoTamanho(produtoTamanho);

                }
                catch (Exception ex)
                {

                }
                finally
                {
                    banco.Connection.Close();
                    cbIDTamanho.SelectedValue = string.Empty;
                    tbPreco.Text = "0";
                    cbIDTamanho.Focus();
                }
            }
        }
    }
}
