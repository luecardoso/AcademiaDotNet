using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios.ListaVetores
{
    internal class Exercicio05
    {
        public static void menorElemento()
        {
            /*
             * 5.	Escreva um algoritmo que leia um vetor de 80 elementos inteiros. 
             * Encontre e mostre o menor elemento e a sua posição.
             */
            int[] vetor = new int[7];
            int menor = 0, posicao = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write("Digite o " + (i + 1) + " número: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            menor = vetor[0];
            for (int i = 1; i < vetor.Length; i++)
            {
                if (vetor[i] < menor)
                {
                    menor = vetor[i];
                    posicao = i;
                }
            }

            Console.WriteLine("Menor valor: " + menor);
            Console.WriteLine("Posição: " + posicao);
        }
    }
}
