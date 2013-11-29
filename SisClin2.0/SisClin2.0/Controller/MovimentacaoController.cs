using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SisClin2._0.Model;
using System.Data;

namespace SisClin2._0.Controller
{
    class MovimentacaoController
    {

        private MovimentacaoModel movimentacaoModel = new MovimentacaoModel();

        public int registraMovimentacao(float valor, string tipo, int idConsulta, int idPaciente, string data)
        {
            return this.movimentacaoModel.registraMovimentacao(valor, tipo, idConsulta, idPaciente, data);
        }

        public DataTable listaProcedimentos(int idPaciente)
        {
            return this.movimentacaoModel.listaProcedimentos(idPaciente);
        }


    }
}
