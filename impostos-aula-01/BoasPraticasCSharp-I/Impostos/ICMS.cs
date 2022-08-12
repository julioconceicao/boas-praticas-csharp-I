using System;
using System.Collections.Generic;
using System.Text;

namespace impostos_aula_01.Impostos
{
    public class ICMS : IImposto
    {
        public ICMS(Impostos outroImposto) : base(outroImposto) { }

        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05 + 50.0;
        }

        private double CalculoDoOutroImposto(Orcamento orcamento)
        {
            return OutroImposto.Calcula(orcamento);
        }
    }
}
