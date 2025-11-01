using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace FrontendBlazorApi.Models
{
    public class Archivo_Entregable
    {
        [Key, Column(Order = 0)]
        [Required(ErrorMessage = "Debe seleccionar un archivo")]
        [JsonPropertyName("IdArchivo")]
        public int IdArchivo { get; set; }

        [Key, Column(Order = 1)]
        [Required(ErrorMessage = "Debe seleccionar un entregable")]
        [JsonPropertyName("IdEntregable")]
        public int IdEntregable { get; set; }

        // Relaciones
        [ForeignKey(nameof(IdArchivo))]
        public virtual Archivo? Archivo { get; set; }

        [ForeignKey(nameof(IdEntregable))]
        public virtual Entregable? Entregable { get; set; }
    }
}
