using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_I.Extras
{
    internal class CampoMinado
    {
        public static void principal()
        {
            string[,] matriz = new string[5, 5];
            tabuleiro(matriz);
        }

        static void tabuleiro(string[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.WriteLine("-------------------------");
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("|  " + matriz[i,j]+" |");
                }
                Console.WriteLine("");
                if (i == matriz.GetLength(0) - 1)
                {
                    Console.WriteLine("-------------------------");
                }
            }
        }
    }
}
