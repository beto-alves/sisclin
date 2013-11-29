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
    public partial class RealizarPagamento : Form
    {

        private int idPaciente;
    

        public RealizarPagamento(int idPaciente)
        {
            InitializeComponent();

            txtData.Text = DateTime.Today.ToString();
            this.idPaciente = idPaciente;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            MovimentacaoController movController = new MovimentacaoController();
                
            if(movController.registraMovimentacao(float.Parse(txtValor.Text), "C", 0, idPaciente, txtData.Text) != 0)
            {
                MessageBox.Show(this, "Movimentação registrada com sucesso", "Movimentação financeira", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
