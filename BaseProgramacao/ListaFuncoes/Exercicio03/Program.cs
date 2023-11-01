namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
           * Desenvolva uma função que calcule a média de três
           * números fornecidos como argumentos.
           */
            double x = 0, y = 0, z = 0;

            mensagem(media(x, y, z));
        }

        static double digiteNumero()
        {
            Console.Write("Digite um número: ");
            double numero = double.Parse(Console.ReadLine());
            return numero;
        }

        static double media(double a, double b, double c)
        {
            a = digiteNumero();
            b = digiteNumero();
            c = digiteNumero();
            double media = (a + b + c) / 3;
            return media;
        }

        static void mensagem(double valor)
        {
            Console.WriteLine("Média = " + valor);
        }
    }
}