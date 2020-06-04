using System;

namespace Aula_10__Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p = new Player();
            p.Pular();
            p.Correr();

            System.Console.WriteLine();

            Mario m = new Mario();
            m.Pular();
            m.Correr();

            System.Console.WriteLine();

            Luigi l = new Luigi();
            l.Pular();
            l.Correr();
        }
    }
}
