using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistroEstudiantil.Models
{
    public class Matricula
    {
        [Key]
        public int Id { get; set; }

        [Range(1, 9)]
        public string Semestre { get; set; }

        [Required]
        [ForeignKey("Fecha de Matrícula")]
        [DataType(DataType.Date)]
        public DateTime FechaMatricula { get; set; }

        [Required]
        [ForeignKey("Estudiante")]
        public int EstudianteId { get; set; }

        [Required]
        [ForeignKey("Materia")]
        public int MateriaId { get; set; }

        public Estudiante Estudiante { get; set; }

        public Materia Materia { get; set; }


    }
}
