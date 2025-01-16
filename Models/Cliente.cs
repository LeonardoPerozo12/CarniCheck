using System.ComponentModel.DataAnnotations;

namespace CarniCheck.Models
{
    public class Cliente
    {
        [Key]
        public int ID_Cliente { get; set; }
        public string Nombres { get; set; } = null!;
        public string Apellidos { get; set; } = null!;
        public string Correo { get; set; } = null!;
        public string Contraseña { get; set; } = null!;
        public string? Dirección { get; set; }
        public string? Teléfono { get; set; }
        public string? Documentación { get; set; }
        public string Estado_Cliente { get; set; } = "Activo";
    }
}
