namespace Exercicio_01
{
    internal class Pessoa
    {
        private string _nome;
        private int _idade;

        public string Nome { get => _nome; set => _nome = value; }
        public int Idade { get => _idade; set => _idade = value; }

        public virtual void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome}\nIdade: {Idade}");
        }
    }
}