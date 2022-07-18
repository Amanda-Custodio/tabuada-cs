using System;

namespace Exercicio_tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fator, i, produto;

            Console.WriteLine("Digite o número que deseja saber a tabuada: ");
            fator = int.Parse(Console.ReadLine());

            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine("Para " + fator + " x " + i);
                produto = fator * i;
                Console.WriteLine("O produto é: " + produto);
                Console.WriteLine();
            }

        }
    }
}
