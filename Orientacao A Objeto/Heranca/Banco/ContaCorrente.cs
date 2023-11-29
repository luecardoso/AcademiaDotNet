using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class ContaCorrente : ContaBancaria
    {
        private int _contSaques;

        public ContaCorrente() 
        {
            this._contSaques = 0;
        }
        public override void Depositar(double valor)
        {
            this.Saldo = valor;
            Console.WriteLine("Saldo atual = "+Saldo);
        }

        public override double Sacar(double valor)
        {
            _contSaques++;
            if (_contSaques == 1)
            {
                this.Saldo = valor;
            }
            else
            {
                this.Saldo = valor - 0.05;
            }
            return this.Saldo;
            
        }
    }
}
