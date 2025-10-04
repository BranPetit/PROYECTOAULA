using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace FrontendBlazorApi.Models
{
    // ===========================================
    // Modelo: VariableEstrategica
    // ===========================================
    public class VariableEstrategica
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "El Titulo es obligatorio")]

        public string Titulo { get; set; } = "";

        [Required(ErrorMessage = "La Descripcion es obligatoria")]
        public string? Descripcion { get; set; } = "";
    }
}

