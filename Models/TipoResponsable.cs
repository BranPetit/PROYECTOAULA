using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace FrontendBlazorApi.Models
{
    // ===========================================
    // Modelo: TipoResponsable
    // ===========================================
    public class TipoResponsable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "El Titulo es obligatorio")]
        public string Titulo { get; set; } = string.Empty;

        [Required(ErrorMessage = "La Descripcion es obligatoria")]
        public string Descripcion { get; set; } = string.Empty;
    }
}
