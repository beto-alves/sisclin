﻿using SisClin2._0.Vo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SisClin2._0.Model;

namespace SisClin2._0.Controller
{
    class ProcedimentoController
    {
        private ProcedimentoModel model;

        public ProcedimentoController()
        {
            this.model = new ProcedimentoModel();
        }

        public int cadastraProcedimento(ProcedimentoVO procedimentoVO)
        {
            return this.model.cadastraProcedimento(procedimentoVO);
        }

    }
}
