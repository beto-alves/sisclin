using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SisClin2._0.Vo;

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

        public int realizaConsulta(ConsultaVO consulta)
        {
            int retorno;
            using (MySqlConnection conexao = DaoMySQL.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();

                    string sql = "INSERT INTO `consultarealizada` " + 
                                 "(`idConsulta`, `idMedico`, `idPaciente`, `horario`, " + 
                                 "`data`, `atestado`, `receita`, `informacoes`)" + 
                                 " VALUES " + 
                                 " (''," + consulta.medico.id + "," + consulta.paciente.id + ", " + consulta.horario + "," + 
                                 "'" + consulta.data + "','" + consulta.atestado + "','" + consulta.receita + "','" + consulta.informacoes + "')";

                    MySqlCommand cmd = new MySqlCommand(sql, conexao);

                    retorno = cmd.ExecuteNonQuery();

                    int idConsultaRealizada = (int)cmd.LastInsertedId;

                    if (consulta.procedimentos != null)
                    {
                        foreach (DataRow row in consulta.procedimentos.Rows)
                        {
                            string sqlProcedimentos = "INSERT INTO `procedimentoconsulta`" +
                                                      "(`idProcedimentoConsulta`, `idConsulta`, `idProcedimento`) " +
                                                      "VALUES " +
                                                      "(''," + idConsultaRealizada + "," + row["idProcedimento"] + ")";

                            cmd = new MySqlCommand(sqlProcedimentos, conexao);
                            cmd.ExecuteNonQuery();

                        }
                    }


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

        public DataTable listaConsultasPacientes(PacienteVO paciente)
        {

            DataTable tabela = new DataTable();

            using (MySqlConnection conexao = DaoMySQL.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();

                    string sqlConsulta = "SELECT  `consultarealizada`.`idconsulta` ,  `consultarealizada`.`idpaciente` ,  `consultarealizada`.`idmedico` ,  `consultarealizada`.`horario` ,  `consultarealizada`.`data` ,  `funcionario`.`idfuncionario` ,  `funcionario`.`nome` AS `nomeFuncionario` " +
                                         " FROM  `consultarealizada` " +
                                         " LEFT JOIN  `pacientes` ON  `pacientes`.`idpaciente` =  `consultarealizada`.`idpaciente` " +
                                         " LEFT JOIN  `funcionario` ON  `funcionario`.`idFuncionario` =  `consultarealizada`.`idmedico` " +
                                         " WHERE  `consultarealizada`.`idpaciente` = " + paciente.id;
                    MySqlCommand cmdConsulta = new MySqlCommand(sqlConsulta, conexao);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmdConsulta);
                    da.Fill(tabela);

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
            return tabela;
        }

        public ConsultaVO retornaUltimaConsulta(PacienteVO paciente, FuncionarioVO medico)
        {

            using (MySqlConnection conexao = DaoMySQL.getInstancia().getConexao())
            {
                ConsultaVO consultaVO = new ConsultaVO();
                try
                {
                    conexao.Open();

                    string sql = "SELECT * FROM  `consultarealizada` WHERE  `idPaciente` = " + paciente.id + " AND `idMedico` = " + medico.id + " ORDER BY  `idConsulta` DESC LIMIT 1";
                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        consultaVO.idConsulta = Int16.Parse(reader["idConsulta"].ToString());
                        consultaVO.data = reader["data"].ToString();
                        
                    }

                    return consultaVO;

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

        public ConsultaVO buscaConsultaID(int idConsulta)
        {
            using (MySqlConnection conexao = DaoMySQL.getInstancia().getConexao())
            {
                try
                {
                    ConsultaVO consulta = new ConsultaVO();
                    conexao.Open();

                    string sql = "SELECT * FROM `consultarealizada` WHERE `idConsulta` = " + idConsulta;
                    MySqlCommand cmd = new MySqlCommand(sql, conexao);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    PacienteVO paciente = new PacienteVO();
                    FuncionarioVO medico = new FuncionarioVO();

                    if (reader.HasRows)
                    {
                        reader.Read();

                        consulta.idConsulta = Int16.Parse(reader["idConsulta"].ToString());
                        paciente.id = Int16.Parse(reader["idPaciente"].ToString());
                        consulta.paciente = paciente;
                        medico.id = Int16.Parse(reader["idMedico"].ToString());
                        consulta.medico = medico;
                        consulta.horario = Int16.Parse(reader["horario"].ToString());
                        consulta.data = reader["data"].ToString();
                        consulta.atestado = reader["atestado"].ToString();
                        consulta.receita = reader["receita"].ToString();
                        consulta.informacoes = reader["informacoes"].ToString();                        
                    }
                    return consulta;

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