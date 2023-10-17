using System.ComponentModel.DataAnnotations;

namespace FrontendAdministracion.AppBlazor.Models
{
    public class Servicio
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Estado es requerido")]
        public string Estado { get; set; }
    }

}

