using Arquivo;

namespace Arquivo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Se o método da classe persistencia não fosse estático, ela deveria ser instanciada dessa forma para ter acesso ao serviço:
            //Persistencia obj = new Persistencia();
            //obj.LerArquivoParaTela("C:\\Workspace\\academia_dotnet_atos\\Aula25\\dados.dat"); 

            List<Pessoa> listaPessoas = new List<Pessoa>();

            Persistencia.PopularArquivoLista("C:\\Workspace\\academia_dotnet_atos\\Aula25\\dados.dat", listaPessoas);

            string nome;
            string dataNascimento;
            Pessoa pessoa;

            for (int i = 0; i < 3; i++)
            {
                 Console.Write("Nome: ");
                 nome = Console.ReadLine();

                 Console.Write("Data Nascimento: ");
                 dataNascimento = Console.ReadLine();

                 pessoa = new Pessoa(nome, dataNascimento);

                 if (!listaPessoas.Contains(pessoa)) //????
                 {
                     listaPessoas.Add( pessoa );
                     Persistencia.AtualizarPessoaArquivo(pessoa, "C:\\Workspace\\academia_dotnet_atos\\Aula25\\dados.dat");
                 } else
                 {
                     Console.WriteLine("Pessoa com este email já na base de dados");
                 }
            }

            /*
            Persistencia.exibirLista(listaPessoas);

            Console.Write("Digite nome a ser excluido: ");
            nome = Console.ReadLine();

            bool removeu = false;
            foreach (var item in listaPessoas)
            {
                if (nome == item.Nome)
                {
                    listaPessoas.Remove(item);
                    removeu = true;
                    break;
                }
            }
            if (removeu)
            {
                Persistencia.gravarListaArquivo(listaPessoas, "dados.dat");
            }
            */


            //Persistir na base de dados
            //Persistencia.gravarListaArquivo(listaPessoas, "C:\\Users\\alexz\\academia_AtosUFN_DotNet_4\\anotacoesAlexandre\\dados.dat");


        }
    }
}