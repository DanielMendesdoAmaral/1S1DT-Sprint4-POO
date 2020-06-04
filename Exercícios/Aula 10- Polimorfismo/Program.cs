/*

Capacidade: Utilizar o paradigma da programação orientada a objetos
Tipo: Formativa
	Nesta atividade crie as classes:
	
	Relatorio
	- datetime data
	+ public virtual void MostrarRelatorio();
		ConsoleWriteLine("Mostrando relatório geral");
	
	
	Mensal : Relatorio
	+ public override void MostrarRelatorio();
		base.MostrarRelatorio();
		ConsoleWriteLine("Mostrando relatório por mês");

	Anual : Relatorio
	+ public override void MostrarRelatorio();
		base.MostrarRelatorio();
		ConsoleWriteLine("Mostrando relatório por ano");
	
	Chame todos os métodos criados no Program.cs, através de instâncias das classes filhas.
	Suba a atividade para um repositório no github chamado "RelatoriosPOO" e entregue o link como envio desta atividade

*/

using System;

namespace Aula_10__Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CLASSE RELATÓRIO:");
            Relatorio r = new Relatorio();
            r.MostrarRelatorio();

            System.Console.WriteLine();

            Console.WriteLine("CLASSE MENSAL:");
            Mensal m = new Mensal();
            m.MostrarRelatorio();

            System.Console.WriteLine();

            Console.WriteLine("CLASSE ANUAL:");
            Anual a = new Anual();
            a.MostrarRelatorio();
        }
    }
}
