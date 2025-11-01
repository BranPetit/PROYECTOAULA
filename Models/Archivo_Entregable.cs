using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace FrontendBlazorApi.Models
{
    public class Archivo_Entregable
    {
        [Key, Column(Order = 0)]
        [Required(ErrorMessage = "Debe seleccionar un archivo")]
        [JsonPropertyName("idarchivo")]
        public int IdArchivo { get; set; }

        [Key, Column(Order = 1)]
        [Required(ErrorMessage = "Debe seleccionar un entregable")]
        [JsonPropertyName("identregable")]
        public int IdEntregable { get; set; }

        // Relaciones
        [ForeignKey(nameof(IdArchivo))]
        [JsonIgnore]
        public virtual Archivo? Archivo { get; set; }

        [ForeignKey(nameof(IdEntregable))]
        [JsonIgnore]
        public virtual Entregable? Entregable { get; set; }

        // Propiedades auxiliares para mostrar datos relacionados
        [NotMapped]
        [JsonPropertyName("archivoNombre")]
        public string? ArchivoNombre { get; set; }

        [NotMapped]
        [JsonPropertyName("entregableTitulo")]
        public string? EntregableTitulo { get; set; }

        // Payload opcional
        [NotMapped]
        [JsonPropertyName("payload")]
        public object? Payload { get; set; }
    }
}