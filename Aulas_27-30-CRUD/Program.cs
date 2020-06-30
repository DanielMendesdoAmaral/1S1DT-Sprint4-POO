//CRUD feito em 4 aulas. 
//Desafio proposto na aula 27 solucionado: Apagar a pasta e o arquivo .csv gera um erro. Para isso, eu decidi criar a pasta separada do arquivo. Assim, toda vez que um deles forem apagados, ao rodar o programa novamente não irá gerar o erro.
//Desafio proposto na aula 28 solucionado: Faça um método que aproveite o método Ler() para realizar uma busca por nome, passado como argumento. Dica: utilize expressão Lambda. Com a expressão lambda só estava conseguindo printar 1.. mas com o if consegui achar todos os que tem o nome especificado.

using System;

namespace Aulas_27_30_CRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto(6, "GTA V", 0);

            Console.Clear();
            
            //Percorremos cada produto de nossa lista de produtos do método Ler().
            foreach( Produto produto in p.Ler() ) {
                Console.WriteLine($"{produto.Nome} - {produto.Preco}");
            }

            Console.WriteLine();

            //Mostramos no console os produtos com nome de GTA V
            foreach( Produto produto in p.Ler("GTA V") ) {
                Console.WriteLine($"{produto.Nome} - {produto.Preco}");
            }
        }
    }
}
