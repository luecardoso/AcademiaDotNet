namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1) Escreva um programa em C# e no Visual Studio para calcular
            //a média aritmética entre dois números quaisquer.
            Console.WriteLine("--------------------------------");
            Console.WriteLine("--- MÉDIA ENTRE DOIS VALORES ---");
            Console.WriteLine("--------------------------------");
            Console.Write("Digite o valor do 1o número: ");
            double numero1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor do 2o número: ");
            double numero2 = double.Parse(Console.ReadLine());

            double media = (numero1 + numero2) / 2;
            Console.WriteLine("A média entre " + numero1 + " e " + numero2 + " é = " + media);
            Console.WriteLine("--------------------------------");
        }
    }
}