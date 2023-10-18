using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios.ListaMatrizes
{
    internal class Exercicio10
    {
        public static void mediaMatriz()
        {
            /*
                10) Leia duas matrizes A e B de 4x4 elementos, calcule a 
                média dos mesmos, em seguida, diga quantos dos elementos lidos 
                estão abaixo, acima e na média.
             */
            int[,] matrizA = new int[4, 4];
            int[,] matrizB = new int[4, 4];
            int media = 0, soma = 0, acimaMedia = 0, abaixoMedia = 0, naMedia = 0;

            Console.WriteLine("----------------------------------");
            Console.WriteLine("Matriz A");
            Console.WriteLine("----------------------------------");
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    matrizA[i, j] = new Random().Next(0, 10);
                    //Console.Write("Informe um valor para M[" + i + "][" + j + "]:");
                    //matrizA[i, j] = int.Parse(Console.ReadLine());
                    soma += matrizA[i, j];
                }
            }
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    Console.Write("[" + matrizA[i, j] + "]");
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Matriz B");
            Console.WriteLine("----------------------------------");
            for (int i = 0; i < matrizB.GetLength(0); i++)
            {
                for (int j = 0; j < matrizB.GetLength(1); j++)
                {
                    matrizB[i, j] = new Random().Next(0, 10);
                    //Console.Write("Informe um valor para M[" + i + "][" + j + "]:");
                    //matrizB[i, j] = int.Parse(Console.ReadLine());
                    soma += matrizB[i, j];
                }
            }
            for (int i = 0; i < matrizB.GetLength(0); i++)
            {
                for (int j = 0; j < matrizB.GetLength(1); j++)
                {
                    Console.Write("[" + matrizB[i, j] + "]");
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------------------------------");
            media = soma / (matrizA.GetLength(0) * matrizB.GetLength(0));

            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    if (matrizA[i, j] > media)
                    {
                        acimaMedia++;
                    }
                    else if (matrizA[i, j] < media)
                    {
                        abaixoMedia++;
                    }
                    else
                    {
                        naMedia++;
                    }
                }
            }
            for (int i = 0; i < matrizB.GetLength(0); i++)
            {
                for (int j = 0; j < matrizB.GetLength(1); j++)
                {
                    if (matrizB[i, j] > media)
                    {
                        acimaMedia++;
                    }
                    else if (matrizB[i, j] < media)
                    {
                        abaixoMedia++;
                    }
                    else
                    {
                        naMedia++;
                    }
                }
            }

            Console.WriteLine("Soma: " + soma);
            Console.WriteLine("Média: " + media);
            Console.WriteLine("Abaixo da média: " + abaixoMedia);
            Console.WriteLine("Acima da média: " + acimaMedia);
            Console.WriteLine("Na média: " + naMedia);
        }
    }
}
