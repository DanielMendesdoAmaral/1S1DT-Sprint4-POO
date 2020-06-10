namespace Aula_13___Projeto_uber_console
{
    public class Passageiro : Usuario
    {
        public Passageiro(string login, string senha, string nome, string foto, string localizacaoAtual) : base(login, senha, nome, foto, localizacaoAtual) {

        }

        private Cartao cartao;
        public Cartao Cartao
        {
            get { return cartao; }
            set { cartao = value; }
        }
        
        public string SolicitarMotorista() {
            if (TokenLogin!=null)
                return "MOTORISTA SOLICITADO COM SUCESSO!";
            else 
                return "ERRO! VOCÊ NÃO ESTÁ LOGADO.";
        }

        public bool Pagar() {
            if (SolicitarMotorista()=="MOTORISTA SOLICITADO COM SUCESSO!") {
                System.Console.WriteLine("PAGAMENTO EFETUADO COM SUCESSO!");
                return true;
            }
            else {
                return false;
            }
        }
    }
}