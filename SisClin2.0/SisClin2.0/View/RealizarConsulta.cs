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
using System.IO;
using System.Drawing.Printing;

namespace SisClin2._0.View
{
    public partial class RealizarConsulta : Form
    {
        private FuncionarioController funcionarioController;
        private PacienteController pacienteController;
        private ProcedimentoController procedimentoController;
        private ConsultaController consultaController;

        private FuncionarioVO funcionarioVO;
        private PacienteVO pacienteVO;
        private ConsultaVO consultaVO;

        public int horario;
        public string data;
        private int tipo;
        private int idConsultaAnterior;

        public DataTable procedimentosConsulta;

        public RealizarConsulta(int idConsulta)
        {
            InitializeComponent();
            
            this.funcionarioController = new FuncionarioController();
            this.pacienteController = new PacienteController();
            this.procedimentoController = new ProcedimentoController();
            this.consultaController = new ConsultaController();

            ConsultaVO consulta = consultaController.buscaConsultaID(idConsulta);

            this.funcionarioVO = funcionarioController.buscaFuncionario(consulta.medico.id);
            this.pacienteVO = pacienteController.buscaPaciente(consulta.paciente.id);

            this.horario = consulta.horario;
            this.data = consulta.data;
            lblDt.Visible = true;
            lblData.Visible = true;
            lblData.Text = this.data;

            txtAtestado.Text = consulta.atestado;
            txtReceita.Text = consulta.receita;
            textInformacoes.Text = consulta.informacoes;

            lblHorario.Text = horario.ToString();
            lblPaciente.Text = this.pacienteVO.nome;
            lblMedico.Text = this.funcionarioVO.nome;
            dgProcedimentosConsulta.DataSource = procedimentoController.procedimentosPorConsulta(consulta.idConsulta);
            dgProcedimentosConsulta.Columns["idProcedimento"].Visible = false;
            dgProcedimentosConsulta.Columns["idProcedimento1"].Visible = false;
            dgProcedimentosConsulta.Columns["idProcedimentoConsulta"].Visible = false;
            dgProcedimentosConsulta.Columns["idConsulta"].Visible = false;
            dgProcedimentosConsulta.Columns["nome"].HeaderText = "Nome";
            dgProcedimentosConsulta.Columns["descricao"].HeaderText = "Descrição";
            dgProcedimentosConsulta.Columns["valor"].HeaderText = "Valor";
            dgProcedimentosConsulta.Columns["valor"].DefaultCellStyle.Format = "N2";
            dgProcedimentosConsulta.Columns["valor"].DefaultCellStyle.NullValue = "0,00";
            dgProcedimentosConsulta.Columns["valor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            btnInserir.Enabled = false;
            btnInserir.Visible = false;

            btnAdicionar.Enabled = false;
            btnAdicionar.Visible = false;
            cbProcedimentos.Visible = false;
                       
        }
        

        public RealizarConsulta(int idMedico, int idPaciente, int horario, string data)
        {
            InitializeComponent();


            this.funcionarioController = new FuncionarioController();
            this.pacienteController = new PacienteController();
            this.procedimentoController = new ProcedimentoController();
            this.consultaController = new ConsultaController();

            this.funcionarioVO = funcionarioController.buscaFuncionario(idMedico);
            this.pacienteVO = pacienteController.buscaPaciente(idPaciente);

            this.horario = horario;
            this.data = data;

            lblHorario.Text = horario.ToString();
            lblPaciente.Text = this.pacienteVO.nome;
            lblMedico.Text = this.funcionarioVO.nome;

            cbProcedimentos.DataSource = procedimentoController.listaProcedimentos();

            procedimentosConsulta = new DataTable();
            procedimentosConsulta.Columns.Add("idProcedimento");
            procedimentosConsulta.Columns.Add("nomeProcedimento");
            procedimentosConsulta.Columns.Add("descricao");
            procedimentosConsulta.Columns.Add("valor");

            verificaRetorno();
   
        }

        private void verificaRetorno()
        {
            ConsultaVO con = consultaController.retornaUltimaConsulta(pacienteVO, funcionarioVO);

            if (con.idConsulta != 0)
            {

                string data = con.data;

                string[] dataSeparada = data.Split('/');

                string[] anoSemHora = dataSeparada[2].Split(' ');

                DateTime hoje = DateTime.Now;

                DateTime ultimaConsulta = new DateTime(Int16.Parse(anoSemHora[0]), Int16.Parse(dataSeparada[1]), Int16.Parse(dataSeparada[0]));

                TimeSpan ts = hoje - ultimaConsulta;

                if (ts.Days < 30)
                {
                    lblRetorno.Visible = true;
                    btnConsultaAnterior.Visible = true;
                    btnConsultaAnterior.Enabled = true;
                    tipo = 2;
                    idConsultaAnterior = con.idConsulta;
                }
                else
                {
                    tipo = 1;
                }
            }
        
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.consultaVO = new ConsultaVO();

            consultaVO.medico = this.funcionarioVO;
            consultaVO.paciente = this.pacienteVO;
            consultaVO.horario = this.horario;
            consultaVO.data = this.data;
            consultaVO.atestado = txtAtestado.Text;
            consultaVO.receita = txtReceita.Text;
            consultaVO.informacoes = textInformacoes.Text;
            consultaVO.tipo = tipo;

            if (dgProcedimentosConsulta.DataSource != null)
            {
                consultaVO.procedimentos = (DataTable)dgProcedimentosConsulta.DataSource;
            }



            if (consultaController.realizaConsulta(consultaVO) != 0)
            {
                MessageBox.Show(this, "Informações inseridas com sucesso", "Realizar Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(this, "Ocorreu um erro no processo", "Realizar Consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            ProcedimentoVO procedimentoSelecionado = (ProcedimentoVO)cbProcedimentos.SelectedItem;

            DataRow row = procedimentosConsulta.NewRow();
            row["idProcedimento"] = procedimentoSelecionado.idProcedimento;
            row["nomeProcedimento"] = procedimentoSelecionado.nomeProcedimento;
            row["descricao"] = procedimentoSelecionado.descricao;
            row["valor"] = Convert.ToDecimal(procedimentoSelecionado.valor.ToString("N2")); 
            
            procedimentosConsulta.Rows.Add(row);

            carregaGrid();
        }

        private void carregaGrid()
        {
            dgProcedimentosConsulta.DataSource = procedimentosConsulta;
            dgProcedimentosConsulta.Columns["idProcedimento"].Visible = false;
            dgProcedimentosConsulta.Columns["nomeProcedimento"].HeaderText = "Nome";
            dgProcedimentosConsulta.Columns["descricao"].HeaderText = "Descrição";
            dgProcedimentosConsulta.Columns["valor"].HeaderText = "Valor";
            dgProcedimentosConsulta.Columns["valor"].DefaultCellStyle.Format = "N2";
            dgProcedimentosConsulta.Columns["valor"].DefaultCellStyle.NullValue = "0,00";
            dgProcedimentosConsulta.Columns["valor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void btnConsultaAnterior_Click(object sender, EventArgs e)
        {
            RealizarConsulta consultaAnterior = new RealizarConsulta(idConsultaAnterior);
            consultaAnterior.ShowDialog();            
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
