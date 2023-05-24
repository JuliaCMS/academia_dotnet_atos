namespace Exercicio_02
{
    internal class Carro : Veiculo
    {
        public int _quantidadeDePortas;

        public override void Dirigir()
        {
            Console.WriteLine($"Dirigindo o {_marca} {_modelo} com {_quantidadeDePortas} portas.");
        }
    }
}