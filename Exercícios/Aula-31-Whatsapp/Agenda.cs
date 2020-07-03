using System.Collections.Generic;
using System.IO;

namespace Aula_31_Whatsapp
{
    public class Agenda : IAgenda
    {
        //PROPRIEDADES
        public List<Contato> Contatos = new List<Contato>();
        private const string PATH = "Database/Agenda.csv";


        //CONSTRUTOR
        public Agenda() {
            if( !File.Exists(PATH) ) {
                Directory.CreateDirectory( PATH.Split("/")[0] );
                File.Create(PATH).Close();
            }
        }


        /// <summary>
        ///     Cadastra um contato no csv.
        /// </summary>
        /// <param name="contato">Contato a ser cadastrado no csv.</param>
        public void Cadastrar(Contato contato)
        {
            //Adiciona o contato na lista.
            Contatos.Add(contato);
            //Adiciona o contato no csv.
            string[] linha = new string[] { PrepararLinhaCSV(contato) };
            File.AppendAllLines(PATH, linha);
        }


        /// <summary>
        ///     Exclui um contato do csv.
        /// </summary>
        /// <param name="contato">Contato a ser excluído do csv.</param>
        public void Excluir(Contato contato)
        {
            //Remove o contato da lista.
            Contatos.Remove(contato);
            //Reescreve o csv após o contato tiver sido apagado.
            using(StreamWriter arquivo = new StreamWriter(PATH)) {

            }
        }

        public List<Contato> Listar()
        {
            return this.Contatos;
        }


        /// <summary>
        ///     Método interno que formata os dados de um registro, separando cada dado por um ";".
        /// </summary>
        /// <param name="contato">Contato que será incluído no csv.</param>
        /// <returns>Retorna uma string, já formatada, com cada dado separado por ";".</returns>
        private string PrepararLinhaCSV(Contato contato) {
            return $"Nome={contato.Nome};Telefone={contato.Telefone}";
        }
    }
}