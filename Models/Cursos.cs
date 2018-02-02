using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Propaganda.Models
{
    public class Cursos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCursos { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Nome { get; set; }


        [Required]
        [DataType(DataType.Text)]
        public string Descricão { get; set; }


        public int IdAreas { get; set; }
        public Areas areas { get; set; }


        public ICollection<Turmas> Turmas { get; set; }
    }
}