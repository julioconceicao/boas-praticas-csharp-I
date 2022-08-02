using System;

namespace impostos_aula_01
{
    class Program
    {
        static void Main(string[] args)
        {
            IImposto iss = new ISS();
            IImposto icms = new ICMS();

            Orcamento orcamento = new Orcamento(923.0);

            CalculadorDeimpostos calculador = new CalculadorDeimpostos();

            calculador.RealizaCalculo(orcamento, iss);

            Console.ReadKey();

        }
    }
}
