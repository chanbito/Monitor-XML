using DanfeSharp;
using DanfeSharp.Modelo;
using Model;
using MonitorDanfe.Apoio;
using MonitorDanfe.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonitorDanfe
{
    public partial class Form1 : Form
    {
        private int contador;
        
        public string Pesquisa { get; private set; }
        public ConfiguraçõesBanco Config { get; private set; }

        int timer = 0;
        string PastaEntrada = "";
        string PastaSaida = "";


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Config = Configurações.BuscarConfig();
            if (!Configurações.IsConfigurado())
            {
                ChamaConfig();
                timer = 0;
            }

            InicializaBanco();
            SetaLabel(timer);
            Atualiza.Start();

            this.Hide();
        }

        private void InicializaBanco()
        {
            var b = Config;
            if(b== null)
            {
                b = Configurações.BuscarConfig();
            }
            timer = b.timer;
            PastaEntrada = b.CaminhoEntradaUnimake;
            PastaSaida = b.Saida;
        }

        #region timer
        private void Atualiza_Tick(object sender, EventArgs e)
        {
            contador = int.Parse(LabelTimer.Text);
            Atualiza.Stop();
            if(contador > 0)
            {
                contador--;
                SetaLabel(contador);
            }
            else
            {
                if (!Processador.IsBusy)
                {
                    Processador.RunWorkerAsync();
                    AtualizaGrig();
                }
                SetaLabel(timer);
            }
            Atualiza.Start();
        }

        private void SetaLabel(int NumeroParaTela)
        {
            LabelTimer.Text = NumeroParaTela.ToString();
        }
        #endregion

        private void ConfigButton_Click(object sender, EventArgs e)
        {
            ChamaConfig();
        }

        private static void ChamaConfig()
        {
            ConfiguraçõesForm a = new ConfiguraçõesForm();
            a.ShowDialog();
        }

        private void ForçarButton_Click(object sender, EventArgs e)
        {
            if (!Processador.IsBusy)
            {
                Processador.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("Ja estou processando os arquivos");
            }
        }

        private void Processador_DoWork(object sender, DoWorkEventArgs e)
        {
            InicializaBanco();

            ProcessaArquivosAutorizados(PastaEntrada+@"Enviado\Autorizado\");
            ProcessaArquivosErro();
        }

        #region Erro
        private void ProcessaArquivosErro()
        {
            var ArquivosComErro = PastaEntrada + @"Erro\";
            var PastaRetorno = PastaEntrada + @"Retorno\";
            

            DirectoryInfo Retorno = new DirectoryInfo(ArquivosComErro);

            foreach (var arquivo in Retorno.GetFiles())
            {
                var nome = arquivo.Name.Split('.').FirstOrDefault();
                var extenção = arquivo.Name.Split('.').LastOrDefault();

                DirectoryInfo Destino = SubpastasOrganizadas(PastaSaida + @"NaoProcessado\");

                if (extenção.ToLower() != "xml")
                {
                    arquivo.MoveTo(Destino + arquivo.Name);
                    continue;
                }

                DirectoryInfo DestinoXMLErro = new DirectoryInfo(PastaSaida + @"XML\Erro\");
                if (!DestinoXMLErro.Exists)
                {
                    DestinoXMLErro.Create();
                }
                    using (Context a = new Context())
                    {
                        Notas b = new Notas
                        {
                            Caminho = DestinoXMLErro.FullName + arquivo.Name,
                            Detalhes = "Erro",
                            Status = RetornaErro(nome, PastaRetorno),
                            Numero = RetornarNumero(arquivo, "nNF"),
                            DataProcess = DateTime.Now
                            
                        };
                        a.Notas.Add(b);
                        a.SaveChanges();
                    }

                    arquivo.MoveTo(DestinoXMLErro + arquivo.Name);
            }
        }

        private string RetornaErro(string NomeOrigem, string pastaErro)
        {
            DirectoryInfo Erro = new DirectoryInfo(pastaErro);
            string retorno = "";

            foreach (var item in Erro.GetFiles())
            {
                var nome = item.Name.Split('.').FirstOrDefault();
                var extenção = item.Name.Split('.').LastOrDefault();

                if(nome == NomeOrigem && extenção == "err")
                {
                    using (StreamReader sr = item.OpenText())
                    {
                        string R = "";
                        while ((R = sr.ReadLine()) != null)
                        {
                            var tags = R.Trim().Split('|').ToList();
                            var a = tags.Contains("Message");
                            if (a)
                            {
                                var index = tags.FindIndex(x => x.Contains("Message"));
                                retorno = tags[index + 1].Trim();
                                return retorno;
                            }
                        }
                    }
                }
            }
            return "";
        }
        #endregion

        private void AtualizaGrig()
        {
            var query = "Select * from Notas ";
            if (!string.IsNullOrEmpty(Pesquisa))
            {
                query += $" where Numero like '%{Pesquisa}%' ";
            }
            query += " order by DataProcess ";

            var notas = new List<Notas>();
            using(var contexto = new Context())
            {
                notas = contexto.Notas.SqlQuery(query).ToList();
            }

            ReDraw.SuspendDrawing(this);

            int selecionado = -10;

            if(GridNotas.SelectedRows.Count > 0)
            {
                selecionado = GridNotas.SelectedRows[0].Index;
            }

            notasBindingSource.DataSource = null;
            notasBindingSource.DataSource = notas.Take(50);

            if(selecionado > 0)
            {
                GridNotas.Rows[selecionado].Selected = true;
                    //.Tag = DataGridViewElementStates.Selected;
            }

            ReDraw.ResumeDrawing(this);
        }

        #region entradaSucesso      

        private void ProcessaArquivosAutorizados(string pastaEntrada)
        {
            DirectoryInfo origem = new DirectoryInfo(pastaEntrada);

            var arquivos = origem.GetFiles();

            foreach (var arquivo in arquivos)
            {
                var nome = arquivo.Name.Split('.').FirstOrDefault();
                var extenção = arquivo.Name.Split('.').LastOrDefault();

                DirectoryInfo Destino = SubpastasOrganizadas(PastaSaida + @"NaoProcessado\");

                if (extenção.ToUpper() != "XML")
                {
                    arquivo.MoveTo(Destino + arquivo.Name);
                    continue;
                }

                DirectoryInfo DestinoXML = new DirectoryInfo(PastaSaida + @"XML\");
                if (!DestinoXML.Exists)
                {
                    DestinoXML.Create();
                }

                using(Context a = new Context())
                {

                    Notas b = new Notas
                    {
                        Caminho = DestinoXML.FullName + arquivo.Name,
                        Detalhes = "Aprovada",
                        Status = "Aprovada",
                        Numero = RetornarNumero(arquivo, "nNF"),
                        DataProcess = DateTime.Now
                    };
                    a.Notas.Add(b);
                    a.SaveChanges();
                }


                DirectoryInfo DestinoDANFE = SubpastasOrganizadas(PastaSaida + @"DANFE\");

                try
                {
                    var modelo = DanfeViewModelCreator.CriarDeArquivoXml(arquivo.FullName);

                    using (var danfe = new Danfe(modelo))
                    {
                        danfe.Gerar();
                        danfe.Salvar(DestinoDANFE.FullName + nome + ".PDF");
                    }
                    arquivo.MoveTo(DestinoXML + arquivo.Name);
                }
                catch
                {
                    arquivo.MoveTo(Destino + arquivo.Name);
                }
            }
        }

        #endregion

        private string RetornarNumero(FileInfo arquivo, string tag)
        {
            string retorno = "";
            using (StreamReader sr = arquivo.OpenText())
            {
                string R = "";
                while ((R = sr.ReadLine()) != null)
                {
                    var tags = R.Split('<', '>').ToList();
                    var a = tags.Contains(tag);
                    if (a)
                    {
                        var index = tags.FindIndex(x => x.Contains(tag));
                        retorno = tags[index + 1].Trim();
                    }
                }
            }
            return retorno;
        }

        private static DirectoryInfo SubpastasOrganizadas(string destino)
        {
            DirectoryInfo SubPastaano = new DirectoryInfo(destino + DateTime.Now.Year.ToString() + @"\");
            if (!SubPastaano.Exists)
            {
                Directory.CreateDirectory(SubPastaano.FullName);
            }

            DirectoryInfo SubPastames = new DirectoryInfo(SubPastaano + DateTime.Now.Month.ToString() + @"\");

            if (!SubPastames.Exists)
            {
                Directory.CreateDirectory(SubPastames.FullName);
            }

            DirectoryInfo SubPastadia = new DirectoryInfo(SubPastames + DateTime.Now.Day.ToString() + @"\");
            if (!SubPastadia.Exists)
            {
                Directory.CreateDirectory(SubPastadia.FullName);
            }

            return SubPastadia;
        }

        private void PesquisarButton_Click(object sender, EventArgs e)
        {
            Pesquisa = PesquisarTextBox.Text;
            AtualizaGrig();
        }

        private void VizualizarButton_Click(object sender, EventArgs e)
        {
            var selecionado = notasBindingSource.Current as Notas;

            if(selecionado == null)
            {
                MessageBox.Show("Selecione uma linha por favor!");
                return;
            }


            try
            {
                string caminhoPDF = SalvarTemp.Salvar(selecionado.Caminho);
                System.Diagnostics.Process.Start(caminhoPDF);
            }
            catch
            {
                MessageBox.Show("Verifique se o arquivo .XML esta na pasta correta");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var selecionado = notasBindingSource.Current as Notas;
            try
            {
                string caminhoPDF = SalvarTemp.Salvar(selecionado.Caminho);

                FileInfo file = new FileInfo(caminhoPDF);

                if (file.Exists)
                {
                    Process process = new Process();
                    Process objP = new Process();

                    objP.StartInfo.FileName = caminhoPDF;

                    objP.StartInfo.WindowStyle = ProcessWindowStyle.Hidden; //Hide the window.
                    objP.StartInfo.Verb = "print";
                    objP.StartInfo.CreateNoWindow = true;
                    objP.Start();

                    objP.CloseMainWindow();

                    MessageBox.Show("Arquivo enviado para sua impressora padrão");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
