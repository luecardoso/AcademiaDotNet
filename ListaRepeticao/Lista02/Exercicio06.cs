using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios.ListaRepeticao.Lista02
{
    internal class Exercicio06
    {
        public static void verificadorIdade()
        {
            /*
                 Faça um programa em VS que solicite ao o usuário que 
                informe a idade e valide a entrada de dados, ou seja, 
                repita a leitura até que ela esteja correta (maior do que zero). 
                Ao final, mostre a idade digitada.
             */
            int idade;
            do
            {
                Console.Write("Digite sua idade: ");
                idade = int.Parse(Console.ReadLine());

                if (idade <= 0)
                {
                    Console.WriteLine("Digite um idade válida!");
                }
            } while (idade <= 0);
            Console.WriteLine("Você tem " + idade + " ano(s)");
        }

    }
}
