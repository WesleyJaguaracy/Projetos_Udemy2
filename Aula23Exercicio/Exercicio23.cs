using System;
using System.Globalization;

namespace Exercicio23
{
    class Exercicio23
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome cpmpleto: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o preço: ");
            double preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com seu ultimo nome, idade e altura: ");
            string[] vet = Console.ReadLine().Split(' ');
            string sobrenome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(sobrenome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
