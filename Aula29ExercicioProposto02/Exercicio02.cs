using System;

namespace cond02
{
    class Exercicio02
    {
        static void Main(string[] args)
        {

            int negativo = int.Parse(Console.ReadLine());

            if (negativo % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }
        }
    }
}