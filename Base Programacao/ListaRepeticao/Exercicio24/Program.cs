namespace Exercicio24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //17. Apresentar os quadrados dos números inteiros de 15 a 200.

            for (int i = 15; i <= 200; i++)
            {
                Console.WriteLine(i + "^2 = " + (i * i));
            }
        }
    }
}