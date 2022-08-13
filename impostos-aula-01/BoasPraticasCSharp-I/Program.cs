using impostos_aula_01.Descontos;
using impostos_aula_01.Impostos;
using System;

namespace impostos_aula_01
{
    class Program
    {
        static void Main(string[] args)
        {
            NotaFiscalBuilder criador = new NotaFiscalBuilder();
            criador
                .ParaEmpresa("Caelum")
                .ComCNPJ("123.456.789/0001-11")
                .ComItem(new ItemDaNota("Item 1", 100.0))
                .ComItem(new ItemDaNota("Item 2", 200.0))
                .ComObservacoes("Observações do cliente")
                .NaDataAtual();

            NotaFiscal nf = criador.Constroi();

            Console.WriteLine(nf.ValorBruto);
            Console.WriteLine(nf.Impostos);
            Console.ReadKey();
        }
    }
}
