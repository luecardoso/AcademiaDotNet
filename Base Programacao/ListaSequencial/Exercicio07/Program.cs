﻿namespace Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                7 - Faça um programa em C# e no VS para receber uma frase qualquer 
               e uma palavra de pesquisa.O programa deve avaliar se a palavra 
               aparece na frase, informando o usuário via mensagem, como por exemplo,
               A palavra encontra-se na frase   ou A palavra não se encontra na frase.
            */

            Console.WriteLine("--------------------------------------");
            Console.Write("Digite um frase: ");
            string frase = Console.ReadLine();

            Console.Write("Digite uma palavra de busca: ");
            string busca = Console.ReadLine();

            if (frase.Contains(busca))
            {
                Console.WriteLine("A palavra encontra-se na frase");
            }
            else
            {
                Console.WriteLine("A palavra NÃO se encontra na frase");
            }
            Console.WriteLine("--------------------------------------");
        }
    }
}