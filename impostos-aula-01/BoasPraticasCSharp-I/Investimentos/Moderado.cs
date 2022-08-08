﻿using System;
using System.Collections.Generic;
using System.Text;

namespace impostos_aula_01.Investimentos
{
    public class Moderado : IInvestimento
    {
        private Random random;
        public Moderado()
        {
            this.random = new Random();
        }
        public double Calcula(Conta conta)
        {
            if (random.Next(2) == 0)
                return conta.Saldo * 0.025;
            else
                return conta.Saldo * 0.007;
        }
    }
}
