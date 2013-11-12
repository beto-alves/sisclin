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
        private FuncionarioController funcionarioController;
        private ConsultaController consultaController;
        private int codigoAgenda = 0;
        private int excluiGrid = 0;
        private bool eMedico = false;

        public MarcaConsulta()
        {
            
            this.funcionarioController = new FuncionarioController();
            consultaController = new ConsultaController();
            InitializeComponent();            
            init();
        }

        public MarcaConsulta(FuncionarioVO medicoLogado, bool emedico)
        {
            this.funcionarioController = new FuncionarioController();
            consultaController = new ConsultaController();
            InitializeComponent();           
            init();

            List<FuncionarioVO> medico = new List<FuncionarioVO>();
            medico.Add(medicoLogado);
            cbMedico.DataSource = medico;
            cbMedico.Enabled = false;

            this.eMedico = emedico;

            btnDesmarcar.Enabled = false;
            btnDesmarcar.Visible = false;
            btnInserir.Enabled = false;
            btnInserir.Visible = false;

            carregaGrid();
        }

        public void init()
        {
            List<FuncionarioVO> medicos = this.funcionarioController.listarMedico();
            cbMedico.DataSource = medicos;
            dtDataConsulta.Value = DateTime.Now.Date;
        }

        private void dtDataConsulta_ValueChanged(object sender, EventArgs e)
        {
            carregaGrid();
        }

        private void carregaGrid()
        {
            string data = dtDataConsulta.Value.Date.ToString();
            FuncionarioVO medico = (FuncionarioVO)cbMedico.SelectedItem;

            DataTable dtHorarios = consultaController.retornaHorarios(data, medico.id);
            DataRow row;
            codigoAgenda = 0;

            if (dtHorarios.Rows.Count > 0)
            {
                codigoAgenda = int.Parse(dtHorarios.Rows[0]["idAgenda"].ToString());
            }

            if (dtHorarios.Rows.Count == 0)
            {
                int hora = 800;
                for (int i = 0; i < 11; i++)
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
            dgListaConsultas.Columns["idCodigo"].Visible = false;
            dgListaConsultas.Columns["horario"].HeaderText = "Horário";
            //dgListaConsultas.Columns["horario"].Width = 90;
            dgListaConsultas.Columns["nome"].HeaderText = "Nome"; 
        }

        private void dgListaConsultas_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (this.eMedico)
            {

                FuncionarioVO medico = (FuncionarioVO)cbMedico.SelectedItem;

                int idPacienteConsulta = int.Parse(dgListaConsultas.Rows[e.RowIndex].Cells["idPaciente"].Value.ToString());
                int horario = int.Parse(dgListaConsultas.Rows[e.RowIndex].Cells["horario"].Value.ToString());
                string dataAgenda = dtDataConsulta.Value.Date.ToString();

                RealizarConsulta objRealizarConsulta = new RealizarConsulta(medico.id, idPacienteConsulta, horario, dataAgenda);
                objRealizarConsulta.ShowDialog();
            }
            else
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
            
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            FuncionarioVO medico = (FuncionarioVO)cbMedico.SelectedItem;
            string dataAgenda = dtDataConsulta.Value.Date.ToString();

            if (codigoAgenda == 0)
            {

                if (consultaController.inserirAgenda((DataTable)dgListaConsultas.DataSource, medico.id, dataAgenda) != 0)
                {
                    MessageBox.Show(this, "Agenda atualizada com sucesso", "Agenda de horários", MessageBoxButtons.OK);
                }

                dgListaConsultas.DataSource = null;
                carregaGrid();
            }
            else
            {
                if (consultaController.atualizaAgenda((DataTable)dgListaConsultas.DataSource, medico.id, dataAgenda))
                {
                    MessageBox.Show(this, "Agenda atualizada com sucesso", "Agenda de horários", MessageBoxButtons.OK);
                }
                dgListaConsultas.DataSource = null;
                carregaGrid();
            }
            
        }

        private void dgListaConsultas_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (!String.IsNullOrEmpty(dgListaConsultas.CurrentRow.Cells["idPaciente"].Value.ToString()))
            {
                btnDesmarcar.Enabled = true;
                excluiGrid = e.RowIndex;
            }
            else
            {
                btnDesmarcar.Enabled = false;
            }            
        }

        public void desmarcaConsulta(int rowIndex)
        {            
            dgListaConsultas.Rows[rowIndex].Cells["idPaciente"].Value = 0;
            dgListaConsultas.Rows[rowIndex].Cells["nome"].Value = "";

            FuncionarioVO medico = (FuncionarioVO)cbMedico.SelectedItem;
            string dataAgenda = dtDataConsulta.Value.Date.ToString();

            if (consultaController.atualizaAgenda((DataTable)dgListaConsultas.DataSource, medico.id, dataAgenda))
            {
                MessageBox.Show(this, "Agenda atualizada com sucesso", "Agenda de horários", MessageBoxButtons.OK);
            }
            dgListaConsultas.DataSource = null;
            carregaGrid();
            btnDesmarcar.Enabled = false;

        }

        private void btnDesmarcar_Click(object sender, EventArgs e)
        {
            desmarcaConsulta(excluiGrid);
        }
    }
}
