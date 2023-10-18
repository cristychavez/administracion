using System.ComponentModel.DataAnnotations;

namespace Reservas.AdministradorBlazor.Models
{
    public class Servicio
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La estado es requerida")]
        public int Estado { get; set; }
    }
}