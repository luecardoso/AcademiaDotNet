namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testando o padrão Observer");
            Sujeito s = new Sujeito(); //seria a loja que tem o produto


            //agora vamos adicionar os interessados no assunto ou produto
            Observador o1 = new Observador("Ricardo");
            Observador o2 = new Observador("Fabrício");
            Observador o3 = new Observador("Alexandre");
            Observador o4 = new Observador("Guilherme");


            s.RegistrarObservador(o1);
            s.RegistrarObservador(o2);
            s.RegistrarObservador(o3);
            s.RegistrarObservador(o4);
            s.RegistrarObservador(new Observador("Ana Paula"));

            s.NotificarObservadores("A aula de hoje não está legal!");

            s.RemoverObservador(o4);

            s.NotificarObservadores("O Guilherme foi embora pois está chato pra caramba!!");
            Console.WriteLine("Final do teste do padrão Observer");
        }
    }
}
