using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisClin2._0.Model
{
    class ConsultaModel
    {
        public DataTable RetornarHorarios(string data, int idMedico)
        {
            DataTable dtHorarios = new DataTable();

            using (MySqlConnection conexao = DaoMySQL.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();

                    String sql = "SELECT agenda.idAgenda, horario, pacientes.idPaciente, horarioagenda.idCodigo, nome FROM horarioagenda";
                    sql += " LEFT JOIN pacientes ON pacientes.idpaciente = horarioagenda.idpaciente";
                    sql += " INNER JOIN AGENDA ON AGENDA.IDAGENDA = HORARIOAGENDA.IDAGENDA";
                    sql += " WHERE idmedico = " + idMedico + " AND data = '" + data + "'";

                    MySqlCommand mysqlCmd = new MySqlCommand(sql, conexao);

                    MySqlDataAdapter da = new MySqlDataAdapter(mysqlCmd);

                    da.Fill(dtHorarios);

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

            return dtHorarios;
        }

        public int inserAgenda(DataTable table, int medico, string dataAgenda)
        {
            int retorno = 0;
            using (MySqlConnection conexao = DaoMySQL.getInstancia().getConexao())
            {
                try
                {

                    conexao.Open();
                    string sqlAgenda = "INSERT INTO `agenda`(`idAgenda`, `idMedico`, `data`) VALUES (''," + medico + ",'" + dataAgenda + "')";
                    MySqlCommand cmd = new MySqlCommand(sqlAgenda, conexao);
                    cmd.ExecuteNonQuery();
                    int idAgenda = (int)cmd.LastInsertedId;

                    foreach (DataRow row in table.Rows)
                    {
                        string sqlHorario = "INSERT INTO `horarioagenda`(`idAgenda`, `idCodigo`, `Horario`, `idPaciente`) VALUES (" + idAgenda + ", '' ,'" + row["horario"] + "'," + row["idPaciente"] + ")";
                        cmd = new MySqlCommand(sqlHorario, conexao);
                        cmd.ExecuteNonQuery();
                    }

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
            return retorno;
        }

        public bool atualizaAgenda(DataTable table, int medico, string dataAgenda)
        {
            using (MySqlConnection conexao = DaoMySQL.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();
                    MySqlCommand cmd;

                    foreach (DataRow row in table.Rows)
                    {

                        string sql;

                        if (String.IsNullOrEmpty(row["idPaciente"].ToString()) || row["idPaciente"].Equals(0))
                        {
                            sql = "UPDATE `horarioagenda` SET `idPaciente`= null WHERE idCodigo = " + row["idCodigo"];
                        }
                        else
                        {
                            sql = "UPDATE `horarioagenda` SET `idPaciente`= " + row["idPaciente"] + " WHERE idCodigo = " + row["idCodigo"];
                        }

                        cmd = new MySqlCommand(sql, conexao);
                        cmd.ExecuteNonQuery();
                    }

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
            return true;
        }


    }
}
