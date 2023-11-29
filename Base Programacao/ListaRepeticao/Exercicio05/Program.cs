namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5. Escreva um algoritmo para calcular o fatorial de um número.
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());
            int fatorial = 1;

            for (int i = numero; i > 0; i--)
            {
                Console.Write(i + " * ");
                fatorial *= i;
            }
            Console.WriteLine("\n\n");
            Console.WriteLine("O fatorial de " + numero + " é = " + fatorial);
        }
    }
}