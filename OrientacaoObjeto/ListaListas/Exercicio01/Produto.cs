using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    internal class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public int Quantidade { get; set; }

        public Produto() { }

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public static void Adicionar(Produto produto,int quantidade)
        {
            produto.Quantidade += quantidade;
        }

        public static void Remover(Produto produto,int quantidade)
        { 
            if (produto.Quantidade < quantidade)
            {
                Console.WriteLine("A quantidade a ser removida é maior que a quantidade em estoque!");
            }
            else
            {
                produto.Quantidade -= quantidade;
            }
            
        }

        public override string? ToString()
        {
            return "Produto: " + Nome+"\nPreço: "+Preco+"\nQuantidade: "+Quantidade;
        }
    }
}
