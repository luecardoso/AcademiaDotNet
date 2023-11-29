namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
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