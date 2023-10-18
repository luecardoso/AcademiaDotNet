using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios.ListaVetores
{
    internal class Exercicio01
    {
        public static void parImpar()
        {
            /*
             * 1.	Escreva um algoritmo que leia os valores para um vetor de 
             * 10 elementos e então mostre na tela a quantidade de números 
             * pares e ímpares.
             */
            double[] vetor = new double[10];
            int pares = 0, impares = 0;

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write("Digite o " + (i + 1) + " número: ");
                double valor = double.Parse(Console.ReadLine());

                if (valor % 2 == 0)
                {
                    pares++;
                }
                else
                {
                    impares++;
                }
            }
            Console.WriteLine("----- QUANTIDADE DE NÚMEROS -----");
            Console.WriteLine("Pares: " + pares);
            Console.WriteLine("Impares: " + impares);
            Console.WriteLine("---------------------------------");
        }
    }
}
