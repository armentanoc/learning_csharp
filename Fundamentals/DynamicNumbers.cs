using System;
namespace Fundamentals
{
    class DynamicNumbers
    {
        public static void run()
        {
            double[] numbers = new double[1];
            int totalNumbers = 0;
            double sum = 0;
            int evenNumbersCount = 0;

            Console.WriteLine("Digite números (digite 0 para encerrar):");

            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out double number) && number != 0)
                {
                    numbers[totalNumbers] = number;
                    totalNumbers++;
                    sum += number;
                    evenNumbersCount += (number % 2 == 0) ? 1 : 0;
                    Array.Resize(ref numbers, totalNumbers+1);
                }
                else if (number == 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Número inválido. Por favor, insira um número válido.");
                }
            }

            Console.WriteLine($"Total de números lidos: {totalNumbers}");
            Console.WriteLine($"Soma dos números: {sum}");
            Console.WriteLine($"Quantidade de números pares: {evenNumbersCount}");
        
        }
    }
}

/*
 
EXERCÍCIO 04

Faça um algoritmo que leia números até o usuário digitar 0, após
finalizar, mostre quantos números lidos, a soma e quantos são pares.

string.join(',', vetor);
 */