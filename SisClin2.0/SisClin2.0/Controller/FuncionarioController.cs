using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SisClin2._0.Model;
using SisClin2._0.View;
using SisClin2._0.Vo;
using System.Data;

namespace SisClin2._0.Controller
{
    class FuncionarioController
    {
        private FuncionarioModel model;

        public FuncionarioController() 
        {
            this.model = new FuncionarioModel();
        }

        public bool login(FuncionarioVO funcionario)
        {
            FuncionarioVO funcionarioLog = this.model.login(funcionario);

            if( funcionario.id != 0 )
            {
                FormPrincipal frmPrincipal = new FormPrincipal(funcionarioLog);
                frmPrincipal.ShowDialog();
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool cadFuncionario(FuncionarioVO funcionario)
        {         
            bool retorno = this.model.cadFuncionario(funcionario);
            return retorno;
        }

        public DataTable listarFuncionarios()
        {
            return this.model.listaFuncionarios();
        }

        public FuncionarioVO buscaFuncionario(int codigo)
        {
            return this.model.buscaFuncionario(codigo);
        }

        public bool atualizaFuncionario(FuncionarioVO funcionario)
        {
            return this.model.atualizaFuncionario(funcionario);
        }

        public bool deletaFuncionario(FuncionarioVO funcionario)
        {
            return this.model.deletaFuncionario(funcionario);
        }

        public List<FuncionarioVO> listarMedico()
        {          
            return this.model.listarMedicos();
        }

        public bool buscaFuncionario(string cpf)
        {
            return this.model.buscaFuncionario(cpf);
        }

    }
}
