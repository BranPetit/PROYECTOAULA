using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FrontendBlazorApi.Models
{
    // ===========================================
    // Modelo: Responsable (coincide exactamente con la tabla)
    // ===========================================
    public class Responsable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un tipo de responsable")]
        public int IdTipoResponsable { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un usuario")]
        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(255)]
        public string Nombre { get; set; } = string.Empty;   

// Propiedades opcionales para mostrar nombres
        public string? TipoResponsable { get; set; }
        public string? Usuario { get; set; }
    }
}