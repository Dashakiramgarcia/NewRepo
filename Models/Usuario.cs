using System.ComponentModel.DataAnnotations;
using Vacafriaweb.Dtos;

namespace Vacafriaweb.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        
        public string? NombreCompleto { get; set; }
        [Required]
        public string? Correo { get; set; }
        [Required]
        public string? password { get; set; }
       public RolEnum? Rol { get; set; }
    }
}
