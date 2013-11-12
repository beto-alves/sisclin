using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SisClin2._0.Vo;
using System.Data;
using MySql.Data.MySqlClient;

namespace SisClin2._0.Model
{
    class ProcedimentoModel
    {

        public int cadastraProcedimento(ProcedimentoVO procedimentoVO)
        {
            int retorno;
            using (MySqlConnection conexao = DaoMySQL.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();

                    string sql = "INSERT INTO `procedimentos`" + 
                                 "(`idProcedimento`, `nome`, `descricao`, `valor`) " + 
                                 " VALUES ('','" + procedimentoVO.nomeProcedimento + "', '" + procedimentoVO.descricao + "', '" + procedimentoVO.valor + "')";

                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    retorno = cmd.ExecuteNonQuery();

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
            return retorno;
        }

    }
}
