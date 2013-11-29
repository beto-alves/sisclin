using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace SisClin2._0.Model
{
    class MovimentacaoModel
    {
        public int registraMovimentacao(float valor, string tipo, int idConsulta, int idPaciente, string data)
        {
            using (MySqlConnection conexao = DaoMySQL.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();

                    string sql = "INSERT INTO `movimentacaofinanceira` " + 
                                 " (`idMovimentacao`, `idPaciente`, `idConsulta`, `tipo`, `valor`, `data`) " + 
                                 " VALUES " + 
                                 " ('',"+ idPaciente +"," + idConsulta + ",'" + tipo + "','" + valor + "', '" + data + "')";

                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    int retorno = cmd.ExecuteNonQuery();
                    return retorno;

                }
                catch (MySqlException)
                {
                    throw;
                }
                finally
                {
                    conexao.Close();
                }
            }
        }

        public DataTable listaProcedimentos(int idPaciente)
        {
            using (MySqlConnection conexao = DaoMySQL.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();
                    string sql = "SELECT * FROM `movimentacaofinanceira` WHERE `idPaciente` = " + idPaciente;
                    MySqlCommand cmd = new MySqlCommand(sql, conexao);

                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);

                    return dt;
                }
                catch (MySqlException)
                {
                    throw;
                }
                finally
                {
                    conexao.Close();
                }
            }
        }

    }
}
