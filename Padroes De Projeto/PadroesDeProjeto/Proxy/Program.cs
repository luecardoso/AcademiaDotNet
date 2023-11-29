namespace Proxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IServico proxy = new Proxy();
            proxy.Solicitar();
        }
    }
}
