using System.Collections.Generic;
using System.IO;
using System;

namespace Aulas_27_30_CRUD
{
    public class Produto
    {
        //PROPRIEDADES
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        private const string PATHDIRECTORY = "C:\\Users\\Juninho\\Desktop\\Códigos Daniel\\1S1DT-Sprint4-POO\\Aulas_27-30-CRUD\\Database"; //Caminho do diretório onde ficará o arquivo csv.
        private const string PATHARCHIVE = "Database/Produto.csv"; //Diretório onde o arquivo será criado.

        //CONSTRUTOR
        public Produto(int codigo, string nome, double preco) {
            this.Codigo=codigo;
            this.Nome=nome;
            this.Preco=preco;

            //Primeiro, verifica-se a existência do diretório. Se este não existir, será criado aqui.
            if(!Directory.Exists(PATHDIRECTORY)) {
                Directory.CreateDirectory(PATHDIRECTORY);
            }
            //A partir daqui, o diretório já existe. Então, verifica-se a existência do arquivo. Se este não existir, será criado aqui.
            if(!File.Exists(PATHARCHIVE)) {
                File.Create(PATHARCHIVE).Close(); //Cria-se e logo em seguida o fecha. Sempre faça isso se possível.
            }
        }

        /// <summary>
        ///     Para registrar dados em arquivos csv, necessita-se que os dados estejam separados por "," ou ";". Este método faz isso. É um método interno.
        /// </summary>
        /// <returns>Retorna a string já formatada, com todos os dados já formatados.</returns>
        private string PrepararLinha() {
            return $"{this.Codigo};{this.Nome};{this.Preco}";
        }

        /// <summary>
        ///     Cadastra o produto no banco de dados.
        /// </summary>
        public void Cadastrar() {
            //Para utilizar o AppendAllLines, necessita-se de um array. Por isso criamos um array básico apenas para resolver o problema, e inserimos nele a nossa string que já tem os dados formatados.
            var linha = new string[] {PrepararLinha()}; 
            //Este método necessita do caminho onde se quer gravar os dados e de um array de dados.
            File.AppendAllLines(PATHARCHIVE, linha);
        }

        /// <summary>
        ///     Pega todas as linhas do banco de dados e guarda em um array. Em seguida, percorre-se cada linha deste array e separa todos os dados em outro array. Em seguida instancia-se um objeto com todos esses dados (um objeto para cada registro do banco de dados) e o adiciona em uma lista de produtos. Em seguida, retorna-se esta lista.
        /// </summary>
        /// <returns>Uma lista com todos os produtos.</returns>
        public static List<Produto> Ler() {
            List<Produto> produtos = new List<Produto>();
            //Array que em cada posição guarda uma linha do banco de dados.
            string[] linhas = File.ReadAllLines(PATHARCHIVE);

            //Agora percorremos todos os registros, todas as linhas do banco de dados.
            foreach(string linha in linhas) {
                //Separamos agora cada dado de cada linha.
                string[] dado = linha.Split(";");
                //Criamos um novo produto passando os dados já separados.
                Produto produto = new Produto( Int32.Parse(dado[0]), dado[1], Double.Parse(dado[2]) );
                //Adicionamos o produto na lista de produtos, que será retornada assim que todos os produtos estiverem nela.
                produtos.Add(produto);
            }

            return produtos;
        }

        /// <summary>
        ///     Uma sobrecarga do método Ler() que reaproveita o próprio método Ler() para achar uma instância com o nome especificado por um parâmetro.
        /// </summary>
        /// <param name="nome">Nome para filtro.</param>
        /// <returns>Retorna uma lista com todos os objetos com o nome especificado.</returns>
        public static List<Produto> Ler(string nome) {
            List<Produto> produtos = new List<Produto>();
            foreach( Produto produto in Ler() ) {
                if(produto.Nome==nome) {
                    produtos.Add(produto);
                }
            }
            return produtos;
        }
    }
}