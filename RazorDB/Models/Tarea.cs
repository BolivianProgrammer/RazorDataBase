using System;
using System.ComponentModel.DataAnnotations;

namespace RazorDB.Models
{
    public class Tarea
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre de la tarea es obligatorio")]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "El nombre debe tener entre 10 y 100 caracteres")]
        [Display(Name = "Nombre de la tarea")]
        public string nombreTarea { get; set; }

        [Required(ErrorMessage = "La fecha de vencimiento es obligatoria")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de vencimiento")]
        public DateTime fechaVencimiento { get; set; }

        [Required(ErrorMessage = "El estado es obligatorio")]
        [RegularExpression("^(En progreso|Pendiente|Cancelado|Terminado)$",
            ErrorMessage = "El estado solo puede ser: En progreso, Pendiente, Cancelado o Terminado")]
        [Display(Name = "Estado")]
        public string estado { get; set; }

        [Required(ErrorMessage = "El ID de usuario es obligatorio")]
        [Range(1, int.MaxValue, ErrorMessage = "El ID de usuario debe ser un número positivo")]
        [Display(Name = "ID de Usuario")]
        public int idUsuario { get; set; }
    }
}
