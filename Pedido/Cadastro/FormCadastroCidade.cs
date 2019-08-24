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
    public partial class FormCadastroCidade : Form
    {
        public FormCadastroCidade()
        {
            InitializeComponent();

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
        string operacao;
        int idCidade;
        FormPesquisaCidade formPesquisaCidade;
        FormCadastroPessoa formCadastroPessoa;

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
        public int IdCidade
        {
            get
            {
                return idCidade;
            }

            set
            {
                idCidade = value;
                EfetuaConsulta();
            }
        }
        public FormPesquisaCidade FormPesquisaCidade
        {
            get
            {
                return formPesquisaCidade;
            }

            set
            {
                formPesquisaCidade = value;
            }
        }

        public FormCadastroPessoa FormCadastroPessoa
        {
            get
            {
                return formCadastroPessoa;
            }

            set
            {
                formCadastroPessoa = value;
            }
        }

        private void FormCadastroCidade_Shown(object sender, EventArgs e)
        {

        }

        private void bGravar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if (MessageBox.Show("Confirma a gravação da cidade?", "Configuração", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool erro = false;
                    BancoDataContext banco = new BancoDataContext();
                    try
                    {
                        banco.Connection.Open();
                        banco.Transaction = banco.Connection.BeginTransaction();

                        Cidade cidade = new Cidade();

                        if (operacao == "Alterar")
                        {
                            cidade = (from c in banco.Cidade where c.IDCidade == idCidade select c).SingleOrDefault();
                        }

                        cidade.Nome = tbNome.Text;
                        cidade.IDEstado = int.Parse(cbUF.SelectedValue.ToString());

                        if (operacao == "Incluir")
                        {
                            banco.Cidade.InsertOnSubmit(cidade);
                        }

                        banco.SubmitChanges();
                        banco.Transaction.Commit();

                        if (formCadastroPessoa != null)
                        {
                            formCadastroPessoa.cbCidade.DataSource = (from c in banco.Cidade select c).ToList();
                            formCadastroPessoa.cbCidade.ValueMember = "IDCidade";
                            formCadastroPessoa.cbCidade.DisplayMember = "Nome";
                            formCadastroPessoa.cbCidade.Text = cidade.Nome;
                        }

                        MessageBox.Show("Cidade gravada com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Erro ao gravar a cidade.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private bool Validar()
        {
            Validacao.SetError(tbNome, null);
            Validacao.SetError(cbUF, null);

            bool resposta = true;

            if (String.IsNullOrEmpty(tbNome.Text))
            {
                Validacao.SetError(tbNome, "Informe o nome da cidade.");
                resposta = false;
            }

            if (String.IsNullOrEmpty(cbUF.Text))
            {
                Validacao.SetError(cbUF, "Informe a UF da cidade.");
                resposta = false;
            }

            return resposta;
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EfetuaConsulta()
        {
            BancoDataContext banco = new BancoDataContext();
            try
            {
                banco.Connection.Open();
                Cidade cidade = new Cidade();
                cidade = (from c in banco.Cidade where c.IDCidade == idCidade select c).SingleOrDefault();

                if (cidade != null)
                {
                    tbIDCidade.Text = cidade.IDCidade.ToString();
                    tbNome.Text = cidade.Nome;
                    cbUF.SelectedValue = cidade.IDEstado;
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

        private void FormCadastroCidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }
       
        private void FormCadastroCidade_FormClosing(object sender, FormClosingEventArgs e)
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
