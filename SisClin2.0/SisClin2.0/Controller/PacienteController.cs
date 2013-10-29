using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SisClin2._0.Model;
using SisClin2._0.Vo;
using System.Data;

namespace SisClin2._0.Controller
{
    class PacienteController
    {
        private PacienteModel model;

        public PacienteController() 
        {
            this.model = new PacienteModel();
        }

        public bool cadPaciente(PacienteVO paciente)
        {
            int retorno = model.cadPaciente(paciente);
            if (retorno != 0)
            {
                return true;
            }
            else 
            {
                return true;
            }            
        }

        public DataTable listaPacientes()
        {
            DataTable pacientes = model.listaPacientes();
            return pacientes;
        }

        public PacienteVO buscaPaciente(int codigo)
        {
            PacienteVO paciente = model.buscaPaciente(codigo);
            return paciente;
        }

        public bool deletaPaciente(PacienteVO paciente)
        {
            bool retorno = model.deletaPaciente(paciente);
            return retorno;
        }

        public bool atualizaPaciente(PacienteVO paciente)
        {
            bool retorno = model.atualizaPaciente(paciente);
            return retorno;
        }

    }
}
