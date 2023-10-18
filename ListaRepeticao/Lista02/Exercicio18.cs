using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios.ListaRepeticao.Lista02
{
    internal class Exercicio18
    {
        public static void potencia()
        {
            /*
            18. Elaborar um programa que apresente o valor de uma potência 
            de uma base qualquer elevada a um expoente qualquer, ou seja, NM.
             */

            Console.Write("Digite o valor da base: ");
            double n = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor da potencia: ");
            double m = double.Parse(Console.ReadLine());
            double elevado = 1;

            for (int i = 0; i < m; i++)
            {
                elevado *= n;
            }
            Console.WriteLine("Potencia de "+ n+" elevado a "+m+" = " + elevado);
        }
    }
}
