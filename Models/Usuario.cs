using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace FrontendBlazorApi.Models
{
    // Modelo que representa un usuario tal como lo devuelve y recibe la API
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [JsonPropertyName("id")]
        public int Id { get; set; }


        [Required(ErrorMessage = "El Email es obligatorio")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "La contrasena es obligatoria")]
        public string Contrasena { get; set; } = string.Empty;

        [JsonPropertyName("rutaavatar")]
        public string? RutaAvatar { get; set; }

        [JsonPropertyName("activo")]
        public bool Activo { get; set; } = true;
    }
}
