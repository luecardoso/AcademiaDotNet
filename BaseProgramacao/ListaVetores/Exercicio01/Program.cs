namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1.	Escreva um algoritmo que leia os valores para um vetor de 
             * 10 elementos e então mostre na tela a quantidade de números 
             * pares e ímpares.
             */
            double[] vetor = new double[10];
            int pares = 0, impares = 0;

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write("Digite o " + (i + 1) + " número: ");
                double valor = double.Parse(Console.ReadLine());

                if (valor % 2 == 0)
                {
                    pares++;
                }
                else
                {
                    impares++;
                }
            }
            Console.WriteLine("----- QUANTIDADE DE NÚMEROS -----");
            Console.WriteLine("Pares: " + pares);
            Console.WriteLine("Impares: " + impares);
            Console.WriteLine("---------------------------------");
        }
    }
}