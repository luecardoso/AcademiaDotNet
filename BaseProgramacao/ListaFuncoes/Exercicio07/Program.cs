namespace Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Crie uma função que determine se um número é primo ou não.
            */
            numeroPrimo(digiteNumero());
        }

        static int digiteNumero()
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());
            return numero;
        }
        static void numeroPrimo(int numero)
        {
            int cont = 0;
            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    cont++;
                }
            }
            if (cont == 2)
            {
                Console.WriteLine(numero + " É PRIMO!");
            }
            else
            {
                Console.WriteLine(numero + " NÃO É PRIMO!");
            }
        }
    }
}