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
    public partial class MovimentacaoFinanceiraCliente : Form
    {

        MovimentacaoController movController;
        private PacienteVO paciente;
                
        public MovimentacaoFinanceiraCliente(int idPaciente)
        {
            InitializeComponent();

            this.movController = new MovimentacaoController();
            PacienteController pacController = new PacienteController();

            this.paciente = pacController.buscaPaciente(idPaciente);

            lblPaciente.Text = paciente.nome;
            
            carregaGrid(idPaciente);

        }

        public void carregaGrid(int idPaciente)
        {
            dgMovimentacao.DataSource = this.movController.listaProcedimentos(idPaciente);
            dgMovimentacao.Columns["idMovimentacao"].Visible = false;
            dgMovimentacao.Columns["idConsulta"].Visible = false;
            dgMovimentacao.Columns["idPaciente"].Visible = false;
            dgMovimentacao.Columns["tipo"].HeaderText = "Tipo";
            dgMovimentacao.Columns["valor"].HeaderText = "Valor";
            dgMovimentacao.Columns["data"].HeaderText = "Data";

            DataTable tabela = (DataTable)dgMovimentacao.DataSource;

            float saldoDevedor = 0;
            float saldoPago = 0;

            foreach (DataRow row in tabela.Rows)
            {
                if(row["tipo"].ToString() == "D")
                {
                    saldoDevedor += float.Parse(row["valor"].ToString());
                }
                else if (row["tipo"].ToString() == "C")
                {
                    saldoPago += float.Parse(row["valor"].ToString());
                }
            }

            float saldoTotal = saldoDevedor - saldoPago;

            lblSaldo.Text = saldoTotal.ToString();

        }

        private void dgMovimentacao_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewRow r = dgMovimentacao.Rows[e.RowIndex];
            if ( r.Cells["tipo"].Value.ToString() == "D" )
            {
                r.DefaultCellStyle.BackColor = Color.Red;
            }
            else
            {
                r.DefaultCellStyle.BackColor = Color.Green;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RealizarPagamento pagamento = new RealizarPagamento(this.paciente.id);
            pagamento.ShowDialog();
            carregaGrid(paciente.id);
        }
    }
}
