using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploAnimais
{
    internal abstract class Animal
    {
        public string Nome {  get; set; }
        public string Especie { get; set; }
        public int Idade { get; set; }

        public Animal() { }

        public void Movimentar()
        {

        }

        public abstract void EmitirSom();
    }
}
