using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SisClin2._0.Vo;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SisClin2._0.Model
{
    class FuncionarioModel
    {

        public bool login(FuncionarioVO funcionario)
        {
            using (MySqlConnection conexao = DaoMySQL.getInstancia().getConexao())
            {

                try
                {
                    conexao.Open();
                    string sql = "SELECT * FROM funcionario WHERE nome = '" + funcionario.nome + "' AND senha = '" + funcionario.senha + "'";
                    MySqlCommand cmdSql = new MySqlCommand(sql, conexao);

                    MySqlDataReader dataReader = cmdSql.ExecuteReader();

                    if (dataReader.HasRows)
                    {
                        return true;
                    }
                    return false;


                }
                catch (MySqlException e)
                {
                    MessageBox.Show("Erro no acesso ao mysql " + e.Message, "Erro");
                }
                finally
                {
                    conexao.Close();
                }

            }

            return false;
 
        }

    }
}
