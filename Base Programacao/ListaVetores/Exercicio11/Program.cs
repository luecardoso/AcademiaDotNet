﻿namespace Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
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