using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios.ListaFuncoes.Lista02
{
    internal class Exercicio07
    {
        public static void principal()
        {
            int[] vetor = new int[10];
            lerVetor(vetor);
            imprimirVetor(vetor);
            Console.WriteLine("O vetor possui numero primos = " + VerificaNumeroPrimo(vetor));

        }

        static bool VerificaNumeroPrimo(int[] v)
        {
            int cont = 0;
            bool[] status = new bool[v.Length];
            for (int i = 0; i < v.Length; i++)
            {
                if (numeroPrimo(v[i]))
                {
                    return true;
                }
            }
            return false;
        }

        static bool numeroPrimo(int numero)
        {
            int cont = 0;
            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    cont++;
                }
            }
            if (cont == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void imprimirVetor(int[] v)
        {
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write(v[i] + "| ");
            }
            Console.WriteLine();
        }

        static void lerVetor(int[] v)
        {
            Console.WriteLine("-----VETOR------");
            for (int i = 0; i < v.Length; i++)
            {
                //Console.Write(i + 1 + "a posição = ");
                //v[i] = int.Parse(Console.ReadLine());
                v[i] = new Random().Next(0, 30);
            }
        }
    }
}
