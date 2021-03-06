using System.ComponentModel.DataAnnotations;

namespace Vehicles.Api.Data.Entities
{
    public class Brand
    {
        public int Id { get; set; }

        [Display(Name = "Marcas de Vehiculos")]
        [Required(ErrorMessage = "Este campo es requerido")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")]
        public string Description { get; set; }
    }
}
