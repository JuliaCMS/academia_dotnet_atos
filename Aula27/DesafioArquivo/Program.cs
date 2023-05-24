namespace DesafioArquivo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> listaPessoas = new List<Pessoa>();
            string nomeArquivo = "C:\\Workspace\\academia_dotnet_atos\\Aula27\\DesafioArquivo\\dados.dat";
            Persistencia.PopularArquivoLista(nomeArquivo, listaPessoas); // conectando com a "base de dados"

            string opcao;
            do
            {
                Console.WriteLine("1 - Cadastrar pessoa");
                Console.WriteLine("2 - Listar pessoas");
                Console.WriteLine("3 - Pesquisar pessoa");
                Console.WriteLine("4 - Excluir pessoa");
                Console.WriteLine("5 - Sair");
                Console.WriteLine("Opcao: ");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Cadastrando pessoa");
                        //rotina para cadastrar pessoa
                        Comunicacao.Cadastrar(listaPessoas, nomeArquivo); //listaPessoas armazena no disco, nomeArquivo armazena na memoria
                        break;
                    case "2":
                        Console.WriteLine("Listando pessoas");
                        //rotina para listar pessoa
                        Comunicacao.Listar(listaPessoas);
                        break;
                    case "3":
                        Console.WriteLine("Pesquisando pessoa");
                        //rotina para pesquisar pessoa
                        Comunicacao.Pesquisar(listaPessoas);
                        break;
                    case "4":
                        Console.WriteLine("Excluindo pessoa");
                        //rotina para excluir pessoa
                        Comunicacao.Excluir(listaPessoas, nomeArquivo);
                        break;
                    case "5":
                        Console.WriteLine("Obrigado por usar o sistema");
                        break;
                }
                Console.WriteLine("Pressione alguma tecla para continuar");
                Console.ReadKey();
            } while (opcao != "5");

            
        }
    }
}