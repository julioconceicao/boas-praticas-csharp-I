using System;
using System.Collections.Generic;
using System.Text;

namespace impostos_aula_01.Investimentos
{
    public interface Investimento
    {
        double Calcula(Conta conta);
    }
}
