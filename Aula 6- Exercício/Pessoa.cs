namespace Aula_6__Exercício
{
    public class Pessoa
    {
        private string nome;

        public Pessoa(string n) {
            SetNome(n);
        }

        public string GetNome() {
            return nome;
        }
        public void SetNome(string n) {
            nome=n;
        }

        public void Saudar() {
            System.Console.WriteLine($"Olá, sou {nome}.");
        }
    }
}