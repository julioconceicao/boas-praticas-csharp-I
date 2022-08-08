using System;
using System.Collections.Generic;
using System.Text;

namespace impostos_aula_01.Descontos
{
    public class Item
    {
        public string Nome { get; private set; }

        public double Valor { get; private set; }

        public Item(string nome, double valor)
        {
            this.Nome = nome;
            Valor = valor;
        }
    }
}
