using System;

namespace ListaFilmesSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X" )
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarFilmes();
                        break;
                }
            }
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine("Bem vindo a listagem de filmes!");
            Console.WriteLine("Selecione a opção desjada");
            Console.WriteLine("1- Listar filmes");
            Console.WriteLine("2- Adicionar filme");
            Console.WriteLine("3- Alterar filme");
            Console.WriteLine("4- Visualizar filme");
            Console.WriteLine("5- Excluir filme");
            Console.WriteLine("C- Limpar tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine("");

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine("");
            return opcaoUsuario;
        }
    }
}
