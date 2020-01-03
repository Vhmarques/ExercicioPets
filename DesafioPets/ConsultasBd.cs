using DesafioPets.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DesafioPets
{
    class ConsultasBd
    {
        public static void ExibePessoasComPet()
        {
            using (var contexto = new DesafioPetsContext())
            {
                var resultado = contexto.Pessoas.Where(a => a.Pets.Any());

                Console.WriteLine("Pessoas com pet:");
                foreach (var pessoa in resultado)
                {
                    Console.WriteLine(pessoa.Nome);
                }
            }
        }

        public static void ExibePessoaComFilhoSemPet()
        {
            using (var contexto = new DesafioPetsContext())
            {
                var resultado = contexto.Pessoas.Where(a => a.QtdFilhos != 0 && !a.Pets.Any());

                Console.WriteLine("Pessoas com Filhos sem pet:");
                foreach (var pessoa in resultado)
                {
                    Console.WriteLine(pessoa.Nome);
                }

            }

        }

        public static void ExibePetsPorPessoa()
        {
            using (var contexto = new DesafioPetsContext())
            {
                var resultado = contexto.Pessoas.Where(a => a.Pets.Any());

                Console.WriteLine("Pessoas com seus respectivos pets:");
                foreach (var pessoa in resultado.Include(a => a.Pets))
                {
                    Console.WriteLine("Nome: " + pessoa.Nome);
                    Console.WriteLine("Id dos pet(s): ");
                    foreach (var pet in pessoa.Pets)
                    {
                        Console.WriteLine(pet.PetId);

                    }
                    Console.WriteLine();
                }
            }


        }


        public static void ExibeAdotadosPorPessoa1()
        {
            using (var contexto = new DesafioPetsContext())
            {
                foreach (var pessoa in contexto.Pessoas)
                {
                    contexto.Entry(pessoa).Collection(p => p.Pets).Query().Where(p => p.Adotado == true).Load();
                    if (pessoa.Pets.Any())
                    {
                        Console.WriteLine(pessoa.Nome + " Adotou o(s) Pet(s): ");
                    }

                    foreach (var p in pessoa.Pets)
                    {
                        Console.WriteLine(p.PetId);

                    }
                    Console.WriteLine();

                }
            }

        }

        public static void ExibeAdotadosPorPessoa2()
        {

            using (var contexto = new DesafioPetsContext())
            {
                var pet = contexto.Pets.Where(p => p.Adotado != false);
                foreach (var s in pet)
                {
                    Console.Write("O pet: " + s.PetId);

                    foreach (var Pessoa in contexto.Pessoas.Where(x => x.Pets.Any()))
                    {

                        if (Pessoa.PessoaId == s.PessoaId)
                        {
                            Console.WriteLine(" Foi adotado pelo(a) " + Pessoa.Nome);
                        }
                    }
                }
            }
        }
    }
}