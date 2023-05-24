using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_03
{
    internal class Animal
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Animal(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public virtual void MostraDados()
        {
            Console.WriteLine("Nome: " + Nome + "; Idade: " + Idade);
        }
    }
}
