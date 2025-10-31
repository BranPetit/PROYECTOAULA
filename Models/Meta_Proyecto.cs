using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace FrontendBlazorApi.Models
{
    [Table("Meta_Proyecto")]
    public class MetaProyecto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe seleccionar una meta estratégica")]
        [JsonPropertyName("idmeta")]
        public int IdMeta { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un proyecto")]
        [JsonPropertyName("idproyecto")]
        public int IdProyecto { get; set; }

        [JsonPropertyName("fechaasociacion")]
        public DateTime? FechaAsociacion { get; set; }

        // ====== Propiedades no mapeadas (solo visualización) ======
        [NotMapped]
        [JsonPropertyName("metaNombre")]
        public string? MetaNombre { get; set; }

        [NotMapped]
        [JsonPropertyName("proyectoNombre")]
        public string? ProyectoNombre { get; set; }
    }
}