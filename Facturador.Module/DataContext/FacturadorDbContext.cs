/*
 * Tlacaelel iCPAC
 * 2021
 * tlacaelel.icpac@gmail.com
 * https://github.com/icpac/Facturador
 * */

// https://www.compose.com/articles/code-first-database-design-with-entity-framework-and-postgresql/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Facturador.Module.BusinessObjects;

namespace Facturador.Module.DataContext
{
    // add-migration Facturar/update-database

    public class FacturadorDbContext : DbContext
    {
        public FacturadorDbContext() : base(nameOrConnectionString: "ConnecFactura")
        {
        }
        public FacturadorDbContext(string conn) : base(nameOrConnectionString: conn)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Cliente> Clientes { get; set; }

        public virtual DbSet<Producto> Productos { get; set; }
        
        public virtual DbSet<Empresa> Empresas { get; set; }
    }
}
