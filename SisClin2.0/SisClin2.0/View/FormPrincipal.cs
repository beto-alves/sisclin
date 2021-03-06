﻿using System;
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
        public FuncionarioVO funcionarioVO;

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

            txtNomeUser.Text = funcionarioVO.nome;
            this.liberaMenus();
        }

        private void liberaMenus()
        {
            switch (funcionarioVO.funcao)
            {
                case "Administrador" :
                     mnSecretaria.Enabled = true;
                     mnMedico.Enabled = true;
                     mnAdministrador.Enabled = true;
                break;
                case "Secretária" :
                    mnSecretaria.Enabled = true;
                break;
                case "Médico" :
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

        private void smnCadPaciente_Click(object sender, EventArgs e)
        {
            CadastroPacientes objCadastroPacientes = new CadastroPacientes();
            objCadastroPacientes.ShowDialog();
        }

        private void smnPesquisaPacientes_Click(object sender, EventArgs e)
        {
            PesquisaPacientes objPesquisaPacientes = new PesquisaPacientes(this);
            objPesquisaPacientes.ShowDialog();
        }

        private void smnVerConsultas_Click(object sender, EventArgs e)
        {
            if (funcionarioVO.funcao == "Médico")
            {
                MarcaConsulta objMarcaConsulta = new MarcaConsulta(funcionarioVO, true);
                objMarcaConsulta.ShowDialog();
            }
            else
            {
                MarcaConsulta objMarcaConsulta = new MarcaConsulta();
                objMarcaConsulta.ShowDialog();
            }
        }

        private void smnPesquisaPaciente_Click(object sender, EventArgs e)
        {
            PesquisaPacientes objPesqusiaPacientes = new PesquisaPacientes(this);
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

        private void smnMeusDados_Click(object sender, EventArgs e)
        {
            CadastroFuncionarios objMeusDados = new CadastroFuncionarios(funcionarioVO);
            objMeusDados.ShowDialog();
        }

        private void smnCadProcedimento_Click(object sender, EventArgs e)
        {
            CadastrarProcedimento objCadProcedimento = new CadastrarProcedimento();
            objCadProcedimento.ShowDialog();
        }

        private void smnListaProcedimentos_Click(object sender, EventArgs e)
        {
            ListaProcedimento listaProcedimento = new ListaProcedimento();
            listaProcedimento.ShowDialog();
        }
    }
}
