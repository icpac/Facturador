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
    [Table("Cliente", Schema ="public")]
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        /*
        [Key]
        public string Oid { get; set; }*/
        [StringLength(15)]
        public string Rfc { get; set; }
        [StringLength(150)]
        public string Nombre { get; set; }
        [StringLength(50)]
        public string Correo { get; set; }
    }
}
