using System;
using System.Diagnostics.Metrics;

namespace Fundamentals
{
    class SecretNumber
    {

        public static void run()
        {
            //instantiates Random and draws a random int between 1 and 100
            Random rd = new Random();
            int secretNumber = rd.Next(1, 100); //inclusive interval
            Console.WriteLine("\nO número secreto foi sorteado!");

            //creates a horizontal line to divide terminal
            int lineWidth = Console.WindowWidth;
            char lineChar = '_';
            string horizontalLine = new string(lineChar, lineWidth);
            
            while (true)
            {
                Console.WriteLine(horizontalLine);
                Console.WriteLine($"\nTente acertar o número aleatório entre 1 e 100: ");
                if (int.TryParse(Console.ReadLine(), out int userGuess))
                {
                    if(userGuess == secretNumber)
                    {
                        Console.WriteLine($"\nParabéns! Você chutou {userGuess} e o número secreto realmente era {secretNumber}.");
                        break;
                    }
                    else if(userGuess > secretNumber)
                    {
                        Console.WriteLine($"\nAinda não... O número secreto é MENOR que {userGuess}...");
                        continue;
                    }
                    else if(userGuess < secretNumber)
                    //else would be sufficent, else if just to improve readability
                    {
                        Console.WriteLine($"\nSerá que tá chegando perto? O número secreto é MAIOR que {userGuess}");
                        continue;
                    }

                }

                Console.WriteLine("\nErro! Parece que você digitou um valor inválido.");

            }
        }
    }
}

/*
 
03 - Escreva um programa em C# que solicite ao usuário que adivinhe um número secreto entre 1 e 100. O programa deve gerar aleatoriamente 
o número secreto e fornecer dicas sobre se o palpite do usuário é maior ou menor do que o número secreto. O programa deve continuar pedindo 
palpites até que o usuário adivinhe corretamente o número secreto.
 
 */