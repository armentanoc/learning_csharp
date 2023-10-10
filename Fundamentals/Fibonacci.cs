using System;
using System.Diagnostics.Metrics;

namespace Fundamentals

{
    class Fibonacci
    {
        public static void run()
        {
            //fibonacci sequence starts with 0 and 1
            int before = 0,
                after = 1,
                aux,
                max;

            //initializes fibonacci list to receive numbers
            List<int> fibonacciList = new List<int>();

            //loop that asks again if the input is not a valid int number
            while (true)
            {
                Console.WriteLine($"\nDigite o limite da sequência (número inteiro): ");
                if (int.TryParse(Console.ReadLine(), out max))
                {
                    break;
                }
            }

            //loop to create fibonacci sequence
            for (int i = 0; i < max; i++)
            {
                fibonacciList.Add(before);
                aux = before + after;
                before = after;
                after = aux; 
            }

            //prints fibonacci list
            Console.WriteLine($"\nSEQUÊNCIA DE FIBONACCI: {string.Join(", ", fibonacciList)}");
        }
    }
}

/*

02 - Escreva um programa em C# que gere e exiba os primeiros N termos da sequência de Fibonacci, onde N é especificado pelo usuário.
 
 */