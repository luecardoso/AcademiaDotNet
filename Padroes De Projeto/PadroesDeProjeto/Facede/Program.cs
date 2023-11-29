namespace Facede
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Facade fachada = new Facade("root", "1234");
            fachada.InicializarSistema();

            /*A utilização do facade evita com que seja necessário sempre alterar 
            no cliente novos componentes.
            tudo ficará centraliado na classe Facade
            SistemaBancoDeDados sbd = new SistemaBancoDeDados();
            SistemaServidorWeb ssw = new SistemaServidorWeb();
            SistemaAutenticacao sa = new SistemaAutenticacao("root", "1234");
            sbd.IniciarBancoDeDados();
            ssw.IniciarServidor();
            sa.IniciarSistema();*/

        }
    }
}
