using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace FrontendBlazorApi.Models
{
    public class Presupuesto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un proyecto")]
        [JsonPropertyName("idproyecto")]
        public int IdProyecto { get; set; }

        [Required(ErrorMessage = "Debe ingresar el monto solicitado")]
        [Range(0, double.MaxValue, ErrorMessage = "El monto solicitado debe ser positivo")]
        [JsonPropertyName("montosolicitado")]
        public decimal MontoSolicitado { get; set; }

        [StringLength(20)]
        [JsonPropertyName("estado")]
        public string Estado { get; set; } = "Pendiente";

        [JsonPropertyName("montoaprobado")]
        public decimal? MontoAprobado { get; set; }

        [JsonPropertyName("periodoanio")]
        public int? PeriodoAnio { get; set; }

        [DataType(DataType.Date)]
        [JsonPropertyName("fechasolicitud")]
        public DateTime? FechaSolicitud { get; set; }

        [DataType(DataType.Date)]
        [JsonPropertyName("fechaaprobacion")]
        public DateTime? FechaAprobacion { get; set; }

        [JsonPropertyName("observaciones")]
        public string? Observaciones { get; set; }

        // ====== Propiedad no mapeada (solo para visualización) ======
        [NotMapped]
        [JsonPropertyName("proyectotitulo")]
        public string? ProyectoTitulo { get; set; }
    }
}