namespace Exercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2 - Criar uma classe Veiculo que contém as propriedades Marca e Modelo. Criar duas classes derivadas, Carro e Moto, que herdam de Veiculo.
            // A classe Carro deve ter uma propriedade adicional QuantidadeDePortas, enquanto a classe Moto deve ter uma propriedade adicional Cilindrada.
            // Criar um método Dirigir na classe Veiculo que imprime "Dirigindo o <marca> <modelo>". Em seguida, criar um método Dirigir na classe Carro
            // que imprime "Dirigindo o <marca> <modelo> com <quantidadeDePortas> portas" e um método Dirigir na classe Moto que imprime "Dirigindo a
            // <marca> <modelo> com <cilindrada> cilindradas".

            Veiculo veiculo = new Veiculo();
            veiculo._marca = "Volkswagen";
            veiculo._modelo = "Fox";

            Carro carro = new Carro();
            carro._marca = "Hyundai";
            carro._modelo = "HB20";
            carro._quantidadeDePortas = 4;

            Moto moto = new Moto();
            moto._marca = "Harley-Davidson";
            moto._modelo = "Sportster 883";
            moto._cilindrada = 883;

            veiculo.Dirigir();
            carro.Dirigir();
            moto.Dirigir();

        }
    }
}