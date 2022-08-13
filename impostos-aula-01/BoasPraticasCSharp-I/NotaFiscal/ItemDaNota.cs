using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace impostos_aula_01.NotaFiscal
{
    public class ItemDaNota
    {
        public String Nome { get; set; }
        public double Valor { get; set; }

        public ItemDaNota(String nome, double valor)
        {
            this.Nome = nome;
            this.Valor = valor;
        }
    }
}