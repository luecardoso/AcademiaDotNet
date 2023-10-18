using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios.ListaSequencial
{
    internal class Exercicio05
    {
        public static void aprovadoOuReprovado()
        {
            /*
                Escrever um algoritmo para ler duas notas de um aluno e escrever 
                na tela a palavra “Aprovado” se a média das duas notas for maior ou 
                igual a 7,0. Caso a média seja inferior a 7,0, o programa deve ler a 
                nota do exame e calcular a média final, é a média entre a nota do 
                exame e a média das 2 notas. Se esta média final for maior ou igual 
                a 5,0, o programa deve escrever “Aprovado”, caso contrário deve 
                escrever “Reprovado”.
             */

            Console.WriteLine("-----------------------------");
            Console.Write("Digite a 1a Nota do aluno: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a 2a Nota do aluno: ");
            double nota2 = double.Parse(Console.ReadLine());

            double media = (nota1 + nota2) / 2;

            Console.WriteLine("MÉDIA " + media);
            if (media >= 7)
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine("--------- *APROVADO* --------");
                Console.WriteLine("-----------------------------");
            }
            else
            {
                Console.Write("Digite a Nota do exame: ");
                double notaExame = double.Parse(Console.ReadLine());
                double mediaFinal = (media + notaExame) / 2;
                Console.WriteLine("MÉDIA FINAL " + mediaFinal);
                if (mediaFinal >= 5)
                {
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("--------- *APROVADO* --------");
                    Console.WriteLine("-----------------------------");
                }
                else
                {
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("-------- *REPROVADO* --------");
                    Console.WriteLine("-----------------------------");
                }

            }
        }
    }
}
