using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SisClin2._0.Vo;

namespace SisClin2._0.View
{
    public partial class FormPrincipal : Form
    {
        private FuncionarioVO funcionarioVO;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        public FormPrincipal(FuncionarioVO funcionario)
        {
            InitializeComponent();

            funcionarioVO = funcionario;

            mnSecretaria.Enabled = false;
            mnMedico.Enabled = false;
            mnAdministrador.Enabled = false;

            txtNomeUser.Text = this.funcionarioVO.nome;
            this.liberaMenus();
        }

        private void liberaMenus()
        {
            switch (this.funcionarioVO.funcao)
            {
                case "administrador" :
                     mnSecretaria.Enabled = true;
                     mnMedico.Enabled = true;
                     mnAdministrador.Enabled = true;
                break;
                case "secretaria" :
                    mnSecretaria.Enabled = true;
                break;
                case "medico" :
                    mnMedico.Enabled = true;
                break;
            }
        }

        private void smnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void smnMarcarConsulta_Click(object sender, EventArgs e)
        {
            MarcaConsulta objMarcaConsulta = new MarcaConsulta();
            objMarcaConsulta.ShowDialog();
        }

        private void smnListaConsulta_Click(object sender, EventArgs e)
        {
            ListaConsultas objListaConsultas = new ListaConsultas();
            objListaConsultas.ShowDialog();
        }

        private void smnCadPaciente_Click(object sender, EventArgs e)
        {
            CadastroPacientes objCadastroPacientes = new CadastroPacientes();
            objCadastroPacientes.ShowDialog();
        }

        private void smnPesquisaPacientes_Click(object sender, EventArgs e)
        {
            PesquisaPacientes objPesquisaPacientes = new PesquisaPacientes();
            objPesquisaPacientes.ShowDialog();
        }

        private void smnVerConsultas_Click(object sender, EventArgs e)
        {
           /**
            * @todo criar tela para exibir agenda do dia.
            **/
        }

        private void smnRealizaConsultas_Click(object sender, EventArgs e)
        {
            RealizarConsulta objRealizaConsulta = new RealizarConsulta();
            objRealizaConsulta.ShowDialog();
        }

        private void smnPesquisaPaciente_Click(object sender, EventArgs e)
        {
            PesquisaPacientes objPesqusiaPacientes = new PesquisaPacientes();
            objPesqusiaPacientes.ShowDialog();
        }

        private void smnCadFuncionario_Click(object sender, EventArgs e)
        {
            CadastroFuncionarios objCadastroFuncionario = new CadastroFuncionarios();
            objCadastroFuncionario.ShowDialog();
        }

        private void smnListaFuncionarios_Click(object sender, EventArgs e)
        {
            PesquisaFuncionario objPesquisaFuncionario = new PesquisaFuncionario();
            objPesquisaFuncionario.ShowDialog();
        }

    }
}
