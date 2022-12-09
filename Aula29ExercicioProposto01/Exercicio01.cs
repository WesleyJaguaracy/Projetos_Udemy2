using System;

namespace Projetos_Udemy2
{
    class Exercicio01
    {
        static void Main(string[] args)
        {


            int negativo = int.Parse(Console.ReadLine());

            if (negativo < 0)
            {
                Console.WriteLine("NEGATIVO");
            }
            else
            {
                Console.WriteLine("NAO NEGATIVO");
            }
        }
    }
}