namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            * Escreva uma função que calcule o fatorial de um 
            * número inteiro positivo.
            */
            fatorial(digiteNumero());

        }

        static int digiteNumero()
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());
            return numero;
        }

        static void fatorial(int numero)
        {
            int fatorial = 1;
            for (int i = numero; i > 0; i--)
            {
                Console.Write(i + " * ");
                fatorial *= i;
            }
            Console.Write(" = " + fatorial);
        }
    }
}