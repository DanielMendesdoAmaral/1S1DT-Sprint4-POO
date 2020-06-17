//ATRIBUTOS: Valor adicional
//MÉTODOS: Construtor, imprimir valor, getters/setters

using System;

namespace Aula_19__Dojô_2
{
    public class IngressoVIP : Ingresso
    {
        // ATRIBUTO/ GETTER/ SETTER
        private double _valorAdicional;
        public double ValorAdicional
        {
            get { return _valorAdicional; }
            set { _valorAdicional = value; }
        }
        
        /// <summary>
        ///     Construtor.
        /// </summary>
        /// <param name="valor">O valor do ingresso.</param>
        /// <param name="valorAdicional">O valor adicional.</param>
        public IngressoVIP(double valorIngresso, double valorAdicional) : base(valorIngresso) {
            this.ValorAdicional=valorAdicional;
        }

        /// <summary>
        ///     Retorna o novo valor do ingresso.
        /// </summary>
        /// <returns>Um double contendo a soma do valor normal+valor adicional.</returns>
        public override double ImprimirValor() {
            return ValorIngresso+ValorAdicional;
        } 
    }
}