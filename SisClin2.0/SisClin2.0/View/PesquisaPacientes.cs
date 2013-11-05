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

namespace SisClin2._0.View
{
    public partial class PesquisaPacientes : Form
    {

        private PacienteController controller;

        private Form formOrigem;

        public PesquisaPacientes(Form form)
        {
            this.controller = new PacienteController();

            InitializeComponent();
            this.formOrigem = form;

            init();            
        }

        public void init()
        {
            DataTable listaPacientes = this.controller.listaPacientes();
            dgPesquisaPaciente.DataSource = listaPacientes;

            dgPesquisaPaciente.Columns["idPaciente"].Visible = false;
            dgPesquisaPaciente.Columns["telefone"].Visible = false;
            dgPesquisaPaciente.Columns["celular"].Visible = false;
            dgPesquisaPaciente.Columns["email"].Visible = false;
            dgPesquisaPaciente.Columns["rua"].Visible = false;
            dgPesquisaPaciente.Columns["bairro"].Visible = false;
            dgPesquisaPaciente.Columns["cidade"].Visible = false;
            dgPesquisaPaciente.Columns["estado"].Visible = false;
            dgPesquisaPaciente.Columns["complemento"].Visible = false;
            dgPesquisaPaciente.Columns["numero"].Visible = false;
            dgPesquisaPaciente.Columns["foto"].Visible = false;
            dgPesquisaPaciente.Columns["profissao"].Visible = false;
            dgPesquisaPaciente.Columns["cep"].Visible = false;
            dgPesquisaPaciente.Columns["nome"].HeaderText = "Nome";
            dgPesquisaPaciente.Columns["dataNascimento"].HeaderText = "Nascimento";
            dgPesquisaPaciente.Columns["rg"].HeaderText = "RG";
            dgPesquisaPaciente.Columns["cpf"].HeaderText = "CPF";

        }

        private void dgPesquisaPaciente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Auxiliar.resultadoPesquisa = Convert.ToInt16(dgPesquisaPaciente.Rows[e.RowIndex].Cells["idPaciente"].Value);

            if (this.formOrigem.Name == "FormPrincipal")
            {                
                Close();
                PerfilPaciente perfilPaciente = new PerfilPaciente();
                perfilPaciente.ShowDialog();
            }
            else if (this.formOrigem.Name == "CadastroPacientes")
            {
                Close(); 
            }
            else if (this.formOrigem.Name == "MarcaConsulta")
            {
                Close();
            }
            
        }
    }
}
