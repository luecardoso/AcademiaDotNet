namespace Exercicio16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            * 16.	Escreva um algoritmo que leia 2 vetores X[10] e Y[10] e os 
            * escreva. Crie, a seguir, um vetor para cada uma das operações:
            * •	A união de X com Y (UNIÃO: todos os elementos de X, e todos 
            * os elementos de Y que não estão em X.)
            * •	A diferença entre X e Y (DIFERENÇA:  todos os elementos de 
            * X que não existem em Y)
            * •	A interseção entre X e Y (INTERSECÇÃO: Apenas os elementos
            * que aparecem nos 2 vetores)
            * Escreva o vetor resultado de cada uma das operações.
            */

            /*REALIZADO PELO PROFESSOR FABRICIO*/
            int[] x = new int[4] { 0, 1, 2, 3 };
            int[] y = new int[4] { 3, 4, 5, 2 };

            int[] uniao = new int[8];
            int[] diferenca = new int[4];
            int[] interseccao = new int[4];

            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine("X[" + i + "] = " + x[i]);
            }

            Console.WriteLine();

            for (int i = 0; i < y.Length; i++)
            {
                Console.WriteLine("Y[" + i + "] = " + y[i]);
            }

            Console.WriteLine();

            //UNIÃO 
            x.CopyTo(uniao, 0);

            int aux = 4;

            for (int i = 0; i < y.Length; i++)
            {
                for (int j = 0; j < x.Length; j++)
                {
                    if (y[i] == x[j])
                    {
                        break;
                    }

                    if (j == x.Length - 1)
                    {
                        uniao[aux] = y[i];
                        aux++;
                    }
                }
            }

            for (int i = 0; i < aux; i++)
            {
                Console.WriteLine("união[" + i + "] = " + uniao[i]);
            }

            //DIFERENÇA
            Console.WriteLine();

            int aux2 = 0;

            for (int i = 0; i < x.Length; i++)
            {
                for (int j = 0; j < y.Length; j++)
                {
                    if (x[i] == y[j])
                    {
                        break;
                    }

                    if (j == y.Length - 1)
                    {
                        diferenca[aux2] = x[i];
                        aux2++;
                    }
                }
            }

            for (int i = 0; i < aux2; i++)
            {
                Console.WriteLine("Diferença[" + i + "] = " + diferenca[i]);
            }

            Console.WriteLine();


            //INTERSECÇÃO

            int aux3 = 0;

            for (int i = 0; i < x.Length; i++)
            {
                for (int j = 0; j < y.Length; j++)
                {
                    if (x[i] == y[j])
                    {
                        interseccao[aux3] = x[i];
                        aux3++;
                        break;
                    }
                }
            }

            for (int i = 0; i < aux3; i++)
            {
                Console.WriteLine("Intersecção[" + i + "] = " + interseccao[i]);
            }

        }
    }
}