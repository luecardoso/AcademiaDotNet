using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios.ListaRepeticao.Lista02
{
    internal class Exercicio15
    {
        public static void aprovarAluno()
        {
            /*
             15. Ler 4 valores referentes a notas escolares de um aluno e 
            imprimir uma mensagem dizendo se ele está aprovado ou reprovado, 
            após ter calculado sua média ponderando, considerando 
            pesos 2, 1, 2, e 4, respectivamente. Considerar nota 7,0 como 
            mínima para aprovação.
             */
            double nota = 0, media = 0, nota1 = 0, nota2 = 0, nota3 = 0, nota4 = 0;
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Digite a " + (i + 1) + " nota: ");
                nota = double.Parse(Console.ReadLine());
                if (i == 0)
                {
                    nota1 = nota * 2;
                }
                if (i == 1)
                {
                    nota2 = nota * 1;
                }
                if (i == 2)
                {
                    nota3 = nota * 2;
                }
                if (i == 3)
                {
                    nota4 = nota * 4;
                }
            }
            media = (nota1 + nota2 + nota3 + nota4) / 9;
            Console.WriteLine("MÉDIA = "+media.ToString("F2"));
           
            if (media >= 7)
            {
                Console.WriteLine("APROVADO!");
            }
            else
            {
                Console.WriteLine("REPROVADO");
            }

        }
    }
}
