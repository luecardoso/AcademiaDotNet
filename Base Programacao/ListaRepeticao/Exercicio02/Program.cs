namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2. Faça um algoritmo que leia 10 números pelo teclado, e que no
            //final mostre o maior deles. Não usar vetor.
            double maior = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Digite o " + (i + 1) + "o número: ");
                double numero = double.Parse(Console.ReadLine());
                if (i == 0)
                {
                    maior = numero;
                }
                if (numero > maior)
                {
                    maior = numero;
                }
            }
            Console.WriteLine("Maior número digitado: " + maior);
        }
    }
}