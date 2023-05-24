using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula26
{
    internal class Pessoa
    {
        /*
        private string _nome;
        private int _idade;

        public string Nome { get => _nome; set => _nome = value; }
        public int Idade { get => _idade; set => _idade = value; }

        public virtual void Apresentar() 
        {
            Console.WriteLine($"Nome: {Nome}\nIdade: {Idade}");
        }
        */

        public string Nome;
        public Endereco end;
        public List<Cachorro> caes;
        public Pessoa(string nome)
        {
            Nome = nome;
        }

    }
}
