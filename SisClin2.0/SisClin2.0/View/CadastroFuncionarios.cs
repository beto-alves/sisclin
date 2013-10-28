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
    public partial class CadastroFuncionarios : Form
    {
        public FuncionarioVO funcionario = new FuncionarioVO();
        public CadastroFuncionarios()
        {
            InitializeComponent();           
        }

        public CadastroFuncionarios(FuncionarioVO funcionario)
        {
            InitializeComponent();
            btnInserir.Enabled = btnInserir.Visible = btnPesquisar.Enabled = btnPesquisar.Visible = btnExcluir.Enabled = btnExcluir.Visible = false;
            btnEditar.Enabled = true;
            cbCargo.Visible = false;
            menuMeusdados(funcionario);
            this.funcionario = funcionario;
        }

        public void menuMeusdados(FuncionarioVO funcionario)
        {
            txtNome.Text = funcionario.nome;
            txtNascimento.Text = funcionario.nascimento;
            txtRg.Text = funcionario.rg;
            txtCpf.Text = funcionario.cpf;
            txtTelefone.Text = funcionario.telefone;
            txtCelular.Text = funcionario.celular;
            txtEmail.Text = funcionario.email;
            txtRua.Text = funcionario.rua;
            txtBairro.Text = funcionario.bairro;
            txtCidade.Text = funcionario.cidade;
            txtCep.Text = funcionario.cep;
            cbUF.SelectedItem = funcionario.estado;
            txtComplemento.Text = funcionario.complemento;
            txtNumero.Text = funcionario.numero;
            cbCargo.SelectedItem = funcionario.funcao;
            txtCRM.Text = funcionario.crm;
            txtEspecializacao.Text = funcionario.especializacao;
            txtSenha.Text = funcionario.senha;
        }


        private void btnInserir_Click(object sender, EventArgs e)
        {

           
            funcionario.nome        = txtNome.Text;
            funcionario.nascimento  = txtNascimento.Text;
            funcionario.rg          = txtRg.Text;
            funcionario.cpf         = txtCpf.Text;
            funcionario.telefone    = txtTelefone.Text;
            funcionario.celular     = txtCelular.Text;
            funcionario.email       = txtEmail.Text;
            funcionario.rua         = txtRua.Text;
            funcionario.bairro      = txtBairro.Text;
            funcionario.cidade      = txtCidade.Text;
            funcionario.cep         = txtCep.Text;
            funcionario.estado      = cbUF.Text;
            funcionario.complemento = txtComplemento.Text;
            funcionario.numero      = txtNumero.Text;
            funcionario.funcao      = cbCargo.Text;
            funcionario.senha       = txtSenha.Text;
            funcionario.crm         = txtCRM.Text;
            funcionario.especializacao = txtEspecializacao.Text;

            FuncionarioController controller = new FuncionarioController();
            limpaTela();
            
            bool retorno = controller.cadFuncionario(funcionario);

            if (retorno)
            {
                MessageBox.Show("Funcionario incluído com sucesso", "Cadastro de Funcionários", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ocorreu algum erro", "Cadastro de Funcionários", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void habilitaGpBox(object sender, EventArgs e)
        {
            if (cbCargo.Text == "Médico")
            {
                gpAdicional.Enabled = true;
            }
            else
            {
                gpAdicional.Enabled = false;
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PesquisaFuncionario pesquisaFuncionario = new PesquisaFuncionario();
            pesquisaFuncionario.ShowDialog();

            int codigo = Auxiliar.resultadoPesquisa;

            if (codigo != 0)
            {
                FuncionarioController controller = new FuncionarioController();
                funcionario = controller.buscaFuncionario(codigo);

                txtNome.Text = funcionario.nome;
                txtNascimento.Text = funcionario.nascimento;
                txtRg.Text = funcionario.rg;
                txtCpf.Text = funcionario.cpf;
                txtTelefone.Text = funcionario.telefone;
                txtCelular.Text = funcionario.celular;
                txtEmail.Text = funcionario.email;
                txtRua.Text = funcionario.rua;
                txtBairro.Text = funcionario.bairro;
                txtCidade.Text = funcionario.cidade;
                txtCep.Text = funcionario.cep;
                cbUF.SelectedItem = funcionario.estado;
                txtComplemento.Text = funcionario.complemento;
                txtNumero.Text = funcionario.numero;
                cbCargo.SelectedItem = funcionario.funcao;
                txtCRM.Text = funcionario.crm;
                txtEspecializacao.Text = funcionario.especializacao;

                desabilitaControles(true);

            }

        }

        public void desabilitaControles(bool altera)
        {
            if (altera)
            {
                btnEditar.Enabled = btnExcluir.Enabled = true;
                btnInserir.Enabled = false;
            }
            else
            {
                btnInserir.Enabled = btnEditar.Enabled = btnExcluir.Enabled = false;
            }
        }

        private void habilitaControles(object sender, EventArgs e)
        {
            if (!cbCargo.Text.Trim().Equals(String.Empty) && !txtNome.Text.Trim().Equals(String.Empty) && 
                txtNascimento.MaskFull && txtTelefone.MaskFull && txtCelular.MaskFull && txtRg.MaskFull && txtCpf.MaskFull &&
                !txtSenha.Text.Trim().Equals(String.Empty) && !txtRua.Text.Trim().Equals(String.Empty) && !txtNumero.Text.Trim().Equals(String.Empty) &&
                !txtCidade.Text.Trim().Equals(String.Empty) && txtCep.MaskFull && !txtBairro.Text.Trim().Equals(String.Empty))
            {
                btnInserir.Enabled = true;
            }
            else
            {
                btnInserir.Enabled = false;
            }
        }

        private void limpaTela()
        {
            txtNome.Text = txtEmail.Text = txtNascimento.Text = txtSenha.Text = txtRg.Text = txtCpf.Text = txtTelefone.Text
            = txtCelular.Text = txtRua.Text = txtNumero.Text = txtComplemento.Text = txtCidade.Text = txtCep.Text = cbUF.Text = cbCargo.Text
            = txtBairro.Text = txtEspecializacao.Text = txtCRM.Text = String.Empty;
            desabilitaControles(false);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FuncionarioController controller = new FuncionarioController();

            funcionario.nome = txtNome.Text;
            funcionario.nascimento = txtNascimento.Text;
            funcionario.rg = txtRg.Text;
            funcionario.cpf = txtCpf.Text;
            funcionario.telefone = txtTelefone.Text;
            funcionario.celular = txtCelular.Text;
            funcionario.email = txtEmail.Text;
            funcionario.rua = txtRua.Text;
            funcionario.bairro = txtBairro.Text;
            funcionario.cidade = txtCidade.Text;
            funcionario.cep = txtCep.Text;
            funcionario.estado = cbUF.Text;
            funcionario.complemento = txtComplemento.Text;
            funcionario.numero = txtNumero.Text;
            funcionario.funcao = cbCargo.Text;
            funcionario.senha = txtSenha.Text;
            funcionario.crm = txtCRM.Text;
            funcionario.especializacao = txtEspecializacao.Text;

            if (controller.atualizaFuncionario(funcionario))
            {
                MessageBox.Show("Funcionario atualizado com sucesso", "Cadastro de Funcionários", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpaTela();
            }
            else
            {
                MessageBox.Show("Ocorreu um erro na atualização.", "Cadastro de Funcionários", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            FuncionarioController controller = new FuncionarioController();

            if (controller.deletaFuncionario(funcionario))
            {
                MessageBox.Show("Funcionario apagado com sucesso", "Cadastro de Funcionários", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpaTela();
            }
            else
            {
                MessageBox.Show("Ocorreu um erro na exclusão.", "Cadastro de Funcionários", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            limpaTela();
        }

    }
}
