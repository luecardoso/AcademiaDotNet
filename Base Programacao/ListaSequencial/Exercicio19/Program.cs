namespace Exercicio19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                19 - Ajuste o exercício 18 de maneira que mostre os valores 
                informados em ordem crescente.
             */
            Console.WriteLine("--------------------------------------");
            Console.Write("Digite o 1o numero: ");
            double numero1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o 2o numero: ");
            double numero2 = double.Parse(Console.ReadLine());

            Console.Write("Digite o 3o numero: ");
            double numero3 = double.Parse(Console.ReadLine());

            double maior = 0, menor = 0, meio = 0;

            if (numero1 > numero2 && numero1 > numero3)
            {
                maior = numero1;
                if (numero2 > numero3)
                {
                    meio = numero2;
                    menor = numero3;
                }
                else
                {
                    meio = numero3;
                    menor = numero2;
                }
            }
            if (numero2 > numero1 && numero2 > numero3)
            {
                maior = numero2;
                if (numero1 > numero3)
                {
                    meio = numero1;
                    menor = numero3;
                }
                else
                {
                    meio = numero3;
                    menor = numero1;
                }
            }
            if (numero3 > numero2 && numero3 > numero1)
            {
                maior = numero3;
                if (numero2 > numero1)
                {
                    meio = numero2;
                    menor = numero1;
                }
                else
                {
                    meio = numero1;
                    menor = numero2;
                }
            }
            Console.Write("Ordem crescente: " + maior + ", " + meio + ", " + menor);
            Console.WriteLine("--------------------------------------");
        }
    }
}