using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace FrontendBlazorApi.Models
{
    public class ProyectoProducto
    {
        [Key, Column(Order = 0)]
        [JsonPropertyName("idproyecto")]
        [Required(ErrorMessage = "Debe seleccionar un proyecto")]
        public int IdProyecto { get; set; }

        [Key, Column(Order = 1)]
        [JsonPropertyName("idproducto")]
        [Required(ErrorMessage = "Debe seleccionar un producto")]
        public int IdProducto { get; set; }

        [DataType(DataType.Date)]
        [JsonPropertyName("fechaasociacion")]
        public DateTime? FechaAsociacion { get; set; }

        // ======= Propiedades adicionales (no mapeadas) =======
        [NotMapped]
        [JsonPropertyName("proyectonombre")]
        public string? ProyectoNombre { get; set; }

        [NotMapped]
        [JsonPropertyName("productonombre")]
        public string? ProductoNombre { get; set; }
    }
}