using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios.ListaMatrizes
{
    internal class Exercicio07
    {
        public static void subtracaoMatriz()
        {
            /*
             7) Leia duas matrizes A e B com 3x3 elementos. Construir uma 
            matriz C, onde cada elemento de C é a subtração do elemento 
            correspondente de A com B.
             */
            int[,] matrizA = new int[3, 3];
            int[,] matrizB = new int[3, 3];
            int[,] matrizC = new int[3, 3];
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Matriz A");
            Console.WriteLine("----------------------------------");
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    matrizA[i, j] = new Random().Next(0, 50);
                }
            }
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    Console.Write("[" + matrizA[i, j] + "]");
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Matriz B");
            Console.WriteLine("----------------------------------");

            for (int i = 0; i < matrizB.GetLength(0); i++)
            {
                for (int j = 0; j < matrizB.GetLength(1); j++)
                {
                    matrizB[i, j] = new Random().Next(0, 50);
                }
            }
            for (int i = 0; i < matrizB.GetLength(0); i++)
            {
                for (int j = 0; j < matrizB.GetLength(1); j++)
                {
                    Console.Write("[" + matrizB[i, j] + "]");
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Matriz C");
            Console.WriteLine("----------------------------------");
            for (int i = 0; i < matrizC.GetLength(0); i++)
            {
                for (int j = 0; j < matrizC.GetLength(1); j++)
                {
                    matrizC[i, j] = matrizA[i, j] - matrizB[i, j];
                }
            }
            for (int i = 0; i < matrizC.GetLength(0); i++)
            {
                for (int j = 0; j < matrizC.GetLength(1); j++)
                {
                    Console.Write("[" + matrizC[i, j] + "]");
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------------------------------");
        }
    }
}
