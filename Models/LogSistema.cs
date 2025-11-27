namespace FrontendBlazorApi.Models
{
    
        public class LogSistema
        {
            public int Id { get; set; }

          
            public string Entidad { get; set; } = string.Empty;

            
            public string Accion { get; set; } = string.Empty;

            
            public int IdRegistro { get; set; }

          
            public int IdUsuario { get; set; }

            
            public string IpRegistro { get; set; } = string.Empty;


            public DateTime FechaRegistro { get; set; }
        }
    }


