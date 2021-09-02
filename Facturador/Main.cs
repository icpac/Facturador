/*
 * Tlacaelel iCPAC
 * 2021
 * tlacaelel.icpac@gmail.com
 * https://github.com/icpac/Facturador
 * */

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
            FConsulta cnst = new FConsulta();

            cnst.Parent = MdiParent;
            cnst.Show();
        }
    }
}
