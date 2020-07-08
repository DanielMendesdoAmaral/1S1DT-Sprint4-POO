using System;
using System.Collections.Generic;
using Aula_34_Aplicando_MVC_em_um_projeto_de_console.Models; //Colocamos a pasta onde se encontra a classe Produto.

namespace Aula_34_Aplicando_MVC_em_um_projeto_de_console.Views
{
    public class ProdutoView //Nome da classe + View
    {
        /// <summary>
        ///     Escreve no console dados sobre o produto.
        /// </summary>
        /// <param name="produtos">Uma lista de produtos.</param>
        public void MostrarNoConsole(List<Produto> produtos) {
            foreach(Produto produto in produtos) {
                Console.WriteLine($"{produto.Nome} - {produto.Preco:c}");
            }
        }
    }
}