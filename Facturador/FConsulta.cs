/*
 * Tlacaelel iCPAC
 * 2021
 * tlacaelel.icpac@gmail.com
 * https://github.com/icpac/Facturador
 * */

using Facturador.Module.BusinessObjects;
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
        FacturadorDbContext db;
        Type Objeto;

        public FConsulta()
        {
            InitializeComponent();
        }

        public FConsulta(string conn, Type obj)
        {
            InitializeComponent();
            ShowInTaskbar = false;

            ConnectionString = conn;
            db = new FacturadorDbContext("ConnecFactura" /*conn*/);

            Objeto = obj;
        }

        private void FConsulta_Load(object sender, EventArgs e)
        {
            /*
            if (db != null)
            {
                if (Objeto == typeof(Cliente))
                    dataGridViewMain.DataSource = db.Clientes.ToList();
                else if (Objeto == typeof(Producto))
                    dataGridViewMain.DataSource = db.Productos.ToList();
                else
                    dataGridViewMain.DataSource = db.Empresas.ToList();
            }*/
        }

        private void toolStripMenuItemAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
