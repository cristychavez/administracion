using System.ComponentModel.DataAnnotations;

namespace Reservas.AdministradorBlazor.Models
{
    public class Reserva
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El idmesa es requerido")]
        public int IdMesa { get; set; }

        [Required(ErrorMessage = "El idservicio es requerido")]
        public int IdServicio { get; set; }

        [Required(ErrorMessage = "El cliente es requerido")]
        public string Cliente { get; set; }

        [Required(ErrorMessage = "La telefono es requerida")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "La fecha es requerida")]
        public string Fecha { get; set; }

        [Required(ErrorMessage = "La persona es requerida")]
        public string Persona { get; set; }

        [Required(ErrorMessage = "La horarioEntrada es requerida")]
        public string HorarioEntrada { get; set; }

        [Required(ErrorMessage = "La horarioSalida es requerida")]
        public string HorarioSalida { get; set; }
        public Mesa Mesa { get; set; }
        public Servicio Servicio { get; set; }
    }
}