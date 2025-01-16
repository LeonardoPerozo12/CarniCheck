using System.ComponentModel.DataAnnotations;

namespace CarniCheck.Models
{
    public class Inspeccion
    {
        [Key]
        public int ID_Inspección { get; set; }
        public int ID_Establecimiento { get; set; }
        public int ID_Inspector { get; set; }
        public DateTime Fecha_Inspección { get; set; }
        public string Estado_Inspección { get; set; } = "Pendiente";
        public string? Observaciones { get; set; }
    }
}
