using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula26
{
    internal class Professor : Pessoa
    {
        private string _disciplina;

        public string Disciplina { get => _disciplina; set => _disciplina = value; }

        public override void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome}\nIdade: {Idade}\nDisciplina: {Disciplina}");
        }
    }
}
