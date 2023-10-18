using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios.ListaMatrizes
{
    internal class Exercicio11
    {
        public static void divisaoMatriz()
        {
            /*
             * Leia uma matriz A de tipo double de dimenção 3x3, crie uma nova 
             * matriz resultante da divisão dos elementos da matriz A pela 
             * soma dos seus indices.
             */
            double[,] matrizA = new double[3, 3];
            double[,] matrizResultante = new double[3, 3];

            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    matrizA[i, j] = new Random().Next(0, 10);
                    //Console.Write("Informe um valor para M[" + i + "][" + j + "]:");
                    //matrizA[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("MATRIZ A");
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    Console.Write("[" + matrizA[i, j] + "]");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    if (i+j == 0)
                    {
                        matrizResultante[i, j] = 0;
                    }
                    else
                    {
                        matrizResultante[i, j] = matrizA[i, j] / (i + j);
                    }
                    
                }
            }
            Console.WriteLine("MATRIZ RESULTANTE");
            for (int i = 0; i < matrizResultante.GetLength(0); i++)
            {
                for (int j = 0; j < matrizResultante.GetLength(1); j++)
                {
                    Console.Write("[" + matrizResultante[i, j].ToString("F2") + "]");
                }
                Console.WriteLine();
            }

        }
    }
}
