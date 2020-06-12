using System;

namespace Aula_16__Método_construtor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Produto tenis = new Produto(1, "Nike Air Max.", 250.00, "Tênis casual.");
            Console.WriteLine( tenis.DescreverProduto() );
        }
    }
}
