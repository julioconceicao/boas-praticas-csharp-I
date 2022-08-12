using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace impostos_aula_01.Impostos
{
    public class IHIT : TemplateDeImpostoCondicional
    {
        public IHIT(Impostos outroImposto) :base (outroImposto) { }
        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            IList<String> noOrcamento = new List<String>();

            foreach (Item item in orcamento.Itens)
            {
                if (noOrcamento.Contains(item.Nome))
                    return true;
                else
                    noOrcamento.Add(item.getNome);
            }

            return false;
        }

        protected public override double MaximaTaxacao(Orcamento orcamento)
        {
            return (orcamento.Valor * 0.13) + 100.00;
        }

        protected public override double MinimaTaxacao(Orcamento orcamento)
        {
            return (orcamento.Valor * 0.01) + orcamento.Itens.Count;
        }
        private double CalculoDoOutroImposto(Orcamento orcamento)
        {
            return OutroImposto.Calcula(orcamento);
        }
    }
}