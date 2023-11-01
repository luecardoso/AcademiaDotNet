namespace Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Na teoria dos Sistemas, define-se como elemento minimax de uma matriz,
             * o menor elemento da linha em que se encontra o maior elemento da matriz. 
             * Escreva um programa que lê uma matriz [10 X 10] e em uma função encontre
             * e mostre o elemento minimax e sua posição na matriz.
             */
            int[,] matriz = new int[4, 4];
            lerMatriz(matriz);
            imprimirMatriz(matriz);
            minimax(matriz);
        }

        static void lerMatriz(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("M[" + i + "][" + j + "]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                    //matriz[i,j] = new Random().Next(0, 3);
                }
            }
        }

        static void imprimirMatriz(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("[" + matriz[i, j] + "]");
                }

                Console.WriteLine();
            }
        }

        static void minimax(int[,] matriz)
        {
            int maiorElemento = matriz[0, 0];
            int linhaMaior = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j] > maiorElemento)
                    {
                        maiorElemento = matriz[i, j];
                        linhaMaior = i;
                    }
                }
            }

            int menorElemento = matriz[linhaMaior, 0];
            int colunaMenor = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[linhaMaior, j] < menorElemento)
                    {
                        menorElemento = matriz[linhaMaior, j];
                        colunaMenor = j;
                    }
                }
            }

            Console.WriteLine("O maior elemento é " + maiorElemento + " que se encontra " +
                "na linha " + linhaMaior + " e que possui o menor elemento = " +
                "" + menorElemento + " na coluna = " + colunaMenor);
        }
    }
}