/*
 * Tlacaelel iCPAC
 * 2021
 * tlacaelel.icpac@gmail.com
 * https://github.com/icpac/Facturador
 * */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturador.Module.BusinessObjects
{
    [Table("Producto", Schema = "public")]
    public class Producto
    {
        [Key]
        // public string Oid { get; set; }
        public int Id { get; set; }
        [StringLength(40)]
        public string Clave { get; set; }
        [StringLength(100)]
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
    }
}
