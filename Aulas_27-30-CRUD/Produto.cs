using System.Collections.Generic;
using System.IO;
using System;
using System.Linq;

namespace Aulas_27_30_CRUD
{
    public class Produto : IProduto
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
        private string PrepararLinha(Produto produto) {
            return $"{produto.Codigo};{produto.Nome};{produto.Preco}";
        }

        /// <summary>
        ///     Cadastra o produto no banco de dados.
        /// </summary>
        public void Cadastrar(Produto produto) {
            //Para utilizar o AppendAllLines, necessita-se de um array. Por isso criamos um array básico apenas para resolver o problema, e inserimos nele a nossa string que já tem os dados formatados.
            var linha = new string[] {PrepararLinha(produto)}; 
            //Este método necessita do caminho onde se quer gravar os dados e de um array de dados.
            File.AppendAllLines(PATHARCHIVE, linha);
        }

        /// <summary>
        ///     Pega todas as linhas do banco de dados e guarda em um array. Em seguida, percorre-se cada linha deste array e separa todos os dados em outro array. Em seguida instancia-se um objeto com todos esses dados (um objeto para cada registro do banco de dados) e o adiciona em uma lista de produtos. Em seguida, retorna-se esta lista.
        /// </summary>
        /// <returns>Uma lista com todos os produtos.</returns>
        public List<Produto> Ler() {
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

            //Coloca a lista em ordem alfabética. Primeiro contato com a biblioteca LINQ.
            produtos=produtos.OrderBy(produto=>produto.Nome).ToList();

            return produtos;
        }

        /// <summary>
        ///     Uma sobrecarga do método Ler() que reaproveita o próprio método Ler() para achar uma instância com o nome especificado por um parâmetro.
        /// </summary>
        /// <param name="nome">Nome para filtro.</param>
        /// <returns>Retorna uma lista com todos os objetos com o nome especificado.</returns>
        public List<Produto> Ler(string nome) {
            List<Produto> produtos = new List<Produto>();
            foreach( Produto produto in Ler() ) {
                if(produto.Nome==nome) {
                    produtos.Add(produto);
                }
            }
            return produtos;
        }

        /// <summary>
        ///     Remove todos os registros do banco de dados que contenha o termo especificado no parâmetro.
        /// </summary>
        /// <param name="termo">Todos os registros que tiverem este termo serão apagados.</param>
        public void Remover(string termo) {
            //Lista que servirá como um backup de nosso arquivo csv.
            List<string> linhas = new List<string>();

            //Utiliza-se a StreamReader em um using para ler nosso arquivo e em seguida fechá-lo.
            using( StreamReader arquivo = new StreamReader(PATHARCHIVE) ) { //Aqui entra o caminho do arquivo a ser lido.
                string linha;

                //Vai adicionar a linha no "backup" até encontrar uma linha vazia.
                while( (linha=arquivo.ReadLine()) != null ) {
                    linhas.Add(linha);
                }

                //Remove as linhas que tiver o termo, que foi passado como argumento. 
                linhas.RemoveAll( l=>l.Contains(termo) );
            }

            //Reescreve o csv de acordo com o "backup", que já teve os dados apagados. 
            ReescreverCsv(linhas);
        }

        /// <summary>
        ///     Altera um produto já existente com base no código do produto já existente e o do novo produto.
        /// </summary>
        /// <param name="produtoAlterado">O produto que entrará no lugar de um já cadastrado no banco de dados.</param>
        public void Alterar(Produto produtoAlterado) {
            //Lista que servirá como um backup de nosso arquivo csv.
            List<string> linhas = new List<string>();

            //Utiliza-se a StreamReader em um using para ler nosso arquivo e em seguida fechá-lo.
            using( StreamReader arquivo = new StreamReader(PATHARCHIVE) ) { //Aqui entra o caminho do arquivo a ser lido.
                string linha;

                //Vai adicionar a linha no "backup" até encontrar uma linha vazia.
                while( (linha=arquivo.ReadLine()) != null ) {
                    linhas.Add(linha);
                }
            }

            //Irá remover o produto do csv que tiver o código igual ao do novo produto. Assim, podemos apagar o já existente e criar um novo, alterado.
            linhas.RemoveAll( x=>x.Split(";")[0].Contains( produtoAlterado.Codigo.ToString() ) );

            //
            linhas.Add( PrepararLinha(produtoAlterado) );

            //Reescreve o csv de acordo com o "backup", que já teve os dados apagados. 
            ReescreverCsv(linhas);
        }



        //REFATORAÇÃO DE MÉTODOS -> Alguns métodos estavam utilizando códigos repetidos. Então vamos "otimizar" isto. Não há só refatoração de métodos. Por exemplo, voce pode criar classes abstratas.

        /// <summary>
        ///     Reescreve o csv a partir de um "backup".
        /// </summary>
        /// <param name="lines">Uma lista, que funciona como um backup.</param>
        private void ReescreverCsv(List<string> lines) {
            using( StreamWriter output = new StreamWriter(PATHARCHIVE) ) {
                foreach(string ln in lines) {
                    output.Write($"{ln}\n");
                }
            }
        }
    }
}