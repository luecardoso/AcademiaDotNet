using Exercicio02;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    internal class RegistroDeCompras
    {
        public String dataCompra {  get; set; }
        //public double ValorTotal;
        public List<Produto> ListaProdutos {  get;}

        public double Valor {  get; set; }
        public RegistroDeCompras() { }

        public RegistroDeCompras(String dataCompra, List<Produto> listaProdutos)
        {
            this.dataCompra = dataCompra;
            this.ListaProdutos = listaProdutos;
        }

        public static void ListarCompras(RegistroDeCompras rc)
        {
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine(rc.dataCompra);
            foreach (Produto produto in rc.ListaProdutos)
            {  
                Console.WriteLine(produto);
            }
            RegistroDeCompras.ValorTotal(rc.ListaProdutos);
        }
        public static void AdicionarCompras(Produto produto, List<Produto> lista)
        {
            lista.Add(produto);
        }

        public static void ValorTotal(List<Produto> lista)
        {
            double valor =0;
            foreach (Produto produto in lista)
            {
                valor += (produto.Preco * produto.Quantidade);
            }
            Console.WriteLine("TOTAL DA COMPRA: "+valor.ToString("F2"));
        }
    }
}
