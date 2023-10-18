using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios.ListaSequencial
{
    internal class Exercicio02
    {
        public static void imparOuPar()
        {
            //2- Faça um algoritmo para ler um número e verificar se ele é par ou ímpar.
            Console.WriteLine("------------------------------------");
            Console.WriteLine("-----------IMPAR OU PAR ------------");
            Console.WriteLine("------------------------------------");
            Console.Write("Digite um número: ");
            double numero = double.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("É PAR!!!");
            }
            else
            {
                Console.WriteLine("É IMPAR!!!");
            }
            Console.WriteLine("------------------------------------");
        }
    }
}
