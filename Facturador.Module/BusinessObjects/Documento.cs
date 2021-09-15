using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturador.Module.BusinessObjects
{
    [Table("Documento", Schema = "public")]
    public class Documento
    {
        [Key]
        public int Id { get; set; }
        public string Serie { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        // Navigation
        public List<ItemDocumento> ItemsDocumento { get; set; }
    }
}
