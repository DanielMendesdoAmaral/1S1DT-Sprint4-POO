namespace Aula_16__Método_construtor
{
    public class Produto
    {
        public int codigo { get; set; }
        public string nome { get; set; }
        public double preco { get; set; }
        public string categoria { get; set; }

        public Produto(int _codigo, string _nome, double _preco, string _categoria) {
            this.codigo=_codigo;
            this.nome=_nome;
            this.preco=_preco;
            this.categoria=_categoria;
        }

        public string DescreverProduto() {
            return $"CÓDIGO: {codigo}\nNOME: {nome}\nPREÇO: R${preco}\nCATEGORIA: {categoria}";
        }
    }
}