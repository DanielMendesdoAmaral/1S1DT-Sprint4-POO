//Usuário do sistema = Cliente do restaurante. 
//Quando o cliente faz o pedido, ele faz este pedido ao garçom. Da mesma forma, o usuário, quando faz uma requisição, o faz ao controller. 
//O garçom leva este pedido até a cozinha, onde o pedido do cliente será preparado e processado. Da mesma forma, o controller leva o pedido até o model, onde os dados serão processados, talvez alterados, excluídos, etc. 
//Por fim, o garçom traz o pedido, já preparado, até a mesa do cliente. Da mesma forma, todo o processo será mostrado pro usuário, ou trazido até ele, pela view.

using System;
using Aula_34_Aplicando_MVC_em_um_projeto_de_console.Controllers;

namespace Aula_34_Aplicando_MVC_em_um_projeto_de_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            //Aqui usamos o controller, pois ele tem acesso à todas as classes. Ele é o controlador, o garçom, o que transita com as requisições entre a view e o model.
            ProdutoController controller = new ProdutoController();
            controller.Listar();
        }
    }
}
