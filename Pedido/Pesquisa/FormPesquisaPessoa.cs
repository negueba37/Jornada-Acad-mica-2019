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
    public partial class FormPesquisaPessoa : Form
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

        public FormPesquisaPessoa()
        {
            InitializeComponent();
        }

        private void bIncluir_Click(object sender, EventArgs e)
        {
            FormCadastroPessoa formCadastroPessoa = new FormCadastroPessoa();
            formCadastroPessoa.Operacao = "Incluir";
            formCadastroPessoa.FormPesquisaPessoa = this;
            formCadastroPessoa.ShowDialog();
            limpar();
            pesquisar();
        }

        private void bAlterar_Click(object sender, EventArgs e)
        {
            if (dgvPessoas.Rows.Count > 0)
            {
                FormCadastroPessoa formCadastroPessoa = new FormCadastroPessoa();
                formCadastroPessoa.Operacao = "Alterar";
                formCadastroPessoa.IdPessoa = int.Parse(dgvPessoas.CurrentRow.Cells["colIDPessoa"].Value.ToString());
                formCadastroPessoa.FormPesquisaPessoa = this;
                formCadastroPessoa.ShowDialog();
                limpar();
                pesquisar();
            }
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

                List<Pessoa> pessoas = new List<Pessoa>();
                pessoas = banco.ExecuteQuery<Pessoa>(sql()).ToList();

                dgvPessoas.Rows.Clear();

                foreach (Pessoa pessoa in pessoas)
                {
                    dgvPessoas.Rows.Add(
                        pessoa.IDPessoa,
                        pessoa.Status,
                        pessoa.Nome_RazaoSocial,
                        pessoa.Apelido_Fantasia,
                        pessoa.CPF_CNPJ,
                        pessoa.RG_InscricaoEstadual,
                        pessoa.Cidade.Nome,
                        pessoa.Cidade.Estado.UF);
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

        private string sql()
        {
            StringBuilder comando = new StringBuilder();
            comando.Append("Select\n");
            comando.Append("    p.*\n");
            comando.Append("From\n");
            comando.Append("    Pessoa p\n");
            comando.Append("    Inner Join Cidade c On c.IDCidade = p.IDCidade\n");
            comando.Append("    Inner Join Estado e On e.IDEstado = c.IDEstado\n");
            comando.Append("Where\n");
            comando.Append("    p.IDPessoa <> 0\n");            
            if (!String.IsNullOrEmpty(tbIDPessoa.Text))
            {
                comando.AppendFormat("    And p.IDPessoa = {0}\n", tbIDPessoa.Text);
            }
            if (!String.IsNullOrEmpty(tbNome_RazaoSocial.Text))
            {
                comando.AppendFormat("    And p.Nome_RazaoSocial Like '%{0}%'\n", tbNome_RazaoSocial.Text);
            }
            if (!String.IsNullOrEmpty(tbApelido_Fantasia.Text))
            {
                comando.AppendFormat("    And p.Apelido_Fantasia Like '%{0}%'\n", tbApelido_Fantasia.Text);
            }
            if (!String.IsNullOrEmpty(tbCPF_CNPJ.Text))
            {
                comando.AppendFormat("    And p.CPF_CNPJ Like '%{0}%'\n", tbCPF_CNPJ.Text);
            }
            if (!String.IsNullOrEmpty(tbRG_InscricaoEstadual.Text))
            {
                comando.AppendFormat("    And p.RG_InscricaoEstadual Like '%{0}%'\n", tbRG_InscricaoEstadual.Text);
            }
            if (!String.IsNullOrEmpty(tbCidade.Text))
            {
                comando.AppendFormat("    And c.Nome Like '%{0}%'\n", tbCidade.Text);
            }
            if (!String.IsNullOrEmpty(tbUF.Text))
            {
                comando.AppendFormat("    And e.UF Like '%{0}%'\n", tbUF.Text);
            }
            if (!String.IsNullOrEmpty(cbStatus.Text))
            {
                comando.AppendFormat("    And p.Status = {0}\n", cbStatus.Text == "Ativo" ? 1 : 0);
            }
            comando.Append("Order by\n");
            comando.Append("    p.Nome_RazaoSocial Asc");
            return comando.ToString();
        }

        private void bExcluir_Click(object sender, EventArgs e)
        {
            if (dgvPessoas.RowCount > 0)
            {
                if (MessageBox.Show("Confirma a exclusão da pessoa?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BancoDataContext banco = new BancoDataContext();
                    try
                    {
                        banco.Connection.Open();
                        banco.Transaction = banco.Connection.BeginTransaction();

                        Pessoa pessoa = new Pessoa();
                        pessoa = (from p in banco.Pessoa where p.IDPessoa == int.Parse(dgvPessoas.CurrentRow.Cells["colIDPessoa"].Value.ToString()) select p).SingleOrDefault();

                        if (pessoa != null)
                        {
                            banco.Pessoa.DeleteOnSubmit(pessoa);
                        }

                        banco.SubmitChanges();
                        banco.Transaction.Commit();
                        MessageBox.Show("Pessoa excluida com sucesso.","Atenção",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir a pessoa.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            tbIDPessoa.Clear();
            cbStatus.Text = string.Empty;
            tbNome_RazaoSocial.Clear();
            tbApelido_Fantasia.Clear();
            tbCPF_CNPJ.Clear();
            tbRG_InscricaoEstadual.Clear();
            tbCidade.Clear();
            tbUF.Clear();
            dgvPessoas.Rows.Clear();
        }

        private void FormPesquisaPessoa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }

        private void bFechar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgvPessoas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idPessoa = int.Parse(dgvPessoas.CurrentRow.Cells["colIDPessoa"].Value.ToString());

            if(formMovimentoPedido != null)
            {
                formMovimentoPedido.tbIDPessoa.Text = idPessoa.ToString();
            }

            this.Dispose();
        }
    }
}
