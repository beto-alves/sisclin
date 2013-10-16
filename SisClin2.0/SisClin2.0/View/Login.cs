using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SisClin2._0.Controller;
using SisClin2._0.Vo;

namespace SisClin2._0.View
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            FuncionarioVO funcionarioVo = new FuncionarioVO();
            funcionarioVo.nome = txtNome.Text;
            funcionarioVo.senha = txtSenha.Text;

            FuncionarioController funcionarioController = new FuncionarioController();

            if (funcionarioController.login(funcionarioVo))
            {
                this.Hide();
                this.Show();
            }
            else
            {
                MessageBox.Show(this, "Dados não encontrados, verifique suas informações", "Erro login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }          
           
        }
    }
}
