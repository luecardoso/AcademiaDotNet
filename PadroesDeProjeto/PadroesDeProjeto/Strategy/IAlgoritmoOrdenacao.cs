﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal interface IAlgoritmoOrdenacao
    {
        void Ordenar(List<int> lista);
    }
}
