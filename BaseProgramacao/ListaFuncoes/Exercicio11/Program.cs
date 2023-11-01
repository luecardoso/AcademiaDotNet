namespace Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Escreva uma função chamada CalcularMedia que recebe um vetor de 
             * números, a informação se o usuário deseja escolher os pares ou os 
             * impares, e retorna a média dos valores conforme a escolha do usuário.
             */
            int[] vetor = new int[10]; ;
            lerVetor(vetor);
            imprimirVetor(vetor);
            CalcularMedia(vetor);
        }

        static void CalcularMedia(int[] vetor)
        {
            int somaPar = 0, somaImpar = 0, quantidadePar = 0;
            double mediaPar = 0, mediaImpar = 0, quantidadeImpar = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] % 2 == 0)
                {
                    somaPar += vetor[i];
                    quantidadePar++;
                }
                else
                {
                    somaImpar += vetor[i];
                    quantidadeImpar++;
                }
            }
            if (quantidadePar > 0)
            {
                mediaPar = somaPar / quantidadePar;
            }
            if (quantidadeImpar > 0)
            {
                mediaImpar = somaImpar / quantidadeImpar;
            }
            Console.WriteLine("A média de quais números você quer saber: ");
            Console.WriteLine("1 - Pares");
            Console.WriteLine("2 - Impares");
            string escolha = Console.ReadLine();
            if (escolha.ToUpper().Equals("1") || escolha.ToUpper().Equals("PARES"))
            {
                Console.WriteLine("A média dos pares é = " + mediaPar);
            }
            else
            {
                Console.WriteLine("A média dos impares é = " + mediaImpar);
            }

        }

        static void imprimirVetor(int[] v)
        {
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write(v[i] + "| ");
            }
            Console.Write("");
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
    }
}