using System;

namespace Projetos_Udemy2
{
    class Exercicio03
    {
        static void Main(string[] args)
        {

            int a, b, c, d, diferente;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());

            diferente = a * b - c * d;

            Console.WriteLine("Diferença será = " + diferente);
        }
    }
}