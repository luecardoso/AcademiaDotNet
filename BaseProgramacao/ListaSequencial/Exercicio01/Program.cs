namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               Faça um algoritmo para calcular e mostrar a área de um triângulo a 
               partir dos valores da base e da altura lidos pelo teclado: 
               Área do triangulo = (base * altura) / 2; 
               Teste se a base ou a altura digitada não foi igual a zero.  
            */
            Console.WriteLine("------------------------------------");
            Console.WriteLine("---------AREA DO TRIANGULO----------");
            Console.WriteLine("------------------------------------");

            Console.Write("Base: ");
            double baseTriangulo = double.Parse(Console.ReadLine());

            Console.Write("Altura: ");
            double alturaTriangulo = double.Parse(Console.ReadLine());
            double areaTriangulo = 0;

            if (baseTriangulo != 0 && alturaTriangulo != 0)
            {
                areaTriangulo = baseTriangulo * alturaTriangulo / 2;
            }
            else
            {
                Console.WriteLine("Um dos valores de base ou altura está igual 0!");
            }
            Console.WriteLine("Area = " + areaTriangulo);
            Console.WriteLine("------------------------------------");
        }
    }
}