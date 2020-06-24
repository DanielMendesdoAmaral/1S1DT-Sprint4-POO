using System;

namespace Aula_24__Objetos_como_argumento___CRUD
{
    class Program
    {
        //Create
        //Read
        //Update
        //Delete
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

            cartSteam.Criar(p1);
            cartSteam.Criar(p2);
            cartSteam.Criar(p3);
            cartSteam.Criar(p4);
            cartSteam.Criar(p5);

            cartSteam.Atualizar(5, p5PrecoAtualizado);

            cartSteam.Deletar(p3);

            cartSteam.Ler();

            Console.ForegroundColor=ConsoleColor.DarkGreen;
            Console.WriteLine( $"PREÇO TOTAL: { cartSteam.CalcularValorTotal() }" );
            Console.ResetColor();
        }
    }
}
