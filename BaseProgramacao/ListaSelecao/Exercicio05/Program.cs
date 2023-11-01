namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5) Escreva um programa em C# e no Visual Studio para calcular o consumo médio de um automóvel (medido em Km/l),
            //sendo que são conhecidos a distância total percorrida e o volume de combustível consumido para percorrê-la (medido em l).
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("-------Consumo Médio de um Automóvel-------");
            Console.WriteLine("-------------------------------------------");
            Console.Write("Digite a distância percorrida: ");
            double kilometros = double.Parse(Console.ReadLine());

            Console.Write("Digite o total de litros consumidos: ");
            double litros = double.Parse(Console.ReadLine());

            double consumoMedio = kilometros / litros;

            Console.WriteLine("O valor do consumo médio em Km/L = " + consumoMedio);
            Console.WriteLine("-------------------------------------------");
        }
    }
}