using System;

namespace Aula_13___Projeto_uber_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Conta conta = new Conta();
            conta.Agencia = "1234";
            conta._Conta = "1515151";
            
            Motorista m = new Motorista();
            m.Login = "Jr";
            m.Senha = "123";
            m.Nome = "Lauro";
            m.Foto = "3x4";
            m.LocalizacaoAtual = "São Mateus";
            m.Carro = "Siena";
            m.Conta=conta;

            Cartao cartao = new Cartao();
            cartao.Numero = "1234 1234 1234 1234";
            cartao.Titular = "Daniel Mendes do Amaral";
            cartao.Bandeira = "Visa";
            cartao.Cvv = "123";

            Passageiro p = new Passageiro();
            p.Login = "Daniel";
            p.Senha = "123";
            p.Cartao = cartao;
            System.Console.Write("LOGIN: ");
            string l = Console.ReadLine();
            System.Console.Write("SENHA: ");
            string s = Console.ReadLine();
            p.FazerLogin(l, s);
            System.Console.WriteLine($"{p.SolicitarMotorista()}\n{m.AceitarPassageiro(p)}\n");

            Pagamento p123456789 = new Pagamento();

            System.Console.WriteLine($"\nDADOS DO PAGAMENTO\n{p123456789.Data}\n{p123456789.Status}");

            Corrida c24574522 = new Corrida();
            c24574522.Inicio = "São Mateus";
            c24574522.Chegada = "Parque São Rafael";
            c24574522.Motorista = m;
            c24574522.Passageiro = p;
            System.Console.WriteLine($"\nDADOS DA CORRIDA: {c24574522.Inicio}\n{c24574522.Chegada}\n{c24574522.Motorista.Nome}\n{c24574522.Passageiro.Login}");

            
        }
    }
}
