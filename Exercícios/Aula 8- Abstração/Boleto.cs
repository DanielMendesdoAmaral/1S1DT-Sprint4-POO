using System;

namespace Aula_8__Abstração
{
    public class Boleto : Pagamento
    {
        public DateTime dataVencimento {get; set;}
        public string bancoEmissor {get; set;}
        public string codigoBarras {get; set;}

        public string RegistrarNoSistema() {
            return "Boleto registrado no sistema.";
        }
    }
}