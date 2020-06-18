/*

Capacidade: Utilizar o paradigma da programação orientada a objetos
Tipo: Formativa

Na aula de hoje faremos o exercício de uma aplicação de serviço de entregas, utilizando o diagrama de classes disponível em anexo.

*/

using System;

namespace Aula_20__Exercício_ifood
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            Restaurante restaurante = new Restaurante("McDonald's", "Av. dos Estados, 6955 - Parque Central, Santo André - SP, 09210-580");

            string nome, endereco;

            Console.Clear();
            Console.Write("IFOOD\n\nDIGITE SEU NOME: ");
            nome=Console.ReadLine();
            Console.Write("DIGITE UM ENDEREÇO PARA A ENTREGA: ");
            endereco=Console.ReadLine();
            Console.Clear();
            Cliente cliente = new Cliente(nome, endereco);

            Console.Clear();

            Console.Write("Insira seus pedidos ao lado (separados por espaços e vírgula): ");
            string pedidos = Console.ReadLine();
            string[] itens = pedidos.Split(", ");
            
            Console.Write("Qual a forma de pagamento? ");
            string pagamento = Console.ReadLine();

            Pedido pedido = new Pedido(itens, cliente, restaurante, pagamento, false);

            Console.WriteLine(pedido.EntregarPedido());
        }
    }
}