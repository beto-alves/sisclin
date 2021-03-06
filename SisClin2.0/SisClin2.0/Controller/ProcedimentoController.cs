﻿using SisClin2._0.Vo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SisClin2._0.Model;
using System.Data;

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

        public List<ProcedimentoVO> listaProcedimentos()
        {
            return this.model.listaProcedimentos();
        }

        public DataTable listarProcedimentos()
        {
            return this.model.listarProcedimentos();
        }

        public ProcedimentoVO buscaProcedimento(int idProcedimento)
        {
            return this.model.buscaProcedimento(idProcedimento);
        }

        public int excluirProcedimento(int idProcedimento)
        {
            return this.model.excluirProcedimento(idProcedimento);
        }

        public int atualizaProcedimento(ProcedimentoVO procedimento)
        {
            return this.model.atualizaProcedimento(procedimento);
        }

        public DataTable procedimentosPorConsulta(int idConsulta)
        {
            return this.model.procedimentosPorConsulta(idConsulta);
        }

    }
}
