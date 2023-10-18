using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios.ListaSelecao
{
    internal class Exercicio08
    {
        public static void conversorDeTemperatura()
        {
            //8) Ler uma temperatura em graus Celsius e apresentá-la convertida em graus
            //Fahrenheit. A fórmula da conversão é F = (9 * C + 160) / 5.

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("-------Conversão de Temperatura-------");
            Console.WriteLine("--------------------------------------");
            Console.Write("Temperatura em graus Celsius: ");
            double temperaturaCelcius = double.Parse(Console.ReadLine());

            double temperaturaFahrenheit = (9 * temperaturaCelcius + 160) / 5;

            Console.WriteLine("Temperatura em Fahrenheit: " + temperaturaFahrenheit);
            Console.WriteLine("--------------------------------------");
        }
    }
}
