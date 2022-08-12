using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace impostos_aula_01.Impostos
{
    public abstract class TemplateDeImpostoCondicional : IImposto
    {
        public TemplateDeImpostoCondicional(Imposto outroImposto) : base(outroImposto) { }

        public TemplateDeImpostoCondicional() : base() { }
        
        public double Calcula(Orcamento orcamento)
        {
            if (DeveUsarMaximaTaxacao(orcamento))
            {
                return MaximaTaxacao(orcamento);
            }
            else
            {
                return MinimaTaxacao(orcamento);
            }
        }

        protected public abstract bool DeveUsarMaximaTaxacao(Orcamento orcamento);
        protected public abstract double MaximaTaxacao(Orcamento orcamento);
        protected public abstract double MinimaTaxacao(Orcamento orcamento);
    }
}