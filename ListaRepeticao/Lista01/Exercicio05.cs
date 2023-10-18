using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios.ListaRepeticao.Lista01
{
    internal class Exercicio05
    {
        public static void calcularFatorial()
        {
            //5. Escreva um algoritmo para calcular o fatorial de um número.
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());
            int fatorial = 1;

            for (int i = numero; i > 0; i--)
            {
                Console.Write(i + " * ");
                fatorial *= i;
            }
            Console.WriteLine("\n\n");
            Console.WriteLine("O fatorial de " + numero + " é = " + fatorial);
        }
    }
}
