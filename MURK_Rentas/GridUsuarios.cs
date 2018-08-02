﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MURK_Rentas
{
    public partial class GridUsuarios : Form
    {
        string port;
        public GridUsuarios(string p)
        {
            InitializeComponent();
            port = p;            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FormUsuarios fu = new FormUsuarios(port);
            fu.ShowDialog();
        }
    }
}
