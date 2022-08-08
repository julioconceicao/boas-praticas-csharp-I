using impostos_aula_01.Descontos;
using System;
using System.Collections.Generic;
using System.Text;

namespace impostos_aula_01
{
    public class Orcamento
    {
        public double Valor { get; private set; }

        public IList<Item> Itens { get; private set; }

        public Orcamento(double valor)
        {
            Valor = valor;
            this.Itens = new List<Item>();
        }

        public void AdicionaItem(Item item)
        {
            Itens.Add(item);
        }
    }
}
