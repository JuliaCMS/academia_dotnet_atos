using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_03
{
    internal class Cachorro : Animal
    {
        public string Raca { get; set; }

        public Cachorro(string nome, int idade, string raca) : base(nome, idade)
        {
            Raca = raca;
        }

        public override void MostraDados()
        {
            Console.WriteLine("Nome: " + Nome + "; Idade: " + Idade + "; Raça: " + Raca);
        }
    }
}
