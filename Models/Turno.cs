using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcTurnos.Models
{
    public class Turno
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El asunto es requerido")]
        public string Asunto { get; set; }

        [DataType(DataType.Time)]
        [Required(ErrorMessage = "La hora es requerido")]
        public DateTime Hora { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "La fecha es requerida")]
        public DateTime Fecha { get; set; }
        [ForeignKey("Usuario")]
        public string UsuarioId { get; set; }


    }
}