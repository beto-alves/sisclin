using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace SisClin2._0.Model
{
    class Connection
    {
        private static readonly Connection instancia = new Connection();

        private Connection() { }

        public static Connection getInstancia()
        {
            return instancia;
        }

        public MySqlConnection getConexao()
        {
            string conn = ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ToString();
            return new MySqlConnection(conn);
        }
    }
}
