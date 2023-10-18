using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios.ListaMatrizes
{
    internal class Exercicio03
    {
        public static void populandoMatriz()
        {
            //3) Popule uma matriz 4x4 e mostre os elementos da Diagonal Principal!
            int[,] matriz = new int[4, 4];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = new Random().Next(0, 50);
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
            Console.WriteLine("Diagonal Principal");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Console.Write("[" + matriz[i, j] + "]");
                    }
                    else
                    {
                        Console.Write("[00]");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
