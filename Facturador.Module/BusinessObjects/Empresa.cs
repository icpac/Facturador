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
    [Table("Empresa", Schema = "public")]
    public class Empresa
    {
        [Key]
        public string Oid { get; set; }
        public string Rfc { get; set; }
        public string Nombre { get; set; }
        public string Regimen { get; set; }
    }
}
