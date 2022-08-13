using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace impostos_aula_01.NotaFiscal
{
    public class NotaFiscalBuilder
    {
        public String RazaoSocial { get; private set; }

        public String CNPJ { get; private set; }

        public String Observacoes { get; private set; }

        public DateTime Data { get; private set; }

        private double ValorTotal;
        private double Impostos;

        private IList<ItemDaNota> todosItens = new List<ItemDaNota>();


        public NotaFiscalBuilder ParaEmpresa(String razaoSocial)
        {
            this.razaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscalBuilder ComObservacoes(String observacoes)
        {
            this.observacoes = observacoes;
            return this;
        }

        public NotaFiscalBuilder NaDataAtual()
        {
            this.Data = DateTime.Now;
            return this;
        }
        public NotaFiscalBuilder ComCNPJ(String CNPJ)
        {
            this.CNPJ = CNPJ;
            return this;
        }

        public NotaFiscalBuilder ComItem(ItemDaNota item)
        {
            todosItens.Add(item);
            valorTotal += item.Valor;
            impostos += item.Valor * 0.05;
            return this;
        }

        public NotaFiscal Constroi()
        {
            return new NotaFiscal(razaoSocial, CNPJ, Data, ValorTotal, impostos, todosItens, Observacoes);
        }
    }
}