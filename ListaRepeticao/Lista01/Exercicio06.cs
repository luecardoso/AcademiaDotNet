using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios.ListaRepeticao.Lista01
{
    internal class Exercicio06
    {
        public static void mediaAvaliacoes()
        {
            //6. Escreva um algoritmo que leia o número de alunos de uma turma e em seguida leia a quantidade
            //de avaliações aplicadas para aquela turma. Por fim, leia as notas das avaliações de cada aluno e
            //mostre sua nota final (média das notas das avaliações).

            Console.Write("Digite a quantidade de alunos na turma: ");
            int alunos = int.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade de avaliações aplicadas: ");
            int avaliacoes = int.Parse(Console.ReadLine());
            double nota = 0, soma = 0, media = 0; ;

            for (int i = 0; i < alunos; i++)
            {
                Console.WriteLine(i + 1 + " aluno");
                Console.WriteLine("--Notas--");
                for (int j = 0; j < avaliacoes; j++)
                {
                    Console.Write("Digite a " + (j + 1) + "a avaliação: ");
                    nota = double.Parse(Console.ReadLine());
                    soma += nota;
                }
                // Console.WriteLine("Soma das avaliações: "+soma);
                media = soma / avaliacoes;
                Console.WriteLine("Média: " + media.ToString("F2"));
                soma = 0;
            }
        }
    }
}
