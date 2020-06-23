using System;

namespace Aula_23__Listas
{
    public class Cartao
    {
        private string _titular;
        public string Titular
        {
            get { return _titular; }
            set { _titular = value; }
        }
        private string _numero;
        public string Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }
        private string _bandeira;
        public string Bandeira
        {
            get { return _bandeira; }
            set { _bandeira = value; }
        }
        private DateTime _vencimento;
        public DateTime Vencimento
        {
            get { return _vencimento; }
            set { _vencimento = value; }
        }
        private int _cvv;
        public int Cvv
        {
            get { return _cvv; }
            set { _cvv = value; }
        }
        
        public Cartao(string titular, string numero, string bandeira, DateTime vencimento, int cvv) {
            this.Titular=titular;
            this.Numero=numero;
            this.Bandeira=bandeira;
            this.Vencimento=vencimento;
            this.Cvv=cvv;
        }
    }
}