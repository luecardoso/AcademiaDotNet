using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios.ListaMatrizes
{
    internal class Exercicio16
    {
        public static void matrizTransposta()
        {
            /*
             * 16) Escreva um algoritmo para transpor uma matriz 3x4 para outra 
             * 4x3. Transpor uma matriz significa transformar suas linhas em 
             * colunas e vice-versa.
             */
            int[,] matriz = new int[3, 4];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = new Random().Next(0, 10);
                    //Console.Write("Informe um valor para M[" + i + "][" + j + "]:");
                    //matriz1[i, j] = int.Parse(Console.ReadLine());

                }
            }
            Console.WriteLine("MATRIZ");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("[" + matriz[i, j] + "]");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nMATRIZ TRANSPOSTA");
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    Console.Write("[" + matriz[i, j] + "]");
                }
                Console.WriteLine();
            }
        }
    }
}
