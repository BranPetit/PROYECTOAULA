using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace FrontendBlazorApi.Models
{
    public class ProyectosTransformacion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe seleccionar una transformación")]
        [JsonPropertyName("idtransformacion")]
        public int IdTransformacion { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un proyecto")]
        [JsonPropertyName("idproyecto")]
        public int IdProyecto { get; set; }

        [JsonPropertyName("fechaasociacion")]
        public DateTime? FechaAsociacion { get; set; } = DateTime.Now;

        // Propiedades auxiliares (solo para mostrar en la interfaz)
        [NotMapped]
        [JsonPropertyName("transformacionNombre")]
        public string? TransformacionNombre { get; set; }

        [NotMapped]
        [JsonPropertyName("proyectoNombre")]
        public string? ProyectoNombre { get; set; }
    }
}