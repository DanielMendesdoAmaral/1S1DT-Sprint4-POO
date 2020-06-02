namespace Aula_8__Abstração
{
    public class CartaoCredito : Cartao
    {
        public double limite {get; set;}

        public void AumentarLimite(double v) {
            limite+=v;
        }
        public string Bloquear() {
            return "Cartão bloqueado.";
        }
    }
}