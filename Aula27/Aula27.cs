using System;

namespace Aula27
{
    class Aula27
    {
        static void Main(string[] args)
        {
            //IF SIMPLES
            /*int x = 10;
            Console.WriteLine("Bom dia!");
            if(x > 5)
            {
                Console.WriteLine("Boa tarde!");
            }
            Console.WriteLine("Boa noite!");*/

            Console.WriteLine("Qual a hora atual?");   //Encadeada
            int hora = int.Parse(Console.ReadLine());

            if(hora < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else if (hora < 18)
            {
                Console.WriteLine("Boa tarde!");
            }
            else
            {
                Console.WriteLine("Boa noite!");
            }

        }
    }
}
