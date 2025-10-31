using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FrontendBlazorApi.Models
{
    public class EjecucionPresupuesto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un presupuesto")]
        public int IdPresupuesto { get; set; }

        [Required(ErrorMessage = "El campo Año es obligatorio.")]
        [Range(2000, 2100, ErrorMessage = "El año debe estar entre 2000 y 2100")]
        [Display(Name = "Año")]
        public int Anio { get; set; }

        [Column(TypeName = "decimal(15,2)")]
        public decimal? MontoPlaneado { get; set; }

        [Column(TypeName = "decimal(15,2)")]
        public decimal? MontoEjecutado { get; set; }

        public string? Observaciones { get; set; }

        [NotMapped]
        public string? PresupuestoTitulo { get; set; }
    }
}