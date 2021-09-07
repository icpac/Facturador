/*
 * Tlacaelel iCPAC
 * 2021
 * tlacaelel.icpac@gmail.com
 * https://github.com/icpac/Facturador
 * */

using Facturador.Module.DataContext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturador
{
    public partial class FConsulta : Form
    {
        string ConnectionString;
        private ApplicationDbContext db;
        public FConsulta(string conn)
        {
            InitializeComponent();
            ShowInTaskbar = false;

            ConnectionString = conn;
            db = new ApplicationDbContext("ConnecFactura" /*conn*/);
        }

        private void FConsulta_Load(object sender, EventArgs e)
        {
            dataGridViewMain.DataSource = db.ClntObj.ToList();
        }
    }
}
