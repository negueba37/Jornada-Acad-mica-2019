using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pedido.Pesquisa;

namespace Pedido.Cadastro
{
    public partial class FormCadastroPessoa : Form
    {
        string operacao;
        int idPessoa;
        FormPesquisaPessoa formPesquisaPessoa;

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

        public int IdPessoa
        {
            get
            {
                return idPessoa;
            }

            set
            {
                idPessoa = value;
                efetuaConsulta();
            }
        }

        public FormPesquisaPessoa FormPesquisaPessoa
        {
            get
            {
                return formPesquisaPessoa;
            }

            set
            {
                formPesquisaPessoa = value;
            }
        }

        public FormCadastroPessoa()
        {
            InitializeComponent();

            BancoDataContext banco = new BancoDataContext();
            try
            {
                banco.Connection.Open();
                cbUF.DataSource = (from e in banco.Estado select e).ToList();
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

        private void bGravar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                if (MessageBox.Show("Confirma a gravação da pessoa?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BancoDataContext banco = new BancoDataContext();
                    bool erro = false;
                    try
                    {
                        banco.Connection.Open();
                        banco.Transaction = banco.Connection.BeginTransaction();

                        Pessoa pessoa = new Pessoa();
                        if (operacao == "Alterar")
                        {
                            pessoa = (from p in banco.Pessoa where p.IDPessoa == IdPessoa select p).Single();
                        }

                        pessoa.IDCidade = int.Parse(cbCidade.SelectedValue.ToString());
                        pessoa.Status = cbStatus.Checked;
                        pessoa.Tipo = char.Parse(rbFisica.Checked ? "F" : "J");
                        pessoa.Nome_RazaoSocial = tbNomeRazaoSocial.Text;
                        pessoa.Apelido_Fantasia = tbApelido_Fantasia.Text;
                        pessoa.CPF_CNPJ = mtbCPF_CNPJ.Text;
                        pessoa.RG_InscricaoEstadual = tbRG_IncricaoEstadual.Text;
                        pessoa.Endereco = tbEndereco.Text;
                        pessoa.Bairro = tbBairro.Text;
                        pessoa.Numero = tbNumero.Text;
                        pessoa.Complemento = tbComplemento.Text;
                        pessoa.Telefone = mtbTelefone.Text;
                        pessoa.Celular = mtbCelular.Text;
                        pessoa.Email = tbEmail.Text;
                        pessoa.CEP = mtbCEP.Text.Replace("-", "");

                        if (operacao == "Incluir")
                        {
                            pessoa.Status = true;
                            banco.Pessoa.InsertOnSubmit(pessoa);
                        }
                        banco.SubmitChanges();
                        banco.Transaction.Commit();
                        MessageBox.Show("Pessoa gravada com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao gravar o pessoa.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private bool validar()
        {
            Validacao.SetError(cbCidade, String.Empty);
            Validacao.SetError(tbNomeRazaoSocial, String.Empty);
            Validacao.SetError(mtbCPF_CNPJ, String.Empty);

            bool resposta = true;

            if (String.IsNullOrEmpty(cbCidade.Text))
            {
                Validacao.SetError(cbCidade, "Informe a cidade da pessoa.");
                resposta = false;
                cbCidade.Focus();
            }

            if (String.IsNullOrEmpty(tbNomeRazaoSocial.Text))
            {
                Validacao.SetError(tbNomeRazaoSocial, string.Format("Informe o {0} da pessoa.", lbNomeRazaoSocial.Text.ToLower()));
                resposta = false;
                tbNomeRazaoSocial.Focus();
            }

            if (String.IsNullOrEmpty(mtbCPF_CNPJ.Text))
            {
                Validacao.SetError(mtbCPF_CNPJ, string.Format("Informe o {0} da pessoa.", rbFisica.Checked ? "CPF" : "CNPJ"));
                resposta = false;
                mtbCPF_CNPJ.Focus();
            }
            else
            {
                if (rbFisica.Checked)
                {
                    if (!IsCpf(mtbCPF_CNPJ.Text))
                    {
                        Validacao.SetError(mtbCPF_CNPJ, "Informe um CPF válido.");
                        resposta = false;
                        mtbCPF_CNPJ.Focus();
                    }
                    else
                        resposta = verificarDuplicidadeCadastro();
                }
                else
                {
                    if (!IsCnpj(mtbCPF_CNPJ.Text))
                    {
                        Validacao.SetError(mtbCPF_CNPJ, "Informe um CNPJ válido.");
                        resposta = false;
                        mtbCPF_CNPJ.Focus();
                    }
                    else
                        resposta = verificarDuplicidadeCadastro();
                }
            }

            return resposta;
        }

        private bool verificarDuplicidadeCadastro()
        {
            BancoDataContext banco = new BancoDataContext();
            try
            {
                banco.Connection.Open();
                Pessoa pessoa = new Pessoa();
                pessoa = (from p in banco.Pessoa where p.CPF_CNPJ.Equals(mtbCPF_CNPJ.Text.Trim()) select p).SingleOrDefault();
                if (pessoa != null)
                {
                    if (operacao == "Incluir")
                    {
                        Validacao.SetError(mtbCPF_CNPJ, String.Format("Já existe uma pessoa cadastrada com esse {0}", lbCPF_CNPJ.Text));
                        mtbCPF_CNPJ.Focus();
                        return false;
                    }
                    else if (operacao == "Alterar")
                    {
                        if (int.Parse(tbIDPessoa.Text) != pessoa.IDPessoa)
                        {
                            Validacao.SetError(mtbCPF_CNPJ, String.Format("Já existe uma pessoa cadastrada com esse {0}", lbCPF_CNPJ.Text));
                            mtbCPF_CNPJ.Focus();
                            return false;
                        }
                    }
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                banco.Connection.Close();
            }
            return true;
        }

        public static bool IsCnpj(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;
            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");
            if (cnpj.Length != 14)
                return false;
            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cnpj.EndsWith(digito);
        }

        public static bool IsCpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
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
                Pessoa pessoa = new Pessoa();
                pessoa = (from p in banco.Pessoa where p.IDPessoa == IdPessoa select p).SingleOrDefault();

                if (pessoa != null)
                {
                    tbIDPessoa.Text = pessoa.IDPessoa.ToString();
                    if (pessoa.Cidade != null)
                    {
                        cbUF.SelectedValue = pessoa.Cidade.IDEstado;
                        cbCidade.SelectedValue = pessoa.IDCidade;
                    }
                    cbStatus.Checked = pessoa.Status;
                    rbFisica.Checked = pessoa.Tipo == char.Parse("F") ? true : false;
                    rbJuridica.Checked = pessoa.Tipo == char.Parse("J") ? true : false;
                    tbNomeRazaoSocial.Text = pessoa.Nome_RazaoSocial;
                    tbApelido_Fantasia.Text = pessoa.Apelido_Fantasia;
                    mtbCPF_CNPJ.Text = pessoa.CPF_CNPJ;
                    tbRG_IncricaoEstadual.Text = pessoa.RG_InscricaoEstadual;
                    tbEndereco.Text = pessoa.Endereco;
                    tbBairro.Text = pessoa.Bairro;
                    tbNumero.Text = pessoa.Numero;
                    tbComplemento.Text = pessoa.Complemento;
                    mtbTelefone.Text = pessoa.Telefone;
                    mtbCelular.Text = pessoa.Celular;
                    tbEmail.Text = pessoa.Email;
                    mtbCEP.Text = pessoa.CEP;
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

        private void FormCadastroPessoa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }

        private void rbFisica_CheckedChanged(object sender, EventArgs e)
        {
            lbNomeRazaoSocial.Text = "Nome";
            lbCPF_CNPJ.Text = "CPF";
            mtbCPF_CNPJ.Mask = "000,000,000-00";
            lbRG_IncricaoEstadual.Text = "RG";
        }

        private void rbJuridica_CheckedChanged(object sender, EventArgs e)
        {
            lbNomeRazaoSocial.Text = "Razão Social";
            lbCPF_CNPJ.Text = "CNPJ";
            mtbCPF_CNPJ.Mask = "00,000,000/0000-00";
            lbRG_IncricaoEstadual.Text = "Inscrição Estadual";
        }

        private void bCadastrarCidade_Click(object sender, EventArgs e)
        {
            FormCadastroCidade formCadastroCidade = new FormCadastroCidade();
            formCadastroCidade.FormCadastroPessoa = this;
            formCadastroCidade.Operacao = "Incluir";
            formCadastroCidade.ShowDialog();
        }

        private void cbUF_SelectedIndexChanged(object sender, EventArgs e)
        {
            BancoDataContext banco = new BancoDataContext();
            try
            {
                banco.Connection.Open();
                cbCidade.DataSource = (from c in banco.Cidade where c.IDEstado == int.Parse(cbUF.SelectedValue.ToString()) select c).ToList();
                cbCidade.ValueMember = "IDCidade";
                cbCidade.DisplayMember = "Nome";
                cbCidade.Text = null;
            }
            catch (Exception)
            {

            }
            finally
            {
                banco.Connection.Close();
            }
        }

        private void FormCadastroPessoa_FormClosing(object sender, FormClosingEventArgs e)
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
