using System;

namespace Aula_10__Polimorfismo
{
    public class Relatorio
    {
        public DateTime data {get; set;}

        public virtual void MostrarRelatorio() {
            Console.WriteLine("Mostrando relatórios gerais.");
        }
    }
}