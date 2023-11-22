﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class GatoFactory : IAnimalFactory
    {
        public IAnimal CriarAnimal()
        {
            return new Gato();
        }
    }
}
