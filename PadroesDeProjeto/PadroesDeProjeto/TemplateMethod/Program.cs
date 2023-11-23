namespace TemplateMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testando o padrão Template Method");
            Console.WriteLine("Iniciamos usando o Processo A");
            Processo processo;
            processo = new ProcessoA();
            processo.Executar();

            Console.WriteLine();

            Console.WriteLine("Vamos mudar, agora ele vai virar o Processo B");
            processo = new ProcessoB();
            processo.Executar();

            Console.WriteLine();

            Console.WriteLine("Vamos mudar, agora ele vai virar o Processo C");
            processo = new ProcessoC();
            processo.Executar();
        }
    }
}
