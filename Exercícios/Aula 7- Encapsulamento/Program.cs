/*

Capacidade: Utilizar o paradigma da programação orientada a objetos
Tipo: Formativa

Nesta atividade, realize o mesmo exemplo dado em sala, subindo o projeto para o Github com o titulo "Aula07Encapsulamento", enviando o link do repositório como entrega dessa atividade 
Para isto vamos criar uma classe Cartão com os seguintes métodos e atributos:
	
	public class Cartao

	- public string numero { get; set; }
	- public string bandeira { get; set; }
	- private string token { get; set; }
	- protected int cvc { get; set; }
	
	+ public string AprovarCompra(){}
	+ private bool ValidarToken(){}
	+ protected bool ValidarCompra(){}

	Depois criamos uma classe chamada "Mastercard" que herdará as propriedades de "Cartao":

	public class Mastercard : Cartao
	- public int parcelas { get; set; }
	+ public void ComprarComDescontoMastercard(){}

	Para finalizar chamamos todos os métodos e atributos acessíveis no main do projeto de console.

*/

using System;

namespace Aula_7__Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Cartao c = new Cartao();
            c.numero = "1234 1234 1234 1234";
            c.bandeira = "Elo";
            c.GetSetCvv = 12; /*Esta linha fará gerar a desaprovação da compra, pois falta um dígito para o cvv.*/

            System.Console.WriteLine(c.AprovarCompra() + "\n");

            Mastercard m = new Mastercard();
            m.numero = "1234 1234 1234 1234";
            m.bandeira = "Mastercard";
            m.GetSetCvv = 123;
            m.parcelas = 12;
            
            System.Console.WriteLine(m.AprovarCompra());
            m.ComprarComDescontoMastercard(30);
        }
    }
}
