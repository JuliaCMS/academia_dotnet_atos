using static System.Net.Mime.MediaTypeNames;
using System.Net;

namespace exercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 - Criar uma classe chamada Pessoa com 2 construtores, um que receba o nome e a idade da pessoa e 
            //outro recebendo apenas a idade.Solicite ao usuário qual dos construtores ele gostaria de utilizar
            //na instanciação da classe. Além de receber parâmetros, os construtores imprimem na tela o conteúdo
            //dos parâmetros recebidos.

            Console.WriteLine("Qual construtor você deseja utilizar? (Digite o número desejado)\n[1] - Nome e Idade\n[2] - Idade");
            int opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Console.Write("Digite o seu nome: ");
                string nome = Console.ReadLine();

                Console.Write("Digite a sua idade: ");
                int idade = int.Parse(Console.ReadLine());
                Console.WriteLine("--------------------------");

                Pessoa pessoa1 = new Pessoa(nome, idade);
            }
            else if (opcao == 2)
            {
                Console.Write("Digite a sua idade: ");
                int idade = int.Parse(Console.ReadLine());
                Console.WriteLine("--------------------------");

                Pessoa pessoa1 = new Pessoa(idade);
            }
        }
    }
}