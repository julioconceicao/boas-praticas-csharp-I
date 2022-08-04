using System;
using System.Collections.Generic;
using System.Text;

namespace impostos_aula_01.Impostos
{
    public class CalculadorDeimpostos
    {
        public void RealizaCalculo(Orcamento orcamento, IImposto imposto)
        {
            double resultado = imposto.Calcula(orcamento);
            Console.WriteLine(resultado);
        }
    }
}
