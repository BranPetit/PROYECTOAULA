using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FrontendBlazorApi.Models
{
    public class DistribucionPresupuesto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un Presupuesto Padre")]
        public int IdPresupuestoPadre { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un Proyecto Hijo")]
        public int IdProyectoHijo { get; set; }

        [Required(ErrorMessage = "El monto asignado es obligatorio")]
        [Column(TypeName = "decimal(15,2)")]
        public decimal MontoAsignado { get; set; }

        // Opcionales para mostrar nombres en la lista
        public string? PresupuestoPadre { get; set; }
        public string? ProyectoHijo { get; set; }
    }
}