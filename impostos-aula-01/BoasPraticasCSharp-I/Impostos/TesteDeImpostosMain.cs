using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace impostos_aula_01.Impostos
{
    public class TesteDeImpostosMain
    {
        static void Main(String[] args)
        {
            Imposto impostoComplexo = new ImpostoMuitoAlto(new ICMS());

            Orcamento orcamento = new Orcamento(500.0);

            double valor = impostoComplexo.Calcula(orcamento);

            Console.WriteLine(valor);

            Console.ReadKey();
        }
    }
}