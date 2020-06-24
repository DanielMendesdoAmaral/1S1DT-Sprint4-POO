using System;

namespace Aula_24__Objetos_como_argumento___CRUD
{
    public class Produto
    {
        private int _codigo;
        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }
        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        private double _preco;
        public double Preco
        {
            get { return _preco; }
            set { _preco = value; }
        }
        
        public Produto(int codigo, string nome, double preco) {
            this.Codigo=codigo;
            this.Nome=nome;
            this.Preco=preco;
        }
    }
}