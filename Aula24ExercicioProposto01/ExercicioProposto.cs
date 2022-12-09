using System;

namespace Aula24
{
    class ExercicioProposto
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 30;
            int somar = 0;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            somar = a + b;

            Console.WriteLine("Resultado será: " + somar);
        }
    }
}
