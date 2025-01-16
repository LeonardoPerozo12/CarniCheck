using System.ComponentModel.DataAnnotations;

namespace CarniCheck.Models
{
    public class Establecimiento
    {
        [Key]
        public int ID_Establecimiento { get; set; }
        public int ID_Cliente { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Dirección { get; set; }
        public string? Tipo_Establecimiento { get; set; }
        public string? Nivel_Riesgo { get; set; }
        public string? Record_Inspecciones { get; set; }
        public string Estado_Establecimiento { get; set; } = "Activo";
    }
}
