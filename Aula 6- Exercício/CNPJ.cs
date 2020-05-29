namespace Aula_6__Exercício
{
    public class CNPJ : Pessoa
    {
        private string cnpj;

        public CNPJ(string n, string c) : base(n) {
            SetCnpj(c);
        }

        public string GetCnpj() {
            return cnpj;
        }
        public void SetCnpj(string c) {
            cnpj=c;
        }

        public string ValidarCnpj() {
            if (cnpj == "")
                return "CNPJ inválido!";
            else 
                return "Tudo ok!";
        }

        public void ExibirDados() {
            System.Console.WriteLine($"NOME: {GetNome()}\nCNPJ: {GetCnpj()}\nSITUAÇAO CNPJ: {ValidarCnpj()}");
        }
    }
}