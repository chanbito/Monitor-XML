using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MonitorDanfe.Apoio
{
    public partial class ConfiguraçõesForm : Form
    {
        public ConfiguraçõesForm()
        {
            InitializeComponent();
        }

        private void ConfiguraçõesForm_Load(object sender, EventArgs e)
        {
            this.Focus();

            var config = Configurações.BuscarConfig();

            PastaEntradatextBox.Text = config.CaminhoEntradaUnimake;
            PastaSaidatextBox.Text = config.Saida;
        }

        private static string BuscaPasta()
        {
            FolderBrowserDialog a = new FolderBrowserDialog();
            a.ShowDialog();
            return a.SelectedPath.ToString();
        }

        private void PastaEntradabutton_Click(object sender, EventArgs e)
        {
            PastaEntradatextBox.Text = BuscaPasta();
        }

        private void PastaSaidabutton_Click(object sender, EventArgs e)
        {
            PastaSaidatextBox.Text = BuscaPasta();
        }

        private void SalvarButton_Click(object sender, EventArgs e)
        {
            Configurações.Salvar(PastaEntradatextBox.Text + @"\", PastaSaidatextBox.Text + @"\");
            this.Close();
        }
    }
}
