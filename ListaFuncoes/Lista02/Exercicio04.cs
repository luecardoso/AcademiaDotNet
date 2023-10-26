using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios.ListaFuncoes.Lista02
{
    internal class Exercicio04
    {
        public static void principal()
        {
            /*
             * Escreva uma função chamada MultiplicarMatrizes que recebe duas 
             * matrizes como parâmetros e retorna a matriz resultante da multiplicação.
             */
            int[,] matriz1 = new int[3, 3];
            int[,] matriz2 = new int[3, 3];
            LerMatriz(matriz1);
            imprimirMatriz(matriz1);
            LerMatriz(matriz2);
            imprimirMatriz(matriz2);
            imprimirMatriz( multiplicarMatriz(matriz1,matriz2));

        }

        static int[,] multiplicarMatriz(int[,] matriz1, int[,] matriz2)
        {
            int[,] mat = new int[3, 3];
            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                for (int j = 0; j < matriz1.GetLength(1); j++)
                {
                    mat[i, j] = matriz1[i,j] * matriz2[i,j];
                }
            }
            //LerMatriz(mat);
            return mat;
        }

        static int[,] LerMatriz(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    //matriz[i, j] = int.Parse(Console.ReadLine());
                    matriz[i, j] = new Random().Next(0, 10);
                    //Console.Write("[" + matriz[i, j] + "]");
                }
            }
            return matriz;
        }

        static void imprimirMatriz(int[,] matriz)
        {
            Console.WriteLine("--------------------------------");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("[" + matriz[i, j] + "]");
                }
                Console.WriteLine("");
            }
        }

    }
}
