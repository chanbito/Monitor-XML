using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MonitorDanfe.Apoio
{
    public class Configurações
    {
        public static void Salvar(string PastaEntrada, string PastaSaida)
        {
            try
            {
                var db = new Model.Context();

                var teste = BuscarConfig();
                if (teste == null)
                {
                    Model.ConfiguraçõesBanco b = new ConfiguraçõesBanco
                    {
                        CaminhoEntradaUnimake = PastaEntrada,
                        Saida = PastaSaida,
                        timer = 2
                    };
                    db.ConfiguraçõesBancos.Add(b);
                    db.SaveChanges();
                }
                else
                {
                    teste.CaminhoEntradaUnimake = PastaEntrada;
                    teste.Saida = PastaSaida;
                    db.ConfiguraçõesBancos.Add(teste);
                    db.SaveChanges();
                }
                MessageBox.Show("Salvo com Sucesso");
        }
            catch
            {
                MessageBox.Show("Falha ao salvar");
            }
}

        public static bool IsConfigurado()
        {
            var lista = new List<string>();
            var db = new Model.Context();
            Model.ConfiguraçõesBanco b = BuscarConfig();
            lista.Add(b.timer.ToString());
            lista.Add(b.CaminhoEntradaUnimake);
            lista.Add(b.Saida);

            return !lista.Any(string.IsNullOrWhiteSpace);
        }

        public static ConfiguraçõesBanco BuscarConfig()
        {
            var query = "Select * from ConfiguraçõesBanco";

            var config = new ConfiguraçõesBanco();
            using (var contexto = new Context())
            {
                config = contexto.ConfiguraçõesBancos.SqlQuery(query).FirstOrDefault();
            }

            return config;
        }
    }
}
