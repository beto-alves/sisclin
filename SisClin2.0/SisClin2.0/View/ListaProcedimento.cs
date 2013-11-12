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

namespace SisClin2._0.View
{
    public partial class ListaProcedimento : Form
    {

        ProcedimentoController controller = new ProcedimentoController();

        public ListaProcedimento()
        {
            InitializeComponent();
            
            dgListaProcedimentos.DataSource = controller.listarProcedimentos();
            dgListaProcedimentos.Columns["idProcedimento"].Visible = false;
            dgListaProcedimentos.Columns["nome"].HeaderText = "Nome";
            dgListaProcedimentos.Columns["descricao"].HeaderText = "Descrição";
            dgListaProcedimentos.Columns["valor"].HeaderText = "Valor";
        }

        private void dgListaProcedimentos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
