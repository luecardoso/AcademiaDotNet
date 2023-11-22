using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class CachorroFactory : IAnimalFactory
    {
        public IAnimal CriarAnimal()
        {
            /*
            Cachorro cachorro = new Cachorro();
            return cachorro;
            */
            return new Cachorro();
        }
    }
}
