using System;
using System.Text.RegularExpressions;

namespace Fundamentals
{
    public class AgeCalculator
    {
        public static void run()
        {
            int currentYear, birthYear, age;

            currentYear = getValidYear("Informe o ano atual: ");
            birthYear = getValidYear(" \nInforme o seu ano de nascimento: ");
 
            bool birthdayThisYear = haveYouAlreadyHadYourBirthday();
            age = birthdayThisYear ? currentYear - birthYear : currentYear - birthYear - 1;
            Console.WriteLine($"\nVocê tem {age} anos.");
        }

        private static int getValidYear(string message)
        {
            while (true)
            {
                Console.Write(message);
                if (int.TryParse(Console.ReadLine(), out int year) && year <= DateTime.Now.Year)
                {
                    return year;
                }
                Console.WriteLine("\nAno inválido. Tente novamente.\n");
            }
        }

        public static bool haveYouAlreadyHadYourBirthday()
        {
            while (true)
            {
                Console.Write("\nVocê já fez aniversário este ano? (sim/não): ");
                string answer = Console.ReadLine().ToLower();

                if (Regex.IsMatch(answer, @"^(sim|s)$"))
                {
                    return true;
                }
                else if (Regex.IsMatch(answer, @"^(não|nao|n)$"))
                {
                    return false;
                }
                Console.WriteLine("\nResposta inválida. Por favor, responda com 'sim' ou 'não'.");
            }
        }
    }
}

