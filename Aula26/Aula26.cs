using System;

namespace Aula26
{
    class Aula26
    {
        static void Main(string[] args)
        {

            bool c1 = 2 > 3 || 4 != 5;   //True

            bool c2 = !(2 > 3) && 4 != 5; //True

            Console.WriteLine(c1);
            Console.WriteLine(c2);

            Console.WriteLine("===================");

            bool c3 = 10 < 5;   // False

            bool c4 = c1 || c2 && c3; // True

            Console.WriteLine(c3);
            Console.WriteLine(c4);

        }
    }
}
