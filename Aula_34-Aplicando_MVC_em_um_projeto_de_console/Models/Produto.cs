using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

//SEMPRE COMECE PELO MODEL, POIS AS REQUISIÇÕES DO USUÁRIO VIRÁ DIRETAMENTE PARA ELE.

namespace Aula_34_Aplicando_MVC_em_um_projeto_de_console.Models
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public const string PATHARCHIVE = "Database/Produto.csv";

        public Produto(int _codigo, string _nome, double _preco)
        {
            this.Codigo = _codigo;
            this.Nome = _nome;
            this.Preco = _preco;
        }

        public Produto() {
            
        }

        public List<Produto> Ler() {
            List<Produto> produtos = new List<Produto>();
            string[] linhas = File.ReadAllLines(PATHARCHIVE);

            foreach(string linha in linhas) {
                string[] dado = linha.Split(";");
                Produto produto = new Produto( Int32.Parse(dado[0]), dado[1], Double.Parse(dado[2]) );
                produtos.Add(produto);
            }

            produtos=produtos.OrderBy(produto=>produto.Nome).ToList();

            return produtos;
        }
    }
}