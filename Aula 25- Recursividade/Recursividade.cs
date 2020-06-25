using System;

namespace Aula_25__Recursividade
{
    public static class Recursividade
    {
        public static void GerarSequênciaFibonacci(int x, int y, int vezes) {
            if(vezes>0) {
                Console.WriteLine(y);
                GerarSequênciaFibonacci(y, y+x, vezes-1);
            }
        }

        public static int GerarFatorial(int x) {
            if(x==1) 
                return 1;
            else 
                return x*GerarFatorial(x-1);
        }
    }
}