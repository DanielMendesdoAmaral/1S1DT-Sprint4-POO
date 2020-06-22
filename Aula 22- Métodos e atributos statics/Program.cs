using System;

namespace Aula_22__Métodos_e_atributos_statics
{
    class Program
    {
        static void Main(string[] args)
        {
            Conversor.CotacaoDolar=5.24;
            Conversor.CotacaoEuro=5.90;

            Console.WriteLine($"10 DÓLARES EM REAL: {Conversor.ConverterDolarParaReal(10)}");
            Console.WriteLine($"10 REAIS EM DÓLAR: {Conversor.ConverterRealParaDolar(10)}");
            Console.WriteLine($"10 EUROS EM REAL: {Conversor.ConverterEuroParaReal(10)}");
            Console.WriteLine($"10 REAIS EM EURO: {Conversor.ConverterRealParaEuro(10)}");
        }
    }
}
