namespace Mediator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MediatorConcreto mediador = new MediatorConcreto();

            Colega1 c1 = new Colega1(mediador);
            Colega2 c2 = new Colega2(mediador);

            mediador.colega1 = c1;
            mediador.colega2 = c2;

            c1.Enviar("Mensagem enviada pra 1");
            c2.Enviar("Mensagem enviada pra 2");
        }
    }
}
