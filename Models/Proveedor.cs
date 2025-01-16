using System.ComponentModel.DataAnnotations;

namespace CarniCheck.Models
{
    public class Proveedor
    {
        [Key]
        public int ID_Proveedor { get; set; }
        public string Nombre { get; set; } = null!;
        public string Correo { get; set; } = null!;
        public string? Tipo_Producto { get; set; }
    }
}
