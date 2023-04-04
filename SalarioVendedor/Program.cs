namespace SalarioVendedor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número do vendedor:");
            int numeroVendedor = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o salário fixo do vendedor:");
            double salarioFixo = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o total de vendas por ele efetuadas:");
            double totalVendas = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o percentual que o vendedor ganha sobre o total de vendas:");
            double percentualVendas = double.Parse(Console.ReadLine());

            double salarioVendedor = salarioFixo + (totalVendas * (percentualVendas / 100));

            Console.WriteLine($"O salário total do vendedor {numeroVendedor} é R${salarioVendedor:N2}");
        }
    }
}