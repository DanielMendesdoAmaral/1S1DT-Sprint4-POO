using System;

namespace Aula_7__Encapsulamento
{
    public class Cartao
    {
        public string numero {get; set;}
        public string bandeira {get; set;}
        private string token {get; set;} = "se5f21r5g1t5h1jfy5j1ygu51uhoi51i5o1i51op1ok451";
        protected int cvv {get; set;}

        /// <summary>
        /// Auxiliar para retornar e setar os valores de cvv, mesmo ele sendo protected você conseguirá.
        /// </summary>
        /// <value>Se solicitado, retorna o cvv</value>
        public int GetSetCvv {
            get {
                return cvv;
            }
            set {
                cvv=value;
            }
        }

        /// <summary>
        /// Se o validar compra der true, a compra está aprovada.
        /// </summary>
        /// <returns>Retorna mensagens positivas caso a compra seja aprovada e negativas caso a compra seja reprovada.</returns>
        public string AprovarCompra() {
            if (ValidarCompra()==false) 
                return "A compra não foi aprovada pois faltam dados sobre o pagamento ou os dados inseridos são inválidos.";
            else 
                return "A compra foi aprovada.";
        }

        /// <summary>
        /// Valida se o token é nulo.
        /// </summary>
        /// <returns>Se o token for nulo retorna fals, se não, retorna true.</returns>
        private bool ValidarToken() {
            if (token==null)
                return false;
            else 
                return true;
        }

        /// <summary>
        /// Valida a compra.
        /// </summary>
        /// <returns>Se os dados forem nulos ou incorretos, retorna falsa e consequentemente desaprova a compra. Se não, envia true e aprova a compra.</returns>
        protected bool ValidarCompra() {
            if ((numero == null) || (bandeira == null) || (ValidarToken()==false) || ((cvv/100<1) || (cvv/100>99.99))) 
                return false;
            else 
                return true;
        }
    }
}