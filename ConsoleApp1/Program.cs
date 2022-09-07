using System;
using System.Diagnostics;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int salario = 1000;
            //float rating = 1.0f;
            double rating = 90.9;
            bool isActive = false;
            string name = "Joel";
            char initialletter = 'J';

            //tipo de valor: int , enum, bool
            //tipo de referencia: string , class, array

            Loja loja = new Loja();
            loja.Nome = "Lojinha";

            Console.WriteLine(loja.Nome);
            TestTipo(loja);
            Console.WriteLine(loja.Nome);


            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }

        public static void TestTipo(Loja lojaB)
        {
           Console.WriteLine(lojaB.Nome);

            lojaB.Nome = "Lojona";

            Console.WriteLine(lojaB.Nome);
        }

        public class Loja
        {
            public string Nome { get; set; }

        }

    }
}
