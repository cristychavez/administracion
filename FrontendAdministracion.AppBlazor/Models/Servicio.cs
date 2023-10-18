using System.ComponentModel.DataAnnotations;

namespace FrontendAdministracion.AppBlazor.Models
{
    public class Servicio
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        public string Tipo { get; set; }


        [Required(ErrorMessage = "La estado es requerida")]
        public int Estado { get; set; }

    }
}