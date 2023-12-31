﻿namespace Exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                 2. Modificar o programa em VS anterior para que ao
                final ele pergunte ao usuário se ele deseja informar um 
                outro número. Caso positivo, o programa em VS deve ser 
                repetido.

                Exemplo:
                Digite um número inteiro positivo: 8
                Numero digitado: 8
                Números inteiros pares entre 1 e 8: 2, 4, 6.
 
                Deseja informar outro número (s/n)? S
 
                Digite um número inteiro positivo: 12
                Numero digitado: 20
                Números inteiros pares entre 1 e 8: 2, 4, 6, 8, 10.
 
                Deseja informar outro número (s/n)? N 
             */
            string resposta = "N";
            do
            {
                Console.WriteLine("-------------------------------------------");
                int numero;
                do
                {
                    Console.Write("Digite um número inteiro positivo: ");
                    numero = int.Parse(Console.ReadLine());

                    if (numero < 0)
                    {
                        Console.WriteLine("Valor incorreto!");
                    }

                } while (numero < 0);

                Console.WriteLine("Número digitado: " + numero);
                Console.Write("Números inteiros pares entre 1 e " + numero + ": ");
                for (int i = 1; i < numero; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(i + " ");
                    }
                }
                Console.Write("\n");
                Console.Write("Deseja informar outro número (s/n)? ");
                resposta = Console.ReadLine();
            } while (resposta.ToUpper() != "N");
            Console.WriteLine("-------------------------------------------");
        }
    }
}