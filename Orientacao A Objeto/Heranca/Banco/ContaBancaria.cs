using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal abstract class ContaBancaria
    {
        public double Saldo {  get; set; }

        public ContaBancaria() 
        { 
            Saldo = 0;
        }

        public abstract void Depositar(double valor);

        public abstract double Sacar(double valor);
    }
}
