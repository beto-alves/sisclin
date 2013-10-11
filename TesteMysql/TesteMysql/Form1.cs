using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TesteMysql
{
    public partial class Form1 : Form
    {

        private string nome;
        private string email;
        private string msg;

        public Form1()
        {
            InitializeComponent();
            init();
        }

        public void init()
        {
            using (MySqlConnection conexaoMysql = DaoMySQL.getInstancia().getConexao())
            {
                try
                {
                    conexaoMysql.Open();

                    string mSQL = "SELECT * FROM mensagem";
                    MySqlCommand cmd = new MySqlCommand(mSQL, conexaoMysql);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                    DataTable dtMensagens = new DataTable();
                    da.Fill(dtMensagens);
                    this.dgMysql.DataSource = dtMensagens;


                }
                catch (MySqlException e)
                {
                    MessageBox.Show("Erro no acesso ao mysql " + e.Message, "Erro");
                }
                finally
                {
                    conexaoMysql.Close();
                }
            }
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            nome = txtNome.Text;
            email = txtEmail.Text;
            msg = txtMsg.Text;

            using (MySqlConnection conexaoMsqyl = DaoMySQL.getInstancia().getConexao())
            {
                try
                {
                    conexaoMsqyl.Open();

                    string consulta = "INSERT INTO mensagem VALUES('', '" + nome + "', '" + email + "', '" + msg + "')";
                    MySqlCommand cmd = new MySqlCommand(consulta, conexaoMsqyl);
                    cmd.ExecuteNonQuery();
                    init();
                }
                catch (MySqlException re)
                {
                    MessageBox.Show("Erro na operação: " + re.Message, "Erro");
                }
                finally
                {
                    conexaoMsqyl.Close();
                }
            }
        }
    }
}
