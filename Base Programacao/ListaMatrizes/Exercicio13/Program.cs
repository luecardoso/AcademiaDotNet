namespace Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               13) Escreva um programa que leia uma matriz de ordem 5 
               (ou seja, 5x5) e verifique se a soma dos elementos da diagonal 
               principal é igual a soma dos elementos da diagonal secundária.
            */
            int[,] matriz = new int[5, 5];
            int somaDiagonaPrincipal = 0, somaDiagonalSecundaria = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = new Random().Next(0, 10);
                    //Console.Write("Informe um valor para M[" + i + "][" + j + "]:");
                    //matrizA[i, j] = int.Parse(Console.ReadLine());
                    //if (i == j)
                    //{
                    //    matriz[i, j] = 1;
                    //}
                    //if (i + j == matriz.GetLength(0) - 1)
                    //{
                    //    matriz[i, j] = 1;
                    //}
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
                    if (i == j)
                    {
                        somaDiagonaPrincipal += matriz[i, j];
                    }
                    if (i + j == matriz.GetLength(0) - 1)
                    {
                        somaDiagonalSecundaria += matriz[i, j];
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("Soma da diagonal principal: " + somaDiagonaPrincipal);
            Console.WriteLine("Soma da diagonal secundaria: " + somaDiagonalSecundaria);
            if (somaDiagonaPrincipal == somaDiagonalSecundaria)
            {
                Console.WriteLine("A soma da diagona princial e diagonal secundária SÃO iguais!!");
            }
            else
            {
                Console.WriteLine("A soma da diagona princial e diagonal secundária NÃO são iguais!!");
            }
        }
    }
}