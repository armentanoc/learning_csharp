using System;
namespace Fundamentals
{
    public class SimpleCalculator
    {
        public static void run()
        {
            float
                number1 = Receive.FloatByOrder(1),
                number2 = Receive.FloatByOrder(2);

            float
                sum = number1 + number2,
                subtraction = number1 - number2,
                multiplication = number1 * number2,
                division = number1 / number2;

            Console.WriteLine(
                $"\nSoma: {sum}" +
                $"\nSubtração: {subtraction}" +
                $"\nMultiplicação: {multiplication}" +
                $"\nDivisão: {division}"
                );
        }
    }
}

/*
Desafio 1: Calculadora

Objetivo: Escrever um programa que solicite ao usuário dois números e realize operações 
simples de adição, subtração, multiplicação e divisão.

Instruções:

Solicite ao usuário que insira dois números.
Realize as operações de adição, subtração, multiplicação e divisão entre esses números.
Exiba os resultados das operações no console.

Dica: Use variáveis para armazenar os números de entrada e os resultados intermediários.
*/
