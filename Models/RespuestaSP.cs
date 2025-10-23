using System.Text.Json.Serialization;

namespace FrontendBlazorApi.Models
{
    // Clase genérica para mapear la respuesta de la API
    public class RespuestaSP<T>
    {
        [JsonPropertyName("Procedimiento")]
        public string? Procedimiento { get; set; }

        [JsonPropertyName("Resultados")]
        public List<Dictionary<string, object>>? Resultados { get; set; }

        [JsonPropertyName("Total")]
        public int Total { get; set; }

        [JsonPropertyName("Mensaje")]
        public string? Mensaje { get; set; }
    }
}