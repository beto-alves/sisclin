using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SisClin2._0.Model;
using SisClin2._0.Vo;

namespace SisClin2._0.Controller
{
    class FuncionarioController
    {
        public FuncionarioController() { }

        public bool login(FuncionarioVO funcionario)
        {
            FuncionarioModel model = new FuncionarioModel();

            if (model.login(funcionario))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
