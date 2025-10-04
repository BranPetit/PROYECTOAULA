using System.Text.Json.Serialization;

namespace FrontendBlazorApi.Models
{
    // Clase genérica para mapear la respuesta de la API
    public class RespuestaApi<T>
    {
        [JsonPropertyName("datos")]   // Coincide con la estructura JSON de la API
        public T? Datos { get; set; }
    }
}