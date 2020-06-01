using System;

namespace Aula_7__Encapsulamento
{
    public class Mastercard : Cartao
    {
        public int parcelas {get; set;}

        /// <summary>
        /// Escreve no console o número de parcelas e o desconto. 
        /// </summary>
        /// <param name="d">O usuário insere o desconto.</param>
        public void ComprarComDescontoMastercard(double d) {
            System.Console.WriteLine($"PARCELAS: {parcelas}X\nDESCONTO: R${d}");
        }
    }
}