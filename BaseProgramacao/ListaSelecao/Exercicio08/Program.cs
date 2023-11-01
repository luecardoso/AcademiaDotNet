namespace Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
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