using System;
using System.Text;

namespace Fundamentals
{
    public class SwimmerCategorization
    {

        public static void run()
        {
            int swimmersAge = Receive.Int("Informe a idade do nadador: ");
            StringBuilder category = new StringBuilder();

            if (swimmersAge <= 0)
            {
                Console.WriteLine("É impossível ter idade menor que zero.");
            }
            else if (swimmersAge >= 5 && swimmersAge <= 7)
            {
                category.Append("Infantil A");
                printCategory(category);
            }
            else if (swimmersAge >= 8 && swimmersAge <= 1)
            {
                category.Append("Infantil B");
                printCategory(category);
            }
            else if (swimmersAge >= 12 && swimmersAge <= 13)
            {
                category.Append("Juvenil A");
                printCategory(category);
            }
            else if (swimmersAge >= 14 && swimmersAge <= 17)
            {
                category.Append("Juvenil B");
                printCategory(category);
            }
            else if (swimmersAge >= 18)
            {
                category.Append("Adulto");
                printCategory(category);
            }
            else
            {
                Console.WriteLine("Não existe categoria para essa idade.");
            }
        }

        private static void printCategory(StringBuilder category)
        {
            Console.WriteLine($"\nClassificação: {category}");
        }
    }
}

/*


DESAFIO 06:

Elabore um algoritmo que dada a idade de um nadador, classifique-o em uma das 
seguintes categorias:
Infantil A = 5 a 7 anos.
Infantil B = 8 a 11 anos.
Juvenil A = 12 a 13 anos.
Juvenil B = 14 a 17 anos.
Adultos = Maiores de 18 anos.
Apresentar as mensagens no console com a classificação.
 
 */