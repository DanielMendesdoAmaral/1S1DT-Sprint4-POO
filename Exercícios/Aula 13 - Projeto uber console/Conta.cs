namespace Aula_13___Projeto_uber_console
{
    public class Conta
    {
        private string agencia;
        public string Agencia
        {
            get { return agencia; }
            set { agencia = value; }
        }
        private string conta;
        public string _Conta
        {
            get { return conta; }
            set { conta = value; }
        }
        
        public string Cadastrar() {
            if (agencia==null || conta==null) 
                return "ERRO! AGENCIA OU CONTA INVÁLIDA.";
            else 
                return "CADASTRO REALIZADO COM SUCESSO!";
        }
        
        public void Excluir() {
            if (agencia==null || conta==null) 
                System.Console.WriteLine("ERRO! IMPOSSÍVEL EXCLUIR A CONTA POIS ELA NÃO EXISTE.");
            else {
                agencia=null;
                conta=null;
                System.Console.WriteLine("CONTA EXCLUÍDA COM SUCESSO!");
            }
        }
    }
}