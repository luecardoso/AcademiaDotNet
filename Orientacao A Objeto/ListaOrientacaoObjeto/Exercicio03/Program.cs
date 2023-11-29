namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro();
            Carro c2 = new Carro();

            Console.WriteLine("---------Carro 1---------");
            Console.Write("Marca: ");
            c1.marca = Console.ReadLine();
            Console.Write("Modelo: ");
            c1.modelo = Console.ReadLine();
            Console.Write("Ano de Fabricação: ");
            c1.anoFabricacao = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("---------Carro 2---------");
            Console.Write("Marca: ");
            c2.marca = Console.ReadLine();
            Console.Write("Modelo: ");
            c2.modelo = Console.ReadLine();
            Console.Write("Ano de Fabricação: ");
            c2.anoFabricacao = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("---------Carro 1---------");
            Console.WriteLine("Marca: " + c1.marca);
            Console.WriteLine("Modelo: " + c1.modelo);
            Console.WriteLine("Ano de Fabricação: " + c1.anoFabricacao);
            Console.WriteLine("---------Carro 2---------");
            Console.WriteLine("Marca: " + c2.marca);
            Console.WriteLine("Modelo: " + c2.modelo);
            Console.WriteLine("Ano de Fabricação: " + c2.anoFabricacao);
        }
    }
}