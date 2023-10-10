using System;

namespace Fundamentals
{
    class SumInterval
    {
        public static void run()
        {

            List<int> listNumbers = new List<int>();
            int counter = 1;

            while (counter <= 2)
            {
                Console.WriteLine($"\nDigite o {counter}º número inteiro: ");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    listNumbers.Add(number);
                    counter++;
                } else
                {
                    Console.WriteLine("Número inválido. Tente novamente.\n");
                }
            }

            //Console.WriteLine("\nNumbers list: ");
            //Console.Write(string.Join(", ", listNumbers));

            int max_number = listNumbers.Max(),
                min_number = listNumbers.Min(),
                sum = 0;

            for (int i = min_number; i <= max_number; i++)
            {
                if(i % 2 == 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine($"\nRESPOSTA: A soma inclusiva dos números pares entre {min_number} e {max_number} é igual a {sum}.");
        }
    }
}

/*

01 - Escreva um programa em C# que calcule a soma dos números pares em um intervalo de números inteiros especificado pelo usuário.
 
 */