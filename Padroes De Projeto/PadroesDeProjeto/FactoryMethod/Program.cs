namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testando o padrão de projeto Factory Method");
            //eu quero adiar a decisão de qual classe instânciar
            //Cachorro c = new Cachorro();
            //c.FazerSom();
            //agora podemos adiar a decisao de qual objeto vamos instanciar 

            IAnimalFactory cFactory = new CachorroFactory();

            /*
            IAnimal c = cFactory.CriarAnimal();
            c.FazerSom();
            */

            Cliente cli1= new Cliente(cFactory);
            cli1.InteragirComAnimal();


            IAnimalFactory gFactory = new GatoFactory();
            Cliente cli2 = new Cliente(gFactory);

            cli2.InteragirComAnimal();

            List<Cliente> listaClientes = new List<Cliente>();

            listaClientes.Add(cli1);
            listaClientes.Add(cli2);
            listaClientes.Add(new Cliente(cFactory)); // to adicionando outro cachorro
            listaClientes.Add(new Cliente(gFactory));

        }
    }
}
