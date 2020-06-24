using System;
using System.Collections.Generic;

namespace Aula_24__Objetos_como_argumento___CRUD
{
    public class Carrinho
    {
        private double _valorTotal;
        public double ValorTotal
        {
            get { return _valorTotal; }
            set { _valorTotal = value; }
        }
        public List<Produto> carrinho = new List<Produto>();

        /// <summary>
        ///     Adiciona um produto dentro do carrinho.
        /// </summary>
        /// <param name="produto">Objeto a ser adicionado no carrinho.</param>
        public void Criar(Produto produto) {
            this.carrinho.Add(produto);
        }

        /// <summary>
        ///     Mostra os produtos no console.
        /// </summary>
        public void Ler() {
            foreach(Produto produto in carrinho) {
                Console.WriteLine($"{produto.Nome} - {produto.Preco:c}");
            }
        }

        /// <summary>
        ///     Atualiza qualquer produto do carrinho. Para isso, você deverá informar o código do produto a ser modificado e um novo objeto com nome e preço atualizado.
        /// </summary>
        /// <param name="codigo">Código do produto a ser modificado.</param>
        /// <param name="novoProduto">Novo produto contendo as novas informações.</param>
        public void Atualizar(int codigo, Produto novoProduto) {
            this.carrinho.Find(produto => produto.Codigo == codigo).Nome=novoProduto.Nome; //1- Achamos no carrinho o produto que tem o código especificado. 2- Depois alteramos o nome deste produto de acordo com o nome do novo objeto criado. 
            this.carrinho.Find(produto => produto.Codigo == codigo).Preco=novoProduto.Preco; //Fazemos a mesma coisa com o preço.
        }

        /// <summary>
        ///     Deleta um produto do carrinho.
        /// </summary>
        /// <param name="produto">Produto a ser deletado.</param>
        public void Deletar(Produto produto) {
            this.carrinho.Remove(produto);
        }

        /// <summary>
        ///     Calcula e retorna o preço total de todos os produtos do carrinho.
        /// </summary>
        /// <returns>O valor total de produtos contidos no carrinho.</returns>
        public double CalcularValorTotal() {
            foreach(Produto produto in carrinho) {
                ValorTotal+=produto.Preco;
            }
            return ValorTotal;
        }
    }
}