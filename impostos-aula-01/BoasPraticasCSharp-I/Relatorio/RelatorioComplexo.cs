using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace impostos_aula_01.Relatorio
{
    public class RelatorioComplexo : TemplateRelatorio
    {
        protected override void Cabecalho()
        {
            Console.WriteLine("Banco XYZ");
            Console.WriteLine("Avenida Paulista, 1234");
            Console.WriteLine("(11) 1234-5678");
        }

        protected override void Rodape()
        {
            Console.WriteLine("banco@xyz.com.br");
            Console.WriteLine(DateTime.Now);
        }

        protected override void Corpo(IList<Conta> contas)
        {
            foreach (Conta c in contas)
            {
                Console.WriteLine(c.Nome + " - " + c.Numero + " - " + c.Agencia + " - " + c.Saldo);
            }
        }
    }
}