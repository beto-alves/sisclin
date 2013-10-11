using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace TesteMysql
{
    class DaoMySQL
    {
        private static readonly DaoMySQL instancia = new DaoMySQL();

        private DaoMySQL() { }

        public static DaoMySQL getInstancia()
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
