namespace Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                12) Escreva um programa que leia os valores de uma matriz 
                4x3, e em seguida mostre na tela apenas os valores cuja soma 
                dos índices (i+j) seja um número par.
             */
            int[,] matriz = new int[4, 4];
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = new Random().Next(0, 10);
                    //Console.Write("Informe um valor para M[" + i + "][" + j + "]:");
                    //matrizA[i, j] = int.Parse(Console.ReadLine());
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
            Console.WriteLine("----------------------------------");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        Console.Write("[" + matriz[i, j] + "]");
                    }
                    else
                    {
                        Console.Write("[ ]");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}