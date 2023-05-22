namespace exercicio_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             14 - Crie uma classe Agenda que pode armazenar 10 pessoas e que seja capaz de realizar as seguintes operações:
              void armazenaPessoa(String nome, int idade, float altura);
              void removePessoa(String nome);
              Pessoa buscaPessoa(String nome); // retorna a pessoa com o nome informado
              void imprimeAgenda(); // imprime os dados de todas as pessoas da agenda
             */

            Console.WriteLine("Bem vindo ao sistema de agenda!");

            Agenda agenda = new Agenda();

            while (true)
            {
                Console.WriteLine("Digite a opção desejada:\n[1] - Adicionar nova pessoa\n[2] - Remover pessoa\n[3] - Buscar pessoa\n[4] - Mostrar agenda\n[0] - Encerrar");
                int op = int.Parse(Console.ReadLine());

                if (op == 1)
                {
                    Console.WriteLine("Digite o nome da pessoa:");
                    string nome = Console.ReadLine();

                    Console.WriteLine("Digite a idade da pessoa:");
                    int idade = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite a altura da pessoa:");
                    float altura = float.Parse(Console.ReadLine());

                    agenda.ArmazenaPessoa(nome, idade, altura);
                    Console.ReadLine();
                }
                else if (op == 2)
                {
                    Console.WriteLine("Digite o nome da pessoa que deseja remover:");
                    string nome = Console.ReadLine();

                    agenda.RemovePessoa(nome);
                    Console.ReadLine();
                }
                else if (op == 3)
                {
                    Console.WriteLine("Digite o nome da pessoa que deseja buscar:");
                    string nome = Console.ReadLine();

                    Agenda pessoa = agenda.BuscaPessoa(nome);
                    if (pessoa != null)
                    {
                        Console.WriteLine("Pessoa encontrada:");
                        Console.WriteLine("Nome: " + pessoa.Nome);
                        Console.WriteLine("Idade: " + pessoa.Idade);
                        Console.WriteLine("Altura: " + pessoa.Altura);
                    }
                    else
                    {
                        Console.WriteLine("Pessoa não encontrada.");
                    }
                    Console.ReadLine();
                }
                else if (op == 4)
                {
                    agenda.ImprimeAgenda();
                    Console.ReadLine();
                }
                else if (op == 0)
                {
                    break;
                }
            }


        }
    }
}