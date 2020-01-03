using DesafioPets.Models;
using System.Collections.Generic;
using System.Linq;

namespace DesafioPets
{
    public class SeedDataBase
    {
        public static void SeedDb(DesafioPetsContext context)
        {
            if (!context.Pessoas.Any())
            {
                var pessoas = new List<Pessoa>
                {
                    new Pessoa {Nome = "Francisco", Idade= 40, QtdFilhos= 2},
                    new Pessoa {Nome = "Bob", Idade= 25, QtdFilhos= 0},
                    new Pessoa {Nome = "Marcio", Idade= 30, QtdFilhos= 1},
                    new Pessoa {Nome = "Maria", Idade= 25, QtdFilhos= 0},
                    new Pessoa {Nome = "Vanessa", Idade= 20, QtdFilhos= 0},
                    new Pessoa {Nome = "Arthur", Idade= 29, QtdFilhos= 0},
                    new Pessoa {Nome = "Vinicius", Idade= 48, QtdFilhos= 3},
                    new Pessoa {Nome = "Cleide", Idade= 30, QtdFilhos= 1},
                    new Pessoa {Nome = "Carlos", Idade= 35, QtdFilhos= 2},
                    new Pessoa {Nome = "Luis", Idade= 54, QtdFilhos= 3}
                };
                context.AddRange(pessoas);
                context.SaveChanges();
            }

            if (!context.Pets.Any())
            {
                var pets = new List<Pet>
                {
                    new Pet {PessoaId= 1, Adotado= true },
                    new Pet {PessoaId= 1, Adotado= false },
                    new Pet {PessoaId= 1, Adotado= false },
                    new Pet {PessoaId= 2, Adotado= true },
                    new Pet {PessoaId= 3, Adotado= true },
                    new Pet {PessoaId= 3, Adotado= true },
                    new Pet {PessoaId= 4, Adotado= true },
                    new Pet {PessoaId= 4, Adotado= true },
                    new Pet {PessoaId= 4, Adotado= false },
                    new Pet {PessoaId= 4, Adotado= false },
                    new Pet {PessoaId= 6, Adotado= false },
                    new Pet {PessoaId= 6, Adotado= false },
                    new Pet {PessoaId= 7, Adotado= false },
                    new Pet {PessoaId= 7, Adotado= false }
                };


                context.AddRange(pets);
                context.SaveChanges();
            };

        }

    }
}
