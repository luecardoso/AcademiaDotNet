using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios.ListaVetores
{
    internal class Exercicio11
    {
        public static void ordemInversa()
        {
            /*
             * 11.	Escreva um programa que leia valores em um vetor de 5 posições. 
             * Escrever os elementos do vetor e após escrever os elementos na ordem inversa.
             */
            double[] vetor = new double[5];
            Console.WriteLine("---------------------------------");
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write("Digite o " + (i + 1) + " número: ");
                vetor[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("---------------------------------");
            Console.WriteLine("------- VETOR AO CONTRÁRIO ------");

            for (int i = vetor.Length - 1; i > 0; i--)
            {
                Console.WriteLine("V[" + i + "] = " + vetor[i]); ;
            }
            Console.WriteLine("---------------------------------");
        }
    }
}
