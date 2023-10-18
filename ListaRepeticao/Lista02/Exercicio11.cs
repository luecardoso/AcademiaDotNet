using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios.ListaRepeticao.Lista02
{
    internal class Exercicio11
    {
        public static void mediaAlunos()
        {
            /*
                 11. Ler as notas de uma turma de alunos e ao final imprimir a 
                nota mais alta, a nota mais baixa, a média aritmética da turma e a 
                quantidade de alunos da turma. Usar -1 para encerrar a leitura.
             */
            int alunos = 0;
            double nota = 0, maiorNota = 0, menorNota = 0, media = 0, soma = 0;
            Console.WriteLine("-----------------------------------");
            do
            {
                Console.Write("Digite a nota: ");
                nota = double.Parse(Console.ReadLine());
                //nota = new Random().Next(0, 10);
                if (nota == -1)
                {
                    break;
                }
                if (nota > maiorNota)
                {
                    maiorNota = nota;
                }
                if (nota < menorNota)
                {
                    menorNota = nota;
                }
                alunos++;

                soma += nota;
            } while (nota != -1);
            Console.WriteLine("-----------------------------------");
            media = soma / alunos;
            Console.WriteLine("Nota mais alta: " + maiorNota);
            Console.WriteLine("Nota mais baixa: " + menorNota);
            Console.WriteLine("Média: " + media);
            Console.WriteLine("alunos: " + alunos);
            Console.WriteLine("-----------------------------------");
        }
    }
}
