namespace Aula_6__Exercício
{
    public class CPF : Pessoa
    {
        private string cpf;
        private string rg;

        public CPF(string n, string c, string r) : base(n) {
            SetCpf(c);
            SetRg(r);
        }

        public string GetCpf() {
            return cpf;
        }
        public void SetCpf(string c) {
            cpf=c;
        }
        public string GetRg() {
            return rg;
        }
        public void SetRg(string r) {
            rg=r;
        }

        public string ValidarCpf() {
            if (cpf == "") 
                return "CPF inválido!";
            else
                return "Tudo ok!";
        }

        public void ExibirDados() {
            System.Console.WriteLine($"NOME: {GetNome()}\nCPF: {GetCpf()}\nRG: {GetRg()}\nSITUAÇÃO CPF: {ValidarCpf()}");
        }
    }
}