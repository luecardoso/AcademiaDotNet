using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios.ListaFuncoes.Lista01
{
    internal class Exercicio03
    {
        public static void calculoMedia()
        {
            /*
             * Desenvolva uma função que calcule a média de três
             * números fornecidos como argumentos.
             */
            double x = 0, y = 0, z = 0;

            mensagem(media(x, y, z));
        }

        static double digiteNumero()
        {
            Console.Write("Digite um número: ");
            double numero = double.Parse(Console.ReadLine());
            return numero;
        }

        static double media(double a, double b, double c)
        {
            a = digiteNumero();
            b = digiteNumero();
            c = digiteNumero();
            double media = (a + b + c) / 3;
            return media;
        }

        static void mensagem(double valor)
        {
            Console.WriteLine("Média = " + valor);
        }
    }
}
