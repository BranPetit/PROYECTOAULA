using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace FrontendBlazorApi.Models
{
    public class ProductoEntregable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un producto")]
        [JsonPropertyName("idproducto")]
        public int IdProducto { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un entregable")]
        [JsonPropertyName("identregable")]
        public int IdEntregable { get; set; }

        [JsonPropertyName("fechaasociacion")]
        public DateTime? FechaAsociacion { get; set; }

        // ====== Propiedades no mapeadas (solo para visualización) ======
        [NotMapped]
        [JsonPropertyName("productoNombre")]
        public string? ProductoNombre { get; set; }

        [NotMapped]
        [JsonPropertyName("entregableNombre")]
        public string? EntregableNombre { get; set; }
    }
}