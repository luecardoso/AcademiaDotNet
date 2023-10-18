using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios.ListaVetores
{
    internal class Exercicio07
    {
        public static void ordm()
        {
            /*
             * 7.	Fazer um algoritmo que leia dez números inteiros armazenando-os 
             * em um vetor e escreva primeiramente todos os números pares lidos e após 
             * todos os ímpares. Exemplo:
             * a.	lê: 		|7|40|3|9|21|0|63|31|7|22|
             * b.	escreve: 	|40|0|22|7|3|9|21|63|31|7|
             */
            int[] vetor = new int[10];
            Console.WriteLine("---------------------------------");
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write("Digite o " + (i + 1) + " número: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("---------------------------------");
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] % 2 == 0)
                {
                    Console.Write("|" + vetor[i] + "");
                }
            }
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] % 2 != 0)
                {
                    Console.Write("|" + vetor[i] + "");
                }
            }
        }
    }
}
