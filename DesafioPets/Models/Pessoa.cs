using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DesafioPets.Models
{
    public class Pessoa
    {
        public int PessoaId { get; set; }
        [StringLength(255), Required]
        public string Nome { get; set; }
        public int? Idade { get; set; }
        public int? QtdFilhos { get; set; }
        public ICollection<Pet> Pets { get; set; }
    }
}
