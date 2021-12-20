using System.ComponentModel.DataAnnotations;

namespace Vehicles.Api.Data.Entities
{
    public class Procedure
    {
        public int Id { get; set; }

        [Display(Name = "Tipos de Vehiculos")]
        [Required(ErrorMessage = "Este campo es requerido")]
        
        public string Description { get; set; }
        [DisplayFormat(DataFormatString = "{0:C2}")]
        [Display(Name = "Precios")]
        [Required(ErrorMessage = "Este campo es requerido")]
        public decimal Price { get; set; }
    }
}
