namespace Parafusos
{
    internal class Program
    {
        static void Main(string[] args)
        {    
            Console.Write("Digite o código do parafuso A: ");
            string codigoA = Console.ReadLine();

            Console.Write("Digite a quantidade de peças do parafuso A: ");
            int quantidadeA = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor unitário do parafuso A:");
            double valorA = double.Parse(Console.ReadLine());

            Console.Write("Digite o código do parafuso B: ");
            string codigoB = Console.ReadLine();

            Console.Write("Digite a quantidade de peças do parafuso B: ");
            int quantidadeB = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor unitário do parafuso B: ");
            double valorB = double.Parse(Console.ReadLine());

            Console.Write("Digite a porcentagem de IPI a ser acrescentada: ");
            double ipi = double.Parse(Console.ReadLine());

            double totalA = quantidadeA * valorA;
            double totalB = quantidadeB * valorB;
            double total = totalA + totalB;
            double valorIPI = total * (ipi / 100);

            Console.WriteLine($"Total do parafuso A: R${totalA:N2}");
            Console.WriteLine($"Total do parafuso B: R${totalB:N2}");
            Console.WriteLine($"Total da compra: R${total:N2}");
            Console.WriteLine($"Valor do IPI: R${valorIPI:N2}");
        }
    }
}