using System;
using System.Globalization;

namespace Fundamentals
{
    public class ReviewScores
    {

        private double score1, score2, score3;

        public double getScore1()
        {
            return score1;
        }
        public double getScore2()
        {
            return score1;
        }
        public double getScore3()
        {
            return score1;
        }

        public void setScore1(double score1)
        {
            this.score1 = score1;
        }

        public void setScore2(double score2)
        {
            this.score2 = score2;
        }

        public void setScore3(double score3)
        {
            this.score3 = score3;
        }
        public static void run()
        {
            ReviewScores grades = new ReviewScores();

            double score1, score2, score3;

            while (true)
            {
                Console.WriteLine("Informe a primeira nota: ");
                string input = Console.ReadLine();

                if (double.TryParse(input, NumberStyles.Any, CultureInfo.InvariantCulture, out score1) && score1 >= 0 && score1 <= 10)
                {
                    grades.setScore1(score1);
                    break; // Exit the loop if the input is valid
                }
                else
                {
                    Console.WriteLine("Nota inválida. Por favor, informe uma nota entre 0 e 10.");
                }
            }

            // Repeat the same process for the other two scores
            while (true)
            {
                Console.WriteLine("Informe a segunda nota: ");
                string input = Console.ReadLine();

                if (double.TryParse(input, NumberStyles.Any, CultureInfo.InvariantCulture, out score2) && score2 >= 0 && score2 <= 10)
                {
                    grades.setScore2(score2);
                    break;
                }
                else
                {
                    Console.WriteLine("Nota inválida. Por favor, informe uma nota entre 0 e 10.");
                }
            }

            while (true)
            {
                Console.WriteLine("Informe a terceira nota: ");
                string input = Console.ReadLine();

                if (double.TryParse(input, NumberStyles.Any, CultureInfo.InvariantCulture, out score3) && score3 >= 0 && score3 <= 10)
                {
                    grades.setScore3(score3);
                    break;
                }
                else
                {
                    Console.WriteLine("Nota inválida. Por favor, informe uma nota entre 0 e 10.");
                }
            }

            double average = (grades.getScore1() + grades.getScore2() + grades.getScore3()) / 3;

            if (average >= 7.0 && score1 >= 3.0 && score2 >= 3.0 && score3 >= 3.0)
            {
                Console.WriteLine("Aluno aprovado!");
            }
            else
            {
                Console.WriteLine("Aluno em exame final.");
                Console.WriteLine("Informe a nota do exame final: ");

                double examScore;

                while (true)
                {
                    string examInput = Console.ReadLine();

                    if (double.TryParse(examInput, NumberStyles.Any, CultureInfo.InvariantCulture, out examScore) && examScore >= 0 && examScore <= 10)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Nota inválida. Por favor, informe uma nota entre 0 e 10.");
                    }
                }

                double finalAverage = (average + examScore) / 2;

                if (finalAverage >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado no exame final!");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado no exame final.");
                }
            }
        }
    }
}
/*
 
 DESAFIO 08:

Um aluno realizou três provas de uma determinada disciplina. Levando em consideração o
critério apresentado a seguir, faça um programa que mostre se ele ficou para exame final,
e caso positivo, que nota o aluno precisará obter para passar de ano.

"Média = (Prova 1 + Prova 2 + Prova 3) / 3"

A média deve ser igual ou maior que 7,0. Caso o aluno não consiga, a nova média deve ser:

"Final = (Média + Exame) / 2"

A média final para a aprovação deve ser igual ou maior que 5,0.
 
 */