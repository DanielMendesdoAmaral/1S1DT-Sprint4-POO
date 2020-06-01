/*

Capacidade: Utilizar o paradigma da programação orientada a
objetos
Tipo: Formativa

Nesta atividade, realize o mesmo exemplo dado em sala, subindo o projeto para o Github com o titulo "Aula06Heranca", enviando o link do repositório como entrega dessa atividade
Crie um projeto de Console com a classe pai "Pessoa", e as classes filhas "CPF" e "CNPJ"

Exemplo da sintaxe em C# de herança:

public class CPF : Pessoa

comandos:
- dotnet new console
- dotnet run

class Pessoa
- string nome
+ string Saudacao(); (pode ser um texto simples)

class CPF
- string cpf
- string rg
+ bool ValidarCPF(string cpf); (pode ser um texto simples inicialmente)

class CNPJ
- string cnpj
- bool ValidarCNPJ(string cnpj); (pode ser um texto simples inicialmente)

*/

using System;

namespace Aula_6__Exercício
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa("Daniel");
            p.Saudar();

            System.Console.WriteLine();

            CPF pf = new CPF("Daniel", "000.000.000-00", "000.000.000-0");
            pf.ExibirDados();

            System.Console.WriteLine();

            CNPJ pj = new CNPJ("Junior", "");
            pj.ExibirDados();
        }
    }
}