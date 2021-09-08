﻿/*
 * Tlacaelel iCPAC
 * 2021
 * tlacaelel.icpac@gmail.com
 * https://github.com/icpac/Facturador
 * */

using Facturador.Module.BusinessObjects;
using System;
using System.Windows.Forms;

namespace Facturador
{
    public partial class Main : Form
    {
        public string ConnectionString { get; set; }

        public Main()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FConsulta cnst = new FConsulta(ConnectionString, typeof(Cliente));

            cnst.Parent = MdiParent;
            cnst.Show();
        }

        private void productosServiciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FConsulta cnst = new FConsulta(ConnectionString, typeof(Producto));

            cnst.Parent = MdiParent;
            cnst.Show();
        }
    }
}
