namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Crie uma classe Produto com atributos como nome, preço 
             * e quantidade em estoque. Implemente um construtor e métodos
             * para adicionar e remover itens do estoque. 
             */

            Produto p1 = new Produto();
            p1.Nome = "Leite";
            p1.Preco = 3.50;
            p1.Quantidade = 36;

            Produto p2 = new Produto("Pacote de Biscoito", 4.69,43);
            List<Produto> lista = new List<Produto>();  

            lista.Add(p1);
            lista.Add(p2);
            lista.Add(new Produto("Macarrão Pene",5.29,27));

            listar(lista);
            
            Produto.Adicionar(p1, 8);
            Produto.Remover(p2, 50);
            Produto.Remover(p2, 13);

            listar(lista);

        }

        static void listar(List<Produto> lista)
        {
            foreach (Produto produto in lista)
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine(produto);
            }
        }
    }
}