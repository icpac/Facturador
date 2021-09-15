using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Facturador.Module.BusinessObjects
{
    [Table("ItemDocumento", Schema = "public")]
    public class ItemDocumento
    {
        [Key]
        public int Id { get; set; }
        public double Cantidad { get; set; }

        // Navigation
        public int DocumentoId { get; set; }
        public Documento Documento { get; set; }
    }
}