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
        public FuncionarioController() { }

        public bool login(FuncionarioVO funcionario)
        {
            FuncionarioModel model = new FuncionarioModel();

            FuncionarioVO funcionarioLog = model.login(funcionario);

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
            FuncionarioModel model = new FuncionarioModel();

            bool retorno = model.cadFuncionario(funcionario);

            return retorno;
        }

        public DataTable listarFuncionarios()
        {
            FuncionarioModel model = new FuncionarioModel();
            return model.listaFuncionarios();
        }

        public FuncionarioVO buscaFuncionario(int codigo)
        {
            FuncionarioModel model = new FuncionarioModel();
            return model.buscaFuncionario(codigo);
        }

        public bool atualizaFuncionario(FuncionarioVO funcionario)
        {
            FuncionarioModel model = new FuncionarioModel();
            return model.atualizaFuncionario(funcionario);
        }

        public bool deletaFuncionario(FuncionarioVO funcionario)
        {
            FuncionarioModel model = new FuncionarioModel();
            return model.deletaFuncionario(funcionario);
        }
    }
}
