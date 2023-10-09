using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Fundamentals
{
    public class ArraySum
    {
        public static void run()
        {

            int[] vectorA = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] vectorB = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] vectorC = new int[10];

            for (int i = 0, j = vectorB.Length - 1; i < vectorA.Length; i++, j--)
            {
                vectorC[i] = vectorA[i] + vectorB[j];
            }

            Console.WriteLine("Array A => " + printArray(vectorA) + "+");
            Console.WriteLine("Reverse of Array B => " + printArray(vectorB) + "=");
            Console.WriteLine("Array C => " + printArray(vectorC));
        }

        public static StringBuilder printArray(int[] array)
        {
            StringBuilder sb = new StringBuilder();

            foreach (int item in array)
            {
                sb.Append(item).Append(" ");
            }

            return sb;
        }

    }
}
/*
 
Exercício 01: 
Faça um algoritmo que construa dois vetores A e B de 10 elementos e,
a partir deles, crie um vetor C, composto pela somados elementos, sendo: 

C[1] = A[1] + B[9], C[2] = A[2] + B[9], C[3] = A[3] + B[8], etc.
 
 */