using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios.ListaFuncoes.Lista02
{
    internal class Exercicio03
    {
        public static void principal()
        {
            /*
             * Escreva uma função chamada TransporMatriz que recebe uma matriz 
             * como parâmetro e retorna a matriz transposta.
             */
            int[,] m = new int[4,5];
            Console.WriteLine("Matriz Principal");
            LerMatriz(m);
            Console.WriteLine("Matriz Transposta");
            TransporMatriz(m);
        }

        static int[,] TransporMatriz(int[,] matriz)
        {

            int[,] matrizTransposta = new int[matriz.GetLength(1), matriz.GetLength(0)];
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    matrizTransposta[i,j] = matriz[i, j];
                }
                Console.WriteLine("");
            }
            imprimirMatriz(matrizTransposta);
            return matrizTransposta;
        }

        static int[,] LerMatriz(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    //matriz[i, j] = int.Parse(Console.ReadLine());
                    matriz[i, j] = new Random().Next(0,30);
                    Console.Write("[" + matriz[i, j] + "]");
                }
                Console.WriteLine("");
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
