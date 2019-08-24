using Pedido.Movimento;
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
    public partial class FormCadastroTamanho : Form
    {
        public FormCadastroTamanho()
        {
            InitializeComponent();
        }

        string operacao;
        FormPesquisaTamanho formPesquisaTamanho;
        int idTamanho;
        FormCadastroProduto formCadastroProduto;
        FormMovimentoPedido formMovimentoPedido;

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

        public FormPesquisaTamanho FormPesquisaTamanho
        {
            get
            {
                return formPesquisaTamanho;
            }

            set
            {
                formPesquisaTamanho = value;
            }
        }

        public int IdTamanho
        {
            get
            {
                return idTamanho;
            }

            set
            {
                idTamanho = value;
                efetuaConsulta();
            }
        }

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

        public FormCadastroProduto FormCadastroProduto
        {
            get
            {
                return formCadastroProduto;
            }

            set
            {
                formCadastroProduto = value;
            }
        }

        private void bGravar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                if (MessageBox.Show("Confirma a gravação da cor", "Cofirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool erro = false;
                    BancoDataContext banco = new BancoDataContext();
                    try
                    {
                        banco.Connection.Open();
                        banco.Transaction = banco.Connection.BeginTransaction();

                        Tamanho tamanho = new Tamanho();

                        if (operacao == "Alterar")
                        {
                            tamanho = (from t in banco.Tamanho where t.IDTamanho == idTamanho select t).SingleOrDefault();
                        }

                        tamanho.Descricao = tbDescricao.Text;
                        tamanho.Status = cbStatus.Checked;

                        if (operacao == "Incluir")
                        {
                            tamanho.Status = true;
                            banco.Tamanho.InsertOnSubmit(tamanho);
                        }

                        banco.SubmitChanges();
                        banco.Transaction.Commit();

                        if (formCadastroProduto != null)
                        {
                            formCadastroProduto.cbIDTamanho.DataSource = (from t in banco.Tamanho where t.Status == true select t).ToList();
                            formCadastroProduto.cbIDTamanho.ValueMember = "IDTamanho";
                            formCadastroProduto.cbIDTamanho.DisplayMember = "Descricao";
                            formCadastroProduto.cbIDTamanho.Text = tamanho.Descricao;
                        }

                        if (formMovimentoPedido != null)
                        {
                            formMovimentoPedido.cbIDTamanho.DataSource = (from t in banco.Tamanho where t.Status == true select t).ToList();
                            formMovimentoPedido.cbIDTamanho.ValueMember = "IDTamanho";
                            formMovimentoPedido.cbIDTamanho.DisplayMember = "Descricao";
                            formMovimentoPedido.cbIDTamanho.Text = tamanho.Descricao;
                        }

                        MessageBox.Show("Tamanho gravado com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao gravar o tamanho.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Boolean resposta = true;

            if (String.IsNullOrEmpty(tbDescricao.Text))
            {
                Validacao.SetError(tbDescricao, "Informe a descrição do tamanho.");
                resposta = false;
            }

            return resposta;
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCadastroTamanho_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{Tab}");
        }

        private void limpar()
        {
            tbIDTamanho.Clear();
            tbDescricao.Clear();
            cbStatus.Checked = true;
        }

        private void efetuaConsulta()
        {
            BancoDataContext banco = new BancoDataContext();
            try
            {
                banco.Connection.Open();

                Tamanho tamanho = new Tamanho();
                tamanho = (from es in banco.Tamanho where es.IDTamanho == idTamanho select es).SingleOrDefault();

                if (tamanho != null)
                {
                    tbIDTamanho.Text = Convert.ToString(tamanho.IDTamanho);
                    tbDescricao.Text = tamanho.Descricao;
                    cbStatus.Checked = tamanho.Status;
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

        private void FormCadastroTamanho_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (operacao != "Outro")
            {
                if (MessageBox.Show("Confirma o cancelamento da operação?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
