using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios.ListaFuncoes.Lista01
{
    internal class Exercicio08
    {
        public static void principal()
        {
            /*
             * Ler um número inteiro e passar por parâmetro para uma função
             * e retornar 0, se o número é par, ou 1, se o número é ímpar
             */

            Console.WriteLine(parOuImpar(digiteNumero()));
        }

        static int digiteNumero()
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());
            return numero;
        }

        static int parOuImpar(int num)
        {
            return num % 2 == 0 ? 0 : 1;

        }
    }
}
