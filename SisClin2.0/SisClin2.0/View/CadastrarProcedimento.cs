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
        private ProcedimentoVO vo = new ProcedimentoVO();

        public CadastrarProcedimento()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.vo.nomeProcedimento = txtNome.Text;
            this.vo.valor = float.Parse(txtValor.Text);
            this.vo.descricao = txtDescricao.Text;

            if (this.controller.cadastraProcedimento(this.vo) != 0)
            {
                MessageBox.Show("TESTE DE PROCEDIMENTO");
            }

        }
    }
}
