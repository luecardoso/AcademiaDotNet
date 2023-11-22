using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class Gato : IAnimal
    {
        public void FazerSom()
        {
            Console.WriteLine("Miaaau");
        }
    }
}
