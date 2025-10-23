using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace FrontendBlazorApi.Models
{
    public class MetaEstrategica
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un objetivo estratégico")]
        [JsonPropertyName("idobjetivo")]
        public int IdObjetivo { get; set; }

        [Required(ErrorMessage = "El título es obligatorio")]
        [StringLength(255)]
        [JsonPropertyName("titulo")]
        public string Titulo { get; set; } = string.Empty;

        [JsonPropertyName("descripcion")]
        public string? Descripcion { get; set; }

        // ====== Propiedad no mapeada (solo para visualización) ======
        [NotMapped]
        [JsonPropertyName("objetivoNombre")]
        public string? ObjetivoNombre { get; set; }
    }
}