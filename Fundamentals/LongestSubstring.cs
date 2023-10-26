using System;
namespace Fundamentals
{
    public class LongestSubstring
    {
        public static void run()
        {
            Console.WriteLine("\nInforme a string que deseja analisar: ");
            string s = Console.ReadLine().ToLower();

            int n = s.Length, maxLength = 0, left = 0;

            Dictionary<char, int> charIndexMap = new Dictionary<char, int>();

            for (int right = 0; right < n; right++)
            {
                if (charIndexMap.ContainsKey(s[right]) && charIndexMap[s[right]] >= left)
                {
                    left = charIndexMap[s[right]] + 1;
                }
                charIndexMap[s[right]] = right;
                maxLength = Math.Max(maxLength, right - left + 1);
            }

            Console.WriteLine($"\nTamanho da maior substring sem caracteres repetidos: {maxLength}");

        }
    }
}

/*

Programming Problem: Longest Substring Without Repeating Characters

Given a string, find the length of the longest substring without repeating characters.


Solução:

- Abordagem de slide window para encontrar a subsequência mais longa sem
caracteres repetidos

- Há dois ponteiros, left e right, que definem a substring atual

- O dicionário charIndexMap é usado para armazenar o índice da última
ocorrência de cada caractere na string

- Conforme iteramos pela string da esquerda para a direita, se encontrarmos
um caractere repetido (ou seja, um que já esteja na substring entre left e
right), atualizamos o valor de left para o próximo índice do caractere
repetido, garantindo assim que tenhamos uma nova substring sem caracteres
repetidos

- Atualizamos o dicionário charIndexMap e calculamos o comprimento da
substring atual, mantendo um registro do comprimento máximo encontrado
até o momento

- Complexidade de tempo de O(n), porque faz uma única passagem pela
string de entrada, e as operações do dicionário (inserção e busca) têm
uma complexidade média de O(1), encontrando eficientemente o comprimento
da substring mais longa sem caracteres repetidos

 */