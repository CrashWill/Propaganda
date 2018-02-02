using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Propaganda.Models
{
    public class Turmas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTurmas { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Duracao { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Horario { get; set; }

        [Required]
        public int IdCursos { get; set; }
        public Cursos Cursos { get; set; }
    }
}