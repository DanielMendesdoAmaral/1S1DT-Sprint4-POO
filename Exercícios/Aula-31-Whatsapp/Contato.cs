namespace Aula_31_Whatsapp
{
    public class Contato
    {
        //PROPRIEDADES
        public string Nome { get; set; }
        public string Telefone { get; set; }


        //CONSTRUTOR
        public Contato(string _nome, string _telefone) {
            this.Nome=_nome;
            this.Telefone=_telefone;
        }
    }
}