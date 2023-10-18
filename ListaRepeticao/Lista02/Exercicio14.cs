using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios.ListaRepeticao.Lista02
{
    internal class Exercicio14
    {
        public static void potenciaDois()
        {

            //14. Mostrar as potências de 2 variando de 0 a 10.
            int potencia = 1, basePotencia = 2;
            for (int i = 0; i <= 10; i++)
            {
                if (i == 0)
                {
                    potencia = basePotencia / 2;
                }
                else
                {
                    potencia *= basePotencia;
                }
                
                Console.WriteLine("2 ^ " + i + " = " + potencia);
            }
        }
    }
}
