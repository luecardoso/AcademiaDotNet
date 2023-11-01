namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
          * Fazer programa que tenha duas funções. 
          * i) para ler um vetor de 10 elementos (variável global);
          * ii) para verificar e apresentar a quantidade de elementos 
          * pares que este vetor possui.
          */
            int[] vetor = new int[10]; ;
            lerVetor(vetor);
            imprimirVetor(vetor);
            mensagem(numerosPares(vetor));
        }

        static void imprimirVetor(int[] v)
        {
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write(v[i] + "| ");
            }
        }

        static void lerVetor(int[] v)
        {
            Console.WriteLine("-----VETOR------");
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write(i + 1 + "a posição = ");
                v[i] = int.Parse(Console.ReadLine());
            }
        }

        static int numerosPares(int[] v)
        {
            int soma = 0;
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] % 2 == 0)
                {
                    soma++;
                }
            }
            return soma;
        }

        static void mensagem(int valor)
        {
            Console.WriteLine("Quantidade de número pares no vetor: " + valor);
        }
    }
}