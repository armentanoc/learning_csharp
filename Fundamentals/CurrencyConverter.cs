using System;
using System.Globalization;

namespace Fundamentals
{
    public class CurrencyConverter
    {
        public static void run()
        {

            float valueReais = Receive.Float("Informe o valor em reais (ex.: 10.50)");
            (float conversionRate, string prefix) = whichCurrency(valueReais);
            float convertedValue = valueReais / conversionRate;
            Console.WriteLine($"Valor original: BRL {valueReais.ToString("F2")}" +
                $"\nValor convertido: {prefix} {convertedValue.ToString("F2")} ");
        }

        public static (float, string) whichCurrency(float valueReais)
        {
            const float
                REAL_TO_DOLAR = 5.50F,
                REAL_TO_EURO = 6.50F;

            int answer;

            try
            {
                Console.WriteLine("\nPara qual moeda você deseja converter?\n1 - Dólar\n2 - Euro");
                answer = int.Parse(Console.ReadLine());

                switch (answer)
                {
                    case 1:
                        return (REAL_TO_DOLAR, "USD");
                    case 2:
                        return (REAL_TO_EURO, "EUR");
                    default:
                        Console.WriteLine("Digite apenas valores dentro do informado (1 ou 2).");
                        return whichCurrency(valueReais);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return whichCurrency(valueReais);
            }
        }
    }
}

/*

Desafio 4: Conversor de Moedas

Objetivo: Escrever um programa que converta um valor em reais para outras duas moedas 
estrangeiras (por exemplo, dólar e euro).

Instruções:

Solicite ao usuário que insira um valor em reais.
Defina as taxas de conversão para dólar e euro. Por exemplo, 1 dólar = 5,50 reais e 1 euro = 6,50 reais.
Calcule o valor equivalente em dólares e euros.
Exiba os valores convertidos na tela.

Dica: Use variáveis para armazenar os valores de entrada, as taxas de conversão e os resultados intermediários.
 
 */

/*To-do: Make it more optimized with CultureInfo: 
 
  public static void cultureInfo(float value)
        {
            CultureInfo cultureBrasil = CultureInfo.CreateSpecificCulture("pt-BR");
            string formattedValue = value.ToString("C", cultureBrasil);
            Console.WriteLine($"Valor formatado para {cultureBrasil}: {formattedValue}");

        }s
 
 */