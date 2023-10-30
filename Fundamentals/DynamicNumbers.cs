using System;
using System.Collections.Generic;
using System.Linq;

namespace Fundamentals
{
    class DynamicNumbers
    {
        public static void run()
        {
            List<double> numbers = new List<double>();
            double sum = 0;
            int evenNumbersCount = 0;

            Console.WriteLine("Digite números (digite 0 para encerrar):");

            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out double number))
                {
                    if (number == 0)
                    {
                        break;
                    }

                    numbers.Add(number);
                    sum += number;
                    evenNumbersCount += (number % 2 == 0) ? 1 : 0;
                }
                else
                {
                    Console.WriteLine("Número inválido. Por favor, insira um número válido.");
                }
            }

            Console.WriteLine($"\nTotal de números lidos: {numbers.Count}");
            Console.WriteLine($"Soma dos números: {sum}");
            Console.WriteLine($"Quantidade de números pares: {evenNumbersCount}");
            Console.WriteLine($"Vetor: {string.Join(", ", numbers)}");
        }
    }
}

/*
 
EXERCÍCIO 04

Faça um algoritmo que leia números até o usuário digitar 0, após
finalizar, mostre quantos números lidos, a soma e quantos são pares.

 */