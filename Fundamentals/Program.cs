using System;
namespace Fundamentals
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("LEARNING C#\n" +
                "\nQual programa você deseja executar?" +
                "\n(1) Simple Calculator" +
                "\n(2) Age Calculator" +
                "\n(3) Tip Calculator" +
                "\n(4) Currency Converter");

            try
            {
                int choice = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (choice)
                {
                    case 1:
                        SimpleCalculator.run();
                        break;
                    case 2:
                        AgeCalculator.run();
                        break;
                    case 3:
                        TipCalculator.run();
                        break;
                    case 4:
                        CurrencyConverter.run();
                        break;
                    default:
                        throw new ArgumentException("Por gentileza, informe um número inteiro dentre as opções disponíveis.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Main(args);
            }

            //ConsoleInteraction.Strings();

        }
    }
}

