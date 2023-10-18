using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios.ListaVetores
{
    internal class Exercicio04
    {
        public static void multiplicacao()
        {
            /*
             * 4.	Escreva um algoritmo que leia dois vetores de 10 posições e 
             * faça a multiplicação dos elementos de mesmo índice, colocando o 
             * resultado em um terceiro vetor. Mostre o vetor resultante.
             */
            double[] vetor1 = new double[5];
            double[] vetor2 = new double[5];
            double[] vetor3 = new double[5];
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
            Console.WriteLine("-- RESULTADO DA MULTIPLICAÇÃO ---");
            for (int i = 0; i < vetor3.Length; i++)
            {
                vetor3[i] = vetor1[i] * +vetor2[i];
                Console.WriteLine("V[" + i + "] = " + vetor3[i]);
            }
        }
    }
}
