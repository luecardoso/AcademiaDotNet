﻿namespace Exercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                15 - Faça um programa para uma loja de tintas. O programa deverá pedir o
                tamanho em metros quadrados da área a ser pintada. Considere que a cobertura 
                da tinta é de 1 litro para cada 3 metros quadrados e que a tinta é vendida em
                latas de 18 litros, que custam R$ 80,00. Informe ao usuário a quantidades de 
                latas de tinta a serem compradas e o preço total.
             */

            Console.WriteLine("--------------------------------------");
            Console.Write("Digite a area em m²: ");
            double areaPintada = double.Parse(Console.ReadLine());

            double litrosUsados = areaPintada / 3;
            int latas = 0;
            double valor = 0;

            if (litrosUsados > 18)
            {
                if (litrosUsados / 18 != 0)
                {
                    latas = (int)(litrosUsados / 18) + 1;
                }
            }
            else
            {
                latas++;
            }
            valor = latas * 80;
            Console.WriteLine("Qtd. de latas a comprar: " + latas);
            Console.WriteLine("Valor a pagar R$: " + valor);
            Console.WriteLine("--------------------------------------");
        }
    }
}