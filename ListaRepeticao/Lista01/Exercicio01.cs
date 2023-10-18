using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios.ListaRepeticao.Lista01
{
    internal class Exercicio01
    {
        public static void mediaIdades()
        {
            //1-Escreva um algoritmo para ler um número n, e em seguida ler pelo teclado a idade de n 
            // pessoas e calcular a média das idades.
            Console.Write("Digite um número: ");
            int quantidade = int.Parse(Console.ReadLine());
            int soma = 0;

            for (int i = 0; i < quantidade; i++)
            {
                Console.Write("Digite a " + (i + 1) + "a idade: ");
                int idade = int.Parse(Console.ReadLine());
                soma += idade;
            }

            double media = soma / quantidade;
            Console.WriteLine("Média das idades: " + media);
        }
    }
}
