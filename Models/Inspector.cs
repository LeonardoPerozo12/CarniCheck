using System.ComponentModel.DataAnnotations;

namespace CarniCheck.Models
{
    public class Inspector
    {
        [Key]
        public int ID_Inspector { get; set; }
        public string Nombres { get; set; } = null!;
        public string Apellidos { get; set; } = null!;
        public string? Especialidad { get; set; }
        public string? Zona_Asignada { get; set; }
    }
}
