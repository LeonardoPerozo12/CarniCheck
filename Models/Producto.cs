using System.ComponentModel.DataAnnotations;

namespace CarniCheck.Models
{
    public class Producto
    {
        [Key]
        public int ID_Producto { get; set; }
        public int ID_Establecimiento { get; set; }
        public string Nombre { get; set; } = null!;
        public int Cantidad_Productos { get; set; } = 0;
        public string? Categoría { get; set; }
        public bool Disponibilidad { get; set; } = true;
        public DateTime? Fecha_Producción { get; set; }
        public DateTime? Fecha_Vencimiento { get; set; }
    }
}
