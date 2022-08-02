using System;
using System.Collections.Generic;
using System.Text;

namespace impostos_aula_01
{
    public class ICMS : IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return (orcamento.Valor * 0.05) + 50.0;
        }
    }
}
