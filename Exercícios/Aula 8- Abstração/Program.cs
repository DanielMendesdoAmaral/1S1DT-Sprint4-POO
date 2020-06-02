/*

Capacidade: Utilizar o paradigma da programação orientada a objetos
Tipo: Formativa	

Nesta atividade, realize o mesmo exemplo dado em sala, subindo o projeto para o Github com o titulo "Aula08Abstracao", enviando o link do repositório como entrega dessa atividade
Neste exemplo vamos abstrair o conceito de pagamentos de uma loja virtual
	
	- dotnet new console
	- dotnet run	

	Criaremos um projeto de console com as seguintes classes:

	public class Pagamento
	- data
	- valor
	+ Pagar(float valor);
	+ Cancelar();

	public class Boleto : Pagamento 
	- data_vencimento
	- banco_emissor
	- codigo_de_barras
	+ RegistrarNoSistema();

	public class Cartao : Pagamento
	- token
	- bandeira
	- numero
	- titular
	- cvc
	+ ValidarToken();

	public class CartaoCredito : Cartao
	- limite
	+ AumentarLimite(float limite, float acrecsimo);
	+ Bloquear();

	public class CartaoDebito : Cartao
	- saldo
	+ Transferir(float valor);
	+ PagarTitulo();
	
	Depois disso chamamos no Main do console alguns métodos e atributos das classes,
	instanciando um novo objeto:
	
	CartaoCredito visa = new CartaoCredito();
	visa.limite = 1200
	visa.AumentarLimite(visa.limite, 300);
	visa.Pagar(900);

*/

using System;

namespace Aula_8__Abstração
{
    class Program
    {
        static void Main(string[] args)
        {
            CartaoCredito cc = new CartaoCredito();

            cc.bandeira = "Visa";
            cc.numero = "1234 1234 1234 1234";
            cc.titular = "Daniel Mendes do Amaral";
            cc.cvv = 123;
            cc.ValidarToken();
            cc.limite = 100;
            cc.AumentarLimite(1000);
            System.Console.WriteLine(cc.data = DateTime.Parse("07-06-20"));
            System.Console.WriteLine(cc.valor = 200);
            System.Console.WriteLine(cc.Pagar(200));
        }
    }
}
