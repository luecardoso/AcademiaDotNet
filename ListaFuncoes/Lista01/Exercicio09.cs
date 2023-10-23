using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios.ListaFuncoes.Lista01
{
    internal class Exercicio09
    {
        public static void principal()
        {
            /*
             * Escrever um programa com uma função que receba por parâmetro dois 
             * números (n1 e n2) e retorna a soma dos números inteiros que existem 
             * entre n1 e n2 (inclusive ambos). Apresente o resultado na main.
             * Desafio: Ler um vetor de inteiros com 10 elementos e passar por 
             * parâmetro para uma função que verifica e retorna o menor elemento do 
             * vetor.
             */
            somaEntreNumeros(digiteNumero(), digiteNumero());
            int[] vetor = new int[10]; ;
            lerVetor(vetor);
            imprimirVetor(vetor);
            menorNumero(vetor);
        }

        static int digiteNumero()
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());
            return numero;
        }

        static int somaEntreNumeros(int n1, int n2)
        {
            int soma = 0;
            if (n1 < n2)
            {
                for (int i = n1; i <= n2; i++)
                {
                    soma += i;
                }
            }
            else
            {
                for (int i = n1; i >= n2; i--)
                {
                    soma += i;
                }
            }

            Console.WriteLine("Soma entre " + n1 + " e " + n2 + " = " + soma);
            return soma;
        }

        static void lerVetor(int[] v)
        {
            Console.WriteLine("-----VETOR------");
            for (int i = 0; i < v.Length; i++)
            {
                //v[i] = digiteNumero();
                v[i] = new Random().Next(1, 25); ;
            }
        }

        static void imprimirVetor(int[] v)
        {
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write(v[i] + "| ");
            }
            Console.WriteLine("");
        }

        static int menorNumero(int[] v)
        {
            int menor = v[0];
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] < menor)
                {
                    menor = v[i];
                }
            }
            Console.WriteLine("Menor elemento: " + menor);
            return menor;
        }

    }
}
