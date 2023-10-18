using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios.ListaSequencial
{
    internal class Exercicio03
    {
        public static void media()
        {

            //3 - Escrever um algoritmo para ler quatro valores inteiros, calcular a
            //sua média, e escrever na tela os que são superiores à média.

            Console.WriteLine("-----------------------------");
            Console.WriteLine("Média entre quatro valores");
            Console.Write("Digite o 1o valor: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o 2o valor:  ");
            int numero2 = int.Parse(Console.ReadLine());

            Console.Write("Digite o 3o valor: ");
            int numero3 = int.Parse(Console.ReadLine());

            Console.Write("Digite o 4o valor: ");
            int numero4 = int.Parse(Console.ReadLine());

            double media = (numero1 + numero2 + numero3 + numero4) / 4;
            Console.WriteLine("A média entre " + numero1 + ", " + numero2 + ", " + numero3 + ", " + numero4 + " é = " + media);

            Console.WriteLine("Maiores que a média ");
            if (numero1 > media)
            {
                Console.WriteLine(numero1);
            }
            if (numero2 > media)
            {
                Console.WriteLine(numero2);
            }
            if (numero3 > media)
            {
                Console.WriteLine(numero3);
            }
            if (numero4 > media)
            {
                Console.WriteLine(numero4);
            }
            Console.WriteLine("-----------------------------");
        }
    }
}
