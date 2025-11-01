
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace FrontendBlazorApi.Models
{
    [Table("Estado_Proyecto")]
    public class Estado_Proyecto
    {
        [Key]
        [Required(ErrorMessage = "Debe seleccionar un proyecto")]
        [JsonPropertyName("IdProyecto")]
        public int IdProyecto { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un estado")]
        [JsonPropertyName("IdEstado")]
        public int IdEstado { get; set; }

        [ForeignKey("IdProyecto")]
        [JsonIgnore]
        public Proyecto? Proyecto { get; set; }

        [ForeignKey("IdEstado")]
        [JsonIgnore]
        public Estado? Estado { get; set; }
    }
}
