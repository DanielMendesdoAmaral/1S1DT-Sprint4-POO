using System.Collections.Generic;

namespace Aula_31_Whatsapp
{
    public interface IAgenda
    {
        void Cadastrar(Contato contato);
        void Excluir(Contato contato);
        List<Contato> Listar();
    }
}