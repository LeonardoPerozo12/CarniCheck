using System.ComponentModel.DataAnnotations;

namespace CarniCheck.Models
{
    public class Certificacion
    {
        [Key]
        public int ID_Certificación { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Descripción { get; set; }
        public DateTime Fecha_Expedición { get; set; }
        public DateTime Fecha_Vencimiento { get; set; }
    }
}
