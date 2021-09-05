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
        public ApplicationDbContext() : base(nameOrConnectionString: "ConnectionString")
        {

        }

        public virtual DbSet<Cliente> ClntObj { get; set; }
    }
}
