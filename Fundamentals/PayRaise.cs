using System;
namespace Fundamentals
{
    public class PayRaise
    {
        public static void run()
        {
            double currentSalary = 0;
            bool validSalary = false;

            while (!validSalary)
            {
                Console.Write("Digite o salário do colaborador: ");

                if (double.TryParse(Console.ReadLine(), out currentSalary) && currentSalary >= 0)
                {
                    validSalary = true;
                }
                else
                {
                    Console.WriteLine("Valor de salário inválido. Por favor, digite um valor válido.");
                }
            }

            double raisePercentage = 0;
            double raiseAmount = 0;

            if (currentSalary <= 280)
            {
                raisePercentage = 20;
            }
            else if (currentSalary <= 700)
            {
                raisePercentage = 15;
            }
            else if (currentSalary <= 1500)
            {
                raisePercentage = 10;
            }
            else
            {
                raisePercentage = 5;
            }

            raiseAmount = (currentSalary * raisePercentage) / 100;
            double newSalary = currentSalary + raiseAmount;

            Console.WriteLine($"\nSalário antes do reajuste: {currentSalary.ToString("C")}");
            Console.WriteLine($"Percentual de aumento aplicado: {raisePercentage}%");
            Console.WriteLine($"Valor do aumento: {raiseAmount.ToString("C")}");
            Console.WriteLine($"Novo salário após o aumento: {newSalary.ToString("C")}");

        }
    }
}

/*
 
 DESAFIO 11:

As Organizações Tabajara resolveram dar um aumento de salário aos seus colaboradores e 
lhe contraram para desenvolver o programa que calculará os reajustes.
Faça um programa que recebe o salário de um colaborador e o reajuste segundo o seguinte 
critério, baseado no salário atual:    
    - salários até R$ 280,00 (incluindo) : aumento de 20%
    - salários entre R$ 280,00 e R$ 700,00 : aumento de 15%
    - salários entre R$ 700,00 e R$ 1500,00 : aumento de 10%
    - salários de R$ 1500,00 em diante : aumento de 5%

Após o aumento ser realizado, informe na tela:
    - o salário antes do reajuste;
    - o percentual de aumento aplicado;
    - o valor do aumento;
    - o novo salário, após o aumento.
 
 */