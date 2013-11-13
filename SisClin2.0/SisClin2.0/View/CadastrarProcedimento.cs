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
    public partial class CadastrarProcedimento : Form
    {
        private ProcedimentoController controller = new ProcedimentoController();
        private ProcedimentoVO vo;

        public CadastrarProcedimento()
        {
            InitializeComponent();
        }

        public CadastrarProcedimento(int idProcedimento)
        {
            InitializeComponent();

            this.vo = this.controller.buscaProcedimento(idProcedimento);

            txtNome.Text = vo.nomeProcedimento;
            txtDescricao.Text = vo.descricao;
            txtValor.Text = vo.valor.ToString();

            btnExcluir.Enabled = true;
            btnInserir.Enabled = true;

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (this.vo != null)
            {
                this.vo.nomeProcedimento = txtNome.Text;
                this.vo.valor = float.Parse(txtValor.Text);
                this.vo.descricao = txtDescricao.Text;

                if (this.controller.atualizaProcedimento(this.vo) != 0)
                {
                    MessageBox.Show(this, "Procedimento atualizado com sucesso", "Cadastro de Procedimentos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }             

            }
            else
            {

                this.vo = new ProcedimentoVO();

                this.vo.nomeProcedimento = txtNome.Text;
                this.vo.valor = float.Parse(txtValor.Text);
                this.vo.descricao = txtDescricao.Text;

                if (this.controller.cadastraProcedimento(this.vo) != 0)
                {
                    MessageBox.Show(this, "Procedimento cadastrado com sucesso", "Cadastro de Procedimentos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }

               

            }
            
        }

        private void liberaBotao(object sender, EventArgs e)
        {
            if (!txtNome.Text.Trim().Equals(String.Empty) && !txtDescricao.Text.Trim().Equals(String.Empty) &&
               !txtValor.Text.Trim().Equals(String.Empty))
            {
                btnInserir.Enabled = true;
            }
            else
            {
                btnInserir.Enabled = false;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (this.controller.excluirProcedimento(this.vo.idProcedimento) != 0)
            {
                MessageBox.Show(this, "Procedimento excluído com sucesso", "Cadastro de Procedimentos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Close();
        }
    }
}
