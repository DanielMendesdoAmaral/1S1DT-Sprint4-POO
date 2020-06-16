/*

Capacidade: Utilizar o paradigma da programação orientada a objetos
Tipo: Formativa

No exercício de hoje faça o seguinte exercício em dupla, utilizando o Live Share do vs code:
Crie uma classe para representar um jogador de futebol, com os atributos nome, posição, data de nascimento, nacionalidade, altura e peso. Crie os métodos públicos necessários para sets e gets e também um método para imprimir todos os dados do jogador. 

	Desafio:
	- Crie um método para calcular a idade do jogador e outro método para mostrar quanto tempo falta para o jogador se aposentar. Para isso, considere que os jogadores da posição de defesa se aposentam em média aos 40 anos, os jogadores de meio-campo aos 38 e os atacantes aos 35.

	Dicas para conclusão do desafio:
	- Utilize um método(pesquise qual) para converter DateTime em String
	- Separe o DateTime utilizando o método Split() visto nas aulas anteriores

*/

/*

DUPLA:

DANIEL MENDES DO AMARAL
MURILO FERNANDES DELLIZE

*/

using System;

namespace Aula_18__Dojô_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Jogador jogador1 = new Jogador("Pelé", "Ataque", Convert.ToDateTime("1940-10-26"), 1.73, 80);
            string entrada;

            do {

                Console.WriteLine("Edson Arantes do Nascimento, mais conhecido como Pelé, é um ex-futebolista brasileiro que atuava como atacante. Ele é amplamente considerado como um dos maiores atletas de todos os tempos e até mesmo como o 'Rei do Futebol' por alguns.\n");
                Console.WriteLine("[1] Ver idade.\n[2] Verificar aposentadoria.\n[3] Sair.\n");
                
                Console.Write("ENTRADA: ");
                entrada = Console.ReadLine();

                switch (entrada) {
                    case "1":
                        Console.Clear();
                        LimpaTela($"Pelé tem {jogador1.CalcularIdade()} anos de idade.", 5);
                    break;
                    case "2":
                        Console.Clear();
                        LimpaTela(jogador1.VerificarAposentadoria(), 5);
                    break;
                }

            } while (entrada!="3");
            
        }

        static void LimpaTela(string m, int t) {
            int nt = t*1000;
            for (int c=t; c>=0; c--) {
                System.Console.WriteLine(m);
                System.Console.WriteLine($"Saindo em {c} segundos.");
                System.Threading.Thread.Sleep(1000);
                Console.Clear();
            }
            Console.Clear();
        }
    }
}