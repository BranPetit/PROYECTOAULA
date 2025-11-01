using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace FrontendBlazorApi.Models
{
    public class Actividad
    {
        [Key]
        [JsonPropertyName("Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un entregable")]
        [JsonPropertyName("IdEntregable")]
        public int IdEntregable { get; set; }

        [Required(ErrorMessage = "Debe ingresar un título para la actividad")]
        [StringLength(255, ErrorMessage = "El título no puede superar los 255 caracteres")]
        [JsonPropertyName("Titulo")]
        public string Titulo { get; set; } = string.Empty;

        [JsonPropertyName("Descripcion")]
        public string? Descripcion { get; set; }

        [DataType(DataType.Date)]
        [JsonPropertyName("FechaInicio")]
        public DateTime? FechaInicio { get; set; }

        [DataType(DataType.Date)]
        [JsonPropertyName("FechaFinPrevista")]
        public DateTime? FechaFinPrevista { get; set; }

        [DataType(DataType.Date)]
        [JsonPropertyName("FechaModificacion")]
        public DateTime? FechaModificacion { get; set; }

        [DataType(DataType.Date)]
        [JsonPropertyName("FechaFinalizacion")]
        public DateTime? FechaFinalizacion { get; set; }

        [Range(1, 5, ErrorMessage = "La prioridad debe estar entre 1 y 5")]
        [JsonPropertyName("Prioridad")]
        public int? Prioridad { get; set; }

        [Range(0, 100, ErrorMessage = "El porcentaje de avance debe estar entre 0 y 100")]
        [JsonPropertyName("PorcentajeAvance")]
        public int? PorcentajeAvance { get; set; }

        // Relación con Entregable
        [ForeignKey(nameof(IdEntregable))]
        public virtual Entregable? Entregable { get; set; }
    }
}
