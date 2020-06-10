using System;

namespace Aula_13___Projeto_uber_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            string login=null, senha=null, opcao=null;

            Motorista motorista = new Motorista("LauroJr", "123", "Lauro", "3x4", "São Mateus", "Honda Civic", "ABC-1234");
            Passageiro passageiro = new Passageiro("DanielM", "123", "Daniel", "3x4", "São Mateus");
            Ler("LOGIN: ", ref login);
            Ler("SENHA: ", ref senha);
            passageiro.FazerLogin(login, senha);
            Apagar(2);

            Ler("Você quer pedir um uber? [S/N] ", ref opcao);

            switch (opcao) {
                case ("S"):
                    System.Console.WriteLine(passageiro.SolicitarMotorista());
                    System.Console.WriteLine($"NOME DO MOTORISTA: {motorista.Nome}\nMODELO DO CARRO: {motorista.Carro}\nPLACA DO CARRO: {motorista.Placa}");
                    Ler("Selecione seu destino: ", ref opcao);
                    Apagar(3);
                    System.Console.WriteLine("Viagem finalizada com sucesso. Efetue o pagamento.");
                    passageiro.Pagar();
                    motorista.ReceberPagamento(passageiro);
                break;
            }
        }

        static void Ler(string mensagem, ref string variavel) {
            System.Console.Write(mensagem);
            variavel = Console.ReadLine();
        }

        static void Apagar(int segundos) {
            segundos = segundos*1000;
            System.Threading.Thread.Sleep(segundos);
            Console.Clear();
        }
    }
}
