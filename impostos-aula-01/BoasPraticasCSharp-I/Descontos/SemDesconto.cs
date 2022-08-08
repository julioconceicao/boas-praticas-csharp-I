using System;
using System.Collections.Generic;
using System.Text;

namespace impostos_aula_01.Descontos
{
    public class SemDesconto : IDesconto
    {

        public IDesconto Proximo { get; set; }
        
        public double Desconta(Orcamento orcamento)
        {
            return 0;
        }
    }
}
