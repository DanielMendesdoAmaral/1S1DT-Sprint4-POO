using System;

namespace Aula_10__Polimorfismo
{
    public class Player
    {
	//Os m�todos que ser�o sobrescritos t�m que ser virtual.

        public virtual void Pular() {
            Console.WriteLine("Pulou!");
        }

        public virtual void Correr() {
            Console.WriteLine("Correndo...");
        }
    }
}