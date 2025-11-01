using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace FrontendBlazorApi.Models
{
    public class Responsable_Entregable
    {
        [Key]
        [Required(ErrorMessage = "Debe seleccionar un responsable")]
        [JsonPropertyName("IdResponsable")]
        public int IdResponsable { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un entregable")]
        [JsonPropertyName("IdEntregable")]
        public int IdEntregable { get; set; }

        [JsonPropertyName("FechaAsociacion")]
        public DateTime? FechaAsociacion { get; set; }
    }
}
