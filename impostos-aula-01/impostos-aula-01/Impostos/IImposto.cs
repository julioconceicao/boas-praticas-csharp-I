using System;
using System.Collections.Generic;
using System.Text;

namespace impostos_aula_01.Impostos
{
    public interface IImposto
    {
        double Calcula(Orcamento orcamento);
    }
}
