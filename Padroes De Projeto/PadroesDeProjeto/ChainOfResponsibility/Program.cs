namespace ChainOfResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testando o padrão Chain of Responsability");
            //instanciamos os três papeis, ou seja, a cadeia de manipuladores de responsabilidade
            IHandler gerente = new Gerente();
            IHandler diretor = new Diretor();
            IHandler presidente = new Presidente();
            IHandler proprietario = new Proprietario();

            gerente.DefinirProximoHandler(diretor);
            diretor.DefinirProximoHandler(presidente);
            presidente.DefinirProximoHandler(proprietario);


            Despesa d1 = new Despesa("Boleto da água", 450);
            Despesa d2 = new Despesa("Conta do bar da esquina", 950);
            Despesa d3 = new Despesa("Obra do banheiro", 4500);
            Despesa d4 = new Despesa("Conta da lancheria da academia", 9500);

            gerente.AprovarDespesa(d1);
            Console.WriteLine();
            gerente.AprovarDespesa(d2);
            Console.WriteLine();
            gerente.AprovarDespesa(d3);
            Console.WriteLine();
            gerente.AprovarDespesa(d4);
            Console.WriteLine("Fim do teste do padrão Chain of Responsability");
        }
    }
}
