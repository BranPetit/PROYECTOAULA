using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace FrontendBlazorApi.Models
{
    // ===========================================
    // Modelo: TransformacionInstitucional
    // ===========================================
    public class TransformacionInstitucional
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "El código es obligatorio")]
        public string CodigoTI { get; set; } = string.Empty;

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "La descripción es obligatoria")]
        public string? Descripcion { get; set; }
    }
}
