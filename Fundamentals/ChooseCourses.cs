using System;
namespace Fundamentals
{
    public class ChooseCourses
    {
        public static void run()
        {

            int escolhaCurso;

            while (true)
            {
                Console.WriteLine("Escolha um curso:");
                Console.WriteLine("1. Programação em C#");
                Console.WriteLine("2. Desenvolvimento Web");
                Console.WriteLine("3. Design Gráfico");
                Console.WriteLine("4. Inglês Avançado");
                Console.WriteLine("5. Marketing Digital");

                if (int.TryParse(Console.ReadLine(), out escolhaCurso))
                {
                    switch (escolhaCurso)
                    {
                        case 1:
                            Console.WriteLine("Você escolheu o curso de Programação em C#.");
                            break;

                        case 2:
                            Console.WriteLine("Você escolheu o curso de Desenvolvimento Web.");
                            break;

                        case 3:
                            Console.WriteLine("Você escolheu o curso de Design Gráfico.");
                            break;

                        case 4:
                            Console.WriteLine("Você escolheu o curso de Inglês Avançado.");
                            break;

                        case 5:
                            Console.WriteLine("Você escolheu o curso de Marketing Digital.");
                            break;

                        default:
                            Console.WriteLine("Opção inválida. Por favor, escolha um curso válido.");
                            continue; // Volta ao início do loop para pedir a escolha novamente
                    }
                    break; 
                }
                else
                {
                    Console.WriteLine("Escolha inválida. Por favor, insira um número correspondente ao curso desejado.");
                }
            }
        }
    }
}

/*

DESAFIO 09:

Crie um algoritmo que dê um leque de opções de cursos para o usuário
escolher e qual turma ele poderá ingressar, usando o conceito
de "Switch-Case" na linguagem CSharp.
 
 */