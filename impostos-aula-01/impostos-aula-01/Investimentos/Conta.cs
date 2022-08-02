using System;
using System.Collections.Generic;
using System.Text;

namespace impostos_aula_01.Investimentos
{
    public class Conta
    {
        public double Saldo { get; private set; }
        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }
    }
}
