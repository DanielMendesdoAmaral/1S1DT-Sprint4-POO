using System;

namespace Aula_11__Polimorfismo_por_sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculo c = new Calculo();

            Console.WriteLine($"{  c.Calcular()  }\n{  c.Calcular(5, 5, '+')  }\n{  c.Calcular("")  }\n{  c.Calcular("(7/5)*2")  }");
        }
    }
}
