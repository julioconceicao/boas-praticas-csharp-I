using System;
using System.Collections.Generic;
using System.Text;

namespace impostos_aula_01
{
    public interface IImposto
    {
        double Calcula(Orcamento orcamento);
    }
}
