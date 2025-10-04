using System.Text.Json.Serialization;

namespace FrontendBlazorApi.Models
{
    // ===========================================
    // Modelo: Archivo
    // ===========================================
    public class Archivo
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("idusuario")]
        public int IdUsuario { get; set; }

        [JsonPropertyName("ruta")]
        public string Ruta { get; set; } = string.Empty;

        [JsonPropertyName("nombre")]
        public string Nombre { get; set; } = string.Empty;

        [JsonPropertyName("tipo")]
        public string? Tipo { get; set; }

        [JsonPropertyName("fecha")]
        public DateTime? Fecha { get; set; }
    }
}
