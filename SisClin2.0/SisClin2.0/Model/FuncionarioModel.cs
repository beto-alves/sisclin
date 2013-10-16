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
                        funcionario.nascimento = DateTime.Parse(dataReader["dataNascimento"].ToString());
                        funcionario.cpf = dataReader["cpf"].ToString();
                        funcionario.rg = dataReader["rg"].ToString();
                        funcionario.telefone = dataReader["telefone"].ToString();
                        funcionario.celular = dataReader["celular"].ToString();
                        funcionario.email = dataReader["email"].ToString();
                        funcionario.rua = dataReader["rua"].ToString();
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

    }
}
