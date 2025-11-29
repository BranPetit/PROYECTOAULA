namespace FrontendBlazorApi.Models
{
    public class LogSistema
    {
        public int Id { get; set; }

        public int? IdUsuario { get; set; }

        public string Modulo { get; set; } = string.Empty;

        public string Accion { get; set; } = string.Empty;

        public int? IdAfectado { get; set; }

        public string? DatosAnteriores { get; set; }

        public string? DatosNuevos { get; set; }

        public DateTime Fecha { get; set; }

        public string? IpCliente { get; set; }

        public string? Descripcion { get; set; }

        public string? UsuarioEmail { get; set; }



        // 🔗 Relación opcional (si usas EF)
        public Usuario? Usuario { get; set; }
    }

}
