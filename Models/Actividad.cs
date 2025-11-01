using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace FrontendBlazorApi.Models
{
    public class Actividad
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un entregable")]
        [JsonPropertyName("identregable")]
        public int IdEntregable { get; set; }

        [Required(ErrorMessage = "Debe ingresar un título para la actividad")]
        [StringLength(255, ErrorMessage = "El título no puede superar los 255 caracteres")]
        [JsonPropertyName("titulo")]
        public string Titulo { get; set; } = string.Empty;

        [JsonPropertyName("descripcion")]
        public string? Descripcion { get; set; }

        [DataType(DataType.Date)]
        [JsonPropertyName("fechainicio")]
        public DateTime? FechaInicio { get; set; }

        [DataType(DataType.Date)]
        [JsonPropertyName("fechafinprevista")]
        public DateTime? FechaFinPrevista { get; set; }

        [DataType(DataType.Date)]
        [JsonPropertyName("fechamodificacion")]
        public DateTime? FechaModificacion { get; set; }

        [DataType(DataType.Date)]
        [JsonPropertyName("fechafinalizacion")]
        public DateTime? FechaFinalizacion { get; set; }

        [Range(1, 5, ErrorMessage = "La prioridad debe estar entre 1 y 5")]
        [JsonPropertyName("prioridad")]
        public int? Prioridad { get; set; }

        [Range(0, 100, ErrorMessage = "El porcentaje de avance debe estar entre 0 y 100")]
        [JsonPropertyName("porcentajeavance")]
        public int? PorcentajeAvance { get; set; }

        // ====== Propiedad auxiliar para mostrar el entregable asociado ======
        [NotMapped]
        [JsonPropertyName("entregableNombre")]
        public string? EntregableNombre { get; set; }
    }
}