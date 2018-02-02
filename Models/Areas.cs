using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Propaganda.Models
{
    public class Areas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdAreas { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Nome { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Descricao { get; set; }

        public ICollection<Turmas> Turmas { get; set; }


    }
}