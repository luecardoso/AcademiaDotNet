﻿namespace Exercicio20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //13. Elaborar um programa que apresente o somatório dos
            //valores pares existentes entre 1 e 500.
            int soma = 0;
            for (int i = 1; i <= 500; i++)
            {
                if (i % 2 == 0)
                {
                    soma += i;
                }
            }
            Console.WriteLine("Soma = " + soma);

        }
    }
}