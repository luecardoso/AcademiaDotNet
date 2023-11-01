namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2) Escreva um programa em C# e no Visual Studio para calcular
            //a média aritmética entre quatro números quaisquer.
            Console.WriteLine("----------------------------------");
            Console.WriteLine("--- MÉDIA ENTRE QUATRO VALORES ---");
            Console.WriteLine("----------------------------------");
            Console.Write("Digite o valor do 1o número: ");
            double numero1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor do 2o número: ");
            double numero2 = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor do 3o número: ");
            double numero3 = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor do 4o número: ");
            double numero4 = double.Parse(Console.ReadLine());

            double media = (numero1 + numero2 + numero3 + numero4) / 4;
            Console.WriteLine("A média entre " + numero1 + ", " + numero2 + ", " + numero3 + ", " + numero4 + " é = " + media);
            Console.WriteLine("----------------------------------");
        }
    }
}