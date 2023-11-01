namespace Exercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            * Crie uma função chamada SomaDiagonalPrincipal que recebe uma matriz 
            * quadrada como parâmetro e retorna a soma dos elementos na diagonal
            * principal.
            */
            int[,] matriz = new int[3, 3];
            LerMatriz(matriz);
            imprimirMatriz(matriz);
            Console.WriteLine("A soma da diagonal principal é: " + SomaDiagonalPrincipal(matriz));
        }

        static int SomaDiagonalPrincipal(int[,] matriz)
        {
            int soma = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (i == j)
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