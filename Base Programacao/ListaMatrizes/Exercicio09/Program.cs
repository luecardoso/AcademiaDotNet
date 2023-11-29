namespace Exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*

               9) Leia uma matriz 3x3.  Em seguida, solicite um número qualquer 
               ao usuário e pesquise na matriz se o número existe.  Caso, seja 
               verdade imprima a mensagem:  “O número existe no vetor” , caso 
               contrário “Número inexistente”.
            */

            Console.WriteLine("----------------------------------");
            Console.WriteLine("Matriz");
            Console.WriteLine("----------------------------------");
            int[,] matriz = new int[3, 3];
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = new Random().Next(0, 50);
                    //Console.Write("Informe um valor para M[" + i + "][" + j + "]:");
                    //matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
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
            Console.Write("Pesquise um número");
            int busca = int.Parse(Console.ReadLine());

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (busca == matriz[i, j])
                    {
                        Console.WriteLine("O número exixte no vetor");
                    }

                    if (matriz[i, j] == matriz[matriz.GetLength(0) - 1, matriz.GetLength(1) - 1] && busca != matriz[i, j])
                    {
                        Console.WriteLine("Número inexistente");
                    }
                }
                Console.WriteLine();
            }




        }
    }
}