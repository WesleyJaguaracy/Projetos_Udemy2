using System;
using System.Globalization;

namespace uri1002
{
    class Program
    {
        static void Main(string[] args)
        {

            double r, a, pi = 3.14159;

            r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            a = pi * r * r;

            Console.WriteLine("Area = " + a.ToString("F4", CultureInfo.InvariantCulture));
            
        }
    }
}