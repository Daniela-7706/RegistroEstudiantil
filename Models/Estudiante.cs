using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RegistroEstudiantil.Models
{
    public class Estudiante
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(100)]
        public string Apellido { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Fecha de Nacimiento")]
        public DateTime FechaDeNacimiento { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(150)]
        [DisplayName("Correo")]
        public string CorreoElectronico { get; set; }

        [Phone]
        [StringLength(15)]
        [DisplayName("Teléfono")]
        public string Telefono { get; set; }

        [StringLength(250)]
        [DisplayName("Dirección")]
        public string Direccion { get; set; }

        [Range(1, 9)]
        public int Semestre { get; set; }

        public ICollection<Matricula> Matriculas { get; set; }

        
    }
}
