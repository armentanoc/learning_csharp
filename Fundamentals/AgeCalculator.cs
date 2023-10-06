using System;
using System.Text.RegularExpressions;

namespace Fundamentals
{
    public class AgeCalculator
    {
        public static void run()
        {
            int
                currentYear = Receive.Int("Informe o ano atual:"),
                birthYear = Receive.Int("Informe o seu ano de nascimento:"),
                age = currentYear - birthYear;

            bool birthdayThisYear = haveYouAlreadyHadYourBirthday();
            age = (birthdayThisYear == false) ? age - 1 : age;
            Console.WriteLine($"\nCALCULADORA DE IDADE\nVocê tem {age} anos.");
        }

        public static bool haveYouAlreadyHadYourBirthday()
        {
            Console.WriteLine($"Você já fez aniversário esse ano? (sim/não)");

            string
                answer = Console.ReadLine().ToLower(),
                no = @"^não|nao",
                yes = @"^sim";

            if (Regex.IsMatch(answer, yes))
            {
                return true;
            }
            else if (Regex.IsMatch(answer, no))
            {
                return false;
            }
            else
            {
                Console.WriteLine("Erro. A resposta fornecida deve ser sim ou não.");
                return haveYouAlreadyHadYourBirthday();
            }
        }
    }
}

