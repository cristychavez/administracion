using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations;

namespace Reservas.AdministradorBlazor.Models
{
    public class Mesa
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "La zona es requerida")]
        public int Estado { get; set; }
    }
} 
