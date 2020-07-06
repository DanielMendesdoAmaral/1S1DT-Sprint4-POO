/*
Capacidades: 
13. Utilizar o paradigma da programação orientada a objetos
10. Manipular os diferentes tipos de dados na elaboração de programas
12. Utilizar técnicas de versionamento através de softwares específicos
9. Aplicar técnicas de código limpo (clean code)

Tipo: Formativa

Nesta atividade crie um sistema com o contexto similar ao do WhatsApp, aplicando o diagrama em anexo.

Regras:
- Utilize um método construtor para a classe Contato
- Crie uma interface para a agenda antes de criar a classe Agenda
- Implemente a interface utilizando control ponto
- Lembre-se de utilizar o método construtor para criar o arquivo .csv caso ele não exista
- Crie um arquivo .csv para a agenda apenas, salve as mensagens somente sobrar tempo
- Faça os métodos restantes do CRUD somente se sobrar tempo
- No program: pode instanciar Contatos diretamente e salvá-los utilizando os métodos da agenda
*/




/*
PONTOS A SEREM AJUSTADOS
- PascalCase - Métodos e propriedades (prop/profull).
- camelCase - Atributos, variáveis.
- _nomeVar - Parâmetros.
*/




//PARA VER ANTES DA CORREÇÃO, VOLTE UM COMMIT

using System;
using System.Collections.Generic;

namespace Aula_31_Whatsapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            Agenda agenda = new Agenda();

            Contato c1 = new Contato("Daniel", "99999-9999");
            Contato c2 = new Contato("Junior", "88888-8888"); 
            Contato c3 = new Contato("Maria", "77777-7777"); 
            Contato c4 = new Contato("Lauro", "66666-6666"); 

            /*agenda.Cadastrar(c1);
            agenda.Cadastrar(c2);
            agenda.Cadastrar(c3);
            agenda.Cadastrar(c4);*/

            Mensagem m1 = new Mensagem("Olá", c1);
            Mensagem m2 = new Mensagem("Como", c2);
            Mensagem m3 = new Mensagem("Você", c3);
            Mensagem m4 = new Mensagem("Está", c4);

            /*agenda.Cadastrar(m1.Enviar(c1));
            agenda.Cadastrar(m2.Enviar(c2));
            agenda.Cadastrar(m3.Enviar(c3));
            agenda.Cadastrar(m4.Enviar(c4));*/

            //agenda.Excluir(c1);

            //agenda.Alterar(c2, c3);

            foreach(Contato contato in agenda.Listar()) {
                Console.WriteLine($"{contato.Nome} - {contato.Telefone}");
            }
        }
    }
}