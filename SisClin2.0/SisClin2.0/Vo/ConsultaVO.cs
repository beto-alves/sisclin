using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisClin2._0.Vo
{
    class ConsultaVO
    {

        public int idConsulta;
        public FuncionarioVO medico;
        public PacienteVO paciente;
        public int horario;
        public string data;
        public string atestado;
        public string receita;
        public string informacoes;
        public DataTable procedimentos;
        public int tipo;
        
        public ConsultaVO() { }

    }
}
