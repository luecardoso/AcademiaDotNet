using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class ContaPoupanca : ContaBancaria
    {
        public override void Depositar(double valor)
        {
            this.Saldo = valor;
        }

        public override double Sacar(double valor)
        {
            this.Saldo = valor - 0.1;
            return this.Saldo;
        }
    }
}
