using System;

namespace Projetos_Udemy2
{
    class Exercicio01
    {
        static void Main(string[] args)
        {

            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Senha Invalida");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");
        }
    }
}