using System;
using System.Collections.Generic;
using System.Text;

namespace impostos_aula_01.Investimentos
{
    public class Conservador : Investimento
    {
        public double Calcula(Conta conta)
        {
            return conta.Saldo * 0.008;
        }
    }
}
