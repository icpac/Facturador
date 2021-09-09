/*
 * Tlacaelel iCPAC
 * 2021
 * tlacaelel.icpac@gmail.com
 * https://github.com/icpac/Facturador
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Facturador.Module.BusinessObjects;

namespace Facturador.Module.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(string conn) : base(nameOrConnectionString: conn)
        {
        }

        public virtual DbSet<Cliente> ClntObj { get; set; }

        public virtual DbSet<Producto> PrdtObj { get; set; }
        
        public virtual DbSet<Empresa> EmprsObj { get; set; }
    }
}
