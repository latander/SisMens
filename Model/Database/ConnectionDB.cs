using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensalidades.Model.Database
{
    public class ConnectionDB
    {
        static string server = "127.0.0.1";
        static string porta = "5432";
        static string user = "postgres";
        static string password = "123";
        static string nameDB = "sismens";

        public ConnectionDB()
        {
            strConn = String.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};",
               server, porta, user, password, nameDB);
        }

        public string strConn { get; private set; }
    }
}
