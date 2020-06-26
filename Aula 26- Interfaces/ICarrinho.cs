namespace Aula_26__Interfaces
{
    public interface ICarrinho
    {
        void Adicionar(Produto produto);
        void Ler();
        void Alterar(int codigo, Produto produto);
        void Remover(Produto produto);
        void MostrarValorTotal();
    }
}