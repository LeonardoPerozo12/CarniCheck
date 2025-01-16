using System.ComponentModel.DataAnnotations;

namespace CarniCheck.Models
{
    public class Infraccion
    {
        [Key]
        public int ID_Infracción { get; set; }
        public int ID_Inspector { get; set; }
        public int ID_Establecimiento { get; set; }
        public int ID_Inspección { get; set; }
        public string? Descripción { get; set; }
        public string? Nivel_Infracción { get; set; }
        public string Estado_Infracción { get; set; } = "Pendiente";
        public int Cantidad_Infracciones { get; set; }
    }
}
