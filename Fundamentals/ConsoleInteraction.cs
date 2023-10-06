using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Fundamentals
{
    public class ConsoleInteraction
    {
        public static void Strings()
        {

            // command + / to comment
            string string1 = "Ana ";
            string string2 = "Carolina";

            // different methods to concatenate
            string concatenateStringSimple = string1+string2;
            string concatenateStringInterpolation = $"{string1}{string2}";
            string concat = string.Concat(string1, string2);

            Console.WriteLine($"concatenateStringSimple: {concatenateStringSimple}");
            Console.WriteLine($"concatenateStringInterpolation: {concatenateStringInterpolation}");
            Console.WriteLine($"string.Concat(str1, str2): {concat}");

            string firstName = concat.Replace("Carolina", "");
            Console.WriteLine($"replace Carolina with nothing: {firstName}");

            // best way https://dev.to/this-is-learning/performance-benchmarking-string-and-string-builder-3bid#:~:text=StringBuilder%20executes%20significantly%20faster%20than,should%20consider%20the%20StringBuilder%20class.
            StringBuilder sb = new StringBuilder();
            sb.Append(string1).Append(string2);
            Console.WriteLine($"StringBuilder: {sb}");

            //.ToString() is only needed when you are creating a string variable
            //string str = sb; //wrong
            //string str = sb.ToString(); //correct

            string texto = " exemplo de texto ";

            //string methods
            Console.WriteLine($"\n{texto}");
            Console.WriteLine($"Tamanho: {texto.Length}");
            Console.WriteLine($"Sem espaços : {texto.Trim()}");
            texto = texto.Trim();

            Console.WriteLine($"Substring: {texto.Substring(0,7)}");
            Console.WriteLine($"Maiúsculas: {texto.ToUpper()}");
            Console.WriteLine($"First letter: {char.ToUpper(texto[0]) + texto.Substring(1)}");

            Console.WriteLine("\nDigite sim ou não: ");
            string input = Console.ReadLine().ToLower();
            string pattern = @"^não|nao"; //não no início da frase
            bool isMatch = Regex.IsMatch(input, pattern);
            
            if(isMatch)
            {
                Console.WriteLine("A string corresponde ao padrão");
            } else
            {
                Console.WriteLine("A string não corresponde ao padrão");
            }

            /*Telefone:

            Charles Serafim21:21
            Com o 9 seria assim?
            string pattern = @"\(\d{2}\) 9\d{4}-\d{4}";

            Thauã Lucas21:22
            isso, mas geralmente não é obrigatório ter o 9, então a gnt coloca de 4 a 5 digitos

            Charles Serafim21:22
            Tem como colocar um intervalo de valores que nem ce falou aí? Dentro ali do \d{}

            Thauã Lucas21:23
            sim, voce coloca as quantidades minimas e máximas separadas por vírgula
            tipo \d{4,5}*/

            //ternários

            int numero = 5;
            string resultado = (numero % 2 == 0) ? "Par" : "Ímpar";

            string resultado2 = numero > 0 ?
                "Maior que Zero" : numero < 0 ?
                "Menor que Zero" : "Zero";
        }
    }
}

