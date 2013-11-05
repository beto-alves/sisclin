using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisClin2._0.Vo
{
    public class FuncionarioVO : PessoaVO
    {
        public string funcao;
        public string horario;
        public string senha;
        public string crm;
        public string especializacao;
        
        public override string ToString()
        {
            return base.nome;
        }
        
    }
}
