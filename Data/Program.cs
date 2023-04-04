using System.Data;
using System.Runtime.Intrinsics.X86;

namespace Data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o dia (DD): ");
            int dia = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o mês (MM): ");
            int mes = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o ano (AAAA): ");
            int ano = int.Parse(Console.ReadLine());

            Console.WriteLine($"A data no formato AAAAMMDD é: {ano}/{mes}/{dia} ");
        }
    }
}