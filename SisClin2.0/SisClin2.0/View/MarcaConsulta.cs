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
    public partial class MarcaConsulta : Form
    {
        private PacienteVO paciente;
        private FuncionarioVO funcionario;
        private FuncionarioController funcionarioController;
        private ConsultaController consultaController;

        public MarcaConsulta()
        {
            this.funcionarioController = new FuncionarioController();
            consultaController = new ConsultaController();
            InitializeComponent();
            init();
        }

        public void init()
        {
            List<FuncionarioVO> medicos = this.funcionarioController.listarMedico();
            cbMedico.DataSource = medicos;
        }

        private void dtDataConsulta_ValueChanged(object sender, EventArgs e)
        {

            string data = dtDataConsulta.Value.Date.ToString();
            FuncionarioVO medico = (FuncionarioVO)cbMedico.SelectedItem;

            DataTable dtHorarios = consultaController.retornaHorarios(data, medico.id);
            DataRow row; 

            if (dtHorarios.Rows.Count == 0)
            {
                int hora = 800;
                for(int i = 0; i < 11; i++)
                {
                    row = dtHorarios.NewRow();
                    row["horario"] = hora;
                    row["idPaciente"] = 0;
                    hora += 100;
                    dtHorarios.Rows.Add(row);
                }
            }

            dgListaConsultas.DataSource = dtHorarios;
            dgListaConsultas.Columns["idPaciente"].Visible = false;
            dgListaConsultas.Columns["idAgenda"].Visible = false;
            dgListaConsultas.Columns["horario"].HeaderText = "Horário";
            dgListaConsultas.Columns["nome"].HeaderText = "Nome";
        }

        private void dgListaConsultas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PesquisaPacientes listaPacientes = new PesquisaPacientes(this);
            listaPacientes.ShowDialog();

            int codigo = Auxiliar.resultadoPesquisa;

            if (codigo != 0)
            {
                PacienteController pacienteController = new PacienteController();
                paciente = pacienteController.buscaPaciente(codigo);               
            }

            dgListaConsultas.CurrentRow.Cells["nome"].Value = paciente.nome;
            dgListaConsultas.CurrentRow.Cells["idPaciente"].Value = paciente.id;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            FuncionarioVO medico = (FuncionarioVO)cbMedico.SelectedItem;
            string dataAgenda = dtDataConsulta.Value.Date.ToString();

            consultaController.inserirAgenda((DataTable)dgListaConsultas.DataSource, medico.id, dataAgenda);
        }
    }
}
