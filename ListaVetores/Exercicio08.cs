using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios.ListaVetores
{
    internal class Exercicio08
    {
        public static void menorQueZero()
        {
            /*
             * 8.	Fazer um algoritmo que leia trinta números reais armazenando-os 
             * em um vetor e após escreva a posição de cada número menor que zero 
             * desse vetor. Exemplo:
             * a.	lê: |5.1|0|-3.6|4.1|-2.5|-1.3|-4|1.39|-128|-6.9|8.2|9|154|-88|6.4|7.1|...|
             * b.	escreve: 	|3|5|6|7|9|10|14|. . .
             */
            double[] vetor = new double[30];
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write("Digite o " + (i + 1) + " número: ");
                vetor[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] < 0)
                {
                    Console.Write("|" + i + " = " + vetor[i]);
                }
            }
        }
    }
}
