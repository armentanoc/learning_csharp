using System;
namespace Fundamentals
{
    public class Palindromes
    {
        public static void run()
        {
            Console.WriteLine("Digite uma palavra para verificar se é um palíndromo:");
            string word = Console.ReadLine().ToLower();

            string reversedWord = new string(word.ToCharArray().Reverse().ToArray());

            if (word.Equals(reversedWord, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"{word} é um palíndromo!");
            }
            else
            {
                Console.WriteLine($"{word} NÃO é um palíndromo.");
            }
        }
    }
}

/*
 DESAFIO 10:

Palavras palíndromos são aquelas que são lidas da direita para a esquerda da mesma
maneira que da esquerda para a direita. Exemplo ARARA. Dado uma palavra, informar se ela
é palíndroma ou não.
 */