using DanfeSharp;
using DanfeSharp.Modelo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorDanfe.Apoio
{
    public static class SalvarTemp
    {
        internal static string Salvar(string caminho)
        {
            FileInfo file = new FileInfo(caminho);

            var caminhoTemp = Path.GetTempPath();

            var modelo = DanfeViewModelCreator.CriarDeArquivoXml(file.FullName);

            string arquivo = caminhoTemp + file.Name.Split('.').FirstOrDefault() + ".PDF";


            using (var danfe = new Danfe(modelo))
            {
                danfe.Gerar();
                danfe.Salvar(arquivo);
            }

            return arquivo;
        }
    }
}
