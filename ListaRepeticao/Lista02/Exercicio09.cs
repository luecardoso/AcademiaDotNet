using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios.ListaRepeticao.Lista02
{
    internal class Exercicio09
    {
        public static void informacoesZoologico()
        {
            /*
                9. Faça um programa em VS para Ler a quantidade de filhos de cada uma das 
                30 pessoas que visitaram o zoológico num determinado dia, imprimindo:
                Quantas pessoas tem entre 1 e 3 filhos.
                Quantas pessoas tem entre 4 e 7 filhos.
                Quantas pessoas tem mais de 8 filhos.
                Quantas pessoas não tem filhos.
             */
            int filhos1e3 = 0, filhos4e7 = 0, quantidadeFilhos = 0, semFilhos = 0,
                filhosMais8 = 0, clientes = 1;

            for (int i =0; i < 10; i++)
            {
                Console.WriteLine("-------------------------------------------------");
                Console.Write((i+1) + "o cliente, informe quantos filhos você tem: ");
                quantidadeFilhos = int.Parse(Console.ReadLine());

                if (quantidadeFilhos <= 0)
                {
                    semFilhos++;
                }
                else
                {
                    if (quantidadeFilhos >= 8)
                    {
                        filhosMais8++;
                    }
                    if (quantidadeFilhos >= 1 && quantidadeFilhos <= 3)
                    {
                        filhos1e3++;
                    }
                    if (quantidadeFilhos >= 4 && quantidadeFilhos <= 7)
                    {
                        filhos4e7++;
                    }
                }
            }
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Quantidade de pessoas tem entre 1 e 3 filhos: "+filhos1e3);
            Console.WriteLine("Quantidade de pessoas tem entre 4 e 7 filhos: "+filhos4e7);
            Console.WriteLine("Quantidade de pessoas tem mais de 8 filhos: "+filhosMais8);
            Console.WriteLine("Quantidade de pessoas não tem filhos: "+semFilhos);
            Console.WriteLine("-------------------------------------------------");

        }
    }
}
