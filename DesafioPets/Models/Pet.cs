using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DesafioPets.Models
{
    public class Pet
    {
        public int PetId { get; set; }
        public int? PessoaId { get; set; }
        [Required]
        public bool Adotado { get; set; }
        public Pessoa Pessoa { get; set; }
    }
}
