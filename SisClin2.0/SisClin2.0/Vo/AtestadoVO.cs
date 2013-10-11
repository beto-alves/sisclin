using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisClin2._0.Vo
{
    class AtestadoVO
    {
        public int idAtestado;
        public int idConsulta;
        public int idPaciente;
        public int idMedico;
        public string diagnostico;
        public string cid;
        public DateTime dataAtestado;

        public AtestadoVO() { }
    }
}
