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
    public partial class PesquisaFuncionario : Form
    {
        public PesquisaFuncionario()
        {

            FuncionarioController controller = new FuncionarioController();
            List<FuncionarioVO> lista = controller.listarFuncionarios();

            InitializeComponent();

            carregaGrid(lista);
        }

        public void carregaGrid(List<FuncionarioVO> lista)
        {
            dgListaFuncionarios.DataSource = lista;
        }

        
    }
}
