namespace Aula_13___Projeto_uber_console
{
    public class Corrida
    {
        private string inicio;
        public string Inicio
        {
            get { return inicio; }
            set { inicio = value; }
        }
        private string chegada;
        public string Chegada
        {
            get { return chegada; }
            set { chegada = value; }
        }
        private string statusCorrida;
        public string StatusCorrida
        {
            get { return statusCorrida; }
            set { statusCorrida = value; }
        }
        private Motorista motorista;
        public Motorista Motorista
        {
            get { return motorista; }
            set { motorista = value; }
        }
        private Passageiro passageiro;
        public Passageiro Passageiro
        {
            get { return passageiro; }
            set { passageiro = value; }
        }
        
        public string Cancelar() {
            inicio=null;
            chegada=null;
            statusCorrida=null;
            motorista=null;
            passageiro= null;
            return "A VIAGEM FOI CANCELADA COM SUCESSO!";
        }
    }
}