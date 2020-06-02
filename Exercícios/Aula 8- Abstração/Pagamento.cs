using System;

namespace Aula_8__Abstração
{
    public class Pagamento
    {
        public DateTime data {get; set;}
        public double valor {get; set;}

        public string Pagar(double v) {
            return "Conta paga no valor de R$" + v;
        }

        public string Cancelar() {
            return "Conta cancelada.";
        }
    }
}