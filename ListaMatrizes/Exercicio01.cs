using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios.ListaMatrizes
{
    internal class Exercicio01
    {
        public static void matriz()
        {
            /*
                Crie uma Matriz 5x3. Na primeira coluna, solicite que o usuário 
                preencha. A 2ª coluna, some 10 aos elementos da 1ª coluna. 
                Na 3º coluna, armazene o dobro dos elementos da 1ª coluna.
             */
            int[,] matriz = new int[5, 3];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        Console.Write("Informe um valor para M[" + i + "][" + j + "]:");
                        matriz[i, j] = int.Parse(Console.ReadLine());
                    }

                    if (j == 1)
                    {
                        matriz[i, j] = 10 + matriz[i, j - 1];
                    }

                    if (j == 2)
                    {
                        matriz[i, j] = 2 * matriz[i, j - 2];
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
        }
    }
}
