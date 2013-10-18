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
    public partial class PesquisaFuncionario : Form
    {
        public PesquisaFuncionario()
        {
            InitializeComponent();
            init();
        }

        private void init() 
        {
            FuncionarioController controller = new FuncionarioController();
            DataTable lista = controller.listarFuncionarios();
            dgListaFuncionarios.DataSource = lista;
            dgListaFuncionarios.Columns["idFuncionario"].Visible = false;
            dgListaFuncionarios.Columns["telefone"].Visible = false;
            dgListaFuncionarios.Columns["celular"].Visible = false;
            dgListaFuncionarios.Columns["email"].Visible = false;
            dgListaFuncionarios.Columns["crm"].Visible = false;
            dgListaFuncionarios.Columns["especializacao"].Visible = false;
            dgListaFuncionarios.Columns["rua"].Visible = false;
            dgListaFuncionarios.Columns["bairro"].Visible = false;
            dgListaFuncionarios.Columns["cidade"].Visible = false;
            dgListaFuncionarios.Columns["estado"].Visible = false;
            dgListaFuncionarios.Columns["complemento"].Visible = false;
            dgListaFuncionarios.Columns["senha"].Visible = false;
            dgListaFuncionarios.Columns["horarioTrabalho"].Visible = false;
            dgListaFuncionarios.Columns["numero"].Visible = false;
            dgListaFuncionarios.Columns["nome"].HeaderText = "Nome";
            dgListaFuncionarios.Columns["dataNascimento"].HeaderText = "Nascimento";
            dgListaFuncionarios.Columns["rg"].HeaderText = "RG";
            dgListaFuncionarios.Columns["cpf"].HeaderText = "CPF";
            dgListaFuncionarios.Columns["funcao"].HeaderText = "Função";
        }
        
    }
}
