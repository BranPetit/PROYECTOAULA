using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace FrontendBlazorApi.Models
{
    [Table("Proyecto_Producto")]
    public class ProyectoProducto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un proyecto")]
        [JsonPropertyName("idproyecto")]
        public int IdProyecto { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un producto")]
        [JsonPropertyName("idproducto")]
        public int IdProducto { get; set; }

        [JsonPropertyName("fechaasociacion")]
        [DataType(DataType.Date)]
        public DateTime? FechaAsociacion { get; set; }

        // ===== Campos no mapeados para visualización =====
        [NotMapped]
        [JsonPropertyName("proyectoNombre")]
        public string? ProyectoNombre { get; set; }

        [NotMapped]
        [JsonPropertyName("productoNombre")]
        public string? ProductoNombre { get; set; }
    }
}