using Facturador.Module.BusinessObjects;
using Facturador.Module.DataContext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Facturador
{
    public partial class FProducto : Facturador.FConsulta
    {
        public FProducto(string cnn)
            : base(cnn, typeof(Producto))
        {
            InitializeComponent();
        }

        private void FProducto_Load(object sender, EventArgs e)
        {
            using (FacturadorDbContext db = new FacturadorDbContext())
            {
                productoBindingSource.DataSource = db.Productos.ToList();
            }
            splitContainer1.Panel2.Enabled = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
