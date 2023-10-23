using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios.ListaFuncoes.Lista01
{
    internal class Exercicio04
    {
        public static void calculoFatorial()
        {
            /*
             * Escreva uma função que calcule o fatorial de um 
             * número inteiro positivo.
             */
            fatorial(digiteNumero());

        }

        static int digiteNumero()
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());
            return numero;
        }

        static void fatorial(int numero)
        {
            int fatorial = 1;
            for (int i = numero; i > 0; i--)
            {
                Console.Write(i + " * ");
                fatorial *= i;
            }
            Console.Write(" = " + fatorial);
        }
    }
}
