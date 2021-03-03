using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model
{
    public class Context : DbContext
    {
        public DbSet<Notas> Notas { get; set; }
        public DbSet<ConfiguraçõesBanco> ConfiguraçõesBancos { get; set; }

    }

    public class ConfiguraçõesBanco
    {
        public int ID { get; set; }
        public string CaminhoEntradaUnimake { get; set; }
        public string Saida { get; set; }
        public int timer { get; set; }
    }

    public class Notas
    {
        public int ID { get; set; }
        public string Status { get; set; }
        public string Caminho { get; set; }
        public string Detalhes { get; set; }
        public string Numero { get; set; }
        public DateTime DataProcess { get; set; }
    }
}
