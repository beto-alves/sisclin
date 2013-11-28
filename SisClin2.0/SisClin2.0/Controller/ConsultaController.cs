using SisClin2._0.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SisClin2._0.Vo;

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

        public int realizaConsulta(ConsultaVO consulta)
        {
            return consultaModel.realizaConsulta(consulta);
        }

        public DataTable listaConsultasPacientes(PacienteVO paciente)
        {
            return consultaModel.listaConsultasPacientes(paciente);
        }

        public ConsultaVO retornaUltimaConsulta(PacienteVO paciente, FuncionarioVO medico)
        {
            return consultaModel.retornaUltimaConsulta(paciente, medico);
        }

        public ConsultaVO buscaConsultaID(int idConsulta)
        {
            return consultaModel.buscaConsultaID(idConsulta);
        }

        
    }
}
