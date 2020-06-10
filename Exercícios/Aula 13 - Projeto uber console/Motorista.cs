namespace Aula_13___Projeto_uber_console
{
    public class Motorista : Usuario
    {
        public Motorista(string login, string senha, string nome, string foto, string localizacaoAtual, string carro, string placa) : base(login, senha, nome, foto, localizacaoAtual) {
            Carro=carro;
            Placa=placa;
        }

        private string carro;
        public string Carro
        {
            get { return carro; }
            set { carro = value; }
        }
        private string placa;
        public string Placa
        {
            get { return placa; }
            set { placa = value; }
        }
        private Conta conta;
        public Conta Conta
        {
            get { return conta; }
            set { conta = value; }
        }
        
        public string AceitarPassageiro(Passageiro p) {
            return $"PASSAGEIRO {p.Login} ACEITO COM SUCESSO!";
        }

        public bool ReceberPagamento(Passageiro p) {
            if (p.Pagar() == true) {
                System.Console.WriteLine("PAGAMENTO ACEITO PELO MOTORISTA! TENHA UM BOM DIA!");
                return true;
            }
            else 
                return false;
        }
    }
}