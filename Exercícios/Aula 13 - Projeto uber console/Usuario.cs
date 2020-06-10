namespace Aula_13___Projeto_uber_console
{
    public class Usuario
    {
        public Usuario(string login, string senha, string nome, string foto, string localizacaoAtual) {
            Login=login;
            Senha=senha;
            Nome=nome;
            Foto=foto;
            LocalizacaoAtual=localizacaoAtual;
        }

        private string login;
        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        private string senha;
        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        private string foto;
        public string Foto
        {
            get { return foto; }
            set { foto = value; }
        }
        private string localizacaoAtual;
        public string LocalizacaoAtual
        {
            get { return localizacaoAtual; }
            set { localizacaoAtual = value; }
        }
        private string tokenLogin;
        public string TokenLogin
        {
            get { return tokenLogin; }
            set { tokenLogin = value; }
        }
        
        public bool FazerLogin(string l, string s) {
            if ((l!=Login) || (s!=Senha)) {
                System.Console.WriteLine("ERRO! LOGIN OU SENHA INVÁLIDOS.");
                return false;
            }
            else if (TokenLogin!=null) {
                System.Console.WriteLine("ERRO! VOCê JÁ ESTÁ LOGADO.");
                return false;
            }
            else {
                TokenLogin="aw2d85wd18fe41gfr4h1tfh41yfj4ygj48j4g8kjh8k4k4";
                System.Console.WriteLine("LOGIN FEITO COM SUCESSO.");
                return true;
            }
        }

        public void FazerLogout() {
            if (TokenLogin==null) 
                System.Console.WriteLine("ERRO! VOCÊ NÃO PODE FAZER LOGOUT POIS NÃO ESTÁ LOGADO.");
            else {
                TokenLogin = null;
                System.Console.WriteLine("LOGOUT FEITO COM SUCESSO.");
            }
        }
    }
}