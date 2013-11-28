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
    public partial class PerfilPaciente : Form
    {
        PacienteController controller;
        PacienteVO paciente;

        public PerfilPaciente()
        {
            InitializeComponent();

            controller = new PacienteController();

            int codigo = Auxiliar.resultadoPesquisa;

            paciente = controller.buscaPaciente(codigo);
            pbFotoPaciente.ImageLocation = Application.StartupPath + @"\Fotos\" + paciente.foto + ".jpeg";
            lblNome.Text = paciente.nome;
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            ListaConsultas listaConsultas = new ListaConsultas(paciente.id);
            listaConsultas.ShowDialog();
        }

        private void btnInfoPaciente_Click(object sender, EventArgs e)
        {

        }

        private void PerfilPaciente_Load(object sender, EventArgs e)
        {

        }

       
    }
}
