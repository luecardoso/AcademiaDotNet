﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal abstract class Mediator
    {
        public abstract void Enviar(string mensagem, Colega colega);
    }
}
