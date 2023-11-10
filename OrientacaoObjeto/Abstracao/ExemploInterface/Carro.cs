using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploInterface
{
    internal class Carro : IVeiculo
    {
        private int _vel;
        public void Acelerar()
        {
            _vel++;
            Console.WriteLine("acelerando...");
        }

        public void Parar()
        {
            _vel--;
            Console.WriteLine("parando...");
        }
    }
}
