namespace _12_RendimentoTaxista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a marcação do odômetro no início do dia: ");
            int odometroInicial = int.Parse(Console.ReadLine());

            Console.Write("Informe a marcação do odômetro no final do dia: ");
            int odometroFinal = int.Parse(Console.ReadLine());

            Console.Write("Digite o número de litros de combustível gasto: ");
            double litrosCombustivel = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor total recebido dos passageiros: R$");
            double valorTotalRecebido = double.Parse(Console.ReadLine());

            int totalQuilometragem = odometroFinal - odometroInicial;
            double mediaConsumo = totalQuilometragem / litrosCombustivel;
            double lucroDia = valorTotalRecebido - (litrosCombustivel * 6.90);

            Console.WriteLine($"Média de consumo: {mediaConsumo:N2}km/L");
            Console.WriteLine($"Lucro líquido do dia: R${lucroDia:N2}");
        }
    }
}