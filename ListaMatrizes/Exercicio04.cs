using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios.ListaMatrizes
{
    internal class Exercicio04
    {
        public static void informacoesMatriz()
        {
            /*
                Popule uma matriz 5x5 e informe:
                -Quantos números são pares
                - Quantos números são impares
                - Quantos números são positivos
                - Quantos números são negativos
                - Quantos zeros existem!
            */
            int[,] matriz = new int[5, 5];
            int pares = 0, impares = 0, positivos = 0, negativos = 0, zeros = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = new Random().Next(-50, 50);
                    //matriz[0, 0] = 0;
                    //matriz[1, 1] = 0;
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
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j] % 2 == 0)
                    {
                        pares++;
                    }
                    else
                    {
                        impares++;
                    }

                    if (matriz[i, j] > 0)
                    {
                        positivos++;
                    }
                    else if (matriz[i, j] < 0)
                    {
                        negativos++;
                    }
                    else
                    {
                        zeros++;
                    }
                }
            }
            Console.WriteLine("Números pares: " + pares);
            Console.WriteLine("Números impares: " + impares);
            Console.WriteLine("Números positivos: " + positivos);
            Console.WriteLine("Números negativos: " + negativos);
            Console.WriteLine("Números zeros: " + zeros);
        }
    }
}
