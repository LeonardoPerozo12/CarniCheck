using System.ComponentModel.DataAnnotations;

namespace CarniCheck.Models
{
    public class Sancion
    {
        [Key]
        public int ID_Sanción { get; set; }
        public int ID_Establecimiento { get; set; }
        public int ID_Infracción { get; set; }
        public string Tipo { get; set; } = null!;
        public decimal? Fianza { get; set; }
        public DateTime? Fecha_Pago { get; set; }
    }
}
