namespace Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno("Lucas", "23.321.145-6", 24, "20-09-1990", "444.333.444/55", true);
            Console.WriteLine(aluno.getNome());
            Console.WriteLine(aluno.getRg());
            Console.WriteLine(aluno.getIdade());
            Console.WriteLine(aluno.getDataNascimento());
            Console.WriteLine(aluno.getRa());
            Console.WriteLine(aluno.getSituacao());
        }
    }
}