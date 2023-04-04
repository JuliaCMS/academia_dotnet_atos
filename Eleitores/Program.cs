namespace Eleitores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número de eleitores: ");
            int eleitores = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de votos brancos: ");
            int votosBrancos = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de votos nulos: ");
            int votosNulos = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de votos válidos: ");
            int votosValidos = int.Parse(Console.ReadLine());

            double percentualBrancos = ((double)votosBrancos / ) * 100;
            double percentualNulos = ((double)votosNulos / eleitores) * 100;
            double percentualValidos = ((double)votosValidos / eleitores) * 100;
            
            Console.WriteLine($"Percentual de votos brancos: {percentualBrancos:N2}%");
            Console.WriteLine($"Percentual de votos nulos: {percentualNulos:N2}%");
            Console.WriteLine($"Percentual de votos válidos: {percentualValidos:N2}%");
        }
    }
}