namespace Aula_22__Métodos_e_atributos_statics
{
    //Todos membros devem ser statics
    public static class Conversor
    {
        public static double CotacaoDolar;
        public static double CotacaoEuro;

        public static double ConverterDolarParaReal(double valor) {
            return CotacaoDolar*valor;
        }

        public static double ConverterRealParaDolar(double valor) {
            return CotacaoDolar/valor;
        }

        public static double ConverterEuroParaReal(double valor) {
            return CotacaoEuro*valor;
        }

        public static double ConverterRealParaEuro(double valor) {
            return CotacaoEuro/valor;
        }
    }
}