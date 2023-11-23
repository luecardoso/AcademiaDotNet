using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class Colega1 : Colega
    {
        public Colega1(Mediator mediator) : base(mediator)
        {
        }

        public override void Enviar(string mensagem)
        {
            _mediator.Enviar(mensagem, this);
        }

        public override void Notificar(string mensagem)
        {
            Console.WriteLine("Colega 1 recebeu a mensagem: " + mensagem);
        }

    }
}
