using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios.ListaRepeticao.Lista02
{
    internal class Exercicio13
    {
        public static void somaPares()
        {
            //13. Elaborar um programa que apresente o somatório dos
            //valores pares existentes entre 1 e 500.
            int soma = 0;
            for (int i = 1; i <= 500; i++)
            {
                if (i % 2 == 0)
                {
                    soma += i;
                }
            }
            Console.WriteLine("Soma = " + soma);
        }
    }
}
