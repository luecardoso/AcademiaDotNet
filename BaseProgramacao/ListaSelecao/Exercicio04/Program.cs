namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4) Faça um programa em C# e no Visual Studio que receba a data na forma DDMMAAAA e imprima na forma AAAAMMDD
            //e AAMMDD. Note que o dia, o mês e o ano devem ser lidos em variáveis diferentes.
            Console.WriteLine("------------------------------------------");
            Console.Write("Insira uma data [DD/MM/AAAA]: ");

            DateOnly data = DateOnly.Parse(Console.ReadLine());

            Console.WriteLine("---------- TRANSFORMANDO A DATA ----------");
            Console.WriteLine("AAAAMMDD: " + data.Year + "/" + data.Month.ToString("D2") + "/" + data.Day.ToString("D2"));
            Console.WriteLine("AAMMDD: " + data.Year.ToString().Substring(2) + "/" + data.Month.ToString("D2") + "/" + data.Day.ToString("D2"));
            Console.WriteLine("------------------------------------------");
        }
    }
}