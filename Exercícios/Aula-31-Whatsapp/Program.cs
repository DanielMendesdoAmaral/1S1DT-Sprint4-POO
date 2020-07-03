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

using System;
using System.Collections.Generic;

namespace Aula_31_Whatsapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Agenda agenda = new Agenda();
            Contato c = new Contato("Daniel", "999999");
            agenda.Cadastrar(c);
        }
    }
}