namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testanto a classe configuração usando o padrão singleton");

            ConfiguracaoSingleton config1 = ConfiguracaoSingleton.getInstance();
            config1.ExibirDados();

            //config1.Url = "qualquer coisa";

            ConfiguracaoSingleton config2 = ConfiguracaoSingleton.getInstance();
            if (config1 == config2)
            {
                Console.WriteLine("Mesma instância - 1 e 2");
            }

            //na linha abaixo, estou chamando o construtor no cliente
            //isso não podemos, pois criamos uma outra instância.
            //O construtor deve ser privado ou protegido!
            //ConfigurationSingleton config3 = new ConfigurationSingleton();
            ConfiguracaoSingleton config3 = ConfiguracaoSingleton.getInstance();

            if (config1 == config3)
            {
                Console.WriteLine("Mesma instância - 1 e 3");
            }
            else
            {
                Console.WriteLine("Diferente instância - 1 e 3");
            }
        }
    }
}
