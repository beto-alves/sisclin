using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisClin2._0.View
{
    public partial class MarcaConsulta : Form
    {
        public MarcaConsulta()
        {
            InitializeComponent();
        }

        private void btnProcurarPaciente_Click(object sender, EventArgs e)
        {
            PesquisaPacientes objPesquisaPacientes = new PesquisaPacientes();
            objPesquisaPacientes.ShowDialog();
        }
    }
}
