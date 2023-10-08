using System;
using System.Linq;

namespace Fundamentals
{
    public class ArrayFunctions
    {
        public static void run()
        {
            int numero = 0;
            int[] numeros = new int[10];

            Console.WriteLine("Digite 10 números inteiros:");

            for (int i = 0; i < 10; i++)
            {
                bool numeroValido = false;

                while (!numeroValido)
                {
                    Console.Write($"Número {i + 1}: ");

                    if (int.TryParse(Console.ReadLine(), out numero))
                    {
                        numeroValido = true;
                    }
                    else
                    {
                        Console.WriteLine("Número inválido. Digite um número inteiro.");
                    }
                }

                numeros[i] = numero;
            }

            double media = numeros.Average();
            int soma = numeros.Sum();
            int menor = numeros.Min();

            Console.WriteLine($"\nMédia: {media:F2}");
            Console.WriteLine($"Soma: {soma}");
            Console.WriteLine($"Menor número: {menor}");
        }
    }
}
/*
 
EXERCÍCIO 02

Crie um programa que peça 10 números inteiros
e apresente a média, a soma e o menor.
 
 */