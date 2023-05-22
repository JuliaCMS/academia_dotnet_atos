using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_14
{
    internal class Agenda
    {
        private string _nome;
        private int _idade;
        private float _altura;

        public string Nome { get => _nome; set => _nome = value; }
        public int Idade { get => _idade; set => _idade = value; }
        public float Altura { get => _altura; set => _altura = value; }

        List<Agenda> agendaPessoas = new List<Agenda>();

        public void ArmazenaPessoa(string nome, int idade, float altura)
        {
            if (agendaPessoas.Count < 10)
            {
                Agenda pessoa = new Agenda();
                agendaPessoas.Add(pessoa);
                Console.WriteLine("Pessoa adicionada: " + pessoa.Nome);
            }
            else
            {
                Console.WriteLine("A agenda já atingiu o seu limite (10).");
            }
        }

        public void RemovePessoa(string nome)
        {
            Agenda pessoa = BuscaPessoa(nome);
            if (pessoa != null)
            {
                agendaPessoas.Remove(pessoa);
                Console.WriteLine("Pessoa removida: " + pessoa.Nome);
            }
            else
            {
                Console.WriteLine("Pessoa não encontrada.");
            }
        }

        public Agenda BuscaPessoa(string nome)
        {
            return agendaPessoas.Find(p => p.Nome == nome);
        }

        public void ImprimeAgenda()
        {
            foreach (Agenda pessoa in agendaPessoas)
            {
                Console.WriteLine("Nome: " + pessoa.Nome);
                Console.WriteLine("Idade: " + pessoa.Idade);
                Console.WriteLine("Altura: " + pessoa.Altura);
                Console.WriteLine("-------------------------");
            }
        }
    }
}
