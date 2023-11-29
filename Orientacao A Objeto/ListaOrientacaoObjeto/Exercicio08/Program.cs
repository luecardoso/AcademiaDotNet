namespace Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Autor autor = new Autor("Guimarães rosa", "Brasileiro");

            Livro livro = new Livro("Grande Sertoões Veredas", autor, "1956", "Companhia das Letras");

            livro.ExibirInformacoes();
            livro.Emprestar();
            livro.Emprestar();
            livro.ExibirInformacoes();
            livro.Devolver();
            livro.Devolver();
            livro.ExibirInformacoes();
        }
    }
}