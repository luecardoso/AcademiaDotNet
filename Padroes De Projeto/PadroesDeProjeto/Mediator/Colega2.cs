using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class Colega2 : Colega 
    {
        public Colega2(Mediator mediator) : base(mediator)
        {
        }

        public override void Enviar(string mensagem)
        {
            _mediator.Enviar(mensagem, this);
        }

        public override void Notificar(string mensagem)
        {
            Console.WriteLine("Colega 2 recebeu a mensagem: " + mensagem);
        }
    }
}
