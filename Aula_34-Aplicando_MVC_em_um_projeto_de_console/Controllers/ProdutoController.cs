using Aula_34_Aplicando_MVC_em_um_projeto_de_console.Models;
using Aula_34_Aplicando_MVC_em_um_projeto_de_console.Views;

namespace Aula_34_Aplicando_MVC_em_um_projeto_de_console.Controllers
{
    public class ProdutoController //Nome da classe + Controller
    {
        Produto produtoModel = new Produto();
        ProdutoView produtoView = new ProdutoView();

        /// <summary>
        ///     Devolve ao view uma lista processada pelo model.
        /// </summary>
        public void Listar() {
            produtoView.MostrarNoConsole( produtoModel.Ler() );
        }
    }
}