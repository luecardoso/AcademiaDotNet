using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios.ListaFuncoes.Lista01
{
    internal class Exercicio05
    {
        public static void conversao()
        {
            /*
             * Desenvolva uma função que converta uma 
             * temperatura em graus Celsius para Fahrenheit.
             */
            conversaoFahrenheit(digiteNumero());
        }
        static double digiteNumero()
        {
            Console.Write("Digite a temperatura em °C: ");
            double numero = double.Parse(Console.ReadLine());
            return numero;
        }

        static void conversaoFahrenheit(double temperaturaCelcius)
        {
            double temperaturaFahrenheit = (9 * temperaturaCelcius + 160) / 5;
            Console.WriteLine("Temperatura em Fahrenheit: " + temperaturaFahrenheit);
        }
    }
}
