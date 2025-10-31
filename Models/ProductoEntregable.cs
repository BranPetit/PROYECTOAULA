using System;
using System.ComponentModel.DataAnnotations;

namespace FrontendBlazorApi.Models
{
    public class ProductoEntregable
    {
        [Required]
        public int IdProducto { get; set; }

        [Required]
        public int IdEntregable { get; set; }

        public DateTime? FechaAsociacion { get; set; }
    }
}