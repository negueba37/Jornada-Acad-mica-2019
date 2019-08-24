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
    public partial class FormCadastroCor : Form
    {
        public FormCadastroCor()
        {
            InitializeComponent();
        }

        string operacao;
        FormPesquisaCor formPesquisaCor;
        int idCor;
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

        public FormPesquisaCor FormPesquisaCor
        {
            get
            {
                return formPesquisaCor;
            }

            set
            {
                formPesquisaCor = value;
            }
        }

        public int IdCor
        {
            get
            {
                return idCor;
            }

            set
            {
                idCor = value;
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

                        Cor cor = new Cor();

                        if (operacao == "Alterar")
                        {
                            cor = (from es in banco.Cor where es.IDCor == idCor select es).SingleOrDefault();
                        }

                        cor.Descricao = tbDescricao.Text;
                        cor.Status = cbStatus.Checked;

                        if (operacao == "Incluir")
                        {
                            cor.Status = true;
                            banco.Cor.InsertOnSubmit(cor);
                        }

                        banco.SubmitChanges();
                        banco.Transaction.Commit();

                        if (formMovimentoPedido != null)
                        {
                            formMovimentoPedido.cbIDCor.DataSource = (from c in banco.Cor where c.Status == true select c).ToList();
                            formMovimentoPedido.cbIDCor.ValueMember = "IDCor";
                            formMovimentoPedido.cbIDCor.DisplayMember = "Descricao";
                            formMovimentoPedido.cbIDCor.Text = cor.Descricao;
                        }

                        MessageBox.Show("Cor gravado com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao gravar a cor.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                Validacao.SetError(tbDescricao, "Informe o nome da cor.");
                resposta = false;
            }

            return resposta;
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCadastroCor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{Tab}");
        }

        private void limpar()
        {
            tbIDCor.Clear();
            tbDescricao.Clear();
            cbStatus.Checked = true;
        }

        private void efetuaConsulta()
        {
            BancoDataContext banco = new BancoDataContext();
            try
            {
                banco.Connection.Open();

                Cor cor = new Cor();
                cor = (from es in banco.Cor where es.IDCor == idCor select es).SingleOrDefault();

                if (cor != null)
                {
                    tbIDCor.Text = Convert.ToString(cor.IDCor);
                    tbDescricao.Text = cor.Descricao;
                    cbStatus.Checked = cor.Status;
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

        private void FormCadastroCor_FormClosing(object sender, FormClosingEventArgs e)
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
