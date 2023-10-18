using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios.ListaMatrizes
{
    internal class Exercicio15
    {
        public static void matrizResultant()
        {
            /*
             * 15) Escreva um programa em C# para ler os valores e somar duas 
             * matrizes 4 x 4. Mostrar a matriz resultante.
             */
            int[,] matriz1 = new int[4, 4];
            int[,] matriz2 = new int[4, 4];
            double[,] matrizSoma = new double[4, 4];

            Console.WriteLine("1a MATRIZ ");
            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                for (int j = 0; j < matriz1.GetLength(1); j++)
                {
                    matriz1[i, j] = new Random().Next(0, 10);
                    //Console.Write("Informe um valor para M[" + i + "][" + j + "]:");
                    //matriz1[i, j] = int.Parse(Console.ReadLine());

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
                    matriz2[i, j] = new Random().Next(0, 10);
                    //Console.Write("Informe um valor para M[" + i + "][" + j + "]:");
                    //matriz2[i, j] = int.Parse(Console.ReadLine());

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
                    if (matrizSoma[i, j] < 10)
                    {
                        Console.Write("[0" + matrizSoma[i, j] + "]");
                    }
                    else
                    {
                        Console.Write("[" + matrizSoma[i, j] + "]");
                    }

                }
                Console.WriteLine();
            }
        }
    }
}
