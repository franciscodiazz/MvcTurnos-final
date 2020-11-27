using System;
using System.ComponentModel.DataAnnotations;

namespace MvcTurnos.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es requerido")]
        [StringLength(50)]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El Apellido es requerido")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "La cedula es requerida")]
        public string Cedula { get; set; }

        public int Telefono { get; set; }
        public int Edad { get; set; }
        [Required(ErrorMessage = "El Programa es requerido")]
        public string Programa { get; set; }
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string Correo { get; set; }
        [Required(ErrorMessage = "El semestre es requerida")]
        public string Semestre { get; set; }


    }
}