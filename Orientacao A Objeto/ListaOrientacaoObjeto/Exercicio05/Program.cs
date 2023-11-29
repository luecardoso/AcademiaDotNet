namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa("Lucas", 24, "Masculino", "444.333.444/55", "23.321.145-6", "20-09-1990");
            Console.WriteLine(pessoa.nome);
            Console.WriteLine(pessoa.idade);
            Console.WriteLine(pessoa.genero);
            Console.WriteLine(pessoa.cpf);
            Console.WriteLine(pessoa.rg);
            Console.WriteLine(pessoa.dataNascimento);
        }
    }
}