using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios.ListaVetores
{
    internal class Exercicio09
    {
        public static void vetor()
        {
            /*
             * 9.	Escreva um algoritmo que leia os valores para um vetor 
             * de 10 elementos, e em seguida ordene em ordem crescente os 
             * valores desse vetor, utilizando um vetor auxiliar.
             */
            int[] vetor = new int[10];
            int aux = 0;

            for (int i = 0; i < vetor.Length; i++)
            {
                //Console.Write("Digite o " + (i + 1) + " número: ");
                //vetor[i] = int.Parse(Console.ReadLine());
                vetor[i] = new Random().Next(0, 50);
            }
            Console.WriteLine("VETOR ANTES");
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write(vetor[i] + " |");
            }
            for (int i = 0; i < vetor.Length; i++)
            {
                for (int j = 0; j < (vetor.Length - 1); j++)
                {
                    if (vetor[j + 1] < vetor[j])
                    {
                        aux = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j + 1] = aux;
                    }
                }
            }
            Console.WriteLine("\nVETOR DEPOIS");
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write(vetor[i] + " |");
            }
        }
    }
}
