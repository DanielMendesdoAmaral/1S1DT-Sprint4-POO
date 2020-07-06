using System.Collections.Generic;

namespace Aula_31_Whatsapp
{
    public interface IAgenda
    {
        void Cadastrar(Contato _contato);

        void Excluir(Contato _contato);
        
        List<Contato> Listar();
    }
}