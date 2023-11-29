using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal abstract class Colega
    {
        protected Mediator _mediator;

        public Colega(Mediator mediator)
        {
            _mediator = mediator;

        }

        public abstract void Enviar(string mensagem);

        public abstract void Notificar(string mensagem);

    }
}
