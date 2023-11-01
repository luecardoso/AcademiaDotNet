namespace Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                6) Gere e imprima uma matriz M 4x4 com valores aleatórios 
                entre 0-9. Após isso determine o maior número da matriz.
                Random random = new Random();
		        int randomNumber = random.Next(0, 100);
             */
            int[,] matriz = new int[4, 4];
            int maior = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = new Random().Next(0, 10);
                    if (matriz[i, j] > maior)
                    {
                        maior = matriz[i, j];
                    }
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
            Console.WriteLine("Maior número: " + maior);
        }
    }
}