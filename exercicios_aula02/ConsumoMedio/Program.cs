namespace ConsumoMedio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a distância total percorrida (Km):");
            double distanciaPercorrida = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o volume de combustível consumido (litros):");
            double volumeCombustivel = double.Parse(Console.ReadLine());

            double consumoMedio = distanciaPercorrida / volumeCombustivel;

            Console.WriteLine($"O consumo médio do automóvel foi de: {consumoMedio:N2} Km/L");
        }
    }
}