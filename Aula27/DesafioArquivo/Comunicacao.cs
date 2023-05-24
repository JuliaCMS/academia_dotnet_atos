using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioArquivo
{
    internal class Comunicacao
    {
        public static void Cadastrar(List<Pessoa> listaPessoas, string nomeArquivo)
        {
            string nome;
            string dataNascimento;
            Pessoa pessoa;

            do 
            {
                Console.Write("Nome: ");
                nome = Console.ReadLine().ToUpper();
            } while (!ValidaNome(nome)); // validação do nome

            Console.Write("Data Nascimento: ");
            dataNascimento = Console.ReadLine();

            pessoa = new Pessoa(nome, dataNascimento);

            if (!listaPessoas.Contains(pessoa)) //????
            {
                listaPessoas.Add(pessoa);
                Persistencia.AtualizarPessoaArquivo(pessoa, nomeArquivo);
            }
            else
            {
                Console.WriteLine("Pessoa com este e-mail já na base de dados");
            }
        }

        public static bool ValidaNome(string nome)
        {
            string[] vetorNome = nome.Split();
            if (vetorNome.Length < 2)
            {
                return false;
            }
            return true;
        }
                
        public static void Listar(List<Pessoa> listaPessoas)
        {
                foreach (var item in listaPessoas)
                {
                    Console.WriteLine(item);
                }
        }

        internal static void Pesquisar(List<Pessoa> listaPessoas)
        {
            Console.WriteLine("Digite o nome da pessoa a ser pesquisada: ");
            string nome = Console.ReadLine().ToUpper();

            foreach (var pessoa in listaPessoas)
            {
                if (nome == pessoa.Nome)
                {
                    Console.WriteLine(pessoa.Nome + pessoa.DataNascimento + pessoa.Email);
                }
                else
                {
                    Console.WriteLine("Pessoa não encontrada");
                }
            }
        }

        public static void Excluir(List<Pessoa> listaPessoas, string nomeArquivo)
        {
            Console.WriteLine("Digite o nome da pessoa a ser excluída: ");
            string nome = Console.ReadLine();

            bool removeu = false;
            foreach(var item in listaPessoas)
            {
                if(nome == item.Nome)
                {
                    listaPessoas.Remove(item);
                    removeu = true;
                    break;
                }
            }
            if (removeu)
            {
                Persistencia.GravarListaArquivo(listaPessoas, nomeArquivo);
            }
        }
    }
}
