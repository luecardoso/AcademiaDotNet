namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Crie uma classe RegistroDeCompras com atributos para 
             * registrar informações de compras (data, produto, valor). 
             * Implemente um construtor e métodos para adicionar e 
             * listar compras. 
             */
           
            Produto p1 = new Produto("Leite",3.50,8);
            Produto p2 = new Produto("Pacote de Biscoito", 4.69, 5);
            Produto p3 = new Produto("Macarrão Pene", 5.29, 3);
            Produto p4 = new Produto("Café", 5.89, 2);

            List<Produto> lista = new List<Produto>();
            RegistroDeCompras.AdicionarCompras(p1, lista);
            RegistroDeCompras.AdicionarCompras(p2, lista);
            RegistroDeCompras.AdicionarCompras(p3, lista);
            RegistroDeCompras.AdicionarCompras(p4,lista);

            RegistroDeCompras registro1 = new RegistroDeCompras("24/10/2023", lista);
            RegistroDeCompras.ListarCompras(registro1);

            Produto p5 = new Produto("Açucar",3.79,3);
            List<Produto> lista2 = new List<Produto>();

            RegistroDeCompras.AdicionarCompras(p1, lista2);
            RegistroDeCompras.AdicionarCompras(p4, lista2);
            RegistroDeCompras.AdicionarCompras(p5, lista2);
            RegistroDeCompras registro2 = new RegistroDeCompras("05/11/2023", lista2);
            RegistroDeCompras.ListarCompras(registro2);
            Console.WriteLine("-------------------------------------------------------");
        }
    }
}