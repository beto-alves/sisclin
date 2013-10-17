using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SisClin2._0.Model;
using SisClin2._0.View;
using SisClin2._0.Vo;

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

        public List<FuncionarioVO> listarFuncionarios()
        {
            FuncionarioModel model = new FuncionarioModel();

            List<FuncionarioVO> lista = model.listaFuncionarios();

            return lista;
        }
    }
}
