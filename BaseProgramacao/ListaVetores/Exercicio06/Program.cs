﻿namespace Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 6.	Fazer um algoritmo que leia dez números e escreva-os na 
             * ordem contrária à ordem de leitura. 
             * Exemplo:
             * a.	lê: 		|7|40|3|9|21|0|63|31|7|22|
             * b.	escreve: 	|22|7|31|63|0|21|9|3|40|7|
             */
            int[] vetor = new int[10];
            Console.WriteLine("---------------------------------");
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write("Digite o " + (i + 1) + " número: ");
                vetor[i] = int.Parse(Console.ReadLine());
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