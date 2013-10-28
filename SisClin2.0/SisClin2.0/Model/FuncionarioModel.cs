using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SisClin2._0.Vo;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace SisClin2._0.Model
{
    class FuncionarioModel
    {
        public bool cadFuncionario(FuncionarioVO funcionario)
        {
            using (MySqlConnection conexao = DaoMySQL.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();

                    string sql = "INSERT INTO `funcionario`(`idFuncionario`, `nome`, `dataNascimento`, `rg`, `cpf`, `telefone`, `celular`," +
                                                            "`email`, `rua`, `bairro`, `cidade`, `cep`, `estado`, `complemento`, `numero`," +
                                                            "`funcao`, `horarioTrabalho`, `senha`, `crm`, `especializacao`) " +
                                                            "VALUES " + 
                                                            "('','" + funcionario.nome + "','" + funcionario.nascimento + "','" + funcionario.rg + "'," +
                                                            "'" + funcionario.cpf + "','" + funcionario.telefone + "','" + funcionario.celular + "'," + 
                                                            "'" + funcionario.email + "','" + funcionario.rua + "','" + funcionario.bairro + "','" + funcionario.cidade + "'," +
                                                            "'" + funcionario.cep + "','" + funcionario.estado + "','" + funcionario.complemento + "','" + funcionario.numero + "'," +
                                                            "'" + funcionario.funcao + "','" + funcionario.horario + "','" + funcionario.senha + "','" + funcionario.crm + "', '" + funcionario.especializacao + "')";

                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    cmd.ExecuteNonQuery();

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

        public FuncionarioVO login(FuncionarioVO funcionario)
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
                        dataReader.Read();

                        funcionario.id   = int.Parse(dataReader["idFuncionario"].ToString());
                        funcionario.nome = dataReader["nome"].ToString();
                        funcionario.nascimento = dataReader["dataNascimento"].ToString();
                        funcionario.cpf = dataReader["cpf"].ToString();
                        funcionario.rg = dataReader["rg"].ToString();
                        funcionario.telefone = dataReader["telefone"].ToString();
                        funcionario.celular = dataReader["celular"].ToString();
                        funcionario.email = dataReader["email"].ToString();
                        funcionario.rua = dataReader["rua"].ToString();
                        funcionario.cep = dataReader["cep"].ToString();
                        funcionario.bairro = dataReader["bairro"].ToString();
                        funcionario.cidade = dataReader["cidade"].ToString();
                        funcionario.estado = dataReader["estado"].ToString();
                        funcionario.complemento = dataReader["complemento"].ToString();
                        funcionario.numero = dataReader["numero"].ToString();
                        funcionario.funcao = dataReader["funcao"].ToString();
                        funcionario.horario = dataReader["horarioTrabalho"].ToString();
                        funcionario.senha = dataReader["senha"].ToString();
                        funcionario.crm = dataReader["crm"].ToString();
                        funcionario.especializacao = dataReader["especializacao"].ToString();

                        return funcionario;
                    }
                    return funcionario;


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

            return funcionario;
 
        }

        public DataTable listaFuncionarios()
        {
            DataTable dtFuncionarios = new DataTable();

            using (MySqlConnection conexao = DaoMySQL.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();

                    String sql = "SELECT * FROM funcionario";

                    MySqlCommand mysqlCmd = new MySqlCommand(sql, conexao);

                    MySqlDataAdapter da = new MySqlDataAdapter(mysqlCmd);

                    da.Fill(dtFuncionarios);

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

            return dtFuncionarios;
        }

        public FuncionarioVO buscaFuncionario(int codigo)
        {
            FuncionarioVO funcionario = new FuncionarioVO();
            using (MySqlConnection conexao = DaoMySQL.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();

                    String sql = "SELECT * from funcionario WHERE idFuncionario = " + codigo;

                    MySqlCommand cmd = new MySqlCommand(sql, conexao);

                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    if (dataReader.HasRows)
                    {
                        dataReader.Read();
                        funcionario.id = Int16.Parse(dataReader["idFuncionario"].ToString());
                        funcionario.nome = dataReader["nome"].ToString();
                        funcionario.nascimento = dataReader["dataNascimento"].ToString();
                        funcionario.cpf = dataReader["cpf"].ToString();
                        funcionario.rg = dataReader["rg"].ToString();
                        funcionario.telefone = dataReader["telefone"].ToString();
                        funcionario.celular = dataReader["celular"].ToString();
                        funcionario.email = dataReader["email"].ToString();
                        funcionario.rua = dataReader["rua"].ToString();
                        funcionario.bairro = dataReader["bairro"].ToString();
                        funcionario.cidade = dataReader["cidade"].ToString();
                        funcionario.cep = dataReader["cep"].ToString();
                        funcionario.estado = dataReader["estado"].ToString();
                        funcionario.complemento = dataReader["complemento"].ToString();
                        funcionario.numero = dataReader["numero"].ToString();
                        funcionario.funcao = dataReader["funcao"].ToString();
                        funcionario.horario = dataReader["horarioTrabalho"].ToString();
                        funcionario.senha = dataReader["senha"].ToString();
                        funcionario.crm = dataReader["crm"].ToString();
                        funcionario.especializacao = dataReader["especializacao"].ToString();

                        return funcionario;
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
            return funcionario;
        }

        public bool atualizaFuncionario(FuncionarioVO funcionario)
        {
            using (MySqlConnection conexao = DaoMySQL.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();

                    String sql = "UPDATE `funcionario` SET " +
                                 "`nome`='" + funcionario.nome + "',`dataNascimento`='" + funcionario.nascimento + "',`rg`='" + funcionario.rg + "',`cpf`='" + funcionario.cpf + "'," +
                                 "`telefone`='" + funcionario.telefone + "',`celular`='" + funcionario.celular + "',`email`='" + funcionario.email + "'," +
                                 "`rua`='" + funcionario.rua + "',`bairro`='" + funcionario.bairro + "',`cidade`='" + funcionario.cidade + "'," +
                                 "`cep`='" + funcionario.cep + "',`estado`='" + funcionario.estado + "',`complemento`='" + funcionario.complemento + "'," +
                                 "`numero`='" + funcionario.numero + "',`funcao`='" + funcionario.funcao + "',`horarioTrabalho`='" + funcionario.horario + "'," +
                                 "`senha`='" + funcionario.senha + "',`crm`='" + funcionario.crm + "',`especializacao`='" + funcionario.especializacao + "' WHERE `idFuncionario` = " + funcionario.id.ToString();

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

        public bool deletaFuncionario(FuncionarioVO funcionario)
        {
            using (MySqlConnection conexao = DaoMySQL.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();
                    
                    string sql = "DELETE FROM funcionario WHERE `idFuncionario` = " + funcionario.id.ToString();
                    
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

    }
}
