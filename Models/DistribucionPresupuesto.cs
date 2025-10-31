using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace FrontendBlazorApi.Models
{
    public class DistribucionPresupuesto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un presupuesto padre")]
        [JsonPropertyName("idpresupuestopadre")]
        public int IdPresupuestoPadre { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un proyecto hijo")]
        [JsonPropertyName("idproyectohijo")]
        public int IdProyectoHijo { get; set; }

        [Required(ErrorMessage = "Debe ingresar el monto asignado")]
        [Range(0.01, double.MaxValue, ErrorMessage = "El monto debe ser mayor a cero")]
        [JsonPropertyName("montoasignado")]
        public decimal MontoAsignado { get; set; }

        // ====== Propiedades no mapeadas (solo visualización) ======
        [NotMapped]
        [JsonPropertyName("presupuestoNombre")]
        public string? PresupuestoNombre { get; set; }

        [NotMapped]
        [JsonPropertyName("proyectoNombre")]
        public string? ProyectoNombre { get; set; }
    }
}