/*

Capacidade: 4. Demonstrar raciocínio lógico na organização das informações (24)
Tipo: Formativa

Nesta aula vamos aprender o conceito e a aplicação de recursividade, que é quando uma função/método chama que chama a si mesmo. A técnica recursiva permite a escrita de algoritmos mais claros e
precisos, especialmente problemas que possuem natureza recursiva, como por exemplo a sequência Fibonacci, Fatorial e Potênciação.

IMPORTANTE: Em todas as funções recursivas é obrigatório existir:
• Um caso base, ou condição de parada, cujo resultado é imediatamente
conhecido.
• Um passo recursivo em que se tenta resolver um sub-problema do
problema inicial.

*/

using System;

namespace Aula_25__Recursividade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            Recursividade.GerarSequênciaFibonacci(0, 1, 7);

            Console.WriteLine( Recursividade.GerarFatorial(5) ); 
        }
    }
}
