using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios.ListaRepeticao.Lista02
{
    internal class Exercicio12
    {
        public static void somaNumeros()
        {
            //12 - Apresentar o total da soma dos cem primeiros números inteiros.
            int soma = 0;
            for (int i = 0; i <= 100; i++)
            {
                soma += i;
            }
            Console.WriteLine("Soma = "+soma);
        }
    }
}
