using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace FrontendBlazorApi.Models
{
    public class Archivo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un usuario")]
        [JsonPropertyName("idusuario")]
        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "Debe especificar la ruta del archivo")]
        [StringLength(500)]
        [JsonPropertyName("ruta")]
        public string Ruta { get; set; } = string.Empty;

        [Required(ErrorMessage = "Debe ingresar el nombre del archivo")]
        [StringLength(255)]
        [JsonPropertyName("nombre")]
        public string Nombre { get; set; } = string.Empty;

        [StringLength(50)]
        [JsonPropertyName("tipo")]
        public string? Tipo { get; set; }

        [JsonPropertyName("fecha")]
        public DateTime? Fecha { get; set; } = DateTime.Now;

        // Propiedades auxiliares para mostrar datos relacionados
        [NotMapped]
        [JsonPropertyName("usuarioNombre")]
        public string? UsuarioNombre { get; set; }
    }
}