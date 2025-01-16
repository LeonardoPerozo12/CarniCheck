using System.ComponentModel.DataAnnotations;

namespace CarniCheck.Models
{
    public class Solicitud_Inspeccion
    {
        [Key]
        public int ID_Solicitud { get; set; }
        public int ID_Cliente { get; set; }
        public int ID_Establecimiento { get; set; }
        public int? ID_Administrador { get; set; }
        public int? ID_Inspector { get; set; }
        public DateTime Fecha_Solicitud { get; set; }
        public string Estado_Solicitud { get; set; } = "Pendiente";
    }
}
