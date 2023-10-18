using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios.ListaSequencial
{
    internal class Exercicio20
    {
        public static void adivinharNumero()
        {
            /*
                 Escreva um algoritmo para o jogo de adivinhação do número secreto. 
                O jogador tem 3 chances e recebe dicas do tipo “é maior” ou “é menor”. 
                plus: você pode gerar o número de forma randomica (função random c#).
             */

            int numeroSorteado = new Random().Next(0, 100);
            //Console.WriteLine("Número sorteado: " + numeroSorteado);

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("-------------*SORTEIO*--------------");
            Console.WriteLine("Adivinhe um número entre 0 e 100");
            Console.WriteLine("Você terá apenas 3 chances de vencer");

            Console.Write("1o Palpite : ");
            int palpite = int.Parse(Console.ReadLine());

            if (palpite == numeroSorteado)
            {
                Console.WriteLine("Palpite = " + palpite);
                Console.WriteLine("Número sorteado: " + numeroSorteado);
                Console.WriteLine("PARABÉNS VOCÊ VENCEU!!!");
            }
            else
            {
                Console.WriteLine("Não era esse número, tente de novo.");
                Console.Write("2o Palpite : ");
                palpite = int.Parse(Console.ReadLine());

                if (palpite == numeroSorteado)
                {
                    Console.WriteLine("Palpite = " + palpite);
                    Console.WriteLine("Número sorteado: " + numeroSorteado);
                    Console.WriteLine("PARABÉNS VOCÊ VENCEU!!!");
                }
                else
                {
                    Console.Write("3o e ULTIMO Palpite : ");
                    palpite = int.Parse(Console.ReadLine());
                    if (palpite == numeroSorteado)
                    {
                        Console.WriteLine("Palpite = " + palpite);
                        Console.WriteLine("Número sorteado: " + numeroSorteado);
                        Console.WriteLine("PARABÉNS VOCÊ VENCEU!!!");
                    }
                    else
                    {
                        Console.WriteLine("----------------------------");
                        Console.WriteLine("-----NÃO FOI DESSA VEZ!-----");
                        Console.WriteLine("----------------------------");
                    }
                }
            }
            Console.WriteLine("--------------------------------------");

        }
    }
}
