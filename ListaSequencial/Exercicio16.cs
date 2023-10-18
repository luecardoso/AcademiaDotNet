using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios.ListaSequencial
{
    internal class Exercicio16
    {
        public static void mostrarPlacar()
        {
            /*
                Escreva um algoritmo que leia o placar de um jogo da primeira fase 
                da copa do Brasil. Caso o time de fora tenha ganho o jogo por mais de
                2 gols de diferença, mostre na tela uma mensagem indicando que o time
                de fora já se classificou para a próxima fase. Caso contrário, mostre
                uma mensagem indicando que os dois times irão se enfrentar novamente 
                em um novo jogo.
                ex.: time da casa 4 x 3 time de fora, mostra "Os dois times se enfrentarão
                em um novo jogo"
                ex2: time da casa 1 x 3 time de fora, mostra "O time de fora já se classificou"
                obs.: caso ocorra um segundo jogo, leia o placar desse novo jogo e então diga 
                quem passou de fase.
             */
            Console.WriteLine("-----------------------------");
            Console.WriteLine("------* COPA DO BRASIL *-----");
            Console.WriteLine("---------* PLACAR *----------");
            Console.Write("Time de casa: ");
            int timeCasa = int.Parse(Console.ReadLine());
            Console.Write("Time de fora: ");
            int timeFora = int.Parse(Console.ReadLine());

            if (timeCasa - timeFora >= 2)
            {
                Console.WriteLine("O time de casa já se classificou!");
            }
            else if (timeFora - timeCasa >= 2)
            {
                Console.WriteLine("O time de fora já se classificou!");
            }
            else
            {
                Console.WriteLine("Os dois times se enfrentarão \nem um novo jogo.");
                Console.WriteLine("---------* PLACAR *----------");
                Console.Write("Time de casa: ");
                timeCasa = int.Parse(Console.ReadLine());
                Console.Write("Time de fora: ");
                timeFora = int.Parse(Console.ReadLine());

                if (timeCasa - timeFora >= 2)
                {
                    Console.WriteLine("O time de casa passou para a \npróxima fase!");
                }
                else if (timeFora - timeCasa >= 2)
                {
                    Console.WriteLine("O time de fora passou para a \npróxima fase!");
                }
                else
                {
                    Console.WriteLine("Empate!");
                }
            }
        }
    }
}
