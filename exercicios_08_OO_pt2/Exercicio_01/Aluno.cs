using static System.Net.Mime.MediaTypeNames;

namespace Exercicio_01
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