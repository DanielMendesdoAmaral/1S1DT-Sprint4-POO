namespace Aula_20__Exercício_ifood
{
    public class Cliente
    {
        public string nome { get; set; }
        public string enderecoAtual { get; set; }

        public Cliente(string nome, string enderecoAtual) {
            this.nome=nome;
            this.enderecoAtual=enderecoAtual;
        }

        public string MostrarDados() {
            return $"NOME: {nome}\nENDEREÇO ATUAL: {enderecoAtual}";
        }
    }
}