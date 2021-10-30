using System;

namespace ListaFilmesSeries
{
    class Program
    {
        static FilmeRepository repository = new FilmeRepository();

        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X" )
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarFilme();
                        break;
                    case "2":
                        InserirFilme();
                        break;
                    case "3":
                        AtualizarFilme();
                        break;
                    case "4":
                        VisualizarFilme();
                        break;
                    case "5":
                        ExcluirFilme();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    case "X":

                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcaoUsuario();
            }
            Console.WriteLine("Obrigado por utilizar x");
        }

        private static void ListarFilme()
        {
            Console.WriteLine("Listar filmes");

            var lista = repository.Lista();

            if(lista.Count == 0)
            {
                Console.WriteLine("Nenhum filma cadastrado!");
                return;
            }
            
            foreach (var filme in lista)
            {
                var excluido = filme.retornaExcluido();
                Console.WriteLine("#id {0}: - {1} - {2}", filme.retornaId(), filme.retornaTitulo(), (excluido ? "*Excluído*" : ""));
            }
        }

        private static void InserirFilme()
        {
            Console.WriteLine("Inserir novo filme");

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.WriteLine("");
            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o título do filme: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o ano de lançamento: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a nota (1 a 5): ");
            float entradaNota = float.Parse(Console.ReadLine());
            if (entradaNota > 5 || entradaNota < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            Console.WriteLine("Digite a avaliação: ");
            string entradaAvaliacao = Console.ReadLine();

            Filme novoFilme = new Filme(id: repository.ProximoId(),
                                            generoFilme: (Genero)entradaGenero,
                                            tituloFilme: entradaTitulo,
                                            anoLancamentoFilme: entradaAno,
                                            notaFilme: entradaNota,
                                            avaliacaoFilme: entradaAvaliacao);

            repository.Insere(novoFilme);
        }

        public static void AtualizarFilme()
        {
            Console.WriteLine("Digite o id do filme: ");
            int idFilme = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }

            Console.WriteLine("");
            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o título do filme: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o ano de lançamento: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a nota (1 a 5): ");
            float entradaNota = float.Parse(Console.ReadLine());
            if (entradaNota > 5 || entradaNota < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            Console.WriteLine("Digite a avaliação: ");
            string entradaAvaliacao = Console.ReadLine();

            Filme atualizaFilme = new Filme(id: idFilme,
                                            generoFilme: (Genero)entradaGenero,
                                            tituloFilme: entradaTitulo,
                                            anoLancamentoFilme: entradaAno,
                                            notaFilme: entradaNota,
                                            avaliacaoFilme: entradaAvaliacao);

            repository.Atualiza(idFilme, atualizaFilme);                                                
        }

        public static void VisualizarFilme()
        {
            Console.Write("Digite o id do filme: ");
            int idFilme = int.Parse(Console.ReadLine());

            var filme = repository.RetornaId(idFilme);
            Console.WriteLine(filme);
        }

        public static void ExcluirFilme()
        {
            Console.Write("Digite o id do filme: ");
            int idFilme = int.Parse(Console.ReadLine());

            repository.Exclui(idFilme);
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine("Listagem de filmes - By Gustavo");
            Console.WriteLine("Selecione a opção desjada");
            Console.WriteLine("");
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
