using Pedido.Cadastro;
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
    public partial class FormPesquisaEstado : Form
    {
        public FormPesquisaEstado()
        {
            InitializeComponent();
        }

        private void bIncluir_Click(object sender, EventArgs e)
        {
            FormCadastroEstado formCadastroEstado = new FormCadastroEstado();
            formCadastroEstado.operacao = "Incluir";
            formCadastroEstado.formPesquisaEstado = this;
            formCadastroEstado.ShowDialog();
            pesquisar();
        }

        private void bAlterar_Click(object sender, EventArgs e)
        {
            if (dgvEstados.RowCount > 0)
            {
                FormCadastroEstado formCadastroEstado = new FormCadastroEstado();
                formCadastroEstado.operacao = "Alterar";
                formCadastroEstado.Idestado = int.Parse(dgvEstados.CurrentRow.Cells["colIDEstado"].Value.ToString());
                formCadastroEstado.formPesquisaEstado = this;
                formCadastroEstado.ShowDialog();
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

                List<Estado> estados = new List<Estado>();
                estados = banco.ExecuteQuery<Estado>(comandoSql()).ToList();

                dgvEstados.Rows.Clear();

                foreach (Estado estado in estados)
                {
                    dgvEstados.Rows.Add(estado.IDEstado,estado.Nome,estado.UF);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                banco.Connection.Close();
            }
        }

        private string comandoSql()
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendFormat("Select\n");
            sql.AppendFormat("	e.*\n");
            sql.AppendFormat("From\n");
            sql.AppendFormat("	Estado e\n");
            sql.AppendFormat("Where\n");
            sql.AppendFormat("	e.IDEstado <> 0\n");
            if(!String.IsNullOrEmpty(tbIDEstado.Text))
            {
                sql.AppendFormat("	And e.IDEstado = {0}\n", tbIDEstado.Text);
            }
            if (!String.IsNullOrEmpty(tbNome.Text))
            {
                sql.AppendFormat("	And e.Nome Like '%{0}%'", tbNome.Text);
            }
            if (!String.IsNullOrEmpty(tbUF.Text))
            {
                sql.AppendFormat("	And e.UF Like '%{0}%'", tbUF.Text);
            }
            sql.AppendFormat("Order By");
            sql.AppendFormat("	e.Nome Asc");

            return sql.ToString();
        }

        private void bExcluir_Click(object sender, EventArgs e)
        {
            if(dgvEstados.RowCount > 0)
            {
                if (MessageBox.Show("Confirma a exclusão do estado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BancoDataContext banco = new BancoDataContext();
                    try
                    {
                        banco.Connection.Open();
                        banco.Transaction = banco.Connection.BeginTransaction();

                        Estado estado = new Estado();
                        estado = (from es in banco.Estado where es.IDEstado == int.Parse(dgvEstados.CurrentRow.Cells["colIDEstado"].Value.ToString()) select es).SingleOrDefault();

                        if (estado != null)
                        {
                            banco.Estado.DeleteOnSubmit(estado);
                        }                   

                        banco.SubmitChanges();
                        banco.Transaction.Commit();
                        MessageBox.Show("Estado excluido com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Erro ao excluir o estado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public void limpar()
        {
            tbIDEstado.Clear();
            tbNome.Clear();
            tbUF.Clear();
            dgvEstados.Rows.Clear();
        }

        private void FormPesquisaEstado_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }
    }
}
