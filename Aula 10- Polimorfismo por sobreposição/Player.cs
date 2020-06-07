using System;

namespace Aula_10__Polimorfismo
{
    public class Player
    {
	//Os métodos que serão sobrescritos têm que ser virtual.

        public virtual void Pular() {
            Console.WriteLine("Pulou!");
        }

        public virtual void Correr() {
            Console.WriteLine("Correndo...");
        }
    }
}