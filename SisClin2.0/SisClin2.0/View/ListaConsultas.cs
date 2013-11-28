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
        private  ConsultaController consultaController = new ConsultaController();

        private PacienteVO paciente;

        public ListaConsultas(int idPaciente)
        {
            this.paciente = pacienteController.buscaPaciente(idPaciente);

            InitializeComponent();
            lblPaciente.Text = paciente.nome;
            carregaGrid();
        }

        public void carregaGrid()
        {
            dgListaConsultas.DataSource = this.consultaController.listaConsultasPacientes(this.paciente);
            dgListaConsultas.Columns["idPaciente"].Visible = false;
            dgListaConsultas.Columns["idMedico"].Visible = false;
            dgListaConsultas.Columns["idFuncionario"].Visible = false;
            dgListaConsultas.Columns["idConsulta"].Visible = false;
            dgListaConsultas.Columns["nomeFuncionario"].HeaderText = "Médico";
            dgListaConsultas.Columns["horario"].HeaderText = "Horário";
            dgListaConsultas.Columns["data"].HeaderText = "Data";
        }

        private void dgListaConsultas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idConsulta = Int16.Parse(dgListaConsultas.Rows[e.RowIndex].Cells["idConsulta"].Value.ToString());
            RealizarConsulta consulta = new RealizarConsulta(idConsulta);
            consulta.ShowDialog();
        }
    }
}
