using System;
using System.Collections.Generic;
using System.Text;

namespace impostos_aula_01.Impostos
{
    public abstract class IImposto
    {
        private readonly Impostos outroImposto;

        public Imposto(Impostos outroImposto)
        {
            this.OutroImposto = outroImposto;
        }

        // construtor default
        public Imposto()
        {
            this.OutroImposto = null;
        }

        protected double CalculoDoOutroImposto(Orcamento orcamento)
        {
            // tratando o caso do proximo imposto nao existir!
            if (OutroImposto == null) return 0;
            return OutroImposto.Calcula(orcamento);
        }

        public abstract double Calcula(Orcamento orcamento);
    }
}
