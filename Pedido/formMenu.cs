using Pedido.BackupRestauracao;
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

namespace Pedido
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void UsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPesquisaUsuario formPesquisaUsuario = new FormPesquisaUsuario();
            formPesquisaUsuario.MdiParent = this;
            formPesquisaUsuario.Show();
        }

        private void EstadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPesquisaEstado formPesquisaEstado = new FormPesquisaEstado();
            formPesquisaEstado.MdiParent = this;
            formPesquisaEstado.Show();
        }

        private void PedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPesquisaPedido formPesquisaPedido = new FormPesquisaPedido();
            formPesquisaPedido.MdiParent = this;
            formPesquisaPedido.Show();
        }

        private void FormMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void CidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPesquisaCidade formPesquisaCidade = new FormPesquisaCidade();
            formPesquisaCidade.MdiParent = this;
            formPesquisaCidade.Show();
        }

        private void CorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPesquisaCor formPesquisaCor = new FormPesquisaCor();
            formPesquisaCor.MdiParent = this;
            formPesquisaCor.Show();
        }

        private void TamanhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPesquisaTamanho formPesquisaTamanho = new FormPesquisaTamanho();
            formPesquisaTamanho.MdiParent = this;
            formPesquisaTamanho.Show();
        }

        private void PessoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPesquisaPessoa formPesquisaPessoa = new FormPesquisaPessoa();
            formPesquisaPessoa.MdiParent = this;
            formPesquisaPessoa.Show();
        }

        private void ProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPesquisaProduto formPesquisaProduto = new FormPesquisaProduto();
            formPesquisaProduto.MdiParent = this;
            formPesquisaProduto.Show();
        }

        private void BackupRestauraçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBackupRestauracao formBackupRestauracao = new FormBackupRestauracao();
            formBackupRestauracao.MdiParent = this;
            formBackupRestauracao.Show();
        }
    }
}
