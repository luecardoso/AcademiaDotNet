namespace Exercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 15.	Faça um programa em C# que declare um vetor de 20 elementos inteiros, 
             * leia os conteúdos do vetor, e copie estes conteúdos para outro vetor, 
             * invertendo sua ordem. Assim, o valor do primeiro elemento do primeiro vetor 
             * deve ser o valor do último elemento do segundo vetor, por exemplo. Mostrar os
             * conteúdos do primeiro vetor em uma linha e os do segundo uma linha abaixo.
             */

            /*REALIZADO PELO PROFESSOR FABRICIO*/
            int[] vetor = new int[5] { 0, 1, 2, 3, 4 };
            int[] vetorInvertido = new int[5];

            int posicao = (vetor.Length - 1);

            for (int i = 0; i < vetor.Length; i++)
            {
                vetorInvertido[posicao] = vetor[i];
                posicao--;
            }

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("vetor normal [" + i + "] = " + vetor[i]);
            }

            for (int i = 0; i < vetorInvertido.Length; i++)
            {
                Console.WriteLine("vetor invertido [" + i + "] = " + vetorInvertido[i]);
            }


        }
    }
}