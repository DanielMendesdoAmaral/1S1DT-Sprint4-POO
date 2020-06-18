namespace Aula_20__Exercício_ifood
{
    public class Pedido
    {
        public string[] itens { get; set; }
        public Cliente cliente { get; set; }
        public Restaurante restaurante { get; set; }
        public string formaDePgto { get; set; }
        public bool pedidoPago { get; set; }

        public Pedido(string[] itens, Cliente cliente, Restaurante restaurante, string formaDePgto, bool pedidoPago) {
            this.itens=itens;
            this.cliente=cliente;
            this.restaurante=restaurante;
            this.formaDePgto=formaDePgto;
            this.pedidoPago=pedidoPago;
        }

        public string EntregarPedido() {
            return $"PEDIDO ENVIADO COM SUCESSO. DE {restaurante.nomeFantasia} PARA {cliente.nome}.\nTEMPO MÉDIO DE ESPERA: 30m";
        }
    }
}