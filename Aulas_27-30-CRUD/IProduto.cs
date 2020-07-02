using System.Collections.Generic;

namespace Aulas_27_30_CRUD
{
    public interface IProduto
    {
        void Cadastrar(Produto produto);
        List<Produto> Ler();
        void Alterar(Produto produtoAlterado);
        void Remover(string termo);
    }
}