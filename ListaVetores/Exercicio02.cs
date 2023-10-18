using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios.ListaVetores
{
    internal class Exercicio02
    {
        public static void somaElementos()
        {
            /*
             * 2.	Escreva um algoritmo que leia valores para dois vetores de 
             * 20 elementos e então realize a soma dos elementos da mesma 
             * posição, armazenando o resultado em um outro vetor.
             */
            double[] vetor1 = new double[20];
            double[] vetor2 = new double[20];
            Console.WriteLine("----------------------------------");
            Console.WriteLine("-- SOMA DE ELEMENTOS DE VETORES --");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("-----   PRIMEIRO VETOR   ---------");
            for (int i = 0; i < vetor1.Length; i++)
            {
                Console.Write("Digite o " + (i + 1) + " número: ");
                vetor1[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("---------------------------------");
            Console.WriteLine("-----   SEGUNDO VETOR   ---------");
            for (int i = 0; i < vetor2.Length; i++)
            {
                Console.Write("Digite o " + (i + 1) + " número: ");
                vetor2[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("---------------------------------");
            Console.WriteLine("------    NOVO VETOR    ---------");
            double[] vetor3 = new double[20];

            for (int i = 0; i < vetor3.Length; i++)
            {
                vetor3[i] = vetor1[i] + vetor2[i];
                Console.WriteLine("V[" + i + "] = " + vetor3[i]);
            }
        }
    }
}
