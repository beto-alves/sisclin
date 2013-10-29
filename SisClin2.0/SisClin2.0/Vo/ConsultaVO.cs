using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisClin2._0.Vo
{
    class ConsultaVO
    {

        public int idConsulta;
        public PacienteVO paciente;
        public FuncionarioVO medico;
        public string dataHorario;
        public string observacoes;

        public ConsultaVO() { }

    }
}
