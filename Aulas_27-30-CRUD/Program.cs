//CRUD feito em 4 aulas. 
//Desafio proposto na aula 27 solucionado: Apagar a pasta e o arquivo .csv gera um erro. Para isso, eu decidi criar a pasta separada do arquivo. Assim, toda vez que um deles forem apagados, ao rodar o programa novamente não irá gerar o erro.
//Desafio proposto na aula 28 solucionado: Faça um método que aproveite o método Ler() para realizar uma busca por nome, passado como argumento. Dica: utilize expressão Lambda. Com a expressão lambda só estava conseguindo printar 1.. mas com o if consegui achar todos os que tem o nome especificado.
//Desafio proposto na aula 30 solucionado: Refatore o código criando e implementando uma interface para Produto, contendo apenas os métodos do CRUD.

using System;

namespace Aulas_27_30_CRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            Produto p = new Produto(0, "GTA V", 0);
            Produto p1 = new Produto(1, "Red Dead Redemption II", 152.42);
            Produto p2 = new Produto(2, "The Last of Us Part II", 199.99);
            Produto p3 = new Produto(3, "Fortnite", 0);
            Produto p4 = new Produto(4, "Battlefield V", 99.99);
            Produto p5 = new Produto(4, "Battlefield V", 85.40);
            Produto p4e5Alterado = new Produto(4, "Call of Duty: Modern Warfare", 189.97);

            //Cadastrando produtos no bd.
            /*p.Cadastrar(p);
            p1.Cadastrar(p1);
            p2.Cadastrar(p2);
            p3.Cadastrar(p3);
            p4.Cadastrar(p4);
            p5.Cadastrar(p5);*/

            //Mostrando no console todos os produtos cadastrados.
            Console.WriteLine("MOSTRANDO TODOS OS PRODUTOS CADASTRADOS:");
            foreach( Produto produto in p.Ler() ) {
                Console.WriteLine($"{produto.Nome} - {produto.Preco}");
            }

            Console.WriteLine();

            //Alterando todos os produtos que tenham o código 4
            p.Alterar(p4e5Alterado);

            //Deletando os gratuitos
            p.Remover("0");

            //Mostrando no console todos os produtos já alterados.
            Console.WriteLine("MOSTRANDO TODOS OS PRODUTOS, JÁ ALTERADOS:");
            foreach( Produto produto in p.Ler() ) {
                Console.WriteLine($"{produto.Nome} - {produto.Preco}");
            }
        }
    }
}