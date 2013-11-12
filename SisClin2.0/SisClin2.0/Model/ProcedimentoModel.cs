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

        public List<ProcedimentoVO> listaProcedimentos()
        {

            List<ProcedimentoVO> lista = new List<ProcedimentoVO>();

            using (MySqlConnection conexao = DaoMySQL.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();

                    string sql = "SELECT * FROM `procedimentos`";
                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            ProcedimentoVO procedimento = new ProcedimentoVO();

                            procedimento.idProcedimento = int.Parse(reader["idProcedimento"].ToString());
                            procedimento.nomeProcedimento = reader["nome"].ToString();
                            procedimento.descricao = reader["descricao"].ToString();
                            procedimento.valor = float.Parse(reader["valor"].ToString());

                            lista.Add(procedimento);
                        }
                    }

                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    conexao.Close();
                }
            }
            return lista;        
        }

        public DataTable listarProcedimentos()
        {
            DataTable dtProcedimentos = new DataTable();

            using (MySqlConnection conexao = DaoMySQL.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();

                    String sql = "SELECT * FROM `procedimentos`";

                    MySqlCommand mysqlCmd = new MySqlCommand(sql, conexao);

                    MySqlDataAdapter da = new MySqlDataAdapter(mysqlCmd);

                    da.Fill(dtProcedimentos);

                }
                catch (MySqlException e)
                {
                    throw;
                }
                finally
                {
                    conexao.Close();
                }
            }
            return dtProcedimentos;
        }

    }
}
