using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios.ListaRepeticao.Lista01
{
    internal class Exercicio03
    {
        public static void mostrarTabuada()
        {
            //3 Escreva um algoritmo que leia pelo teclado um valor e então calcule a tabuada de 1 a 10 de um número x lido
            // utilizando laços de repetição, e mostre na tela.

            Console.Write("Digite um número: ");
            double numero = double.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i + " * " + numero + " = " + i * numero);
            }



        }
    }
}
