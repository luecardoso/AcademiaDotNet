using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios.ListaMatrizes
{
    internal class Exercicio17
    {
        public static void minimoMaximo()
        {
            /*
             * 17) Fazer um algoritmo que leia uma matriz de 10 linhas por 10 
             * colunas e escreva o elemento minimax, ou seja,o menor elemento 
             * da linha onde se encontra o maior elemento da matriz. Escreva 
             * também a linha e a coluna onde foi encontrado.
             */
            int[,] matriz = new int[10, 10];
            int minimo, maximo;

            int[] posicaoMinimo = new int[2], posicaoMaximo = new int[2];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = new Random().Next(0, 100);
                }
            }
            Console.WriteLine("----------------------------------");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("[" + matriz[i, j] + "]");
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------------------------------");
            minimo = matriz[0, 0];
            maximo = matriz[0, 0];
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j] < minimo)
                    {
                        minimo = matriz[i, j];
                        posicaoMinimo[0] = i;
                        posicaoMinimo[1] = j;
                    }
                    if (matriz[i, j] > maximo)
                    {
                        maximo = matriz[i, j];
                        posicaoMaximo[0] = i;
                        posicaoMaximo[1] = j;
                    }
                }

            }
            Console.WriteLine("Minimo: " + minimo + " Posicao: [" + posicaoMinimo[0] + "][" + posicaoMinimo[1] + "]");
            Console.WriteLine("Maximo: " + maximo + " Posicao: [" + posicaoMaximo[0] + "][" + posicaoMaximo[1] + "]");
        }
    }
}
