//CRUD feito em 4 aulas. 
//Desafio proposto na aula 27 solucionado: Apagar a pasta e o arquivo .csv gera um erro. Para isso, eu decidi criar a pasta separada do arquivo. Assim, toda vez que um deles forem apagados, ao rodar o programa novamente não irá gerar o erro.

using System;

namespace Aulas_27_30_CRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto(1, "GTA V", 34.99);
            Produto p2 = new Produto(2, "Red Dead Redemption", 139.99);
            Produto p3 = new Produto(3, "Battlefield V", 85.40);
            Produto p4 = new Produto(4, "Fortnite", 0);
            Produto p5 = new Produto(5, "COD Modern Warfare", 197.90);

            p1.Cadastrar();
            p2.Cadastrar();
            p3.Cadastrar();
            p4.Cadastrar();
            p5.Cadastrar();
        }
    }
}
