namespace Exercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 14.	Escreva um algoritmo que leia um código numérico inteiro e 
             * um vetor de 50 posições de números. Se o código for zero, termine o 
             * algoritmo. Se o código for 1, mostre o vetor na ordem em que foi lido.
             * Se o código for 2, mostre o vetor na ordem inversa, do último elemento
             * até o primeiro.
             */
            int[] vetor = new int[10];
            Console.WriteLine("-------------------------------------");
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write("Digite o " + (i + 1) + " número: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("SELECIONE O CÓDIGO");
            Console.WriteLine("0 - ENCERRAR O PROGRAMA");
            Console.WriteLine("1 - ORDEM DIGITADA");
            Console.WriteLine("2 - ORDEM INVERSA");
            Console.Write("Escolha: ");
            string escolha = Console.ReadLine();
            if (escolha.Equals("1"))
            {
                for (int i = 0; i < vetor.Length; i++)
                {
                    Console.WriteLine("V[" + i + "] = " + vetor[i]);
                }
            }
            else
            if (escolha.Equals("2"))
            {
                for (int i = vetor.Length - 1; i > 0; i--)
                {
                    Console.WriteLine("V[" + i + "] = " + vetor[i]);
                }
            }
            else
            {
                Console.WriteLine("------------- ENCERRADO -------------");
                Console.WriteLine("-------------------------------------");
            }
        }
    }
}