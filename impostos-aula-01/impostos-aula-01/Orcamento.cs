﻿using System;
using System.Collections.Generic;
using System.Text;

namespace impostos_aula_01
{
    public class Orcamento
    {
        public double Valor { get; private set; }

        public Orcamento(double valor)
        {
            Valor = valor;
        }
    }
}
