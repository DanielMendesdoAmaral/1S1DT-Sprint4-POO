namespace Aula_20__Exercício_ifood
{
    public class Restaurante
    {
        public string nomeFantasia { get; set; }
        public string endereco { get; set; }

        public Restaurante(string nomeFantasia, string endereco) {
            this.nomeFantasia=nomeFantasia;
            this.endereco=endereco;
        }

        public string MostrarDados() {
            return $"NOME DO RESTAURANTE: {nomeFantasia}\nENDEREÇO: {endereco}";
        }
    }
}