using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula26
{
    internal class Aluno : Pessoa
    {
        private string _matricula;

        public string Matricula { get => _matricula; set => _matricula = value; }

        public override void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome}\nIdade: {Idade}\nMatricula: {Matricula}");
        }
    }
}
