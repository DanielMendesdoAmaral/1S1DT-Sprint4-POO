using System;

namespace Aula_10__Polimorfismo
{
    public class Mensal : Relatorio 
    {
        public override void MostrarRelatorio() {
            base.MostrarRelatorio();
            Console.WriteLine("Mostrando relatórios mensais.");
        }
    }
}