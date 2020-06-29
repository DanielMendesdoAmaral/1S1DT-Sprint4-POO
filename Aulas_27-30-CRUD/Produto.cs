using System.IO;

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
                File.Create(PATHARCHIVE).Close();
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
    }
}