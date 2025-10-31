using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace FrontendBlazorApi.Models
{
    public class EjecucionPresupuesto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un presupuesto")]
        [JsonPropertyName("idpresupuesto")]
        public int IdPresupuesto { get; set; }

        [Required(ErrorMessage = "Debe indicar el año")]
        [Range(1900, 3000, ErrorMessage = "El año no es válido")]
        [JsonPropertyName("anio")]
        public int Anio { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "El monto planeado debe ser mayor o igual a cero")]
        [JsonPropertyName("montoplaneado")]
        public decimal? MontoPlaneado { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "El monto ejecutado debe ser mayor o igual a cero")]
        [JsonPropertyName("montoejecutado")]
        public decimal? MontoEjecutado { get; set; }

        [JsonPropertyName("observaciones")]
        public string? Observaciones { get; set; }

        // Propiedad no mapeada para mostrar info del presupuesto en la UI
        [NotMapped]
        [JsonPropertyName("presupuestoNombre")]
        public string? PresupuestoNombre { get; set; }
    }
}