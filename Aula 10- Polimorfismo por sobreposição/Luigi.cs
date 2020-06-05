using System;

namespace Aula_10__Polimorfismo
{
    public class Luigi : Player
    {
        override public void Pular() {
            Console.WriteLine("Pulou mais alto!");
        }

        override public void Correr() {
            base.Correr();
            Console.WriteLine("O Luigi corre normalmente.");
        }
    }
}