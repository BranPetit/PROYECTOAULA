using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace FrontendBlazorApi.Models
{
    // ===========================================
    // Modelo: Producto (coincide con la tabla SQL)
    // ===========================================
    public class Producto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un tipo de producto")]
        [JsonPropertyName("idtipoproducto")]
        public int IdTipoProducto { get; set; }

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
        [NotMapped]
        [JsonPropertyName("tipoproductonombre")]
        public string? TipoProductoNombre { get; set; }
    }
}