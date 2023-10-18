using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios.ListaRepeticao.Lista02
{
    internal class Exercicio04
    {
        public static void conatgemDeVotos()
        {
            /*
                4. Em uma cidadezinha do interior há dois candidatos 
                para prefeito (JOAO e ZECA). Você foi contratado para 
                fazer um programa em VS que conte os votos dos candidatos. 
                Cada vez que o usuário digitar JOAO, você deve somar um 
                ao seu número de votos. O mesmo para ZECA. Você também pode 
                aceitar votos em branco (palavra BRANCO). O programa em VS 
                termina quando o usuário escrever FIM. Ao final devem ser 
                mostradas as quantidades de votos para cada um dos candidatos 
                e o número de votos em branco. 
             */
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("----- *ELEIÇÃO PARA PREFEITO* -----");
            Console.WriteLine("-----------------------------------");
            string palavra;
            int joao = 0, zeca = 0, branco = 0;
            do
            {
                Console.WriteLine("------------ *VOTOS* --------------");
                Console.WriteLine("JOAO");
                Console.WriteLine("ZECA");
                Console.WriteLine("BRANCO");
                Console.WriteLine("-----------------------------------");
                Console.Write("Insira seu voto: ");
                palavra = Console.ReadLine();

                if (palavra.ToUpper().Equals("JOAO"))
                {
                    joao++;
                }
                if (palavra.ToUpper().Equals("ZECA"))
                {
                    zeca++;
                }
                if (palavra.ToUpper().Equals("BRANCO"))
                {
                    branco++;
                }

            } while (palavra.ToUpper() != "FIM");

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("------- *CONATEGM DE VOTOS* -------");
            Console.WriteLine("JOAO: " + joao + " votos");
            Console.WriteLine("ZECA: " + zeca + " votos");
            Console.WriteLine("BRANCO: " + branco + " votos");
            Console.WriteLine("-----------------------------------");
        }
    }
}
