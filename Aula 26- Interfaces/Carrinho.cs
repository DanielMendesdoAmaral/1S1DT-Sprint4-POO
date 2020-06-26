using System;
using System.Collections.Generic;

namespace Aula_26__Interfaces
{
    public class Carrinho : ICarrinho
    {
        public double ValorTotal { get; set; }

        public List<Produto> carrinho = new List<Produto>();

        public void Adicionar(Produto produto)
        {
            carrinho.Add(produto);
        }

        public void Alterar(int codigo, Produto produto)
        {
            carrinho.Find(produto => produto.Codigo==codigo).Nome=produto.Nome;
            carrinho.Find(produto => produto.Codigo==codigo).Preco=produto.Preco;
        }

        public void Ler()
        {
            Console.ForegroundColor=ConsoleColor.Gray;
            foreach(Produto produto in carrinho) {
                Console.WriteLine($"{produto.Nome} - {produto.Preco:c}");
            }
            Console.ResetColor();
        }

        public void MostrarValorTotal()
        {
            foreach(Produto produto in carrinho) {
                this.ValorTotal+=produto.Preco;
            }
            Console.ForegroundColor=ConsoleColor.DarkGreen;
            Console.WriteLine($"VALOR TOTAL DA COMPRA: {this.ValorTotal}");
            Console.ResetColor();
        }

        public void Remover(Produto produto)
        {
            carrinho.Remove(produto);
        }
    }
}