namespace Exercicio_02
{
    internal class Moto : Veiculo
    {
        public int _cilindrada;

        public override void Dirigir()
        {
            Console.WriteLine($"Dirigindo o {_marca} {_modelo} com {_cilindrada} cilindradas.");
        }
    }
}