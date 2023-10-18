using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios.ListaSequencial
{
    internal class Exercicio18
    {
        public static void maiorNumero()
        {
            /*
                 18 - Escreva um algoritmo que leia 3 valores pelo teclado e então 
                informe qual o maior deles.
             */
            Console.WriteLine("--------------------------------------");
            Console.Write("Digite o 1o numero: ");
            double numero1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o 2o numero: ");
            double numero2 = double.Parse(Console.ReadLine());

            Console.Write("Digite o 3o numero: ");
            double numero3 = double.Parse(Console.ReadLine());

            double maior = 0;
            if (numero1 > numero2 && numero1 > numero3)
            {
                maior = numero1;
            }
            if (numero2 > numero1 && numero2 > numero3)
            {
                maior = numero2;
            }
            if (numero3 > numero2 && numero3 > numero1)
            {
                maior = numero3;
            }

            Console.Write("Maior numero digitado: " + maior);
            Console.WriteLine("--------------------------------------");
        }
    }
}
