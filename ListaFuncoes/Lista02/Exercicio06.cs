using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios.ListaFuncoes.Lista02
{
    internal class Exercicio06
    {
        public static void principal()
        {
            /*
             * Escreva uma função chamada MediaColunaMatriz que recebe uma matriz e 
             * um número de coluna como parâmetros, e retorna a soma dos elementos
             * nessa coluna.
             */

            int[,] matriz = new int[3, 3];
            Console.Write("Escolha uma coluna para somar: (1,2,3");
            int coluna = int.Parse(Console.ReadLine());
            LerMatriz(matriz);
            imprimirMatriz(matriz);
            Console.WriteLine("A soma dos elementos da coluna "+coluna+" é = "
                +MediaColunaMatriz(matriz,coluna));
        }

        static int MediaColunaMatriz(int[,] matriz, int coluna)
        {
            int soma = 0;
            coluna--;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (j == coluna)
                    {
                        soma += matriz[i, j];
                    }
                }
            }

            return soma;
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
