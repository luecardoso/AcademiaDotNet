namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               Solicite ao usuário, preencher uma Matriz 3x3
               Informe ao usuário:
               *A soma dos elementos de cada linha
               -Ex: Linha 1: 30
                Linha 2: 17
               *A soma dos elementos de cada coluna
               -Ex: Coluna 1: 23
                Coluna 2: 36
            */
            int[,] matriz = new int[3, 3];
            int somaLinha = 0, somaColuna = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("Informe um valor para M[" + i + "][" + j + "]:");
                    matriz[i, j] = int.Parse(Console.ReadLine());

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
                    somaLinha += matriz[i, j];
                }
                Console.WriteLine("Linha " + (i + 1) + " = " + somaLinha);
                somaLinha = 0;
            }
            for (int j = 0; j < matriz.GetLength(0); j++)
            {
                for (int i = 0; i < matriz.GetLength(1); i++)
                {
                    somaColuna += matriz[i, j];

                }
                Console.WriteLine("Coluna " + (j + 1) + " = " + somaColuna);
                somaColuna = 0;
            }



        }
    }
}