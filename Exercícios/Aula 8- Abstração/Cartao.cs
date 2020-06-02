namespace Aula_8__Abstração
{
    public class Cartao : Pagamento
    {
        protected string token = "wgegfs5fes8f4e8f4efse89f4e89f489saef98a4wd8a9wd4a8wd4a98wd";
        public string bandeira {get; set;}
        public string numero {get; set;}
        public string titular {get; set;}
        public int cvv {get; set;}

        public string ValidarToken() {
            if (token == null)
                return "Token inválido.";
            else 
                return "Token válido.";
        }
    }
}