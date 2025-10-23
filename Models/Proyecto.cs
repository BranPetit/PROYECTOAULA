using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace FrontendBlazorApi.Models
{
    // ===========================================
    // Modelo: Proyecto (coincide con la tabla SQL)
    // ===========================================
    public class Proyecto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("idproyectopadre")]
        public int? IdProyectoPadre { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un responsable")]
        [JsonPropertyName("idresponsable")]
        public int IdResponsable { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un tipo de proyecto")]
        [JsonPropertyName("idtipoproyecto")]
        public int IdTipoProyecto { get; set; }

        [StringLength(50)]
        [JsonPropertyName("codigo")]
        public string? Codigo { get; set; }

        [Required(ErrorMessage = "El título es obligatorio")]
        [StringLength(255)]
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

        [JsonPropertyName("rutalogo")]
        public string? RutaLogo { get; set; }

        // ======= Propiedades adicionales (no mapeadas) =======
        // Solo para presentación en la UI — NO se guardan en la BD
        [NotMapped]
        [JsonPropertyName("proyectopadretitulo")]
        public string? ProyectoPadreTitulo { get; set; }

        [NotMapped]
        [JsonPropertyName("responsablenombre")]
        public string? ResponsableNombre { get; set; }

        [NotMapped]
        [JsonPropertyName("tipoproyectonombre")]
        public string? TipoProyectoNombre { get; set; }
    }
}