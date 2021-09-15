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
    public partial class FCliente : FConsulta
    {
        public FCliente(string cnn)
            : base(cnn, typeof(Cliente))
        {
            InitializeComponent();
        }

        private void FCliente_Load(object sender, EventArgs e)
        {
            using (FacturadorDbContext db = new FacturadorDbContext())
            {
                bindingSourceClnt.DataSource = db.Clientes.ToList();
            }
            splitContainer1.Panel2.Enabled = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Enabled = true;
            bindingSourceClnt.Add(new Cliente());
            bindingSourceClnt.MoveLast();
            textBoxRfc.Focus();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Enabled = true;
            textBoxRfc.Focus();
            Cliente obj = bindingSourceClnt.Current as Cliente;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Enabled = false;
            bindingSourceClnt.ResetBindings(false);
            FCliente_Load(sender, e);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Cliente obj = bindingSourceClnt.Current as Cliente;
            if (obj != null)
            { }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Está seguro de Borrar ?", "Mensaje", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (FacturadorDbContext db = new FacturadorDbContext())
                {
                    Cliente obj = bindingSourceClnt.Current as Cliente;
                    if (obj != null )
                    {
                        if (db.Entry<Cliente>(obj).State == System.Data.Entity.EntityState.Detached)
                        {
                            db.Set<Cliente>().Attach(obj);
                        }
                        db.Entry<Cliente>(obj).State = System.Data.Entity.EntityState.Deleted;
                        db.SaveChanges();
                        MessageBox.Show(this, "Borrado satisfactoriamente !");
                        bindingSourceClnt.RemoveCurrent();
                        splitContainer1.Panel2.Enabled = false;
                    }
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            using (FacturadorDbContext db = new FacturadorDbContext())
            {
                Cliente obj = bindingSourceClnt.Current as Cliente;
                if (obj != null)
                {
                    if (db.Entry<Cliente>(obj).State == System.Data.Entity.EntityState.Detached)
                        db.Set<Cliente>().Attach(obj);

                    if (obj.Id == 0)
                        db.Entry<Cliente>(obj).State = System.Data.Entity.EntityState.Added;
                    else
                        db.Entry<Cliente>(obj).State = System.Data.Entity.EntityState.Modified;

                    db.SaveChanges();
                    MessageBox.Show(this, "Guardado satisfactoriamente !");
                    dataGridView1.Refresh();
                    splitContainer1.Panel2.Enabled = false;
                }
            }
        }
    }
}

