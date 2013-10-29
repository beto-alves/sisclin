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

        public MarcaConsulta()
        {
            InitializeComponent();
        }

        private void btnProcurarPaciente_Click(object sender, EventArgs e)
        {
            PesquisaPacientes objPesquisaPacientes = new PesquisaPacientes(this);
            objPesquisaPacientes.ShowDialog();

            int codigo = Auxiliar.resultadoPesquisa;

            if (codigo != 0)
            {
                PacienteController pacienteController = new PacienteController();
                paciente = pacienteController.buscaPaciente(codigo);
                txtPaciente.Text = paciente.nome;
 
            }

        }
    }
}
