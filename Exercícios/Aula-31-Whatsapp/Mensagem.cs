namespace Aula_31_Whatsapp
{
    public class Mensagem
    {
        //PROPRIEDADES
        public string Texto { get; set; }
        public Contato Destinatario { get; set; }


        //CONSTRUTOR
        public Mensagem(string _texto, Contato _destinatario) {
            this.Texto=_texto;
            this.Destinatario=_destinatario;
        }


        /// <summary>
        ///     Prepara para salvar no banco de dados.
        /// </summary>
        /// <param name="destinatario">Pessoa a quem a mensagem será enviada.</param>
        /// <returns>String pronta para ir para o banco de dados.</returns>
        public string Enviar(Contato _destinatario) {
            return $"Texto={this.Texto};Destinatario={_destinatario.Nome}";
        }
    }
}