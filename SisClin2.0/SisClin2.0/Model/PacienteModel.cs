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

        public bool cadPaciente(PacienteVO paciente)
        {
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

    }
}
