namespace Aula_13___Projeto_uber_console
{
    public class Pagamento
    {
        private System.DateTime data;
        public System.DateTime Data
        {
            get { return data; }
            set { data = System.DateTime.Today; }
        }
        private string status;
        public string Status
        {
            get { return status; }
            set { 
                if (passageiro.Pagar() == true) 
                    status = "PAGAMENTO REALIZADO COM SUCESSO!";
                else 
                    status = "ERRO! PAGAMENTO MAL SUCEDIDO!";
            }
        }
        private Passageiro passageiro;
        public Passageiro Passageiro
        {
            get { return passageiro; }
            set { passageiro = value; }
        }
        private Motorista motorista;
        public Motorista Motorista
        {
            get { return motorista; }
            set { motorista = value; }
        }
    }
}