using static System.Net.Mime.MediaTypeNames;

namespace Exercicio_01
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