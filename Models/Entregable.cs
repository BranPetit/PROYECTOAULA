using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace FrontendBlazorApi.Models
{
    public class Entregable
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "El código es obligatorio")]
        public string Codigo { get; set; } = string.Empty;

        [Required(ErrorMessage = "El título es obligatorio")]
        public string Titulo { get; set; } = string.Empty;

        [Required(ErrorMessage = "La descripción es obligatoria")]
        public string Descripcion { get; set; } = string.Empty;

        [Required(ErrorMessage = "La fecha de inicio es obligatoria")]
        public DateTime? FechaInicio { get; set; }

        [Required(ErrorMessage = "La fecha prevista es obligatoria")]
        public DateTime? FechaFinPrevista { get; set; }

        public DateTime? FechaModificacion { get; set; }
        public DateTime? FechaFinalizacion { get; set; }
    }
}


