using System;

namespace Aula_15__Try_Catch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Permissao permissao = new Permissao();
            permissao.Autorizar();
            permissao.Acessar(permissao.Permitir);
        }
    }
}
