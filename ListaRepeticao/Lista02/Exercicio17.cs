using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios.ListaRepeticao.Lista02
{
    internal class Exercicio17
    {
        public static void quadrados()
        {
            //17. Apresentar os quadrados dos números inteiros de 15 a 200.

            for (int i = 15; i<=200; i++)
            {
                Console.WriteLine(i+"^2 = "+(i*i));
            }
        }
    }
}
