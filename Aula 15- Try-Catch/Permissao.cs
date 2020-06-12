namespace Aula_15__Try_Catch
{
    public class Permissao
    {
        private bool permitir;
        public bool Permitir
        {
            get { return permitir; }
            set { permitir = value; }
        }
        
        public void Autorizar() {
            System.Console.Write("Deseja permitir acesso? [true/false] ");
            try {
                Permitir = System.Convert.ToBoolean( System.Console.ReadLine() );
                System.Console.ForegroundColor = System.ConsoleColor.Green;
                System.Console.WriteLine(Permitir);
                System.Console.ForegroundColor = System.ConsoleColor.White;
            }
            catch {
                System.Console.ForegroundColor = System.ConsoleColor.Red;
                System.Console.WriteLine("ERRO! DADO INVÁLIDO. DIGITE true OU false.");
                System.Console.ForegroundColor = System.ConsoleColor.White;
            }
        }

        public void Acessar(bool Acesso) {
            if (Acesso==true) {
                System.Console.WriteLine("Permitido");
            }
            else {
                System.Console.WriteLine("Negado");
            }
        }
    }
}