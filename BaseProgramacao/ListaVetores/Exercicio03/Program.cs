namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               3.	Escreva um algoritmo que leia os valores para um vetor de 
               20 elementos e então mostre na tela o índice da posição dos 
               valores correspondentes a números primos.
            */


            int[] vetor = new int[20];
            int cont = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = new Random().Next(0, 20);
                // Console.Write("Digite um numero: ");
                // vetor[i] = int.Parse(Console.ReadLine());
                Console.Write(+vetor[i] + "|");
            }
            Console.WriteLine("");
            for (int i = 0; i < vetor.Length; i++)
            {
                for (int j = 1; j <= vetor[i]; j++)
                {
                    if (vetor[i] % j == 0)
                    {
                        cont++;
                    }
                    //Console.WriteLine("Cont " + cont);
                }
                if (cont == 2)
                {
                    Console.WriteLine("V[" + i + "] = " + vetor[i] + " é primo!");
                    cont = 0;
                }
                cont = 0;
            }
        }
    }
}