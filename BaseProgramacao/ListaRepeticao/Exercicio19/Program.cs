namespace Exercicio19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //12 - Apresentar o total da soma dos cem primeiros números inteiros.
            int soma = 0;
            for (int i = 0; i <= 100; i++)
            {
                soma += i;
            }
            Console.WriteLine("Soma = " + soma);
        }
    }
}