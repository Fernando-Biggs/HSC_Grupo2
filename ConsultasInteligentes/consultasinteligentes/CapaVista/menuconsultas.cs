﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class menuconsultas : Form
    {
        

        public menuconsultas()
        {
            InitializeComponent();            
        }
        private void fileMenu_Click(object sender, EventArgs e)
        {
        }

        private void consultasInteligentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultasInteligentes frmcons = new ConsultasInteligentes();
            frmcons.MdiParent = this;
            frmcons.Show();

        }
    }
}
