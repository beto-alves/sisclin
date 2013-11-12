using SisClin2._0.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisClin2._0.Controller
{
    class ConsultaController
    {

        ConsultaModel consultaModel = new ConsultaModel();
        public DataTable retornaHorarios(string data, int idMedico)
        {
            return consultaModel.RetornarHorarios(data, idMedico);
        }

        public int inserirAgenda(DataTable table, int medico, string dataAgenda)
        {
            return consultaModel.inserAgenda(table, medico, dataAgenda);
        }

        public bool atualizaAgenda(DataTable table, int medico, string dataAgenda)
        {
            return consultaModel.atualizaAgenda(table, medico, dataAgenda);
        }

    }
}
