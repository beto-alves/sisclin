using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisClin2._0.Vo
{
    class ProcedimentoVO
    {
        public int idProcedimento;
        public string nomeProcedimento;
        public string descricao;
        public float valor;

        public override string ToString()
        {
            return nomeProcedimento;
        }
    }

}
