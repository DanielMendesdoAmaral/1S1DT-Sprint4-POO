namespace Aula_8__Abstração
{
    public class CartaoDebito : Cartao
    {
        public double saldo {get; set;}

        public string Transferir(double v, string p) {
            return $"O valor de R${v} foi transferido para {p}.";
        }
        public string PagarTitulo() {
            return "Título pago com sucesso.";
        }
    }
}