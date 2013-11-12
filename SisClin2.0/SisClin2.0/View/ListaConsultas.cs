using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SisClin2._0.Vo;
using SisClin2._0.Controller;

namespace SisClin2._0.View
{
    public partial class ListaConsultas : Form
    {
        private PacienteController pacienteController = new PacienteController();
        private PacienteVO paciente;

        public ListaConsultas(int idPaciente)
        {
            this.paciente = pacienteController.buscaPaciente(idPaciente);

            InitializeComponent();
            lblPaciente.Text = paciente.nome;
        }
    }
}
