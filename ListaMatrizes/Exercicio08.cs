using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios.ListaMatrizes
{
    internal class Exercicio08
    {
        public static void ordemInversa()
        {
            /*
             8) Ler uma matriz com 4x4 de inteiros e mostrar os números na
            ordem direta e inversa a que foram lidos.
             */
            int[,] matriz = new int[4, 4];

            Console.WriteLine("----------------------------------");
            Console.WriteLine("Matriz");
            Console.WriteLine("----------------------------------");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    //matriz[i, j] = new Random().Next(0, 50);
                    Console.Write("Informe um valor para M[" + i + "][" + j + "]:");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("----------------------------------");
            Console.WriteLine("ORDEM DIRETA");
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
            Console.WriteLine("ORDEM INVERSA");
            Console.WriteLine("----------------------------------");
            for (int i = matriz.GetLength(0) - 1; i >= 0; i--)
            {
                for (int j = matriz.GetLength(0) - 1; j >= 0; j--)
                {
                    Console.Write("[" + matriz[i, j] + "]");
                }
                Console.WriteLine();
            }
        }
    }
}
