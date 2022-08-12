using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace impostos_aula_01.Impostos
{
    public class ImpostoMuitoAlto : IImposto
    {
        public ImpostoMuitoAlto(Imposto imposto) : base(imposto) { }

        public ImpostoMuitoAlto() : base() { }

        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.2 + CalculaOutroImposto(orcamento);
        }
    }
}