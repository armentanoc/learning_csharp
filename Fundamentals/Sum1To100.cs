using System;
namespace Fundamentals
{
    class Sum1To100
    {
        public static void run()
        {
            int[] numbers = new int[100];
            int sum = 0;

            for (int i = 1; i <= 100; i++)
            {
                numbers[i-1] = i;
                sum += i;
            }

            Console.WriteLine($"A soma dos números de 1 a 100 usando um array é: {sum}");
        }
    }
}

/*
 
EXERCÍCIO 03

Some os números de 1 a 100 a imprima o valor.

 */
