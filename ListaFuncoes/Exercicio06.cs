using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios.ListaFuncoes
{
    internal class Exercicio06
    {
        public static void calculoMedia()
        {
            /*
             * Escreva uma função que calcule a média de um vetor de 10 números.
             */
            int[] vetor = new int[10]; ;
            lerVetor(vetor);
            imprimirVetor(vetor);
            media(vetor);
        }

        static void imprimirVetor(int[] v)
        {
            Console.WriteLine("");
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write(v[i] + "| ");
            }
        }

        static void lerVetor(int[] v)
        {
            Console.WriteLine("-----VETOR------");
            for (int i = 0; i < v.Length; i++)
            {
                v[i] = new Random().Next(1, 10);
            }
        }

        static void media(int[] v)
        {
            Console.WriteLine("");
            int soma = 0;
            for (int i = 0; i < v.Length; i++)
            {
                soma += v[i];
            }
            double media = soma / v.Length;

            Console.WriteLine("Média = " + media.ToString("F1"));
        }
    }
}
