namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Livros livro1 = new Livros();
            Console.WriteLine("Titulo do livro: ");
            livro1.titulo = Console.ReadLine();
            Console.WriteLine("Autor do livro: ");
            livro1.autor = Console.ReadLine();
            Console.WriteLine("Data de publicação: ");
            livro1.anoPublicacao = Console.ReadLine();

            Livros livro2 = new Livros();
            Console.WriteLine("Titulo do livro: ");
            livro2.titulo = Console.ReadLine();
            Console.WriteLine("Autor do livro: ");
            livro2.autor = Console.ReadLine();
            Console.WriteLine("Data de publicação: ");
            livro2.anoPublicacao = Console.ReadLine();

            Livros livro3 = new Livros();
            Console.WriteLine("Titulo do livro: ");
            livro3.titulo = Console.ReadLine();
            Console.WriteLine("Autor do livro: ");
            livro3.autor = Console.ReadLine();
            Console.WriteLine("Data de publicação: ");
            livro3.anoPublicacao = Console.ReadLine();

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Livro 1");
            Console.WriteLine("Titulo: " + livro1.titulo);
            Console.WriteLine("Autor: " + livro1.autor);
            Console.WriteLine("Data de publicação: " + livro1.anoPublicacao);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Livro 2");
            Console.WriteLine("Titulo: " + livro2.titulo);
            Console.WriteLine("Autor: " + livro2.autor);
            Console.WriteLine("Data de publicação: " + livro2.anoPublicacao);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Livro 3");
            Console.WriteLine("Titulo: " + livro3.titulo);
            Console.WriteLine("Autor: " + livro3.autor);
            Console.WriteLine("Data de publicação: " + livro3.anoPublicacao);
            Console.WriteLine("-----------------------------------");
        }
    }
}