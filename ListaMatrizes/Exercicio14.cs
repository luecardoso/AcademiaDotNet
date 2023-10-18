using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios.ListaMatrizes
{
    internal class Exercicio14
    {
        public static void mesmosElementos()
        {
            /*
                14) Escreva um programa que leia uma matriz de ordem 5 e verifique 
                se os elementos da diagonal principal (da esquerda para a direita) são os 
                mesmos da diagonal secundária (direita pra esquerda).
             */
            int[,] matriz = new int[5, 5];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = new Random().Next(0, 10);
                }
            }

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("[" + matriz[i, j] + "]");
                }
                Console.WriteLine();
            }

            int numeroDiagonalPrincipal = 0, numeroDiagonalSecundaria = 0;
            int[] vetor = new int[5];
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        numeroDiagonalPrincipal = matriz[i, j];
                    }
                    if (i + j == matriz.GetLength(0) - 1)
                    {
                        numeroDiagonalSecundaria = matriz[i, j];
                    }
                    if (numeroDiagonalPrincipal == numeroDiagonalSecundaria)
                    {
                        vetor[i] = numeroDiagonalPrincipal;
                    }
                }
            }
            Console.WriteLine("----- números iguais");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.WriteLine(vetor[i]);
            }
        }
    }
}
