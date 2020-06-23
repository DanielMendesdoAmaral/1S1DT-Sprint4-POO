/*

Capacidade: Utilizar o paradigma da programação orientada a objetos
Tipo: Formativa

Nesta atividade faça o mesmo exemplo dado em aula, incrementando com uma classe Cartao, com seus devidos métodos construtores e atributos: titular, numero, bandeira, vencimento e cvv;
Crie uma lista de cartões no Program.cs, utilize foreach para mostrar para o usuário os cartões instanciados.

*/

using System;
using System.Collections.Generic;

namespace Aula_23__Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            //Nossa lista de produtos
            List<Produto> produtos = new List<Produto>();

            //Instância 1
            Produto p1 = new Produto(0, "Televisão SONY", 3999.99);

            //Adicionando o produto na lista
            produtos.Add(p1);

            //Instanciando e adicionando novos objetos na lista
            produtos.Add( new Produto(1, "Televisão LG", 2999.99) );
            produtos.Add( new Produto(2, "Playstation 5", 1799.99) );
            produtos.Add( new Produto(3, "Processador Intel I9", 3699.99) );
            produtos.Add( new Produto(4, "Microondas", 469.99) );
            produtos.Add( new Produto(5, "Microondas", 319.99) );

            //Percorrendo a lista e mostrando no console
            foreach(Produto produto in produtos) {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"{produto.Nome} - {produto.Preco:c}");
                Console.ResetColor();
            }

            //Removendo um item da lista
            produtos.Remove(p1); //Aqui entra o objeto

            //Removendo a partir de um índice
            produtos.RemoveAt(2);

            //Removendo utilizando a expressão lambda
            produtos.RemoveAll(produto => produto.Nome=="Microondas"); //Irá remover todo microondas

            //Percorrendo a nova lista
            foreach(Produto produto in produtos) {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"{produto.Nome} - {produto.Preco:c}");
                Console.ResetColor();
            }

            Cartao c1 = new Cartao("Daniel", "1234 1234 1234 1234", "MasterCard", Convert.ToDateTime("2003-08-13"), 123);

            List<Cartao> cartoes = new List<Cartao>();

            cartoes.Add(c1);
            cartoes.Add( new Cartao("Junior", "1234 1234 1234 1234", "Elo", Convert.ToDateTime("1992-04-25"), 123) );
            cartoes.Add( new Cartao("Maria", "1234 1234 1234 1234", "Visa", Convert.ToDateTime("1960-04-25"), 123) );
            cartoes.Add( new Cartao("Lauro", "1234 1234 1234 1234", "MasterCard", Convert.ToDateTime("1938-04-25"), 123) );

            foreach(Cartao cartao in cartoes) {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"{cartao.Titular} - {cartao.Numero}");
                Console.ResetColor();
            }
        }
    }
}