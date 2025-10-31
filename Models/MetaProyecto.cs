using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace FrontendBlazorApi.Models
{
    // ===========================================
    // Modelo: Meta_Proyecto (coincide con la tabla SQL)
    // ===========================================
    public class MetaProyecto
    {
        [Key]
        [JsonPropertyName("idmeta")]
        public int IdMeta { get; set; }

        [Key]
        [JsonPropertyName("idproyecto")]
        public int IdProyecto { get; set; }

        [DataType(DataType.Date)]
        [JsonPropertyName("fechaasociacion")]
        public DateTime? FechaAsociacion { get; set; }

        // ====== Propiedades no mapeadas (solo para visualización) ======
        [NotMapped]
        [JsonPropertyName("metatitulo")]
        public string? MetaTitulo { get; set; }

        [NotMapped]
        [JsonPropertyName("proyectotitulo")]
        public string? ProyectoTitulo { get; set; }
    }
}