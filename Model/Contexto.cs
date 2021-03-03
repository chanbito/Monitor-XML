using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public static class Contexto
    {
        public static DbContext Servidor = new DbContext(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DataBase;Integrated Security=false;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
    }
}
