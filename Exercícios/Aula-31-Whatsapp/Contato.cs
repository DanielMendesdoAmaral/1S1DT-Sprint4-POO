namespace Aula_31_Whatsapp
{
    public class Contato
    {
        //PROPRIEDADES
        public string Nome { get; set; }
        public string Telefone { get; set; }


        //CONSTRUTOR
        public Contato(string nome, string telefone) {
            this.Nome=nome;
            this.Telefone=telefone;
        }
    }
}