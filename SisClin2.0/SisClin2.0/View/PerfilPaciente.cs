﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SisClin2._0.Controller;

namespace SisClin2._0.View
{
    public partial class PerfilPaciente : Form
    {
        public PerfilPaciente()
        {
            InitializeComponent();
            MessageBox.Show(Auxiliar.resultadoPesquisa.ToString());
        }
    }
}
