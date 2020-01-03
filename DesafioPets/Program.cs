using System;

namespace DesafioPets
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new DesafioPetsContext()) {SeedDataBase.SeedDb(db);}

            ConsultasBd.ExibePessoasComPet();
            Console.WriteLine();
            ConsultasBd.ExibePessoaComFilhoSemPet();
            Console.WriteLine();
            ConsultasBd.ExibePetsPorPessoa();
            Console.WriteLine();
           ConsultasBd.ExibeAdotadosPorPessoa1();
            Console.WriteLine();
            ConsultasBd.ExibeAdotadosPorPessoa2();
            Console.ReadLine();
        }
    }
}
