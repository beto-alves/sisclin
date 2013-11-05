using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SisClin2._0.Vo;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SisClin2._0.Model
{
    class PacienteModel
    {

        public int cadPaciente(PacienteVO paciente)
        {
            int retorno = 0;
            using (MySqlConnection conexao = DaoMySQL.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();

                    string sql = "INSERT INTO " + 
                                    "`pacientes` " + 
                                 "(`idPaciente`, `nome`, `dataNascimento`, `rg`," + 
                                 "`cpf`, `telefone`, `celular`, `email`, " + 
                                 "`rua`, `bairro`, `cidade`, `cep`," + 
                                 "`estado`, `complemento`, `numero`, `foto`," + 
                                 " `profissao`) " + 
                                    " VALUES " + 
                                 "('','" + paciente.nome + "','" + paciente.nascimento + "','" + paciente.rg + "'," +
                                 "'" + paciente.cpf + "','" + paciente.telefone + "','" + paciente.celular + "','" + paciente.email + "', " +
                                 "'" + paciente.rua + "','" + paciente.bairro + "','" + paciente.cidade + "','" + paciente.cep + "'," +
                                 "'" + paciente.estado + "','" + paciente.complemento + "','" + paciente.numero + "','" + paciente.foto + "','" + paciente.profissao + "')";

                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    retorno = cmd.ExecuteNonQuery();
                    return retorno;

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

        public DataTable listaPacientes()
        {
            DataTable dtPacientes = new DataTable();

            using (MySqlConnection conexao = DaoMySQL.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();

                    String sql = "SELECT * FROM pacientes";

                    MySqlCommand mysqlCmd = new MySqlCommand(sql, conexao);

                    MySqlDataAdapter da = new MySqlDataAdapter(mysqlCmd);

                    da.Fill(dtPacientes);

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

            return dtPacientes;
        }

        public PacienteVO buscaPaciente(int codigo)
        {
            PacienteVO paciente = new PacienteVO();
            using (MySqlConnection conexao = DaoMySQL.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();

                    String sql = "SELECT * from pacientes WHERE idPaciente = " + codigo;

                    MySqlCommand cmd = new MySqlCommand(sql, conexao);

                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    if (dataReader.HasRows)
                    {
                        dataReader.Read();
                        paciente.id = Int16.Parse(dataReader["idPaciente"].ToString());
                        paciente.nome = dataReader["nome"].ToString();
                        paciente.nascimento = dataReader["dataNascimento"].ToString();
                        paciente.cpf = dataReader["cpf"].ToString();
                        paciente.rg = dataReader["rg"].ToString();
                        paciente.telefone = dataReader["telefone"].ToString();
                        paciente.celular = dataReader["celular"].ToString();
                        paciente.email = dataReader["email"].ToString();
                        paciente.rua = dataReader["rua"].ToString();
                        paciente.bairro = dataReader["bairro"].ToString();
                        paciente.cidade = dataReader["cidade"].ToString();
                        paciente.cep = dataReader["cep"].ToString();
                        paciente.estado = dataReader["estado"].ToString();
                        paciente.complemento = dataReader["complemento"].ToString();
                        paciente.numero = dataReader["numero"].ToString();
                        paciente.profissao = dataReader["profissao"].ToString();
                        paciente.foto = dataReader["foto"].ToString();

                        return paciente;
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
            return paciente;
        }

        public bool deletaPaciente(PacienteVO paciente)
        {
            using (MySqlConnection conexao = DaoMySQL.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();

                    string sql = "DELETE FROM pacientes WHERE `idPaciente` = " + paciente.id.ToString();

                    MySqlCommand cmd = new MySqlCommand(sql, conexao);

                    int i = cmd.ExecuteNonQuery();

                    if (i == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
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

        public bool atualizaPaciente(PacienteVO paciente)
        {
            using (MySqlConnection conexao = DaoMySQL.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();

                    String sql = "UPDATE `pacientes` SET " +
                                 "`nome`='" + paciente.nome + "',`dataNascimento`='" + paciente.nascimento + "',`rg`='" + paciente.rg + "',`cpf`='" + paciente.cpf + "'," +
                                 "`telefone`='" + paciente.telefone + "',`celular`='" + paciente.celular + "',`email`='" + paciente.email + "'," +
                                 "`rua`='" + paciente.rua + "',`bairro`='" + paciente.bairro + "',`cidade`='" + paciente.cidade + "'," +
                                 "`cep`='" + paciente.cep + "',`estado`='" + paciente.estado + "',`complemento`='" + paciente.complemento + "'," +
                                 "`numero`='" + paciente.numero + "',`foto`='" + paciente.foto + "', `profissao`='" + paciente.profissao +
                                 "' WHERE `idPaciente` = " + paciente.id.ToString();

                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    int i = cmd.ExecuteNonQuery();

                    if (i == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
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

        public bool buscaPaciente(string cpf)
        {
            using (MySqlConnection conexao = DaoMySQL.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();

                    string sql = "SELECT * FROM `pacientes` WHERE `cpf` = '" + cpf + "'";

                    MySqlCommand cmd = new MySqlCommand(sql, conexao);

                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    if (dataReader.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
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

            return false;

        }

    }
}
