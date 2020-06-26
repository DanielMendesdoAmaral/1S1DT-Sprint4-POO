/*

Capacidade: 13. Utilizar o paradigma da programação orientada a objetos
Tipo: Formativa

Nesta atividade incorpore na interface e em suas classes derivadas um método que calcule o total da compra, através da lista de produtos existentes;

Lembre-se das regras e boas práticas para construir interfaces em C#:
- As interfaces tem sua declaração com o termo interface ao invés de class. Ex: public interface ICarrinho{}
- Ela possui somente métodos
- Os métodos não possuem assinatura, somente tipo
- Ao utilizar uma interface em uma classe, TODOS os métodos declarados na interface precisam ser implantados nas classes herdarem essa determinada interface

*/

using System;

namespace Aula_26__Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            Carrinho cartSteam = new Carrinho();

            Produto p1 = new Produto(1, "GTA V", 34.99);
            Produto p2 = new Produto(2, "Red Dead Redemption", 139.99);
            Produto p3 = new Produto(3, "Battlefield V", 85.40);
            Produto p4 = new Produto(4, "Fortnite", 0);
            Produto p5 = new Produto(5, "COD Modern Warfare", 197.90);

            Produto p5PrecoAtualizado = new Produto(6, "COD Modern Warfare", 99);

            cartSteam.Adicionar(p1);
            cartSteam.Adicionar(p2);
            cartSteam.Adicionar(p3);
            cartSteam.Adicionar(p4);
            cartSteam.Adicionar(p5);

            cartSteam.Alterar(5, p5PrecoAtualizado);

            cartSteam.Remover(p3);

            cartSteam.Ler();

            cartSteam.MostrarValorTotal();
        }
    }
}
