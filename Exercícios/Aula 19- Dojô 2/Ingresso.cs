//ATRIBUTOS: Valor
//MÉTODOS: Construtor, imprimir valor, getters/setters

using System;

namespace Aula_19__Dojô_2
{
    public class Ingresso
    {
        public double ValorIngresso { get; private set; }

        /// <summary>
        ///   Construtor
        /// </summary>
        /// <param  valor do ingresso ></param>
        public Ingresso ( double valor){
            ValorIngresso = valor;
        }


        /// <summary>
        ///  Imprime o ingresso
        /// </summary>
        /// <returns> retorna o valor </returns>
        public virtual double ImprimirValor(){
            return ValorIngresso;
        }
    }
}

/*
ja era

só colocar tudo no program?

ss

quer por?

pera ae blz

faz o começo ai 

ta

*/