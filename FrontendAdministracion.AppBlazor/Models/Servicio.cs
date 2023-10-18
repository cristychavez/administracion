using System.ComponentModel.DataAnnotations;

<<<<<<< HEAD
namespace Reservas.AdministradorBlazor.Models
=======
namespace FrontendAdministracion.AppBlazor.Models
>>>>>>> 37892dc465629c9d9ff3d7c2a719f3b1f2ca545b
{
    public class Servicio
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        public string Nombre { get; set; }

<<<<<<< HEAD
        [Required(ErrorMessage = "La estado es requerida")]
        public int Estado { get; set; }
    }
}
=======
        [Required(ErrorMessage = "Estado es requerido")]
        public string Estado { get; set; }
    }

}

>>>>>>> 37892dc465629c9d9ff3d7c2a719f3b1f2ca545b
