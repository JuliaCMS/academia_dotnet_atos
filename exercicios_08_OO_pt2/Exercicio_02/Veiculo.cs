namespace Exercicio_02
{
    internal class Veiculo
    {
        public string _marca;
        public string _modelo;

        public virtual void Dirigir()
        {
            Console.WriteLine($"Dirigindo o {_marca} {_modelo}.");
        }
    }
}