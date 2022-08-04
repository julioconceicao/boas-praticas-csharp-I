using System;
using System.Collections.Generic;
using System.Text;

namespace impostos_aula_01.Descontos
{
    public interface IDesconto
    {
        double Desconta(Orcamento orcamento);
        public IDesconto Proximo { get; set; }
    }
}
