using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace impostos_aula_01.ContaBancaria
{
    public class Conta
    {
        public string Titular { get; private set; }

        public double Saldo { get; private set; }
        
        public Conta(string titular, double saldo)
        {
            this.Titular = titular;
            this.Saldo = saldo;
        }
    }
}