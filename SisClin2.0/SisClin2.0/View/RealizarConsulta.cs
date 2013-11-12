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
    public partial class RealizarConsulta : Form
    {
        private FuncionarioController funcionarioController;
        private PacienteController pacienteController;
        private ProcedimentoController procedimentoController;

        private FuncionarioVO funcionarioVO;
        private PacienteVO pacienteVO;

        public RealizarConsulta(int idMedico, int idPaciente, int horario, string data)
        {            
            InitializeComponent();


            this.funcionarioController = new FuncionarioController();
            this.pacienteController = new PacienteController();
            this.procedimentoController = new ProcedimentoController();

            this.funcionarioVO = funcionarioController.buscaFuncionario(idMedico);
            this.pacienteVO = pacienteController.buscaPaciente(idPaciente);

            lblHorario.Text = horario.ToString();
            lblPaciente.Text = this.pacienteVO.nome;
            lblMedico.Text = this.funcionarioVO.nome;

            cbProcedimentos.DataSource = procedimentoController.listaProcedimentos();
            
        }

    }
}
