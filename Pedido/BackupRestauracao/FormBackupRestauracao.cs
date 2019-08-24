using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pedido.BackupRestauracao
{
    public partial class FormBackupRestauracao : Form
    {
        public FormBackupRestauracao()
        {
            InitializeComponent();
        }

        private void bCaminhoBackup_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                tbCaminhoBackup.Text = folderBrowserDialog.SelectedPath;
                bBackup.Enabled = true;
            }
            else
            {
                tbCaminhoBackup.Text = string.Empty;
                bBackup.Enabled = false;
            }
        }

        private void bCaminhoRestaurar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            openFileDialog.InitialDirectory = tbCaminhoBackup.Text;

            if (!String.IsNullOrEmpty(openFileDialog.FileName))
            {
                tbCaminhoRestauracao.Text = openFileDialog.FileName;
            }
        }

        private void bBackup_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbCaminhoBackup.Text))
            {
                BancoDataContext banco = new BancoDataContext("Data Source=lab5-prof;Initial Catalog=Master;User ID=sa;Password=1234");
                try
                {
                    banco.Connection.Open();
                    StringBuilder sql = new StringBuilder();
                    sql.AppendFormat(@"BACKUP DATABASE [{0}] TO DISK = '{1}\{0}_{2:yyyyMMdd_HHmmss}.bak'", "Banco", tbCaminhoBackup.Text, DateTime.Now);
                    banco.ExecuteCommand(sql.ToString());

                    MessageBox.Show("Backup realizado com sucesso.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                finally
                {
                    banco.Connection.Close();
                }

            }
        }

        private void bRestaurar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbCaminhoRestauracao.Text))
            {
                BancoDataContext banco = new BancoDataContext("Data Source=lab5-prof;Initial Catalog=Master;User ID=sa;Password=1234");
                try
                {
                    banco.Connection.Open();
                    StringBuilder sql = new StringBuilder();
                    sql.Append(@"ALTER DATABASE [Banco] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                    banco.ExecuteCommand(sql.ToString());

                    sql.Clear();
                    sql.AppendFormat("RESTORE DATABASE [Banco] FROM DISK = '{0}'", tbCaminhoRestauracao.Text);
                    banco.ExecuteCommand(sql.ToString());

                    sql.Clear();
                    sql.Append("ALTER DATABASE [Banco] SET MULTI_USER");
                    banco.ExecuteCommand(sql.ToString());

                    MessageBox.Show("Restauração realizado com sucesso.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                finally
                {
                    banco.Connection.Close();
                }
            }
        }
    }
}
