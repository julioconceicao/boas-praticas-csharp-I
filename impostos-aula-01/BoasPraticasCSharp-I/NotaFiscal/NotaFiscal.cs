using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace impostos_aula_01.NotaFiscal
{
    public class NotaFiscal
    {
        public String RazaoSocial { get; set; }
        public String CNPJ { get; set; }

        public DateTime DataDeEmissao { get; set; }

        public double ValorBruto { get; set; }

        public double Impostos { get; set; }

        public IList<ItemDaNota> Itens { get; set; }
        public String Observacoes { get; set; }

        public NotaFiscal(String razaoSocial, String cnpj, DateTime dataDeEmissao, double valorBruto, double valorBruto, double Impostos, IList<ItemDaNota> itens, String observacoes)
        {
            this.RazaoSocial = razaoSocial;
            this.CNPJ = cnpj;
            this.DataDeEmissao = dataDeEmissao;
            this.ValorBruto = valorBruto;
            this.Impostos = Impostos;
            this.Itens = itens;
            this.Observacoes = observacoes;
        }
    }
}