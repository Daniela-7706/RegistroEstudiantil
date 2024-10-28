using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistroEstudiantil.Models
{
    public class Materia
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        [DisplayName("Materia")]
        public string NombreMateria { get; set; }

        [Required]
        [StringLength(10)]
        [DisplayName("Código")]
        public string CodigoMateria { get; set; }

        [Range(1, 100)]
        [DisplayName("Créditos")]
        public int Creditos { get; set; }

        [Required]
        [StringLength(100)]
        public string Profesor { get; set; }

        [Range(1, 9)]
        [ForeignKey("Semestre")]
        public int SemestreOfrecido { get; set; }

        [StringLength(500)]
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }

        public ICollection<Matricula> Matriculas { get; set; }
    }
}
