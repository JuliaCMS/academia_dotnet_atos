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

            // instância da classe DateTime para representação da data
            DateTime data = new DateTime(ano, mes, dia);

            // formatação da data com o método .ToString
            string formatoAAAAMMDD = data.ToString("yyyy/MM/dd");
            string formatoAAMMDD = data.ToString("yy/MM/dd");

            Console.WriteLine($"A data no formato AAAAMMDD é: {formatoAAAAMMDD}");
            Console.WriteLine($"A data no formato AAMMDD é: {formatoAAMMDD}");
        }
    }
}