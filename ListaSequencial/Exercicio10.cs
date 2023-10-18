using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios.ListaSequencial
{
    internal class Exercicio10
    {
        public static void verificarAltura()
        {
            //10 - Faça um programa no VS que receba dados de dois atletas (nome, idade e altura).
            //O programa deve mostrar os dados do atleta mais novo e mais alto.
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("ATLETA 1 ");
            Console.Write("Nome: ");
            string nomeAtleta1 = Console.ReadLine();
            Console.Write("idade: ");
            int idadeAtleta1 = int.Parse(Console.ReadLine());
            Console.Write("altura: ");
            double alturaAtleta1 = double.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("ATLETA 2 ");
            Console.Write("Nome: ");
            string nomeAtleta2 = Console.ReadLine();
            Console.Write("idade: ");
            int idadeAtleta2 = int.Parse(Console.ReadLine());
            Console.Write("altura: ");
            double alturaAtleta2 = double.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------");
            if (idadeAtleta1 < idadeAtleta2 && alturaAtleta1 > alturaAtleta2)
            {
                Console.WriteLine("Nome: " + nomeAtleta1);
                Console.WriteLine("idade: " + idadeAtleta1);
                Console.WriteLine("altura: " + alturaAtleta1);
            }
            else if (idadeAtleta2 < idadeAtleta1 && alturaAtleta2 > alturaAtleta1)
            {
                Console.WriteLine("Nome: " + nomeAtleta1);
                Console.WriteLine("idade: " + idadeAtleta1);
                Console.WriteLine("altura: " + alturaAtleta1);
            }
            else
            {
                if (idadeAtleta1 < idadeAtleta2)
                {
                    Console.WriteLine(nomeAtleta1 + " é mais jovem que " + nomeAtleta2);
                }
                else
                {
                    Console.WriteLine(nomeAtleta2 + " é mais jovem que " + nomeAtleta1);
                }


                if (alturaAtleta1 > alturaAtleta2)
                {
                    Console.WriteLine(nomeAtleta1 + " é mais alto que " + nomeAtleta2);
                }
                else
                {
                    Console.WriteLine(nomeAtleta2 + " é mais alto que " + nomeAtleta1);
                }
            }
            Console.WriteLine("--------------------------------------");
        }
    }
}
