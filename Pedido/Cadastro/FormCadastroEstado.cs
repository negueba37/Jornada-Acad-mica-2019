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
    public partial class FormCadastroEstado : Form
    {

        public string operacao { get; set; }
        private int idestado;
        public FormPesquisaEstado formPesquisaEstado { get; set; }

        public int Idestado
        {
            get
            {
                return idestado;
            }

            set
            {
                idestado = value;
                efetuaConsulta();
            }
        }

        public FormCadastroEstado()
        {
            InitializeComponent();
        }

        private void bGravar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                if (MessageBox.Show("Confirma a gravação do estado","Cofirmação",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool erro = false;
                    BancoDataContext banco = new BancoDataContext();
                    try
                    {
                        banco.Connection.Open();
                        banco.Transaction = banco.Connection.BeginTransaction();

                        Estado estado = new Estado();

                        if (operacao == "Alterar")
                        {
                            estado = (from es in banco.Estado where es.IDEstado == idestado select es).SingleOrDefault();
                        }

                        estado.Nome = tbNome.Text;
                        estado.UF = tbUF.Text;

                        if(operacao == "Incluir")
                        {
                            banco.Estado.InsertOnSubmit(estado);
                        }                        

                        banco.SubmitChanges();
                        banco.Transaction.Commit();

                        MessageBox.Show("Estado gravado com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao gravar a estado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            if (String.IsNullOrEmpty(tbNome.Text))
            {
                Validacao.SetError(tbNome,"Informe o nome do estado.");
                resposta = false;
            }

            if (String.IsNullOrEmpty(tbUF.Text))
            {
                Validacao.SetError(tbUF, "Informe a UF do estado.");
                resposta = false;
            }

            return resposta;
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {           
            this.Close();           
        }

        private void FormCadastroEstado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{Tab}");
        }

        private void limpar()
        {
            tbIDEstado.Clear();
            tbNome.Clear();
            tbUF.Clear();            
        }

        private void efetuaConsulta()
        {
            BancoDataContext banco = new BancoDataContext();
            try
            {
                banco.Connection.Open();
                
                Estado estado = new Estado();                
                estado = (from es in banco.Estado where es.IDEstado == idestado select es).SingleOrDefault();
                
                if (estado != null)
                {
                    tbIDEstado.Text = Convert.ToString(estado.IDEstado);
                    tbNome.Text = estado.Nome;
                    tbUF.Text = estado.UF;
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

        private void FormCadastroEstado_FormClosing(object sender, FormClosingEventArgs e)
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
