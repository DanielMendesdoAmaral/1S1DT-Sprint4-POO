using System.Collections.Generic;
using System.IO;

namespace Aula_31_Whatsapp
{
    public class Agenda : IAgenda
    {
        //PROPRIEDADES/ATRIBUTOS
        public List<Contato> contatos = new List<Contato>();
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
        public void Cadastrar(Contato _contato)
        {
            //Adiciona o contato no csv.
            string[] linha = new string[] { PrepararLinhaCSV(_contato) };
            File.AppendAllLines(PATH, linha);
        }


        /// <summary>
        ///     Cadastra uma mensagem no banco de dados.
        /// </summary>
        /// <param name="mensagemEnviada">É uma string, pronta para entrar no banco de dados, que deve ser retornada a partir do método da classe "Mensagem": Enviar(Contato destinatario). </param>
        public void Cadastrar(string _mensagemEnviada) {
            string[] linha = new string[] { _mensagemEnviada };
            File.AppendAllLines(PATH, linha);
        }


        /// <summary>
        ///     Exclui um contato do csv.
        /// </summary>
        /// <param name="contato">Contato a ser excluído do csv.</param>
        public void Excluir(Contato _contato)
        {
            //Cria uma lista a ser usada como um "backup". 
            List<string> linhas = new List<string>();
            //Verifica se no csv tem algum contato igual ao especificado. Se tiver, o remove. Se não, o adiciona.
            string linha;
            using(StreamReader arquivo = new StreamReader(PATH)) {
                while(( linha=arquivo.ReadLine()) != null) {
                    if( !((linha.Contains(_contato.Nome)) && (linha.Contains(_contato.Telefone))) )
                        linhas.Add(linha);
                }
            }
            //Sobrescreve o csv, agora atualizado. 
            ReescreverCSV(linhas);
        }


        /// <summary>
        ///     Visualizar os contatos registrados no banco de dados.
        /// </summary>
        /// <returns>Retorna uma lista com todos os contatos do banco de dados.</returns>
        public List<Contato> Listar()
        {
            string[] linhas = File.ReadAllLines(PATH);
            string[] dados = new string[2];
            //Percorre cada linha do csv, separando, para cada linha ou registro, seus específicos dados, que estão separados por ";". Cria objetos para cada registro do banco de dados se utilizando dos dados separados aqui.
            foreach(string linha in linhas) {
                //Este if impede de listar mensagens, apenas contatos.
                if(linha.Split(";")[0].Split("=")[0]=="Nome") {
                    //NOME
                    //Nome=String;Telefone=String -> No primeiro split, pega-se a parte "Nome=String". No segundo slipt, pega-se a parte "String".
                    dados[0]=linha.Split(";")[0].Split("=")[1];
                    //TELEFONE
                    dados[1]=linha.Split(";")[1].Split("=")[1];
                    //Cria-se o objeto e o adicionamos na lista de Contatos.
                    contatos.Add( new Contato(dados[0], dados[1]) );
                }
            }
            return contatos;
        }


        /// <summary>
        ///     Remove o contato a ser atualizado e cadastra o atualizado.
        /// </summary>
        /// <param name="antes">Contato a ser atualizado.</param>
        /// <param name="depois">Contato atualizado.</param>
        public void Alterar(Contato _antes, Contato _depois) {
            Excluir(_antes);
            Cadastrar(_depois);
        }


        /// <summary>
        ///     Formata os dados de um registro, separando cada dado por um ";".
        /// </summary>
        /// <param name="contato">Contato que será incluído no csv.</param>
        /// <returns>Retorna uma string, já formatada, com cada dado separado por ";".</returns>
        private string PrepararLinhaCSV(Contato _contato) {
            return $"Nome={_contato.Nome};Telefone={_contato.Telefone}";
        }


        /// <summary>
        ///     Reescreve o csv a partir de uma espécie de backup.
        /// </summary>
        /// <param name="linhas">O "backup".</param>
        private void ReescreverCSV(List<string> _linhas) {
            using(StreamWriter arquivo = new StreamWriter(PATH)) {
                foreach(string linha in _linhas) {
                    arquivo.WriteLine(linha);
                }
            }
        }
    }
}