using System;
using System.Collections.Generic;
using System.Text;

namespace impostos_aula_01
{
    public class Item
    {
        public String nome { get; private set; }

        public double Valor { get; private set; }

        public Item(string nome, double valor)
        {
            this.nome = nome;
            this.Valor = valor;
        }
    }
}
