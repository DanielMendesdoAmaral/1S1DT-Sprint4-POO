using System;

namespace Aula_10__Polimorfismo
{
    public class Player
    {
        public virtual void Pular() {
            Console.WriteLine("Pulou!");
        }

        public virtual void Correr() {
            Console.WriteLine("Correndo...");
        }
    }
}