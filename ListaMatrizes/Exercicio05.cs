using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios.ListaMatrizes
{
    internal class Exercicio05
    {
        public static void somaMatrizes()
        {
            //5) Leia duas matrizes 2x3 de números double. 
            //Imprima a soma destas duas matrizes.
            double[,] matriz1 = new double[2, 3];
            double[,] matriz2 = new double[2, 3];
            double[,] matrizSoma = new double[2, 3];

            Console.WriteLine("1a MATRIZ ");
            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                for (int j = 0; j < matriz1.GetLength(1); j++)
                {
                    Console.Write("Informe um valor para M[" + i + "][" + j + "]:");
                    matriz1[i, j] = double.Parse(Console.ReadLine());

                }
            }
            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                for (int j = 0; j < matriz1.GetLength(1); j++)
                {
                    Console.Write("[" + matriz1[i, j] + "]");
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------------------------------");
            Console.WriteLine("2a MATRIZ ");
            for (int i = 0; i < matriz2.GetLength(0); i++)
            {
                for (int j = 0; j < matriz2.GetLength(1); j++)
                {
                    Console.Write("Informe um valor para M[" + i + "][" + j + "]:");
                    matriz2[i, j] = double.Parse(Console.ReadLine());

                }
            }
            for (int i = 0; i < matriz2.GetLength(0); i++)
            {
                for (int j = 0; j < matriz2.GetLength(1); j++)
                {
                    Console.Write("[" + matriz2[i, j] + "]");
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------------------------------");
            Console.WriteLine("SOMA DAS MATRIZES 1 E 2");
            for (int i = 0; i < matriz2.GetLength(0); i++)
            {
                for (int j = 0; j < matriz2.GetLength(1); j++)
                {
                    matrizSoma[i, j] = matriz1[i, j] + matriz2[i, j];
                    Console.Write("[" + matrizSoma[i, j].ToString("F1") + "]");
                }
                Console.WriteLine();
            }
        }
    }
}
