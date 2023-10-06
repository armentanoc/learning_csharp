using System;
namespace Fundamentals
{
    public class TipCalculator
    {
        public static void run()
        {
            float
                bill = Receive.Float("Informe o valor total da conta (ex.: 120.27): "),
                tip = 0;
            int tipPercentage = Receive.Int("Informe o percentual da gorjeta que deseja oferecer (ex.: 15):");
         
            if (tipPercentage >= 0 && tipPercentage <= 100)
            {
            tip = (bill * tipPercentage) / 100;
            }
            else
            {
                Console.WriteLine("A gorjeta não pode ser menor que 0% ou maior que 100%.");
                run();
            }

            Console.WriteLine($"\nGorjeta: R${Math.Round(tip, 2)}" +
                $"\nTotal da Conta: R${Math.Round((bill + tip), 2)}");
        }

    }
}

/*

Desafio 3: Calculadora de Gorjeta

Objetivo: Escrever um programa que calcule o valor da gorjeta a ser deixada em um 
restaurante com base no valor da conta e na porcentagem de gorjeta.

Instruções:

Solicite ao usuário que insira o valor total da conta do restaurante.
Solicite ao usuário que insira a porcentagem de gorjeta desejada 
(por exemplo, 15% ou 20%).
Calcule o valor da gorjeta multiplicando o valor da conta pela porcentagem de gorjeta 
e dividindo por 100.
Exiba o valor da gorjeta e o total a ser pago (conta + gorjeta) na tela.

Dica: Use variáveis para armazenar os valores de entrada e os resultados intermediários.
 
 */